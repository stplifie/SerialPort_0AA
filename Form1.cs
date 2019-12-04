using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using rtChart;

using System.Diagnostics;
//using VisioForge.MediaFramework.deviceio;

// Inspired by: https://www.youtube.com/watch?v=HlDwVUR71yI&t=560s


namespace SerialPort_0AA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        

        }
        kayChart serialDataChart;
        kayChart serialDataChart1;
        kayChart serialDataChart2;
        kayChart serialDataChart3;
        string DataAxis1;
        string DataAxis2;
        string DataAxis3;
        int DataAxis1_Int;
        int DataAxis2_Int;
        int DataAxis3_Int;
        int chartXsize = 400;
        int cptr1 = 0;
        int cptr2 = 0;
        float cptr0 = 0;


        float f;
        bool flagDataReceived;
        double d;
        bool ScopeCH1 = false;
        bool ScopeCH2 = false;
        bool ScopeCH3 = false;
        SerialPort aSerialPort = new SerialPort("COM5");

        public void btnSP_Click(object sender, EventArgs e)
        {
           
            aSerialPort.BaudRate = 9600;
            aSerialPort.Parity = Parity.None;
            aSerialPort.StopBits = StopBits.One;
            aSerialPort.DataBits = 8;
            //aSerialPort.Handshake = Handshake.None;
            //aSerialPort.RtsEnable = true;
            aSerialPort.DataReceived += new SerialDataReceivedEventHandler(serialDataReceivedEventHandler);

           if (!aSerialPort.IsOpen)
            {
                aSerialPort.Close();
               // Timer.Equals = 1000;

               aSerialPort.Open();
            }
            else
            {
                MessageBox.Show("Serial port is busy. Close it and try again.");
                aSerialPort.Close();
                aSerialPort.Open();
            }
                  
            btnSP.Enabled = (false);
            btnPause.Enabled = (true);

        }

        private void serialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sData = sender as SerialPort;
            string recvData = sData.ReadLine();

            serialData.Invoke((MethodInvoker)delegate { serialData.AppendText(recvData); });
            //serialData1.Invoke((MethodInvoker)delegate { serialData1.AppendText(recvData); });

            //Intitialisation of chart update
            double data;
            double data1;
            //double data2;
            bool result = Double.TryParse(recvData,out data);
            int data2 = Convert.ToInt32(data);
           
            
            if (recvData[0] == '#')
            {
                //Sarial data stream: #0xD31A0x3FF50x037A

                DataAxis1 = recvData.Substring(3,4);
                DataAxis2 = recvData.Substring(9,4);
                DataAxis3 = recvData.Substring(15,4);

                //serialData1.Text = DataAxis1.ToString();
                //f = Convert.ToSingle(DataAxis1);
                DataAxis1_Int = Convert.ToInt32(DataAxis1, 16);
                DataAxis2_Int = Convert.ToInt32(DataAxis2, 16);
                DataAxis3_Int = Convert.ToInt32(DataAxis3, 16);

                cptr2++;

                //bf = *((float*)&DataAxis2_Int);

                //string hexString = DataAxis1; // "43480170";


                //int num = int.Parse(DataAxis1, System.Globalization.NumberStyles.AllowHexSpecifier);
                //byte[] floatVals = BitConverter.GetBytes(num);
                //f = BitConverter.ToSingle(floatVals, 0);
                //d = f * 10e43;



                //if (BitConverter.IsLittleEndian)
                //{
                //    floatVals = floatVals.Reverse().ToArray();
                //}
                //f = BitConverter.ToSingle(floatVals, 0);

                //f = f * 10e40;
                //f = Convert.ToDouble(f);
                //f = Math.Pow(f, 40);

                flagDataReceived = true;             

            }
            else
            {
                flagDataReceived = false;
                              
            }
            // = Convert.ChangeType.ToInt.DataAxis1;
            //string DataAxis1 = "0x142CBD";
            // this works, and returns 1322173            

            //byte[] bytes = BitConverter.GetBytes(DataAxis1_Int);

            bool result1 = Double.TryParse(DataAxis1, out data);
            bool result2 = Double.TryParse(DataAxis2, out data1);

            //llbDataValid.Text = "Data ok";
            //serialDataChart1.TriggeredUpdate(d);

            if (ScopeCH1){
                serialDataChart1.TriggeredUpdate(DataAxis1_Int);}
            if (ScopeCH2)
            {
                serialDataChart2.TriggeredUpdate(DataAxis2_Int);
            }
            if (ScopeCH3)
            {
                serialDataChart3.TriggeredUpdate(DataAxis3_Int);
            }

            chartXsize = hScrollBarChartXSize.Value;

            //serialDataChart2.TriggeredUpdate(DataAxis2_Int);
            //serialDataChart3.TriggeredUpdate(DataAxis3_Int);


            //serialDataChart2.TriggeredUpdate(data);

            ////OK__________________
            //bool result1 = Double.TryParse(DataAxis1, out data);
            //bool result2 = Double.TryParse(DataAxis2, out data);

            if (result1 && result2)
            {
               // llbDataValid.Text = "Data ok";
               // serialDataChart.TriggeredUpdate(Convert.ToInt32(data2));
                //serialDataChart1.TriggeredUpdate(Convert.ToDouble(DataAxis1_Int));
                //serialDataChart1.TriggeredUpdate(Convert.ToInt32(DataAxis1_Int));
                //serialDataChart2.TriggeredUpdate(Convert.ToInt32(DataAxis2_Int));
              
                //serialDataChart.TriggeredUpdate(data);
                //int x = data2;
                //Console.WriteLine($"Before: {Convert.ToString(x, toBase: 2)}");

                //int y = x << 4;
                //double = Convert.ToDouble(y);

                //Console.WriteLine($"After:  {Convert.ToString(y, toBase: 2)}");
                // Output:
                // Before: 11001001000000000000000000010001
                // After:  10010000000000000000000100010000
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           serialDataChart = new kayChart(chart1, chartXsize);
            serialDataChart.serieName = "serialRead";
           serialDataChart1 = new kayChart(chart1, chartXsize); 
            serialDataChart1.serieName = "RxAxis1";
           serialDataChart2 = new kayChart(chart1, chartXsize);
            serialDataChart2.serieName = "RxAxis2";
           serialDataChart3 = new kayChart(chart1, chartXsize);
            serialDataChart3.serieName = "RxAxis3";

        }

        private void btnClosePort_Click(object sender, EventArgs e, object aSerialPort)
        {
            //aSerialPort.Close();
        }
        private void btnEnd_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void serialData_TextChanged(object sender, EventArgs e)
        {
            
            serialData.SelectionStart = serialData.Text.Length;
            serialData.ScrollToCaret();
            serialData1.Text = "Double is: f*10e43: " + d;

            if (flagDataReceived == true)
            {
                llbDataValid.Text = "Good data.";
                llbDataValid.BackColor = Color.Green;
            }
            else
            {
                llbDataValid.Text = "Wrong data.";
                llbDataValid.BackColor = Color.Red;
            }

            //serialData1.Text = "Double is: " + Convert.ToDouble(DataAxis1_Int);
            //serialData1.Text = Convert.ToDouble(DataAxis1_Int) + "#" + DataAxis2_Int + "#" + DataAxis3_Int;
            //serialData1.Text = Convert.ToString(DataAxis1_Int) + "&" + Convert.ToString(DataAxis2_Int);
            //serialData1.Text = Convert.ToString(DataAxis2_Int);

        }
        private void serialData1_TextChanged(object sender, EventArgs e)
        {
            serialData1.SelectionStart = serialData1.Text.Length;
            serialData1.ScrollToCaret();
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {

        }

        private void serialData1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPause.Enabled = (false);
            aSerialPort.Close();

            llbDataValid.Text = "Serial port is paused.";

        }

        private void rbtChanel1_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void cbxCH1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCH1.Checked) {
                ScopeCH1 = true; }
            else
            {
                ScopeCH1 = false;
            }

        }

        private void cbxCH2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCH2.Checked)
            {
                ScopeCH2 = true;
            }
            else
            {
                ScopeCH2 = false;
                
            }
        }

        private void cbxCH3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCH3.Checked)
            {
                ScopeCH3 = true;
            }
            else
            {
                ScopeCH3 = false;
            }
        }

        private void rTbChartXsize_TextChanged(object sender, EventArgs e)
        {
            //rTbChartXsize_TextChanged
            if (rTbChartXsize.Text == "") { }
            else {
                chartXsize = Convert.ToInt32(rTbChartXsize.Text);
            }

            if (chartXsize < 50) { chartXsize = 50; }


        }

        private void hScrollBarChartXSize_Scroll(object sender, ScrollEventArgs e)
        {
            rTbChartXsize.Text = Convert.ToString(hScrollBarChartXSize.Value);
            chartXsize = hScrollBarChartXSize.Value;
            //serialDataChart(chart1, chartXsize);
            //chartXsize = hScrollBarChartXSize.Value;
            //chart1.ChartAreas(ax)
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cptr1++;
            lblSamplingRate1.Text = "Sampling rate is " + Convert.ToString(cptr2-cptr1) + "dt" + " / " + Convert.ToString(cptr1)+ "[ms]";
        }
    }
}
