﻿namespace WindowsFormsApplication1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listSid = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewAlarms = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dailyAlarmsPick = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.periodAlarms = new System.Windows.Forms.RadioButton();
            this.periodAlarmsPickInit = new System.Windows.Forms.DateTimePicker();
            this.periodAlarmsPickEnd = new System.Windows.Forms.DateTimePicker();
            this.dailyAlarms = new System.Windows.Forms.RadioButton();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(8, 417);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(109, 84);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listSid
            // 
            this.listSid.FormattingEnabled = true;
            this.listSid.ItemHeight = 16;
            this.listSid.Location = new System.Drawing.Point(139, 417);
            this.listSid.Name = "listSid";
            this.listSid.Size = new System.Drawing.Size(171, 84);
            this.listSid.TabIndex = 10;
            this.listSid.SelectedIndexChanged += new System.EventHandler(this.listSid_SelectedIndexChanged);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(316, 417);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(178, 84);
            this.listBox3.TabIndex = 11;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 354);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ALARMS";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(225, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 307);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alarmes Recentes";
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
            this.groupBox2.Location = new System.Drawing.Point(6, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 307);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ver por:";
            // 
            // viewAlarms
            // 
            this.viewAlarms.Location = new System.Drawing.Point(31, 275);
            this.viewAlarms.Name = "viewAlarms";
            this.viewAlarms.Size = new System.Drawing.Size(106, 26);
            this.viewAlarms.TabIndex = 35;
            this.viewAlarms.Text = "Visualizar";
            this.viewAlarms.UseVisualStyleBackColor = true;
            this.viewAlarms.Click += new System.EventHandler(this.viewAlarms_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 17);
            this.label7.TabIndex = 42;
            this.label7.Text = "Fim";
            // 
            // dailyAlarmsPick
            // 
            this.dailyAlarmsPick.Location = new System.Drawing.Point(29, 49);
            this.dailyAlarmsPick.Name = "dailyAlarmsPick";
            this.dailyAlarmsPick.Size = new System.Drawing.Size(171, 22);
            this.dailyAlarmsPick.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Inicio";
            // 
            // periodAlarms
            // 
            this.periodAlarms.AutoSize = true;
            this.periodAlarms.Location = new System.Drawing.Point(7, 76);
            this.periodAlarms.Name = "periodAlarms";
            this.periodAlarms.Size = new System.Drawing.Size(78, 21);
            this.periodAlarms.TabIndex = 1;
            this.periodAlarms.TabStop = true;
            this.periodAlarms.Text = "Periodo";
            this.periodAlarms.UseVisualStyleBackColor = true;
            // 
            // periodAlarmsPickInit
            // 
            this.periodAlarmsPickInit.Location = new System.Drawing.Point(31, 118);
            this.periodAlarmsPickInit.Name = "periodAlarmsPickInit";
            this.periodAlarmsPickInit.Size = new System.Drawing.Size(171, 22);
            this.periodAlarmsPickInit.TabIndex = 40;
            // 
            // periodAlarmsPickEnd
            // 
            this.periodAlarmsPickEnd.Location = new System.Drawing.Point(31, 164);
            this.periodAlarmsPickEnd.Name = "periodAlarmsPickEnd";
            this.periodAlarmsPickEnd.Size = new System.Drawing.Size(171, 22);
            this.periodAlarmsPickEnd.TabIndex = 39;
            // 
            // dailyAlarms
            // 
            this.dailyAlarms.AutoSize = true;
            this.dailyAlarms.Location = new System.Drawing.Point(7, 22);
            this.dailyAlarms.Name = "dailyAlarms";
            this.dailyAlarms.Size = new System.Drawing.Size(50, 21);
            this.dailyAlarms.TabIndex = 0;
            this.dailyAlarms.TabStop = true;
            this.dailyAlarms.Text = "Dia";
            this.dailyAlarms.UseVisualStyleBackColor = true;
            this.dailyAlarms.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(511, 417);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(178, 84);
            this.listBox4.TabIndex = 25;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Parametro";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Sensor/Alram Value";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelSid
            // 
            this.labelSid.AutoSize = true;
            this.labelSid.Location = new System.Drawing.Point(136, 395);
            this.labelSid.Name = "labelSid";
            this.labelSid.Size = new System.Drawing.Size(70, 17);
            this.labelSid.TabIndex = 28;
            this.labelSid.Text = "Sensor ID";
            this.labelSid.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 397);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Hora";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(695, 397);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Data";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(695, 417);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(178, 84);
            this.listBox5.TabIndex = 30;
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // paramPeriodPickInit
            // 
            this.paramPeriodPickInit.Location = new System.Drawing.Point(98, 110);
            this.paramPeriodPickInit.Name = "paramPeriodPickInit";
            this.paramPeriodPickInit.Size = new System.Drawing.Size(171, 22);
            this.paramPeriodPickInit.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Inicio";
            // 
            // weakParam
            // 
            this.weakParam.AutoSize = true;
            this.weakParam.Location = new System.Drawing.Point(30, 181);
            this.weakParam.Name = "weakParam";
            this.weakParam.Size = new System.Drawing.Size(84, 21);
            this.weakParam.TabIndex = 2;
            this.weakParam.TabStop = true;
            this.weakParam.Text = "Semanal";
            this.weakParam.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fim";
            // 
            // periodParam
            // 
            this.periodParam.AutoSize = true;
            this.periodParam.Location = new System.Drawing.Point(30, 83);
            this.periodParam.Name = "periodParam";
            this.periodParam.Size = new System.Drawing.Size(78, 21);
            this.periodParam.TabIndex = 1;
            this.periodParam.TabStop = true;
            this.periodParam.Text = "Periodo";
            this.periodParam.UseVisualStyleBackColor = true;
            // 
            // hourlyDatePick
            // 
            this.hourlyDatePick.Location = new System.Drawing.Point(98, 55);
            this.hourlyDatePick.Name = "hourlyDatePick";
            this.hourlyDatePick.Size = new System.Drawing.Size(171, 22);
            this.hourlyDatePick.TabIndex = 23;
            // 
            // paramWeekPick
            // 
            this.paramWeekPick.Location = new System.Drawing.Point(98, 208);
            this.paramWeekPick.Name = "paramWeekPick";
            this.paramWeekPick.Size = new System.Drawing.Size(171, 22);
            this.paramWeekPick.TabIndex = 36;
            // 
            // paramPeriodPickEnd
            // 
            this.paramPeriodPickEnd.Location = new System.Drawing.Point(98, 144);
            this.paramPeriodPickEnd.Name = "paramPeriodPickEnd";
            this.paramPeriodPickEnd.Size = new System.Drawing.Size(171, 22);
            this.paramPeriodPickEnd.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Inicio";
            // 
            // dailyParam
            // 
            this.dailyParam.AutoSize = true;
            this.dailyParam.Location = new System.Drawing.Point(31, 29);
            this.dailyParam.Name = "dailyParam";
            this.dailyParam.Size = new System.Drawing.Size(60, 21);
            this.dailyParam.TabIndex = 0;
            this.dailyParam.TabStop = true;
            this.dailyParam.Text = "Hora";
            this.dailyParam.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 17);
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
            this.groupBox4.Location = new System.Drawing.Point(597, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(500, 354);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PARAMETROS";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
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
            this.groupBox5.Location = new System.Drawing.Point(162, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(323, 307);
            this.groupBox5.TabIndex = 46;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ver por:";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // viewParam
            // 
            this.viewParam.Location = new System.Drawing.Point(98, 275);
            this.viewParam.Name = "viewParam";
            this.viewParam.Size = new System.Drawing.Size(106, 26);
            this.viewParam.TabIndex = 43;
            this.viewParam.Text = "Visualizar";
            this.viewParam.UseVisualStyleBackColor = true;
            this.viewParam.Click += new System.EventHandler(this.viewParam_Click);
            // 
            // chkCi2
            // 
            this.chkCi2.AutoSize = true;
            this.chkCi2.Location = new System.Drawing.Point(17, 99);
            this.chkCi2.Name = "chkCi2";
            this.chkCi2.Size = new System.Drawing.Size(50, 21);
            this.chkCi2.TabIndex = 45;
            this.chkCi2.Text = "CI2";
            this.chkCi2.UseVisualStyleBackColor = true;
            // 
            // chkPh
            // 
            this.chkPh.AutoSize = true;
            this.chkPh.Location = new System.Drawing.Point(17, 126);
            this.chkPh.Name = "chkPh";
            this.chkPh.Size = new System.Drawing.Size(49, 21);
            this.chkPh.TabIndex = 44;
            this.chkPh.Text = "PH";
            this.chkPh.UseVisualStyleBackColor = true;
            // 
            // chkNh3
            // 
            this.chkNh3.AutoSize = true;
            this.chkNh3.Location = new System.Drawing.Point(17, 72);
            this.chkNh3.Name = "chkNh3";
            this.chkNh3.Size = new System.Drawing.Size(58, 21);
            this.chkNh3.TabIndex = 43;
            this.chkNh3.Text = "NH3";
            this.chkNh3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 511);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelSid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listSid);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Smart_H20_SeeApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listSid;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox5;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button viewAlarms;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button viewParam;
        private System.Windows.Forms.CheckBox chkCi2;
        private System.Windows.Forms.CheckBox chkPh;
        private System.Windows.Forms.CheckBox chkNh3;
        private System.Windows.Forms.Label label12;
    }
}

