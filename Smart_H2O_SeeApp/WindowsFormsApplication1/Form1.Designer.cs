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
            this.readValues = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listSid = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.paramTxt = new System.Windows.Forms.TextBox();
            this.Alarms = new System.Windows.Forms.RadioButton();
            this.Param = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxParam = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.periodParam = new System.Windows.Forms.RadioButton();
            this.dailyParam = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.allAlarms = new System.Windows.Forms.RadioButton();
            this.dailyAlarms = new System.Windows.Forms.RadioButton();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSid = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.alarmTxt = new System.Windows.Forms.TextBox();
            this.dailyAlarmsPick = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // readValues
            // 
            this.readValues.Location = new System.Drawing.Point(14, 333);
            this.readValues.Name = "readValues";
            this.readValues.Size = new System.Drawing.Size(106, 26);
            this.readValues.TabIndex = 2;
            this.readValues.Text = "Read Values";
            this.readValues.UseVisualStyleBackColor = true;
            this.readValues.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 417);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(109, 84);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listSid
            // 
            this.listSid.FormattingEnabled = true;
            this.listSid.ItemHeight = 16;
            this.listSid.Location = new System.Drawing.Point(143, 417);
            this.listSid.Name = "listSid";
            this.listSid.Size = new System.Drawing.Size(171, 84);
            this.listSid.TabIndex = 10;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(320, 417);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(178, 84);
            this.listBox3.TabIndex = 11;
            // 
            // paramTxt
            // 
            this.paramTxt.Location = new System.Drawing.Point(257, 335);
            this.paramTxt.Name = "paramTxt";
            this.paramTxt.Size = new System.Drawing.Size(234, 22);
            this.paramTxt.TabIndex = 7;
            this.paramTxt.TextChanged += new System.EventHandler(this.rateTxt_TextChanged);
            // 
            // Alarms
            // 
            this.Alarms.AutoSize = true;
            this.Alarms.Location = new System.Drawing.Point(22, 21);
            this.Alarms.Name = "Alarms";
            this.Alarms.Size = new System.Drawing.Size(80, 21);
            this.Alarms.TabIndex = 18;
            this.Alarms.TabStop = true;
            this.Alarms.Text = "Alarmes";
            this.Alarms.UseVisualStyleBackColor = true;
            this.Alarms.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Param
            // 
            this.Param.AutoSize = true;
            this.Param.Location = new System.Drawing.Point(243, 21);
            this.Param.Name = "Param";
            this.Param.Size = new System.Drawing.Size(102, 21);
            this.Param.TabIndex = 19;
            this.Param.TabStop = true;
            this.Param.Text = "Parametros";
            this.Param.UseVisualStyleBackColor = true;
            this.Param.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 26);
            this.button1.TabIndex = 20;
            this.button1.Text = "Write Param";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxParam
            // 
            this.listBoxParam.FormattingEnabled = true;
            this.listBoxParam.ItemHeight = 16;
            this.listBoxParam.Location = new System.Drawing.Point(351, 21);
            this.listBoxParam.Name = "listBoxParam";
            this.listBoxParam.Size = new System.Drawing.Size(120, 20);
            this.listBoxParam.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.Alarms);
            this.groupBox1.Controls.Add(this.listBoxParam);
            this.groupBox1.Controls.Add(this.Param);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 300);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Logs";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateTimePicker4);
            this.groupBox3.Controls.Add(this.dateTimePicker5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dateTimePicker3);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.periodParam);
            this.groupBox3.Controls.Add(this.dailyParam);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.dateTimePicker2);
            this.groupBox3.Location = new System.Drawing.Point(243, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 237);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mostrar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 34;
            this.label3.Text = "Fim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 32;
            this.label1.Text = "Inicio";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(30, 118);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker3.TabIndex = 25;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 146);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(84, 21);
            this.radioButton5.TabIndex = 2;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Semanal";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // periodParam
            // 
            this.periodParam.AutoSize = true;
            this.periodParam.Location = new System.Drawing.Point(6, 76);
            this.periodParam.Name = "periodParam";
            this.periodParam.Size = new System.Drawing.Size(78, 21);
            this.periodParam.TabIndex = 1;
            this.periodParam.TabStop = true;
            this.periodParam.Text = "Periodo";
            this.periodParam.UseVisualStyleBackColor = true;
            // 
            // dailyParam
            // 
            this.dailyParam.AutoSize = true;
            this.dailyParam.Location = new System.Drawing.Point(7, 22);
            this.dailyParam.Name = "dailyParam";
            this.dailyParam.Size = new System.Drawing.Size(93, 21);
            this.dailyParam.TabIndex = 0;
            this.dailyParam.TabStop = true;
            this.dailyParam.Text = "Hora / Dia";
            this.dailyParam.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 48);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(207, 118);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker2.TabIndex = 24;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dailyAlarmsPick);
            this.groupBox2.Controls.Add(this.allAlarms);
            this.groupBox2.Controls.Add(this.dailyAlarms);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox2.Location = new System.Drawing.Point(22, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 144);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mostrar:";
            // 
            // allAlarms
            // 
            this.allAlarms.AutoSize = true;
            this.allAlarms.Location = new System.Drawing.Point(7, 78);
            this.allAlarms.Name = "allAlarms";
            this.allAlarms.Size = new System.Drawing.Size(69, 21);
            this.allAlarms.TabIndex = 1;
            this.allAlarms.TabStop = true;
            this.allAlarms.Text = "Todos";
            this.allAlarms.UseVisualStyleBackColor = true;
            // 
            // dailyAlarms
            // 
            this.dailyAlarms.AutoSize = true;
            this.dailyAlarms.Location = new System.Drawing.Point(7, 22);
            this.dailyAlarms.Name = "dailyAlarms";
            this.dailyAlarms.Size = new System.Drawing.Size(73, 21);
            this.dailyAlarms.TabIndex = 0;
            this.dailyAlarms.TabStop = true;
            this.dailyAlarms.Text = "Diarios";
            this.dailyAlarms.UseVisualStyleBackColor = true;
            this.dailyAlarms.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(504, 417);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(178, 84);
            this.listBox4.TabIndex = 25;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Parametro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Sensor/Alram Value";
            // 
            // labelSid
            // 
            this.labelSid.AutoSize = true;
            this.labelSid.Location = new System.Drawing.Point(140, 395);
            this.labelSid.Name = "labelSid";
            this.labelSid.Size = new System.Drawing.Size(70, 17);
            this.labelSid.TabIndex = 28;
            this.labelSid.Text = "Sensor ID";
            this.labelSid.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 395);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Hora";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(685, 395);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 31;
            this.label9.Text = "Data";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(688, 417);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(178, 84);
            this.listBox5.TabIndex = 30;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(143, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 26);
            this.button4.TabIndex = 32;
            this.button4.Text = "Write Alarm";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // alarmTxt
            // 
            this.alarmTxt.Location = new System.Drawing.Point(257, 367);
            this.alarmTxt.Name = "alarmTxt";
            this.alarmTxt.Size = new System.Drawing.Size(234, 22);
            this.alarmTxt.TabIndex = 33;
            // 
            // dailyAlarmsPick
            // 
            this.dailyAlarmsPick.Location = new System.Drawing.Point(29, 49);
            this.dailyAlarmsPick.Name = "dailyAlarmsPick";
            this.dailyAlarmsPick.Size = new System.Drawing.Size(171, 22);
            this.dailyAlarmsPick.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Fim";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Inicio";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(30, 189);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker4.TabIndex = 36;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.Location = new System.Drawing.Point(207, 189);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker5.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 517);
            this.Controls.Add(this.alarmTxt);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.labelSid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listSid);
            this.Controls.Add(this.paramTxt);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.readValues);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button readValues;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listSid;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.TextBox paramTxt;
        private System.Windows.Forms.RadioButton Alarms;
        private System.Windows.Forms.RadioButton Param;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxParam;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton allAlarms;
        private System.Windows.Forms.RadioButton dailyAlarms;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton periodParam;
        private System.Windows.Forms.RadioButton dailyParam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox alarmTxt;
        private System.Windows.Forms.DateTimePicker dailyAlarmsPick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
    }
}
