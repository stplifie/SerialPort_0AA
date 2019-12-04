namespace SerialPort_0AA
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnSP = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialData = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialData1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.llbDataValid = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtChanel1 = new System.Windows.Forms.RadioButton();
            this.cbxCH1 = new System.Windows.Forms.CheckBox();
            this.cbxCH2 = new System.Windows.Forms.CheckBox();
            this.cbxCH3 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rTbChartXsize = new System.Windows.Forms.RichTextBox();
            this.hScrollBarChartXSize = new System.Windows.Forms.HScrollBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSamplingRate1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(38, 662);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(415, 58);
            this.btnEnd.TabIndex = 1;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click_1);
            // 
            // btnSP
            // 
            this.btnSP.Location = new System.Drawing.Point(38, 585);
            this.btnSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnSP.Name = "btnSP";
            this.btnSP.Size = new System.Drawing.Size(209, 60);
            this.btnSP.TabIndex = 4;
            this.btnSP.Text = "Open Serial Port";
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.Maximum = 500D;
            chartArea3.AxisX.Minimum = 50D;
            chartArea3.AxisY.Maximum = 1200D;
            chartArea3.AxisY.Minimum = 8D;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Bottom;
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.MaximumAutoSize = 100F;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(736, 95);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series9.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.White;
            series9.Legend = "Legend1";
            series9.Name = "serialRead";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "RxAxis1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series11.Legend = "Legend1";
            series11.Name = "RxAxis2";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Legend1";
            series12.Name = "RxAxis3";
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(1042, 625);
            this.chart1.TabIndex = 6;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // serialData
            // 
            this.serialData.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.serialData.Location = new System.Drawing.Point(43, 129);
            this.serialData.Margin = new System.Windows.Forms.Padding(4);
            this.serialData.Name = "serialData";
            this.serialData.Size = new System.Drawing.Size(331, 166);
            this.serialData.TabIndex = 7;
            this.serialData.Text = "";
            this.serialData.TextChanged += new System.EventHandler(this.serialData_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 738);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Rodotics SA - 25.Nov.2019";
            // 
            // serialData1
            // 
            this.serialData1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.serialData1.Location = new System.Drawing.Point(520, 129);
            this.serialData1.Margin = new System.Windows.Forms.Padding(4);
            this.serialData1.Name = "serialData1";
            this.serialData1.Size = new System.Drawing.Size(204, 166);
            this.serialData1.TabIndex = 9;
            this.serialData1.Text = "";
            this.serialData1.TextChanged += new System.EventHandler(this.serialData1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Channel 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(515, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Channel 2";
            // 
            // llbDataValid
            // 
            this.llbDataValid.AutoSize = true;
            this.llbDataValid.ForeColor = System.Drawing.Color.White;
            this.llbDataValid.Location = new System.Drawing.Point(1596, 47);
            this.llbDataValid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.llbDataValid.Name = "llbDataValid";
            this.llbDataValid.Size = new System.Drawing.Size(112, 25);
            this.llbDataValid.TabIndex = 12;
            this.llbDataValid.Text = "Status live";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(255, 585);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(198, 60);
            this.btnPause.TabIndex = 13;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbtChanel1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(520, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 243);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chart option";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(37, 163);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(129, 29);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Chanel 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(37, 110);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(129, 29);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Chanel 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rbtChanel1
            // 
            this.rbtChanel1.AutoSize = true;
            this.rbtChanel1.ForeColor = System.Drawing.Color.White;
            this.rbtChanel1.Location = new System.Drawing.Point(37, 56);
            this.rbtChanel1.Name = "rbtChanel1";
            this.rbtChanel1.Size = new System.Drawing.Size(129, 29);
            this.rbtChanel1.TabIndex = 0;
            this.rbtChanel1.TabStop = true;
            this.rbtChanel1.Text = "Chanel 1";
            this.rbtChanel1.UseVisualStyleBackColor = true;
            this.rbtChanel1.CheckedChanged += new System.EventHandler(this.rbtChanel1_CheckedChanged);
            // 
            // cbxCH1
            // 
            this.cbxCH1.AutoSize = true;
            this.cbxCH1.ForeColor = System.Drawing.Color.White;
            this.cbxCH1.Location = new System.Drawing.Point(31, 57);
            this.cbxCH1.Name = "cbxCH1";
            this.cbxCH1.Size = new System.Drawing.Size(142, 29);
            this.cbxCH1.TabIndex = 16;
            this.cbxCH1.Text = "Channel 1";
            this.cbxCH1.UseVisualStyleBackColor = true;
            this.cbxCH1.CheckedChanged += new System.EventHandler(this.cbxCH1_CheckedChanged);
            // 
            // cbxCH2
            // 
            this.cbxCH2.AutoSize = true;
            this.cbxCH2.ForeColor = System.Drawing.Color.White;
            this.cbxCH2.Location = new System.Drawing.Point(31, 110);
            this.cbxCH2.Name = "cbxCH2";
            this.cbxCH2.Size = new System.Drawing.Size(142, 29);
            this.cbxCH2.TabIndex = 17;
            this.cbxCH2.Text = "Channel 2";
            this.cbxCH2.UseVisualStyleBackColor = true;
            this.cbxCH2.CheckedChanged += new System.EventHandler(this.cbxCH2_CheckedChanged);
            // 
            // cbxCH3
            // 
            this.cbxCH3.AutoSize = true;
            this.cbxCH3.ForeColor = System.Drawing.Color.White;
            this.cbxCH3.Location = new System.Drawing.Point(31, 164);
            this.cbxCH3.Name = "cbxCH3";
            this.cbxCH3.Size = new System.Drawing.Size(142, 29);
            this.cbxCH3.TabIndex = 18;
            this.cbxCH3.Text = "Channel 3";
            this.cbxCH3.UseVisualStyleBackColor = true;
            this.cbxCH3.CheckedChanged += new System.EventHandler(this.cbxCH3_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxCH1);
            this.groupBox2.Controls.Add(this.cbxCH3);
            this.groupBox2.Controls.Add(this.cbxCH2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(38, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 243);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chanel selecetion";
            // 
            // rTbChartXsize
            // 
            this.rTbChartXsize.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rTbChartXsize.ForeColor = System.Drawing.Color.Silver;
            this.rTbChartXsize.Location = new System.Drawing.Point(520, 597);
            this.rTbChartXsize.Margin = new System.Windows.Forms.Padding(4);
            this.rTbChartXsize.Multiline = false;
            this.rTbChartXsize.Name = "rTbChartXsize";
            this.rTbChartXsize.Size = new System.Drawing.Size(204, 48);
            this.rTbChartXsize.TabIndex = 20;
            this.rTbChartXsize.Text = "120";
            this.rTbChartXsize.TextChanged += new System.EventHandler(this.rTbChartXsize_TextChanged);
            // 
            // hScrollBarChartXSize
            // 
            this.hScrollBarChartXSize.Location = new System.Drawing.Point(520, 673);
            this.hScrollBarChartXSize.Maximum = 500;
            this.hScrollBarChartXSize.Minimum = 50;
            this.hScrollBarChartXSize.Name = "hScrollBarChartXSize";
            this.hScrollBarChartXSize.Size = new System.Drawing.Size(204, 35);
            this.hScrollBarChartXSize.SmallChange = 10;
            this.hScrollBarChartXSize.TabIndex = 21;
            this.hScrollBarChartXSize.Value = 50;
            this.hScrollBarChartXSize.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarChartXSize_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSamplingRate1
            // 
            this.lblSamplingRate1.AutoSize = true;
            this.lblSamplingRate1.ForeColor = System.Drawing.Color.White;
            this.lblSamplingRate1.Location = new System.Drawing.Point(1596, 95);
            this.lblSamplingRate1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSamplingRate1.Name = "lblSamplingRate1";
            this.lblSamplingRate1.Size = new System.Drawing.Size(112, 25);
            this.lblSamplingRate1.TabIndex = 22;
            this.lblSamplingRate1.Text = "Status live";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1800, 781);
            this.Controls.Add(this.lblSamplingRate1);
            this.Controls.Add(this.hScrollBarChartXSize);
            this.Controls.Add(this.rTbChartXsize);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.llbDataValid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serialData1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serialData);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.btnEnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Driver_Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnSP;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox serialData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox serialData1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPause;
        public System.Windows.Forms.Label llbDataValid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtChanel1;
        private System.Windows.Forms.CheckBox cbxCH1;
        private System.Windows.Forms.CheckBox cbxCH2;
        private System.Windows.Forms.CheckBox cbxCH3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rTbChartXsize;
        public System.Windows.Forms.HScrollBar hScrollBarChartXSize;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lblSamplingRate1;
    }
}

