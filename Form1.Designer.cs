namespace ArduinoCommunication
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
            this.cbbComPort = new System.Windows.Forms.ComboBox();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.lbComPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btnDigitalWrite = new System.Windows.Forms.Button();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.cbLedStatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbbComPort
            // 
            this.cbbComPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbComPort.FormattingEnabled = true;
            this.cbbComPort.Location = new System.Drawing.Point(85, 6);
            this.cbbComPort.Name = "cbbComPort";
            this.cbbComPort.Size = new System.Drawing.Size(78, 21);
            this.cbbComPort.TabIndex = 1;
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.DisplayMember = "9600";
            this.cbbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaudRate.FormatString = "N0";
            this.cbbBaudRate.FormattingEnabled = true;
            this.cbbBaudRate.Location = new System.Drawing.Point(85, 34);
            this.cbbBaudRate.Name = "cbbBaudRate";
            this.cbbBaudRate.Size = new System.Drawing.Size(78, 21);
            this.cbbBaudRate.TabIndex = 4;
            this.cbbBaudRate.ValueMember = "9600";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Location = new System.Drawing.Point(12, 37);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(58, 13);
            this.lbBaudRate.TabIndex = 3;
            this.lbBaudRate.Text = "Baud Rate";
            // 
            // lbComPort
            // 
            this.lbComPort.AutoSize = true;
            this.lbComPort.Location = new System.Drawing.Point(12, 9);
            this.lbComPort.Name = "lbComPort";
            this.lbComPort.Size = new System.Drawing.Size(50, 13);
            this.lbComPort.TabIndex = 0;
            this.lbComPort.Text = "Com Port";
            // 
            // btnConnect
            // 
            this.btnConnect.ForeColor = System.Drawing.Color.Red;
            this.btnConnect.Location = new System.Drawing.Point(15, 61);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(92, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Location = new System.Drawing.Point(179, 13);
            this.tbDisplay.Multiline = true;
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDisplay.Size = new System.Drawing.Size(254, 364);
            this.tbDisplay.TabIndex = 5;
            // 
            // btnDigitalWrite
            // 
            this.btnDigitalWrite.Location = new System.Drawing.Point(15, 91);
            this.btnDigitalWrite.Name = "btnDigitalWrite";
            this.btnDigitalWrite.Size = new System.Drawing.Size(92, 23);
            this.btnDigitalWrite.TabIndex = 6;
            this.btnDigitalWrite.Text = "Digital Write";
            this.btnDigitalWrite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDigitalWrite.UseVisualStyleBackColor = true;
            this.btnDigitalWrite.Click += new System.EventHandler(this.btnDigitalWrite_Click);
            // 
            // tbPin
            // 
            this.tbPin.Location = new System.Drawing.Point(114, 93);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(29, 20);
            this.tbPin.TabIndex = 7;
            this.tbPin.Text = "13";
            // 
            // cbLedStatus
            // 
            this.cbLedStatus.AutoSize = true;
            this.cbLedStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbLedStatus.Location = new System.Drawing.Point(150, 95);
            this.cbLedStatus.Name = "cbLedStatus";
            this.cbLedStatus.Size = new System.Drawing.Size(15, 14);
            this.cbLedStatus.TabIndex = 8;
            this.cbLedStatus.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 389);
            this.Controls.Add(this.cbLedStatus);
            this.Controls.Add(this.tbPin);
            this.Controls.Add(this.btnDigitalWrite);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.cbbBaudRate);
            this.Controls.Add(this.lbBaudRate);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbbComPort);
            this.Controls.Add(this.lbComPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbComPort;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.Label lbComPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbDisplay;
        private System.Windows.Forms.Button btnDigitalWrite;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.CheckBox cbLedStatus;

    }
}

