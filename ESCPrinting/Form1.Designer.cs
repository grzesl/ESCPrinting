namespace ESCPrinting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portTB = new System.Windows.Forms.TextBox();
            this.connectB = new System.Windows.Forms.Button();
            this.lineFeedB = new System.Windows.Forms.Button();
            this.paperCutB = new System.Windows.Forms.Button();
            this.beepB = new System.Windows.Forms.Button();
            this.alignLeftB = new System.Windows.Forms.Button();
            this.alignCenterB = new System.Windows.Forms.Button();
            this.alignRightB = new System.Windows.Forms.Button();
            this.boldCB = new System.Windows.Forms.CheckBox();
            this.doubleWidthCB = new System.Windows.Forms.CheckBox();
            this.doubleHeightCB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textTB = new System.Windows.Forms.TextBox();
            this.sendB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.chUTF8B = new System.Windows.Forms.Button();
            this.chCP852B = new System.Windows.Forms.Button();
            this.chASCIIB = new System.Windows.Forms.Button();
            this.disconnectB = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chCP850B = new System.Windows.Forms.Button();
            this.underlineCB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.clearImgB = new System.Windows.Forms.Button();
            this.imgTB = new System.Windows.Forms.TextBox();
            this.sendImg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonTestPrintout = new System.Windows.Forms.Button();
            this.cbAppendLF = new System.Windows.Forms.CheckBox();
            this.buttonSendQRCode = new System.Windows.Forms.Button();
            this.buttonClearQrcode = new System.Windows.Forms.Button();
            this.textBoxQRcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSendBarcode = new System.Windows.Forms.Button();
            this.buttonClearBarcode = new System.Windows.Forms.Button();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Printer IP:";
            // 
            // ipTB
            // 
            this.ipTB.Location = new System.Drawing.Point(165, 10);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(87, 20);
            this.ipTB.TabIndex = 1;
            this.ipTB.Text = "192.168.0.1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(255, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port:";
            // 
            // portTB
            // 
            this.portTB.Location = new System.Drawing.Point(290, 10);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(61, 20);
            this.portTB.TabIndex = 3;
            this.portTB.Text = "9100";
            // 
            // connectB
            // 
            this.connectB.Location = new System.Drawing.Point(367, 8);
            this.connectB.Name = "connectB";
            this.connectB.Size = new System.Drawing.Size(75, 23);
            this.connectB.TabIndex = 4;
            this.connectB.Text = "Connect";
            this.connectB.UseVisualStyleBackColor = true;
            this.connectB.Click += new System.EventHandler(this.connectB_Click);
            // 
            // lineFeedB
            // 
            this.lineFeedB.Location = new System.Drawing.Point(9, 98);
            this.lineFeedB.Name = "lineFeedB";
            this.lineFeedB.Size = new System.Drawing.Size(75, 23);
            this.lineFeedB.TabIndex = 6;
            this.lineFeedB.Text = "LineFeed";
            this.lineFeedB.UseVisualStyleBackColor = true;
            this.lineFeedB.Click += new System.EventHandler(this.lineFeedB_Click);
            // 
            // paperCutB
            // 
            this.paperCutB.Location = new System.Drawing.Point(90, 98);
            this.paperCutB.Name = "paperCutB";
            this.paperCutB.Size = new System.Drawing.Size(75, 23);
            this.paperCutB.TabIndex = 7;
            this.paperCutB.Text = "PaperCut";
            this.paperCutB.UseVisualStyleBackColor = true;
            this.paperCutB.Click += new System.EventHandler(this.paperCutB_Click);
            // 
            // beepB
            // 
            this.beepB.Location = new System.Drawing.Point(171, 98);
            this.beepB.Name = "beepB";
            this.beepB.Size = new System.Drawing.Size(75, 23);
            this.beepB.TabIndex = 8;
            this.beepB.Text = "Beep";
            this.beepB.UseVisualStyleBackColor = true;
            this.beepB.Click += new System.EventHandler(this.beepB_Click);
            // 
            // alignLeftB
            // 
            this.alignLeftB.Location = new System.Drawing.Point(9, 127);
            this.alignLeftB.Name = "alignLeftB";
            this.alignLeftB.Size = new System.Drawing.Size(75, 23);
            this.alignLeftB.TabIndex = 9;
            this.alignLeftB.Text = "AlignLeft";
            this.alignLeftB.UseVisualStyleBackColor = true;
            this.alignLeftB.Click += new System.EventHandler(this.alignLeftB_Click);
            // 
            // alignCenterB
            // 
            this.alignCenterB.Location = new System.Drawing.Point(90, 127);
            this.alignCenterB.Name = "alignCenterB";
            this.alignCenterB.Size = new System.Drawing.Size(75, 23);
            this.alignCenterB.TabIndex = 10;
            this.alignCenterB.Text = "AlignCenter";
            this.alignCenterB.UseVisualStyleBackColor = true;
            this.alignCenterB.Click += new System.EventHandler(this.alignCenterB_Click);
            // 
            // alignRightB
            // 
            this.alignRightB.Location = new System.Drawing.Point(171, 127);
            this.alignRightB.Name = "alignRightB";
            this.alignRightB.Size = new System.Drawing.Size(75, 23);
            this.alignRightB.TabIndex = 11;
            this.alignRightB.Text = "AlignRight";
            this.alignRightB.UseVisualStyleBackColor = true;
            this.alignRightB.Click += new System.EventHandler(this.alignRightB_Click);
            // 
            // boldCB
            // 
            this.boldCB.AutoSize = true;
            this.boldCB.Location = new System.Drawing.Point(9, 156);
            this.boldCB.Name = "boldCB";
            this.boldCB.Size = new System.Drawing.Size(47, 17);
            this.boldCB.TabIndex = 12;
            this.boldCB.Text = "Bold";
            this.boldCB.UseVisualStyleBackColor = true;
            // 
            // doubleWidthCB
            // 
            this.doubleWidthCB.AutoSize = true;
            this.doubleWidthCB.Location = new System.Drawing.Point(62, 156);
            this.doubleWidthCB.Name = "doubleWidthCB";
            this.doubleWidthCB.Size = new System.Drawing.Size(88, 17);
            this.doubleWidthCB.TabIndex = 13;
            this.doubleWidthCB.Text = "DoubleWidth";
            this.doubleWidthCB.UseVisualStyleBackColor = true;
            // 
            // doubleHeightCB
            // 
            this.doubleHeightCB.AutoSize = true;
            this.doubleHeightCB.Location = new System.Drawing.Point(158, 156);
            this.doubleHeightCB.Name = "doubleHeightCB";
            this.doubleHeightCB.Size = new System.Drawing.Size(91, 17);
            this.doubleHeightCB.TabIndex = 14;
            this.doubleHeightCB.Text = "DoubleHeight";
            this.doubleHeightCB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Text:";
            // 
            // textTB
            // 
            this.textTB.Location = new System.Drawing.Point(90, 173);
            this.textTB.Multiline = true;
            this.textTB.Name = "textTB";
            this.textTB.Size = new System.Drawing.Size(255, 140);
            this.textTB.TabIndex = 16;
            // 
            // sendB
            // 
            this.sendB.Location = new System.Drawing.Point(406, 290);
            this.sendB.Name = "sendB";
            this.sendB.Size = new System.Drawing.Size(75, 23);
            this.sendB.TabIndex = 17;
            this.sendB.Text = "Send";
            this.sendB.UseVisualStyleBackColor = true;
            this.sendB.Click += new System.EventHandler(this.sendB_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(58, 171);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(26, 23);
            this.clearB.TabIndex = 18;
            this.clearB.Text = "X";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(14, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 2);
            this.panel3.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Chartset:";
            // 
            // chUTF8B
            // 
            this.chUTF8B.Enabled = false;
            this.chUTF8B.Location = new System.Drawing.Point(75, 57);
            this.chUTF8B.Name = "chUTF8B";
            this.chUTF8B.Size = new System.Drawing.Size(45, 23);
            this.chUTF8B.TabIndex = 22;
            this.chUTF8B.Text = "UTF8";
            this.chUTF8B.UseVisualStyleBackColor = true;
            this.chUTF8B.Visible = false;
            this.chUTF8B.Click += new System.EventHandler(this.chUTF8B_Click);
            // 
            // chCP852B
            // 
            this.chCP852B.Location = new System.Drawing.Point(126, 57);
            this.chCP852B.Name = "chCP852B";
            this.chCP852B.Size = new System.Drawing.Size(106, 23);
            this.chCP852B.TabIndex = 23;
            this.chCP852B.Text = "Windows 1252";
            this.chCP852B.UseVisualStyleBackColor = true;
            this.chCP852B.Click += new System.EventHandler(this.chCP852B_Click);
            // 
            // chASCIIB
            // 
            this.chASCIIB.Location = new System.Drawing.Point(346, 57);
            this.chASCIIB.Name = "chASCIIB";
            this.chASCIIB.Size = new System.Drawing.Size(73, 23);
            this.chASCIIB.TabIndex = 24;
            this.chASCIIB.Text = "ASCII";
            this.chASCIIB.UseVisualStyleBackColor = true;
            this.chASCIIB.Click += new System.EventHandler(this.chASCIIB_Click);
            // 
            // disconnectB
            // 
            this.disconnectB.Enabled = false;
            this.disconnectB.Location = new System.Drawing.Point(448, 8);
            this.disconnectB.Name = "disconnectB";
            this.disconnectB.Size = new System.Drawing.Size(75, 23);
            this.disconnectB.TabIndex = 25;
            this.disconnectB.Text = "Disconnect";
            this.disconnectB.UseVisualStyleBackColor = true;
            this.disconnectB.Click += new System.EventHandler(this.disconnectB_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(15, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 2);
            this.panel1.TabIndex = 5;
            // 
            // chCP850B
            // 
            this.chCP850B.Location = new System.Drawing.Point(238, 57);
            this.chCP850B.Name = "chCP850B";
            this.chCP850B.Size = new System.Drawing.Size(102, 23);
            this.chCP850B.TabIndex = 26;
            this.chCP850B.Text = "Windows 1250";
            this.chCP850B.UseVisualStyleBackColor = true;
            this.chCP850B.Click += new System.EventHandler(this.chCP850B_Click);
            // 
            // underlineCB
            // 
            this.underlineCB.AutoSize = true;
            this.underlineCB.Location = new System.Drawing.Point(254, 156);
            this.underlineCB.Name = "underlineCB";
            this.underlineCB.Size = new System.Drawing.Size(71, 17);
            this.underlineCB.TabIndex = 27;
            this.underlineCB.Text = "Underline";
            this.underlineCB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Image:";
            // 
            // clearImgB
            // 
            this.clearImgB.Location = new System.Drawing.Point(58, 317);
            this.clearImgB.Name = "clearImgB";
            this.clearImgB.Size = new System.Drawing.Size(26, 23);
            this.clearImgB.TabIndex = 30;
            this.clearImgB.Text = "X";
            this.clearImgB.UseVisualStyleBackColor = true;
            this.clearImgB.Click += new System.EventHandler(this.clearImgB_Click);
            // 
            // imgTB
            // 
            this.imgTB.Location = new System.Drawing.Point(90, 319);
            this.imgTB.Name = "imgTB";
            this.imgTB.Size = new System.Drawing.Size(255, 20);
            this.imgTB.TabIndex = 29;
            // 
            // sendImg
            // 
            this.sendImg.Location = new System.Drawing.Point(406, 316);
            this.sendImg.Name = "sendImg";
            this.sendImg.Size = new System.Drawing.Size(75, 23);
            this.sendImg.TabIndex = 31;
            this.sendImg.Text = "Send";
            this.sendImg.UseVisualStyleBackColor = true;
            this.sendImg.Click += new System.EventHandler(this.sendImg_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(9, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 2);
            this.panel2.TabIndex = 33;
            // 
            // buttonTestPrintout
            // 
            this.buttonTestPrintout.Location = new System.Drawing.Point(406, 432);
            this.buttonTestPrintout.Name = "buttonTestPrintout";
            this.buttonTestPrintout.Size = new System.Drawing.Size(75, 23);
            this.buttonTestPrintout.TabIndex = 34;
            this.buttonTestPrintout.Text = "Test Printout";
            this.buttonTestPrintout.UseVisualStyleBackColor = true;
            this.buttonTestPrintout.Click += new System.EventHandler(this.buttonTestPrintout_Click);
            // 
            // cbAppendLF
            // 
            this.cbAppendLF.AutoSize = true;
            this.cbAppendLF.Checked = true;
            this.cbAppendLF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAppendLF.Location = new System.Drawing.Point(361, 294);
            this.cbAppendLF.Name = "cbAppendLF";
            this.cbAppendLF.Size = new System.Drawing.Size(38, 17);
            this.cbAppendLF.TabIndex = 35;
            this.cbAppendLF.Text = "LF";
            this.cbAppendLF.UseVisualStyleBackColor = true;
            // 
            // buttonSendQRCode
            // 
            this.buttonSendQRCode.Location = new System.Drawing.Point(406, 342);
            this.buttonSendQRCode.Name = "buttonSendQRCode";
            this.buttonSendQRCode.Size = new System.Drawing.Size(75, 23);
            this.buttonSendQRCode.TabIndex = 39;
            this.buttonSendQRCode.Text = "Send";
            this.buttonSendQRCode.UseVisualStyleBackColor = true;
            this.buttonSendQRCode.Click += new System.EventHandler(this.buttonSendQRCode_Click);
            // 
            // buttonClearQrcode
            // 
            this.buttonClearQrcode.Location = new System.Drawing.Point(58, 343);
            this.buttonClearQrcode.Name = "buttonClearQrcode";
            this.buttonClearQrcode.Size = new System.Drawing.Size(26, 23);
            this.buttonClearQrcode.TabIndex = 38;
            this.buttonClearQrcode.Text = "X";
            this.buttonClearQrcode.UseVisualStyleBackColor = true;
            this.buttonClearQrcode.Click += new System.EventHandler(this.buttonClearQrcode_Click);
            // 
            // textBoxQRcode
            // 
            this.textBoxQRcode.Location = new System.Drawing.Point(90, 345);
            this.textBoxQRcode.Name = "textBoxQRcode";
            this.textBoxQRcode.Size = new System.Drawing.Size(255, 20);
            this.textBoxQRcode.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "QRCode:";
            // 
            // buttonSendBarcode
            // 
            this.buttonSendBarcode.Location = new System.Drawing.Point(406, 369);
            this.buttonSendBarcode.Name = "buttonSendBarcode";
            this.buttonSendBarcode.Size = new System.Drawing.Size(75, 23);
            this.buttonSendBarcode.TabIndex = 43;
            this.buttonSendBarcode.Text = "Send";
            this.buttonSendBarcode.UseVisualStyleBackColor = true;
            this.buttonSendBarcode.Click += new System.EventHandler(this.buttonSendBarcode_Click);
            // 
            // buttonClearBarcode
            // 
            this.buttonClearBarcode.Location = new System.Drawing.Point(58, 370);
            this.buttonClearBarcode.Name = "buttonClearBarcode";
            this.buttonClearBarcode.Size = new System.Drawing.Size(26, 23);
            this.buttonClearBarcode.TabIndex = 42;
            this.buttonClearBarcode.Text = "X";
            this.buttonClearBarcode.UseVisualStyleBackColor = true;
            this.buttonClearBarcode.Click += new System.EventHandler(this.buttonClearBarcode_Click);
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Location = new System.Drawing.Point(90, 372);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(255, 20);
            this.textBoxBarcode.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Barcode:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 467);
            this.Controls.Add(this.buttonSendBarcode);
            this.Controls.Add(this.buttonClearBarcode);
            this.Controls.Add(this.textBoxBarcode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSendQRCode);
            this.Controls.Add(this.buttonClearQrcode);
            this.Controls.Add(this.textBoxQRcode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAppendLF);
            this.Controls.Add(this.buttonTestPrintout);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sendImg);
            this.Controls.Add(this.clearImgB);
            this.Controls.Add(this.imgTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.underlineCB);
            this.Controls.Add(this.chCP850B);
            this.Controls.Add(this.disconnectB);
            this.Controls.Add(this.chASCIIB);
            this.Controls.Add(this.chCP852B);
            this.Controls.Add(this.chUTF8B);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.sendB);
            this.Controls.Add(this.textTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.doubleHeightCB);
            this.Controls.Add(this.doubleWidthCB);
            this.Controls.Add(this.boldCB);
            this.Controls.Add(this.alignRightB);
            this.Controls.Add(this.alignCenterB);
            this.Controls.Add(this.alignLeftB);
            this.Controls.Add(this.beepB);
            this.Controls.Add(this.paperCutB);
            this.Controls.Add(this.lineFeedB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.connectB);
            this.Controls.Add(this.portTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipTB);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ESCPrinting Test v.1.07";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTB;
        private System.Windows.Forms.Button connectB;
        private System.Windows.Forms.Button lineFeedB;
        private System.Windows.Forms.Button paperCutB;
        private System.Windows.Forms.Button beepB;
        private System.Windows.Forms.Button alignLeftB;
        private System.Windows.Forms.Button alignCenterB;
        private System.Windows.Forms.Button alignRightB;
        private System.Windows.Forms.CheckBox boldCB;
        private System.Windows.Forms.CheckBox doubleWidthCB;
        private System.Windows.Forms.CheckBox doubleHeightCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textTB;
        private System.Windows.Forms.Button sendB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button chUTF8B;
        private System.Windows.Forms.Button chCP852B;
        private System.Windows.Forms.Button chASCIIB;
        private System.Windows.Forms.Button disconnectB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button chCP850B;
        private System.Windows.Forms.CheckBox underlineCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clearImgB;
        private System.Windows.Forms.TextBox imgTB;
        private System.Windows.Forms.Button sendImg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonTestPrintout;
        private System.Windows.Forms.CheckBox cbAppendLF;
        private System.Windows.Forms.Button buttonSendQRCode;
        private System.Windows.Forms.Button buttonClearQrcode;
        private System.Windows.Forms.TextBox textBoxQRcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSendBarcode;
        private System.Windows.Forms.Button buttonClearBarcode;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label label7;
    }
}

