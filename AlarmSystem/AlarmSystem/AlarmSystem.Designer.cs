namespace AlarmSystem
{
    partial class AlarmSystem
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
            this.grpBox_PH = new System.Windows.Forms.GroupBox();
            this.btn_DelPhRules = new System.Windows.Forms.Button();
            this.lstBox_PHRules = new System.Windows.Forms.ListBox();
            this.lbl_phWarning = new System.Windows.Forms.Label();
            this.txtBoxValue2_PH = new System.Windows.Forms.TextBox();
            this.txtBoxValue1_PH = new System.Windows.Forms.TextBox();
            this.lblAnd_PH = new System.Windows.Forms.Label();
            this.lblValue2_PH = new System.Windows.Forms.Label();
            this.lblValue1_PH = new System.Windows.Forms.Label();
            this.cmbBoxCondition_PH = new System.Windows.Forms.ComboBox();
            this.btnSetRule_PH = new System.Windows.Forms.Button();
            this.lblCondition_PH = new System.Windows.Forms.Label();
            this.grpBox_NH3 = new System.Windows.Forms.GroupBox();
            this.btn_DelNH3Rules = new System.Windows.Forms.Button();
            this.lstBox_NH3Rules = new System.Windows.Forms.ListBox();
            this.lbl_nh3Warning = new System.Windows.Forms.Label();
            this.txtBoxValue2_NH3 = new System.Windows.Forms.TextBox();
            this.txtBoxValue1_NH3 = new System.Windows.Forms.TextBox();
            this.lblCondition_NH3 = new System.Windows.Forms.Label();
            this.lblAnd_NH3 = new System.Windows.Forms.Label();
            this.cmbBoxCondition_NH3 = new System.Windows.Forms.ComboBox();
            this.lblValue2_NH3 = new System.Windows.Forms.Label();
            this.btnSetRule_NH3 = new System.Windows.Forms.Button();
            this.lblValue1_NH3 = new System.Windows.Forms.Label();
            this.grpBoc_CI2 = new System.Windows.Forms.GroupBox();
            this.btn_DelCI2Rules = new System.Windows.Forms.Button();
            this.lstBox_CI2Rules = new System.Windows.Forms.ListBox();
            this.lbl_ci2Warning = new System.Windows.Forms.Label();
            this.txtBoxValue2_CI2 = new System.Windows.Forms.TextBox();
            this.txtBoxValue1_CI2 = new System.Windows.Forms.TextBox();
            this.cmbBoxCondition_CI2 = new System.Windows.Forms.ComboBox();
            this.lblAnd_CI2 = new System.Windows.Forms.Label();
            this.lblCondition_CI2 = new System.Windows.Forms.Label();
            this.lblValue2_CI2 = new System.Windows.Forms.Label();
            this.btnSetRule_CI2 = new System.Windows.Forms.Button();
            this.lblValue1_CI2 = new System.Windows.Forms.Label();
            this.btnDefaultRules = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBox_XmlPreviewer = new System.Windows.Forms.TextBox();
            this.grpBox_PH.SuspendLayout();
            this.grpBox_NH3.SuspendLayout();
            this.grpBoc_CI2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBox_PH
            // 
            this.grpBox_PH.Controls.Add(this.btn_DelPhRules);
            this.grpBox_PH.Controls.Add(this.lstBox_PHRules);
            this.grpBox_PH.Controls.Add(this.lbl_phWarning);
            this.grpBox_PH.Controls.Add(this.txtBoxValue2_PH);
            this.grpBox_PH.Controls.Add(this.txtBoxValue1_PH);
            this.grpBox_PH.Controls.Add(this.lblAnd_PH);
            this.grpBox_PH.Controls.Add(this.lblValue2_PH);
            this.grpBox_PH.Controls.Add(this.lblValue1_PH);
            this.grpBox_PH.Controls.Add(this.cmbBoxCondition_PH);
            this.grpBox_PH.Controls.Add(this.btnSetRule_PH);
            this.grpBox_PH.Controls.Add(this.lblCondition_PH);
            this.grpBox_PH.Location = new System.Drawing.Point(12, 12);
            this.grpBox_PH.Name = "grpBox_PH";
            this.grpBox_PH.Size = new System.Drawing.Size(910, 180);
            this.grpBox_PH.TabIndex = 3;
            this.grpBox_PH.TabStop = false;
            this.grpBox_PH.Text = "PH";
            // 
            // btn_DelPhRules
            // 
            this.btn_DelPhRules.Location = new System.Drawing.Point(772, 146);
            this.btn_DelPhRules.Name = "btn_DelPhRules";
            this.btn_DelPhRules.Size = new System.Drawing.Size(114, 23);
            this.btn_DelPhRules.TabIndex = 10;
            this.btn_DelPhRules.Text = "Delete All PH Rules";
            this.btn_DelPhRules.UseVisualStyleBackColor = true;
            // 
            // lstBox_PHRules
            // 
            this.lstBox_PHRules.FormattingEnabled = true;
            this.lstBox_PHRules.Location = new System.Drawing.Point(750, 19);
            this.lstBox_PHRules.Name = "lstBox_PHRules";
            this.lstBox_PHRules.Size = new System.Drawing.Size(154, 121);
            this.lstBox_PHRules.TabIndex = 9;
            // 
            // lbl_phWarning
            // 
            this.lbl_phWarning.AutoSize = true;
            this.lbl_phWarning.BackColor = System.Drawing.Color.Red;
            this.lbl_phWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phWarning.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_phWarning.Location = new System.Drawing.Point(6, 83);
            this.lbl_phWarning.Name = "lbl_phWarning";
            this.lbl_phWarning.Size = new System.Drawing.Size(288, 51);
            this.lbl_phWarning.TabIndex = 8;
            this.lbl_phWarning.Text = "WARNING !!!";
            this.lbl_phWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxValue2_PH
            // 
            this.txtBoxValue2_PH.Location = new System.Drawing.Point(313, 36);
            this.txtBoxValue2_PH.Name = "txtBoxValue2_PH";
            this.txtBoxValue2_PH.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValue2_PH.TabIndex = 7;
            // 
            // txtBoxValue1_PH
            // 
            this.txtBoxValue1_PH.Location = new System.Drawing.Point(176, 36);
            this.txtBoxValue1_PH.Name = "txtBoxValue1_PH";
            this.txtBoxValue1_PH.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValue1_PH.TabIndex = 6;
            // 
            // lblAnd_PH
            // 
            this.lblAnd_PH.AutoSize = true;
            this.lblAnd_PH.Location = new System.Drawing.Point(282, 39);
            this.lblAnd_PH.Name = "lblAnd_PH";
            this.lblAnd_PH.Size = new System.Drawing.Size(25, 13);
            this.lblAnd_PH.TabIndex = 5;
            this.lblAnd_PH.Text = "and";
            // 
            // lblValue2_PH
            // 
            this.lblValue2_PH.AutoSize = true;
            this.lblValue2_PH.Location = new System.Drawing.Point(347, 19);
            this.lblValue2_PH.Name = "lblValue2_PH";
            this.lblValue2_PH.Size = new System.Drawing.Size(34, 13);
            this.lblValue2_PH.TabIndex = 4;
            this.lblValue2_PH.Text = "Value";
            // 
            // lblValue1_PH
            // 
            this.lblValue1_PH.AutoSize = true;
            this.lblValue1_PH.Location = new System.Drawing.Point(205, 19);
            this.lblValue1_PH.Name = "lblValue1_PH";
            this.lblValue1_PH.Size = new System.Drawing.Size(34, 13);
            this.lblValue1_PH.TabIndex = 3;
            this.lblValue1_PH.Text = "Value";
            // 
            // cmbBoxCondition_PH
            // 
            this.cmbBoxCondition_PH.FormattingEnabled = true;
            this.cmbBoxCondition_PH.Items.AddRange(new object[] {
            "Greater Than",
            "Less Than",
            "Between",
            "Equal"});
            this.cmbBoxCondition_PH.Location = new System.Drawing.Point(10, 36);
            this.cmbBoxCondition_PH.Name = "cmbBoxCondition_PH";
            this.cmbBoxCondition_PH.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxCondition_PH.TabIndex = 2;
            this.cmbBoxCondition_PH.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCondition_PH_SelectedIndexChanged);
            // 
            // btnSetRule_PH
            // 
            this.btnSetRule_PH.Location = new System.Drawing.Point(436, 34);
            this.btnSetRule_PH.Name = "btnSetRule_PH";
            this.btnSetRule_PH.Size = new System.Drawing.Size(75, 23);
            this.btnSetRule_PH.TabIndex = 1;
            this.btnSetRule_PH.Text = "Set Rule";
            this.btnSetRule_PH.UseVisualStyleBackColor = true;
            this.btnSetRule_PH.Click += new System.EventHandler(this.btnSetRule_PH_Click);
            // 
            // lblCondition_PH
            // 
            this.lblCondition_PH.AutoSize = true;
            this.lblCondition_PH.Location = new System.Drawing.Point(7, 20);
            this.lblCondition_PH.Name = "lblCondition_PH";
            this.lblCondition_PH.Size = new System.Drawing.Size(51, 13);
            this.lblCondition_PH.TabIndex = 0;
            this.lblCondition_PH.Text = "Condition";
            // 
            // grpBox_NH3
            // 
            this.grpBox_NH3.Controls.Add(this.btn_DelNH3Rules);
            this.grpBox_NH3.Controls.Add(this.lstBox_NH3Rules);
            this.grpBox_NH3.Controls.Add(this.lbl_nh3Warning);
            this.grpBox_NH3.Controls.Add(this.txtBoxValue2_NH3);
            this.grpBox_NH3.Controls.Add(this.txtBoxValue1_NH3);
            this.grpBox_NH3.Controls.Add(this.lblCondition_NH3);
            this.grpBox_NH3.Controls.Add(this.lblAnd_NH3);
            this.grpBox_NH3.Controls.Add(this.cmbBoxCondition_NH3);
            this.grpBox_NH3.Controls.Add(this.lblValue2_NH3);
            this.grpBox_NH3.Controls.Add(this.btnSetRule_NH3);
            this.grpBox_NH3.Controls.Add(this.lblValue1_NH3);
            this.grpBox_NH3.Location = new System.Drawing.Point(12, 198);
            this.grpBox_NH3.Name = "grpBox_NH3";
            this.grpBox_NH3.Size = new System.Drawing.Size(910, 180);
            this.grpBox_NH3.TabIndex = 4;
            this.grpBox_NH3.TabStop = false;
            this.grpBox_NH3.Text = "NH3";
            // 
            // btn_DelNH3Rules
            // 
            this.btn_DelNH3Rules.Location = new System.Drawing.Point(772, 143);
            this.btn_DelNH3Rules.Name = "btn_DelNH3Rules";
            this.btn_DelNH3Rules.Size = new System.Drawing.Size(114, 23);
            this.btn_DelNH3Rules.TabIndex = 13;
            this.btn_DelNH3Rules.Text = "Delete All NH3 Rules";
            this.btn_DelNH3Rules.UseVisualStyleBackColor = true;
            // 
            // lstBox_NH3Rules
            // 
            this.lstBox_NH3Rules.FormattingEnabled = true;
            this.lstBox_NH3Rules.Location = new System.Drawing.Point(750, 16);
            this.lstBox_NH3Rules.Name = "lstBox_NH3Rules";
            this.lstBox_NH3Rules.Size = new System.Drawing.Size(154, 121);
            this.lstBox_NH3Rules.TabIndex = 10;
            // 
            // lbl_nh3Warning
            // 
            this.lbl_nh3Warning.AutoSize = true;
            this.lbl_nh3Warning.BackColor = System.Drawing.Color.Red;
            this.lbl_nh3Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nh3Warning.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_nh3Warning.Location = new System.Drawing.Point(6, 91);
            this.lbl_nh3Warning.Name = "lbl_nh3Warning";
            this.lbl_nh3Warning.Size = new System.Drawing.Size(288, 51);
            this.lbl_nh3Warning.TabIndex = 9;
            this.lbl_nh3Warning.Text = "WARNING !!!";
            this.lbl_nh3Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxValue2_NH3
            // 
            this.txtBoxValue2_NH3.Location = new System.Drawing.Point(313, 33);
            this.txtBoxValue2_NH3.Name = "txtBoxValue2_NH3";
            this.txtBoxValue2_NH3.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValue2_NH3.TabIndex = 12;
            // 
            // txtBoxValue1_NH3
            // 
            this.txtBoxValue1_NH3.Location = new System.Drawing.Point(176, 33);
            this.txtBoxValue1_NH3.Name = "txtBoxValue1_NH3";
            this.txtBoxValue1_NH3.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValue1_NH3.TabIndex = 11;
            // 
            // lblCondition_NH3
            // 
            this.lblCondition_NH3.AutoSize = true;
            this.lblCondition_NH3.Location = new System.Drawing.Point(7, 16);
            this.lblCondition_NH3.Name = "lblCondition_NH3";
            this.lblCondition_NH3.Size = new System.Drawing.Size(51, 13);
            this.lblCondition_NH3.TabIndex = 3;
            this.lblCondition_NH3.Text = "Condition";
            // 
            // lblAnd_NH3
            // 
            this.lblAnd_NH3.AutoSize = true;
            this.lblAnd_NH3.Location = new System.Drawing.Point(282, 36);
            this.lblAnd_NH3.Name = "lblAnd_NH3";
            this.lblAnd_NH3.Size = new System.Drawing.Size(25, 13);
            this.lblAnd_NH3.TabIndex = 10;
            this.lblAnd_NH3.Text = "and";
            // 
            // cmbBoxCondition_NH3
            // 
            this.cmbBoxCondition_NH3.FormattingEnabled = true;
            this.cmbBoxCondition_NH3.Items.AddRange(new object[] {
            "Greater Than",
            "Less Than",
            "Between",
            "Equal"});
            this.cmbBoxCondition_NH3.Location = new System.Drawing.Point(9, 32);
            this.cmbBoxCondition_NH3.Name = "cmbBoxCondition_NH3";
            this.cmbBoxCondition_NH3.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxCondition_NH3.TabIndex = 3;
            this.cmbBoxCondition_NH3.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCondition_NH3_SelectedIndexChanged);
            // 
            // lblValue2_NH3
            // 
            this.lblValue2_NH3.AutoSize = true;
            this.lblValue2_NH3.Location = new System.Drawing.Point(347, 16);
            this.lblValue2_NH3.Name = "lblValue2_NH3";
            this.lblValue2_NH3.Size = new System.Drawing.Size(34, 13);
            this.lblValue2_NH3.TabIndex = 9;
            this.lblValue2_NH3.Text = "Value";
            // 
            // btnSetRule_NH3
            // 
            this.btnSetRule_NH3.Location = new System.Drawing.Point(436, 26);
            this.btnSetRule_NH3.Name = "btnSetRule_NH3";
            this.btnSetRule_NH3.Size = new System.Drawing.Size(75, 23);
            this.btnSetRule_NH3.TabIndex = 2;
            this.btnSetRule_NH3.Text = "Set Rule";
            this.btnSetRule_NH3.UseVisualStyleBackColor = true;
            // 
            // lblValue1_NH3
            // 
            this.lblValue1_NH3.AutoSize = true;
            this.lblValue1_NH3.Location = new System.Drawing.Point(205, 16);
            this.lblValue1_NH3.Name = "lblValue1_NH3";
            this.lblValue1_NH3.Size = new System.Drawing.Size(34, 13);
            this.lblValue1_NH3.TabIndex = 8;
            this.lblValue1_NH3.Text = "Value";
            // 
            // grpBoc_CI2
            // 
            this.grpBoc_CI2.Controls.Add(this.btn_DelCI2Rules);
            this.grpBoc_CI2.Controls.Add(this.lstBox_CI2Rules);
            this.grpBoc_CI2.Controls.Add(this.lbl_ci2Warning);
            this.grpBoc_CI2.Controls.Add(this.txtBoxValue2_CI2);
            this.grpBoc_CI2.Controls.Add(this.txtBoxValue1_CI2);
            this.grpBoc_CI2.Controls.Add(this.cmbBoxCondition_CI2);
            this.grpBoc_CI2.Controls.Add(this.lblAnd_CI2);
            this.grpBoc_CI2.Controls.Add(this.lblCondition_CI2);
            this.grpBoc_CI2.Controls.Add(this.lblValue2_CI2);
            this.grpBoc_CI2.Controls.Add(this.btnSetRule_CI2);
            this.grpBoc_CI2.Controls.Add(this.lblValue1_CI2);
            this.grpBoc_CI2.Location = new System.Drawing.Point(12, 384);
            this.grpBoc_CI2.Name = "grpBoc_CI2";
            this.grpBoc_CI2.Size = new System.Drawing.Size(910, 180);
            this.grpBoc_CI2.TabIndex = 5;
            this.grpBoc_CI2.TabStop = false;
            this.grpBoc_CI2.Text = "CI2";
            // 
            // btn_DelCI2Rules
            // 
            this.btn_DelCI2Rules.Location = new System.Drawing.Point(772, 146);
            this.btn_DelCI2Rules.Name = "btn_DelCI2Rules";
            this.btn_DelCI2Rules.Size = new System.Drawing.Size(114, 23);
            this.btn_DelCI2Rules.TabIndex = 18;
            this.btn_DelCI2Rules.Text = "Delete All CI2 Rules";
            this.btn_DelCI2Rules.UseVisualStyleBackColor = true;
            // 
            // lstBox_CI2Rules
            // 
            this.lstBox_CI2Rules.FormattingEnabled = true;
            this.lstBox_CI2Rules.Location = new System.Drawing.Point(750, 19);
            this.lstBox_CI2Rules.Name = "lstBox_CI2Rules";
            this.lstBox_CI2Rules.Size = new System.Drawing.Size(154, 121);
            this.lstBox_CI2Rules.TabIndex = 13;
            // 
            // lbl_ci2Warning
            // 
            this.lbl_ci2Warning.AutoSize = true;
            this.lbl_ci2Warning.BackColor = System.Drawing.Color.Red;
            this.lbl_ci2Warning.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ci2Warning.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_ci2Warning.Location = new System.Drawing.Point(6, 92);
            this.lbl_ci2Warning.Name = "lbl_ci2Warning";
            this.lbl_ci2Warning.Size = new System.Drawing.Size(288, 51);
            this.lbl_ci2Warning.TabIndex = 13;
            this.lbl_ci2Warning.Text = "WARNING !!!";
            this.lbl_ci2Warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxValue2_CI2
            // 
            this.txtBoxValue2_CI2.Location = new System.Drawing.Point(313, 33);
            this.txtBoxValue2_CI2.Name = "txtBoxValue2_CI2";
            this.txtBoxValue2_CI2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValue2_CI2.TabIndex = 17;
            // 
            // txtBoxValue1_CI2
            // 
            this.txtBoxValue1_CI2.Location = new System.Drawing.Point(176, 33);
            this.txtBoxValue1_CI2.Name = "txtBoxValue1_CI2";
            this.txtBoxValue1_CI2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxValue1_CI2.TabIndex = 16;
            // 
            // cmbBoxCondition_CI2
            // 
            this.cmbBoxCondition_CI2.FormattingEnabled = true;
            this.cmbBoxCondition_CI2.Items.AddRange(new object[] {
            "Greater Than",
            "Less Than",
            "Between",
            "Equal"});
            this.cmbBoxCondition_CI2.Location = new System.Drawing.Point(6, 32);
            this.cmbBoxCondition_CI2.Name = "cmbBoxCondition_CI2";
            this.cmbBoxCondition_CI2.Size = new System.Drawing.Size(121, 21);
            this.cmbBoxCondition_CI2.TabIndex = 4;
            this.cmbBoxCondition_CI2.SelectedIndexChanged += new System.EventHandler(this.cmbBoxCondition_CI2_SelectedIndexChanged);
            // 
            // lblAnd_CI2
            // 
            this.lblAnd_CI2.AutoSize = true;
            this.lblAnd_CI2.Location = new System.Drawing.Point(282, 36);
            this.lblAnd_CI2.Name = "lblAnd_CI2";
            this.lblAnd_CI2.Size = new System.Drawing.Size(25, 13);
            this.lblAnd_CI2.TabIndex = 15;
            this.lblAnd_CI2.Text = "and";
            // 
            // lblCondition_CI2
            // 
            this.lblCondition_CI2.AutoSize = true;
            this.lblCondition_CI2.Location = new System.Drawing.Point(6, 16);
            this.lblCondition_CI2.Name = "lblCondition_CI2";
            this.lblCondition_CI2.Size = new System.Drawing.Size(51, 13);
            this.lblCondition_CI2.TabIndex = 4;
            this.lblCondition_CI2.Text = "Condition";
            // 
            // lblValue2_CI2
            // 
            this.lblValue2_CI2.AutoSize = true;
            this.lblValue2_CI2.Location = new System.Drawing.Point(347, 16);
            this.lblValue2_CI2.Name = "lblValue2_CI2";
            this.lblValue2_CI2.Size = new System.Drawing.Size(34, 13);
            this.lblValue2_CI2.TabIndex = 14;
            this.lblValue2_CI2.Text = "Value";
            // 
            // btnSetRule_CI2
            // 
            this.btnSetRule_CI2.Location = new System.Drawing.Point(436, 30);
            this.btnSetRule_CI2.Name = "btnSetRule_CI2";
            this.btnSetRule_CI2.Size = new System.Drawing.Size(75, 23);
            this.btnSetRule_CI2.TabIndex = 3;
            this.btnSetRule_CI2.Text = "Set Rule";
            this.btnSetRule_CI2.UseVisualStyleBackColor = true;
            // 
            // lblValue1_CI2
            // 
            this.lblValue1_CI2.AutoSize = true;
            this.lblValue1_CI2.Location = new System.Drawing.Point(205, 16);
            this.lblValue1_CI2.Name = "lblValue1_CI2";
            this.lblValue1_CI2.Size = new System.Drawing.Size(34, 13);
            this.lblValue1_CI2.TabIndex = 13;
            this.lblValue1_CI2.Text = "Value";
            // 
            // btnDefaultRules
            // 
            this.btnDefaultRules.Location = new System.Drawing.Point(1228, 217);
            this.btnDefaultRules.Name = "btnDefaultRules";
            this.btnDefaultRules.Size = new System.Drawing.Size(119, 23);
            this.btnDefaultRules.TabIndex = 8;
            this.btnDefaultRules.Text = "Generate XML File";
            this.btnDefaultRules.UseVisualStyleBackColor = true;
            this.btnDefaultRules.Click += new System.EventHandler(this.btnDefaultRules_Click);
            // 
            // txtBox_XmlPreviewer
            // 
            this.txtBox_XmlPreviewer.Location = new System.Drawing.Point(928, 12);
            this.txtBox_XmlPreviewer.Multiline = true;
            this.txtBox_XmlPreviewer.Name = "txtBox_XmlPreviewer";
            this.txtBox_XmlPreviewer.Size = new System.Drawing.Size(419, 199);
            this.txtBox_XmlPreviewer.TabIndex = 9;
            this.txtBox_XmlPreviewer.WordWrap = false;
            // 
            // AlarmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 580);
            this.Controls.Add(this.txtBox_XmlPreviewer);
            this.Controls.Add(this.btnDefaultRules);
            this.Controls.Add(this.grpBoc_CI2);
            this.Controls.Add(this.grpBox_NH3);
            this.Controls.Add(this.grpBox_PH);
            this.Name = "AlarmSystem";
            this.Text = "Alarm System Configurator";
            this.Shown += new System.EventHandler(this.AlarmSystem_Shown);
            this.grpBox_PH.ResumeLayout(false);
            this.grpBox_PH.PerformLayout();
            this.grpBox_NH3.ResumeLayout(false);
            this.grpBox_NH3.PerformLayout();
            this.grpBoc_CI2.ResumeLayout(false);
            this.grpBoc_CI2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBox_PH;
        private System.Windows.Forms.GroupBox grpBox_NH3;
        private System.Windows.Forms.GroupBox grpBoc_CI2;
        private System.Windows.Forms.Button btnSetRule_PH;
        private System.Windows.Forms.Label lblCondition_PH;
        private System.Windows.Forms.Button btnSetRule_NH3;
        private System.Windows.Forms.Button btnSetRule_CI2;
        private System.Windows.Forms.TextBox txtBoxValue2_PH;
        private System.Windows.Forms.TextBox txtBoxValue1_PH;
        private System.Windows.Forms.Label lblAnd_PH;
        private System.Windows.Forms.Label lblValue2_PH;
        private System.Windows.Forms.Label lblValue1_PH;
        private System.Windows.Forms.ComboBox cmbBoxCondition_PH;
        private System.Windows.Forms.TextBox txtBoxValue2_NH3;
        private System.Windows.Forms.TextBox txtBoxValue1_NH3;
        private System.Windows.Forms.Label lblCondition_NH3;
        private System.Windows.Forms.Label lblAnd_NH3;
        private System.Windows.Forms.ComboBox cmbBoxCondition_NH3;
        private System.Windows.Forms.Label lblValue2_NH3;
        private System.Windows.Forms.Label lblValue1_NH3;
        private System.Windows.Forms.TextBox txtBoxValue2_CI2;
        private System.Windows.Forms.TextBox txtBoxValue1_CI2;
        private System.Windows.Forms.ComboBox cmbBoxCondition_CI2;
        private System.Windows.Forms.Label lblAnd_CI2;
        private System.Windows.Forms.Label lblCondition_CI2;
        private System.Windows.Forms.Label lblValue2_CI2;
        private System.Windows.Forms.Label lblValue1_CI2;
        private System.Windows.Forms.Button btnDefaultRules;
        private System.Windows.Forms.Label lbl_phWarning;
        private System.Windows.Forms.Label lbl_nh3Warning;
        private System.Windows.Forms.Label lbl_ci2Warning;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox lstBox_PHRules;
        private System.Windows.Forms.ListBox lstBox_NH3Rules;
        private System.Windows.Forms.ListBox lstBox_CI2Rules;
        private System.Windows.Forms.Button btn_DelPhRules;
        private System.Windows.Forms.Button btn_DelNH3Rules;
        private System.Windows.Forms.Button btn_DelCI2Rules;
        private System.Windows.Forms.TextBox txtBox_XmlPreviewer;
    }
}

