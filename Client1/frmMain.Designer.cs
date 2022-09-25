namespace Client1
{
    partial class frmMain
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtPowerConsumption = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServoTemperature = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVibration = new System.Windows.Forms.TextBox();
            this.chkError = new System.Windows.Forms.CheckBox();
            this.chkWorking = new System.Windows.Forms.CheckBox();
            this.lstMessage = new System.Windows.Forms.ListBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(24, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPowerConsumption
            // 
            this.txtPowerConsumption.Location = new System.Drawing.Point(12, 76);
            this.txtPowerConsumption.Name = "txtPowerConsumption";
            this.txtPowerConsumption.Size = new System.Drawing.Size(100, 20);
            this.txtPowerConsumption.TabIndex = 1;
            this.txtPowerConsumption.Text = "125";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PowerConsumption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Temperature";
            // 
            // txtServoTemperature
            // 
            this.txtServoTemperature.Location = new System.Drawing.Point(12, 125);
            this.txtServoTemperature.Name = "txtServoTemperature";
            this.txtServoTemperature.Size = new System.Drawing.Size(100, 20);
            this.txtServoTemperature.TabIndex = 3;
            this.txtServoTemperature.Text = "45";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vibration";
            // 
            // txtVibration
            // 
            this.txtVibration.Location = new System.Drawing.Point(10, 173);
            this.txtVibration.Name = "txtVibration";
            this.txtVibration.Size = new System.Drawing.Size(100, 20);
            this.txtVibration.TabIndex = 5;
            this.txtVibration.Text = "3";
            // 
            // chkError
            // 
            this.chkError.AutoSize = true;
            this.chkError.Location = new System.Drawing.Point(132, 79);
            this.chkError.Name = "chkError";
            this.chkError.Size = new System.Drawing.Size(49, 17);
            this.chkError.TabIndex = 7;
            this.chkError.Text = "Hata";
            this.chkError.UseVisualStyleBackColor = true;
            // 
            // chkWorking
            // 
            this.chkWorking.AutoSize = true;
            this.chkWorking.Location = new System.Drawing.Point(210, 78);
            this.chkWorking.Name = "chkWorking";
            this.chkWorking.Size = new System.Drawing.Size(64, 17);
            this.chkWorking.TabIndex = 8;
            this.chkWorking.Text = "Çalışıyor";
            this.chkWorking.UseVisualStyleBackColor = true;
            // 
            // lstMessage
            // 
            this.lstMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstMessage.FormattingEnabled = true;
            this.lstMessage.Location = new System.Drawing.Point(0, 198);
            this.lstMessage.Name = "lstMessage";
            this.lstMessage.Size = new System.Drawing.Size(312, 108);
            this.lstMessage.TabIndex = 9;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(132, 125);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(168, 20);
            this.txtTemp.TabIndex = 10;
            // 
            // txtPower
            // 
            this.txtPower.Location = new System.Drawing.Point(132, 172);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(168, 20);
            this.txtPower.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Aşırı Isı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Aşırı Enerji";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 306);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lstMessage);
            this.Controls.Add(this.chkWorking);
            this.Controls.Add(this.chkError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVibration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServoTemperature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPowerConsumption);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtPowerConsumption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServoTemperature;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVibration;
        private System.Windows.Forms.CheckBox chkError;
        private System.Windows.Forms.CheckBox chkWorking;
        private System.Windows.Forms.ListBox lstMessage;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

