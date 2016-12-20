namespace WindowsFormsApplication1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewAlarms = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dailyAlarmsPick = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.periodAlarms = new System.Windows.Forms.RadioButton();
            this.periodAlarmsPickInit = new System.Windows.Forms.DateTimePicker();
            this.periodAlarmsPickEnd = new System.Windows.Forms.DateTimePicker();
            this.dailyAlarms = new System.Windows.Forms.RadioButton();
            this.paramPeriodPickInit = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.weakParam = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.periodParam = new System.Windows.Forms.RadioButton();
            this.hourlyDatePick = new System.Windows.Forms.DateTimePicker();
            this.paramWeekPick = new System.Windows.Forms.DateTimePicker();
            this.paramPeriodPickEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dailyParam = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.viewParam = new System.Windows.Forms.Button();
            this.chkCi2 = new System.Windows.Forms.CheckBox();
            this.chkPh = new System.Windows.Forms.CheckBox();
            this.chkNh3 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(176, 288);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ALARMS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewAlarms);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dailyAlarmsPick);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.periodAlarms);
            this.groupBox2.Controls.Add(this.periodAlarmsPickInit);
            this.groupBox2.Controls.Add(this.periodAlarmsPickEnd);
            this.groupBox2.Controls.Add(this.dailyAlarms);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(4, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(160, 249);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver por:";
            // 
            // viewAlarms
            // 
            this.viewAlarms.Location = new System.Drawing.Point(23, 223);
            this.viewAlarms.Margin = new System.Windows.Forms.Padding(2);
            this.viewAlarms.Name = "viewAlarms";
            this.viewAlarms.Size = new System.Drawing.Size(80, 21);
            this.viewAlarms.TabIndex = 35;
            this.viewAlarms.Text = "Visualizar";
            this.viewAlarms.UseVisualStyleBackColor = true;
            this.viewAlarms.Click += new System.EventHandler(this.viewAlarms_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 116);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Fim";
            // 
            // dailyAlarmsPick
            // 
            this.dailyAlarmsPick.Location = new System.Drawing.Point(22, 40);
            this.dailyAlarmsPick.Margin = new System.Windows.Forms.Padding(2);
            this.dailyAlarmsPick.Name = "dailyAlarmsPick";
            this.dailyAlarmsPick.Size = new System.Drawing.Size(129, 20);
            this.dailyAlarmsPick.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Inicio";
            // 
            // periodAlarms
            // 
            this.periodAlarms.AutoSize = true;
            this.periodAlarms.Location = new System.Drawing.Point(5, 62);
            this.periodAlarms.Margin = new System.Windows.Forms.Padding(2);
            this.periodAlarms.Name = "periodAlarms";
            this.periodAlarms.Size = new System.Drawing.Size(61, 17);
            this.periodAlarms.TabIndex = 1;
            this.periodAlarms.TabStop = true;
            this.periodAlarms.Text = "Periodo";
            this.periodAlarms.UseVisualStyleBackColor = true;
            // 
            // periodAlarmsPickInit
            // 
            this.periodAlarmsPickInit.Location = new System.Drawing.Point(23, 96);
            this.periodAlarmsPickInit.Margin = new System.Windows.Forms.Padding(2);
            this.periodAlarmsPickInit.Name = "periodAlarmsPickInit";
            this.periodAlarmsPickInit.Size = new System.Drawing.Size(129, 20);
            this.periodAlarmsPickInit.TabIndex = 40;
            // 
            // periodAlarmsPickEnd
            // 
            this.periodAlarmsPickEnd.Location = new System.Drawing.Point(23, 133);
            this.periodAlarmsPickEnd.Margin = new System.Windows.Forms.Padding(2);
            this.periodAlarmsPickEnd.Name = "periodAlarmsPickEnd";
            this.periodAlarmsPickEnd.Size = new System.Drawing.Size(129, 20);
            this.periodAlarmsPickEnd.TabIndex = 39;
            // 
            // dailyAlarms
            // 
            this.dailyAlarms.AutoSize = true;
            this.dailyAlarms.Location = new System.Drawing.Point(5, 18);
            this.dailyAlarms.Margin = new System.Windows.Forms.Padding(2);
            this.dailyAlarms.Name = "dailyAlarms";
            this.dailyAlarms.Size = new System.Drawing.Size(41, 17);
            this.dailyAlarms.TabIndex = 0;
            this.dailyAlarms.TabStop = true;
            this.dailyAlarms.Text = "Dia";
            this.dailyAlarms.UseVisualStyleBackColor = true;
            // 
            // paramPeriodPickInit
            // 
            this.paramPeriodPickInit.Location = new System.Drawing.Point(74, 89);
            this.paramPeriodPickInit.Margin = new System.Windows.Forms.Padding(2);
            this.paramPeriodPickInit.Name = "paramPeriodPickInit";
            this.paramPeriodPickInit.Size = new System.Drawing.Size(129, 20);
            this.paramPeriodPickInit.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Inicio";
            // 
            // weakParam
            // 
            this.weakParam.AutoSize = true;
            this.weakParam.Location = new System.Drawing.Point(22, 147);
            this.weakParam.Margin = new System.Windows.Forms.Padding(2);
            this.weakParam.Name = "weakParam";
            this.weakParam.Size = new System.Drawing.Size(66, 17);
            this.weakParam.TabIndex = 2;
            this.weakParam.TabStop = true;
            this.weakParam.Text = "Semanal";
            this.weakParam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fim";
            // 
            // periodParam
            // 
            this.periodParam.AutoSize = true;
            this.periodParam.Location = new System.Drawing.Point(22, 67);
            this.periodParam.Margin = new System.Windows.Forms.Padding(2);
            this.periodParam.Name = "periodParam";
            this.periodParam.Size = new System.Drawing.Size(61, 17);
            this.periodParam.TabIndex = 1;
            this.periodParam.TabStop = true;
            this.periodParam.Text = "Periodo";
            this.periodParam.UseVisualStyleBackColor = true;
            // 
            // hourlyDatePick
            // 
            this.hourlyDatePick.Location = new System.Drawing.Point(74, 45);
            this.hourlyDatePick.Margin = new System.Windows.Forms.Padding(2);
            this.hourlyDatePick.Name = "hourlyDatePick";
            this.hourlyDatePick.Size = new System.Drawing.Size(129, 20);
            this.hourlyDatePick.TabIndex = 23;
            // 
            // paramWeekPick
            // 
            this.paramWeekPick.Location = new System.Drawing.Point(74, 169);
            this.paramWeekPick.Margin = new System.Windows.Forms.Padding(2);
            this.paramWeekPick.Name = "paramWeekPick";
            this.paramWeekPick.Size = new System.Drawing.Size(129, 20);
            this.paramWeekPick.TabIndex = 36;
            // 
            // paramPeriodPickEnd
            // 
            this.paramPeriodPickEnd.Location = new System.Drawing.Point(74, 117);
            this.paramPeriodPickEnd.Margin = new System.Windows.Forms.Padding(2);
            this.paramPeriodPickEnd.Name = "paramPeriodPickEnd";
            this.paramPeriodPickEnd.Size = new System.Drawing.Size(129, 20);
            this.paramPeriodPickEnd.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Inicio";
            // 
            // dailyParam
            // 
            this.dailyParam.AutoSize = true;
            this.dailyParam.Location = new System.Drawing.Point(23, 24);
            this.dailyParam.Margin = new System.Windows.Forms.Padding(2);
            this.dailyParam.Name = "dailyParam";
            this.dailyParam.Size = new System.Drawing.Size(48, 17);
            this.dailyParam.TabIndex = 0;
            this.dailyParam.TabStop = true;
            this.dailyParam.Text = "Hora";
            this.dailyParam.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 49);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Dia";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.chkCi2);
            this.groupBox4.Controls.Add(this.chkPh);
            this.groupBox4.Controls.Add(this.chkNh3);
            this.groupBox4.Location = new System.Drawing.Point(190, 11);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(375, 288);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PARAMETROS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 42);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Seleção";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.paramWeekPick);
            this.groupBox5.Controls.Add(this.viewParam);
            this.groupBox5.Controls.Add(this.paramPeriodPickInit);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.weakParam);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.periodParam);
            this.groupBox5.Controls.Add(this.dailyParam);
            this.groupBox5.Controls.Add(this.hourlyDatePick);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.paramPeriodPickEnd);
            this.groupBox5.Location = new System.Drawing.Point(122, 17);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(242, 251);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ver por:";
            // 
            // viewParam
            // 
            this.viewParam.Location = new System.Drawing.Point(74, 223);
            this.viewParam.Margin = new System.Windows.Forms.Padding(2);
            this.viewParam.Name = "viewParam";
            this.viewParam.Size = new System.Drawing.Size(80, 21);
            this.viewParam.TabIndex = 43;
            this.viewParam.Text = "Visualizar";
            this.viewParam.UseVisualStyleBackColor = true;
            this.viewParam.Click += new System.EventHandler(this.viewParam_Click);
            // 
            // chkCi2
            // 
            this.chkCi2.AutoSize = true;
            this.chkCi2.Location = new System.Drawing.Point(13, 80);
            this.chkCi2.Margin = new System.Windows.Forms.Padding(2);
            this.chkCi2.Name = "chkCi2";
            this.chkCi2.Size = new System.Drawing.Size(42, 17);
            this.chkCi2.TabIndex = 45;
            this.chkCi2.Text = "CI2";
            this.chkCi2.UseVisualStyleBackColor = true;
            // 
            // chkPh
            // 
            this.chkPh.AutoSize = true;
            this.chkPh.Location = new System.Drawing.Point(13, 102);
            this.chkPh.Margin = new System.Windows.Forms.Padding(2);
            this.chkPh.Name = "chkPh";
            this.chkPh.Size = new System.Drawing.Size(41, 17);
            this.chkPh.TabIndex = 44;
            this.chkPh.Text = "PH";
            this.chkPh.UseVisualStyleBackColor = true;
            // 
            // chkNh3
            // 
            this.chkNh3.AutoSize = true;
            this.chkNh3.Location = new System.Drawing.Point(13, 58);
            this.chkNh3.Margin = new System.Windows.Forms.Padding(2);
            this.chkNh3.Name = "chkNh3";
            this.chkNh3.Size = new System.Drawing.Size(48, 17);
            this.chkNh3.TabIndex = 43;
            this.chkNh3.Text = "NH3";
            this.chkNh3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 331);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Smart_H20_SeeApp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton periodAlarms;
        private System.Windows.Forms.RadioButton dailyAlarms;
        private System.Windows.Forms.DateTimePicker dailyAlarmsPick;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker periodAlarmsPickInit;
        private System.Windows.Forms.DateTimePicker periodAlarmsPickEnd;
        private System.Windows.Forms.DateTimePicker paramPeriodPickInit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton weakParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton periodParam;
        private System.Windows.Forms.DateTimePicker hourlyDatePick;
        private System.Windows.Forms.DateTimePicker paramWeekPick;
        private System.Windows.Forms.DateTimePicker paramPeriodPickEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton dailyParam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button viewAlarms;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button viewParam;
        private System.Windows.Forms.CheckBox chkCi2;
        private System.Windows.Forms.CheckBox chkPh;
        private System.Windows.Forms.CheckBox chkNh3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Timer timer1;
         
    }
}

