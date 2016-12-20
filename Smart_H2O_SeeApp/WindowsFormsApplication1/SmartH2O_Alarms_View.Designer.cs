namespace WindowsFormsApplication1
{
    partial class SmartH2O_Alarms_View
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartH2O_Alarms_View));
            this.button1 = new System.Windows.Forms.Button();
            this.alarmsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureAlarm = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listboxAlarmData = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listboxAlarmHour = new System.Windows.Forms.ListBox();
            this.listboxAlarmValue = new System.Windows.Forms.ListBox();
            this.listboxAlarmParam = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlarm)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 405);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alarmsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.alarmsChart.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.alarmsChart.Legends.Add(legend1);
            this.alarmsChart.Location = new System.Drawing.Point(28, 32);
            this.alarmsChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.alarmsChart.Name = "alarmsChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.Name = "NH3";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "CI2";
            series2.YValuesPerPoint = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Legend = "Legend1";
            series3.Name = "PH";
            this.alarmsChart.Series.Add(series1);
            this.alarmsChart.Series.Add(series2);
            this.alarmsChart.Series.Add(series3);
            this.alarmsChart.Size = new System.Drawing.Size(381, 216);
            this.alarmsChart.TabIndex = 6;
            this.alarmsChart.Text = "chart2";
            title1.Name = "phDailyView";
            title1.Text = "PH Vista Diaria";
            title1.Visible = false;
            title2.Name = "phPeriodView";
            title2.Text = "PH Vista por Periodo";
            title2.Visible = false;
            title3.Name = "phWeeklyView";
            title3.Text = "PH Vista Semanal";
            title3.Visible = false;
            this.alarmsChart.Titles.Add(title1);
            this.alarmsChart.Titles.Add(title2);
            this.alarmsChart.Titles.Add(title3);
            this.alarmsChart.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(686, 258);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vista de Alarms";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureAlarm
            // 
            this.pictureAlarm.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureAlarm.ErrorImage")));
            this.pictureAlarm.Image = ((System.Drawing.Image)(resources.GetObject("pictureAlarm.Image")));
            this.pictureAlarm.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureAlarm.InitialImage")));
            this.pictureAlarm.Location = new System.Drawing.Point(482, 46);
            this.pictureAlarm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureAlarm.Name = "pictureAlarm";
            this.pictureAlarm.Size = new System.Drawing.Size(187, 179);
            this.pictureAlarm.TabIndex = 0;
            this.pictureAlarm.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(448, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Data";
            // 
            // listboxAlarmData
            // 
            this.listboxAlarmData.FormattingEnabled = true;
            this.listboxAlarmData.Location = new System.Drawing.Point(448, 37);
            this.listboxAlarmData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listboxAlarmData.Name = "listboxAlarmData";
            this.listboxAlarmData.Size = new System.Drawing.Size(134, 69);
            this.listboxAlarmData.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Hora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Parametro";
            // 
            // listboxAlarmHour
            // 
            this.listboxAlarmHour.FormattingEnabled = true;
            this.listboxAlarmHour.Location = new System.Drawing.Point(313, 37);
            this.listboxAlarmHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listboxAlarmHour.Name = "listboxAlarmHour";
            this.listboxAlarmHour.Size = new System.Drawing.Size(134, 69);
            this.listboxAlarmHour.TabIndex = 35;
            // 
            // listboxAlarmValue
            // 
            this.listboxAlarmValue.FormattingEnabled = true;
            this.listboxAlarmValue.Location = new System.Drawing.Point(172, 37);
            this.listboxAlarmValue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listboxAlarmValue.Name = "listboxAlarmValue";
            this.listboxAlarmValue.Size = new System.Drawing.Size(134, 69);
            this.listboxAlarmValue.TabIndex = 34;
            // 
            // listboxAlarmParam
            // 
            this.listboxAlarmParam.FormattingEnabled = true;
            this.listboxAlarmParam.Location = new System.Drawing.Point(86, 37);
            this.listboxAlarmParam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listboxAlarmParam.Name = "listboxAlarmParam";
            this.listboxAlarmParam.Size = new System.Drawing.Size(83, 69);
            this.listboxAlarmParam.TabIndex = 32;
            this.listboxAlarmParam.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.listboxAlarmParam);
            this.groupBox2.Controls.Add(this.listboxAlarmData);
            this.groupBox2.Controls.Add(this.listboxAlarmValue);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.listboxAlarmHour);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(9, 280);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(686, 119);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalhes de Alarmes";
            // 
            // SmartH2O_Alarms_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 431);
            this.ControlBox = false;
            this.Controls.Add(this.pictureAlarm);
            this.Controls.Add(this.alarmsChart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SmartH2O_Alarms_View";
            this.Text = "SmartH2O_Alarms_View";
            this.Load += new System.EventHandler(this.SmartH2O_Alarms_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alarmsChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAlarm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart alarmsChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listboxAlarmData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listboxAlarmHour;
        private System.Windows.Forms.ListBox listboxAlarmValue;
        private System.Windows.Forms.ListBox listboxAlarmParam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureAlarm;
    }
}