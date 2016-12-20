namespace WindowsFormsApplication1
{
    partial class SmartH2O_Graph_View
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ci2Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.nh3Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.phChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ci2Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nh3Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ci2Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.ci2Chart.ChartAreas.Add(chartArea1);
            legend1.AutoFitMinFontSize = 5;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.ci2Chart.Legends.Add(legend1);
            this.ci2Chart.Location = new System.Drawing.Point(392, 28);
            this.ci2Chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ci2Chart.Name = "ci2Chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "MIN";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "MED";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "MAX";
            this.ci2Chart.Series.Add(series1);
            this.ci2Chart.Series.Add(series2);
            this.ci2Chart.Series.Add(series3);
            this.ci2Chart.Size = new System.Drawing.Size(381, 216);
            this.ci2Chart.TabIndex = 0;
            this.ci2Chart.Text = "chart1";
            title1.Name = "ci2DailyView";
            title1.Text = "CI2 Vista Diaria";
            title1.Visible = false;
            title2.Name = "ci2PeriodView";
            title2.Text = "CI2 Vista por Periodo";
            title2.Visible = false;
            title3.Name = "ci2WeekView";
            title3.Text = "CI2 Vista Semanal";
            title3.Visible = false;
            this.ci2Chart.Titles.Add(title1);
            this.ci2Chart.Titles.Add(title2);
            this.ci2Chart.Titles.Add(title3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 481);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nh3Chart
            // 
            chartArea2.Name = "ChartArea1";
            this.nh3Chart.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.nh3Chart.Legends.Add(legend2);
            this.nh3Chart.Location = new System.Drawing.Point(206, 244);
            this.nh3Chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nh3Chart.Name = "nh3Chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "MIN";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "MED";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "MAX";
            this.nh3Chart.Series.Add(series4);
            this.nh3Chart.Series.Add(series5);
            this.nh3Chart.Series.Add(series6);
            this.nh3Chart.Size = new System.Drawing.Size(381, 216);
            this.nh3Chart.TabIndex = 2;
            this.nh3Chart.Text = "chart1";
            title4.Alignment = System.Drawing.ContentAlignment.BottomCenter;
            title4.Name = "nh3DailyView";
            title4.Text = "NH3 Vista Diaria";
            title4.Visible = false;
            title5.Name = "nh3PeriodView";
            title5.Text = "NH3 Vista por Periodo";
            title5.Visible = false;
            title6.Name = "nh3WeekView";
            title6.Text = "NH3 Vista Semanal";
            title6.Visible = false;
            this.nh3Chart.Titles.Add(title4);
            this.nh3Chart.Titles.Add(title5);
            this.nh3Chart.Titles.Add(title6);
            // 
            // phChart
            // 
            chartArea3.Name = "ChartArea1";
            this.phChart.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Name = "Legend1";
            this.phChart.Legends.Add(legend3);
            this.phChart.Location = new System.Drawing.Point(11, 28);
            this.phChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phChart.Name = "phChart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "MIN";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "MED";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "MAX";
            this.phChart.Series.Add(series7);
            this.phChart.Series.Add(series8);
            this.phChart.Series.Add(series9);
            this.phChart.Size = new System.Drawing.Size(381, 216);
            this.phChart.TabIndex = 3;
            this.phChart.Text = "chart2";
            title7.Name = "phDailyView";
            title7.Text = "PH Vista Diaria";
            title7.Visible = false;
            title8.Name = "phPeriodView";
            title8.Text = "PH Vista por Periodo";
            title8.Visible = false;
            title9.Name = "phWeeklyView";
            title9.Text = "PH Vista Semanal";
            title9.Visible = false;
            this.phChart.Titles.Add(title7);
            this.phChart.Titles.Add(title8);
            this.phChart.Titles.Add(title9);
            this.phChart.UseWaitCursor = true;
            // 
            // SmartH2O_Graph_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(785, 511);
            this.ControlBox = false;
            this.Controls.Add(this.phChart);
            this.Controls.Add(this.nh3Chart);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ci2Chart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SmartH2O_Graph_View";
            this.Text = "SmartH2O_Graph_View";
            ((System.ComponentModel.ISupportInitialize)(this.ci2Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nh3Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ci2Chart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart nh3Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart phChart;
    }
}