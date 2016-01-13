namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_BaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.comboBox_DataBits = new System.Windows.Forms.ComboBox();
            this.comboBox_Parity = new System.Windows.Forms.ComboBox();
            this.comboBox_StopBits = new System.Windows.Forms.ComboBox();
            this.checkBox_XON = new System.Windows.Forms.CheckBox();
            this.checkBox_RTS = new System.Windows.Forms.CheckBox();
            this.checkBox_DTR = new System.Windows.Forms.CheckBox();
            this.button_form2_OK = new System.Windows.Forms.Button();
            this.button_form2_CANCEL = new System.Windows.Forms.Button();
            this.button_form2_refresh = new System.Windows.Forms.Button();
            this.button_form2_open = new System.Windows.Forms.Button();
            this.comboBox_hand = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bits:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parity:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stop Bits:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Flow Control:";
            // 
            // comboBox_BaudRate
            // 
            this.comboBox_BaudRate.FormattingEnabled = true;
            this.comboBox_BaudRate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "11520"});
            this.comboBox_BaudRate.Location = new System.Drawing.Point(112, 33);
            this.comboBox_BaudRate.Name = "comboBox_BaudRate";
            this.comboBox_BaudRate.Size = new System.Drawing.Size(121, 21);
            this.comboBox_BaudRate.TabIndex = 6;
            this.comboBox_BaudRate.Text = "9600";
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(112, 6);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Port.TabIndex = 7;
            this.comboBox_Port.SelectedIndexChanged += new System.EventHandler(this.comboBox_Port_SelectedIndexChanged);
            this.comboBox_Port.Click += new System.EventHandler(this.comboBox_Port_SelectedIndexChanged);
            // 
            // comboBox_DataBits
            // 
            this.comboBox_DataBits.FormattingEnabled = true;
            this.comboBox_DataBits.Items.AddRange(new object[] {
            "8"});
            this.comboBox_DataBits.Location = new System.Drawing.Point(112, 59);
            this.comboBox_DataBits.Name = "comboBox_DataBits";
            this.comboBox_DataBits.Size = new System.Drawing.Size(121, 21);
            this.comboBox_DataBits.TabIndex = 8;
            this.comboBox_DataBits.Text = "8";
            // 
            // comboBox_Parity
            // 
            this.comboBox_Parity.FormattingEnabled = true;
            this.comboBox_Parity.Items.AddRange(new object[] {
            "Even",
            "None"});
            this.comboBox_Parity.Location = new System.Drawing.Point(112, 83);
            this.comboBox_Parity.Name = "comboBox_Parity";
            this.comboBox_Parity.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Parity.TabIndex = 9;
            this.comboBox_Parity.Text = "Even";
            // 
            // comboBox_StopBits
            // 
            this.comboBox_StopBits.FormattingEnabled = true;
            this.comboBox_StopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_StopBits.Location = new System.Drawing.Point(112, 108);
            this.comboBox_StopBits.Name = "comboBox_StopBits";
            this.comboBox_StopBits.Size = new System.Drawing.Size(121, 21);
            this.comboBox_StopBits.TabIndex = 10;
            this.comboBox_StopBits.Text = "2";
            // 
            // checkBox_XON
            // 
            this.checkBox_XON.AutoSize = true;
            this.checkBox_XON.Location = new System.Drawing.Point(112, 188);
            this.checkBox_XON.Name = "checkBox_XON";
            this.checkBox_XON.Size = new System.Drawing.Size(81, 17);
            this.checkBox_XON.TabIndex = 11;
            this.checkBox_XON.Text = "XON/XOFF";
            this.checkBox_XON.UseVisualStyleBackColor = true;
            // 
            // checkBox_RTS
            // 
            this.checkBox_RTS.AutoSize = true;
            this.checkBox_RTS.Location = new System.Drawing.Point(180, 165);
            this.checkBox_RTS.Name = "checkBox_RTS";
            this.checkBox_RTS.Size = new System.Drawing.Size(74, 17);
            this.checkBox_RTS.TabIndex = 12;
            this.checkBox_RTS.Text = "RTS/CTS";
            this.checkBox_RTS.UseVisualStyleBackColor = true;
            // 
            // checkBox_DTR
            // 
            this.checkBox_DTR.AutoSize = true;
            this.checkBox_DTR.Location = new System.Drawing.Point(112, 165);
            this.checkBox_DTR.Name = "checkBox_DTR";
            this.checkBox_DTR.Size = new System.Drawing.Size(49, 17);
            this.checkBox_DTR.TabIndex = 13;
            this.checkBox_DTR.Text = "DTR";
            this.checkBox_DTR.UseVisualStyleBackColor = true;
            // 
            // button_form2_OK
            // 
            this.button_form2_OK.Location = new System.Drawing.Point(16, 207);
            this.button_form2_OK.Name = "button_form2_OK";
            this.button_form2_OK.Size = new System.Drawing.Size(75, 23);
            this.button_form2_OK.TabIndex = 14;
            this.button_form2_OK.Text = "OK";
            this.button_form2_OK.UseVisualStyleBackColor = true;
            this.button_form2_OK.Click += new System.EventHandler(this.button_form2_OK_Click);
            // 
            // button_form2_CANCEL
            // 
            this.button_form2_CANCEL.Location = new System.Drawing.Point(197, 207);
            this.button_form2_CANCEL.Name = "button_form2_CANCEL";
            this.button_form2_CANCEL.Size = new System.Drawing.Size(75, 23);
            this.button_form2_CANCEL.TabIndex = 15;
            this.button_form2_CANCEL.Text = "CANCEL";
            this.button_form2_CANCEL.UseVisualStyleBackColor = true;
            this.button_form2_CANCEL.Click += new System.EventHandler(this.button_form2_CANCEL_Click);
            // 
            // button_form2_refresh
            // 
            this.button_form2_refresh.Location = new System.Drawing.Point(239, 6);
            this.button_form2_refresh.Name = "button_form2_refresh";
            this.button_form2_refresh.Size = new System.Drawing.Size(62, 22);
            this.button_form2_refresh.TabIndex = 16;
            this.button_form2_refresh.Text = "Refresh";
            this.button_form2_refresh.UseVisualStyleBackColor = true;
            this.button_form2_refresh.Click += new System.EventHandler(this.button_form2_refresh_Click);
            // 
            // button_form2_open
            // 
            this.button_form2_open.Location = new System.Drawing.Point(306, 6);
            this.button_form2_open.Margin = new System.Windows.Forms.Padding(2);
            this.button_form2_open.Name = "button_form2_open";
            this.button_form2_open.Size = new System.Drawing.Size(56, 24);
            this.button_form2_open.TabIndex = 17;
            this.button_form2_open.Text = "Open";
            this.button_form2_open.UseVisualStyleBackColor = true;
            this.button_form2_open.Click += new System.EventHandler(this.button_form2_open_Click);
            // 
            // comboBox_hand
            // 
            this.comboBox_hand.FormattingEnabled = true;
            this.comboBox_hand.Items.AddRange(new object[] {
            "None"});
            this.comboBox_hand.Location = new System.Drawing.Point(112, 133);
            this.comboBox_hand.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_hand.Name = "comboBox_hand";
            this.comboBox_hand.Size = new System.Drawing.Size(121, 21);
            this.comboBox_hand.TabIndex = 18;
            this.comboBox_hand.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "xonxoff:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 25);
            this.button3.TabIndex = 28;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 275);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox_hand);
            this.Controls.Add(this.button_form2_open);
            this.Controls.Add(this.button_form2_refresh);
            this.Controls.Add(this.button_form2_CANCEL);
            this.Controls.Add(this.button_form2_OK);
            this.Controls.Add(this.checkBox_DTR);
            this.Controls.Add(this.checkBox_RTS);
            this.Controls.Add(this.checkBox_XON);
            this.Controls.Add(this.comboBox_StopBits);
            this.Controls.Add(this.comboBox_Parity);
            this.Controls.Add(this.comboBox_DataBits);
            this.Controls.Add(this.comboBox_Port);
            this.Controls.Add(this.comboBox_BaudRate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Serial setting";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_BaudRate;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.ComboBox comboBox_DataBits;
        private System.Windows.Forms.ComboBox comboBox_Parity;
        private System.Windows.Forms.ComboBox comboBox_StopBits;
        private System.Windows.Forms.CheckBox checkBox_XON;
        private System.Windows.Forms.CheckBox checkBox_RTS;
        private System.Windows.Forms.CheckBox checkBox_DTR;
        private System.Windows.Forms.Button button_form2_OK;
        private System.Windows.Forms.Button button_form2_CANCEL;
        private System.Windows.Forms.Button button_form2_refresh;
        private System.Windows.Forms.Button button_form2_open;
        private System.Windows.Forms.ComboBox comboBox_hand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
    }
}