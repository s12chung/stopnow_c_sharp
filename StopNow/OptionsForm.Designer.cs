namespace StopNow
{
    partial class OptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.alarmTimeLabel = new System.Windows.Forms.Label();
            this.maxIdleLabel = new System.Windows.Forms.Label();
            this.alarmLabel = new System.Windows.Forms.Label();
            this.preAlarmLabel = new System.Windows.Forms.Label();
            this.alarmTimeHour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.alarmTimeMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.alarmTimeSec = new System.Windows.Forms.TextBox();
            this.maxIdleHour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maxIdleMin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maxIdleSec = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.minimizeToTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alarmTimeLabel
            // 
            resources.ApplyResources(this.alarmTimeLabel, "alarmTimeLabel");
            this.alarmTimeLabel.Name = "alarmTimeLabel";
            // 
            // maxIdleLabel
            // 
            resources.ApplyResources(this.maxIdleLabel, "maxIdleLabel");
            this.maxIdleLabel.Name = "maxIdleLabel";
            // 
            // alarmLabel
            // 
            resources.ApplyResources(this.alarmLabel, "alarmLabel");
            this.alarmLabel.Name = "alarmLabel";
            // 
            // preAlarmLabel
            // 
            resources.ApplyResources(this.preAlarmLabel, "preAlarmLabel");
            this.preAlarmLabel.Name = "preAlarmLabel";
            // 
            // alarmTimeHour
            // 
            resources.ApplyResources(this.alarmTimeHour, "alarmTimeHour");
            this.alarmTimeHour.Name = "alarmTimeHour";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // alarmTimeMin
            // 
            resources.ApplyResources(this.alarmTimeMin, "alarmTimeMin");
            this.alarmTimeMin.Name = "alarmTimeMin";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // alarmTimeSec
            // 
            resources.ApplyResources(this.alarmTimeSec, "alarmTimeSec");
            this.alarmTimeSec.Name = "alarmTimeSec";
            // 
            // maxIdleHour
            // 
            resources.ApplyResources(this.maxIdleHour, "maxIdleHour");
            this.maxIdleHour.Name = "maxIdleHour";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // maxIdleMin
            // 
            resources.ApplyResources(this.maxIdleMin, "maxIdleMin");
            this.maxIdleMin.Name = "maxIdleMin";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // maxIdleSec
            // 
            resources.ApplyResources(this.maxIdleSec, "maxIdleSec");
            this.maxIdleSec.Name = "maxIdleSec";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Sorted = true;
            // 
            // okButton
            // 
            resources.ApplyResources(this.okButton, "okButton");
            this.okButton.Name = "okButton";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // minimizeToTrayCheckBox
            // 
            resources.ApplyResources(this.minimizeToTrayCheckBox, "minimizeToTrayCheckBox");
            this.minimizeToTrayCheckBox.Name = "minimizeToTrayCheckBox";
            this.minimizeToTrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Sorted = true;
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // OptionsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.minimizeToTrayCheckBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.maxIdleSec);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maxIdleMin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maxIdleHour);
            this.Controls.Add(this.alarmTimeSec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.alarmTimeMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.alarmTimeHour);
            this.Controls.Add(this.preAlarmLabel);
            this.Controls.Add(this.alarmLabel);
            this.Controls.Add(this.maxIdleLabel);
            this.Controls.Add(this.alarmTimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alarmTimeLabel;
        private System.Windows.Forms.Label maxIdleLabel;
        private System.Windows.Forms.Label alarmLabel;
        private System.Windows.Forms.Label preAlarmLabel;
        private System.Windows.Forms.TextBox alarmTimeHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox alarmTimeMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox alarmTimeSec;
        private System.Windows.Forms.TextBox maxIdleHour;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maxIdleMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maxIdleSec;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckBox minimizeToTrayCheckBox;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button cancelButton;
    }
}