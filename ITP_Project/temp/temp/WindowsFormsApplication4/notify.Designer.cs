namespace WindowsFormsApplication4
{
    partial class notify
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtMess = new System.Windows.Forms.TextBox();
            this.txtGmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ChkSSL = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtSmtp = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPort = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSubject = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSnd = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnSnd);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtMess);
            this.panel1.Controls.Add(this.txtGmail);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.ChkSSL);
            this.panel1.Controls.Add(this.txtSmtp);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtMessage);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSubject);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCC);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 632);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPass.Location = new System.Drawing.Point(189, 184);
            this.txtPass.Margin = new System.Windows.Forms.Padding(6);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(185, 20);
            this.txtPass.TabIndex = 11;
            // 
            // txtMess
            // 
            this.txtMess.BackColor = System.Drawing.Color.LightGray;
            this.txtMess.Location = new System.Drawing.Point(189, 220);
            this.txtMess.Multiline = true;
            this.txtMess.Name = "txtMess";
            this.txtMess.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMess.Size = new System.Drawing.Size(185, 182);
            this.txtMess.TabIndex = 12;
            // 
            // txtGmail
            // 
            this.txtGmail.AutoSize = true;
            this.txtGmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtGmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtGmail.HintText = "";
            this.txtGmail.isPassword = false;
            this.txtGmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtGmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtGmail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtGmail.LineThickness = 3;
            this.txtGmail.Location = new System.Drawing.Point(189, 129);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(216, 33);
            this.txtGmail.TabIndex = 10;
            this.txtGmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPhone
            // 
            this.txtPhone.AutoSize = true;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.HintForeColor = System.Drawing.Color.Empty;
            this.txtPhone.HintText = "";
            this.txtPhone.isPassword = false;
            this.txtPhone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtPhone.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPhone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtPhone.LineThickness = 3;
            this.txtPhone.Location = new System.Drawing.Point(189, 88);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(216, 33);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.Text = "+94 PhoneNo@txtlocal.co.uk";
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(24, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 24);
            this.label15.TabIndex = 124;
            this.label15.Text = "Message :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(24, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 24);
            this.label14.TabIndex = 123;
            this.label14.Text = "Password :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(24, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 24);
            this.label13.TabIndex = 122;
            this.label13.Text = "Gmail Account :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(24, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 24);
            this.label12.TabIndex = 121;
            this.label12.Text = "Phone Number:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(141, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 29);
            this.label11.TabIndex = 120;
            this.label11.Text = "Quick SMS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.Location = new System.Drawing.Point(620, 419);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(158, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(757, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 24);
            this.label10.TabIndex = 8;
            this.label10.Text = "SSL";
            // 
            // ChkSSL
            // 
            this.ChkSSL.BackColor = System.Drawing.Color.DarkGray;
            this.ChkSSL.ChechedOffColor = System.Drawing.Color.DarkGray;
            this.ChkSSL.Checked = false;
            this.ChkSSL.CheckedOnColor = System.Drawing.Color.DarkGray;
            this.ChkSSL.ForeColor = System.Drawing.Color.Black;
            this.ChkSSL.Location = new System.Drawing.Point(731, 481);
            this.ChkSSL.Name = "ChkSSL";
            this.ChkSSL.Size = new System.Drawing.Size(20, 20);
            this.ChkSSL.TabIndex = 7;
            this.ChkSSL.OnChange += new System.EventHandler(this.ChkSSL_OnChange);
            // 
            // txtSmtp
            // 
            this.txtSmtp.AutoSize = true;
            this.txtSmtp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSmtp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSmtp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSmtp.HintForeColor = System.Drawing.Color.Empty;
            this.txtSmtp.HintText = "";
            this.txtSmtp.isPassword = false;
            this.txtSmtp.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtSmtp.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSmtp.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtSmtp.LineThickness = 3;
            this.txtSmtp.Location = new System.Drawing.Point(558, 512);
            this.txtSmtp.Margin = new System.Windows.Forms.Padding(4);
            this.txtSmtp.Name = "txtSmtp";
            this.txtSmtp.Size = new System.Drawing.Size(234, 33);
            this.txtSmtp.TabIndex = 8;
            this.txtSmtp.Text = "smtp.gmail.com";
            this.txtSmtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(482, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 24);
            this.label9.TabIndex = 119;
            this.label9.Text = "Smtp :";
            // 
            // txtPort
            // 
            this.txtPort.AutoSize = true;
            this.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPort.HintForeColor = System.Drawing.Color.Empty;
            this.txtPort.HintText = "";
            this.txtPort.isPassword = false;
            this.txtPort.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtPort.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPort.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtPort.LineThickness = 3;
            this.txtPort.Location = new System.Drawing.Point(558, 468);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(131, 33);
            this.txtPort.TabIndex = 6;
            this.txtPort.Text = "587";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(482, 477);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 117;
            this.label6.Text = "Port :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(482, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 115;
            this.label1.Text = "Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HintForeColor = System.Drawing.Color.Empty;
            this.txtUsername.HintText = "";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtUsername.LineThickness = 3;
            this.txtUsername.Location = new System.Drawing.Point(620, 369);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(184, 33);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(482, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 113;
            this.label5.Text = "User Name :";
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.LightGray;
            this.txtMessage.Location = new System.Drawing.Point(617, 225);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessage.Size = new System.Drawing.Size(250, 135);
            this.txtMessage.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(479, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 112;
            this.label8.Text = "Message :";
            // 
            // txtSubject
            // 
            this.txtSubject.AutoSize = true;
            this.txtSubject.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubject.HintForeColor = System.Drawing.Color.Empty;
            this.txtSubject.HintText = "";
            this.txtSubject.isPassword = false;
            this.txtSubject.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtSubject.LineIdleColor = System.Drawing.Color.Gray;
            this.txtSubject.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtSubject.LineThickness = 3;
            this.txtSubject.Location = new System.Drawing.Point(617, 170);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(291, 33);
            this.txtSubject.TabIndex = 3;
            this.txtSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(479, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 110;
            this.label7.Text = "Subject :";
            // 
            // txtCC
            // 
            this.txtCC.AutoSize = true;
            this.txtCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtCC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCC.HintForeColor = System.Drawing.Color.Empty;
            this.txtCC.HintText = "";
            this.txtCC.isPassword = false;
            this.txtCC.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtCC.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCC.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtCC.LineThickness = 3;
            this.txtCC.Location = new System.Drawing.Point(617, 129);
            this.txtCC.Margin = new System.Windows.Forms.Padding(4);
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(291, 33);
            this.txtCC.TabIndex = 2;
            this.txtCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(479, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 108;
            this.label3.Text = "CC :";
            // 
            // txtTo
            // 
            this.txtTo.AutoSize = true;
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.txtTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTo.HintForeColor = System.Drawing.Color.Empty;
            this.txtTo.HintText = "";
            this.txtTo.isPassword = false;
            this.txtTo.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtTo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtTo.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(100)))), ((int)(((byte)(0)))));
            this.txtTo.LineThickness = 3;
            this.txtTo.Location = new System.Drawing.Point(617, 88);
            this.txtTo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(291, 33);
            this.txtTo.TabIndex = 1;
            this.txtTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTo.Leave += new System.EventHandler(this.txtTo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(479, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 24);
            this.label2.TabIndex = 106;
            this.label2.Text = "To :";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(424, 25);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(20, 601);
            this.bunifuSeparator1.TabIndex = 105;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(645, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 29);
            this.label4.TabIndex = 92;
            this.label4.Text = "Send Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Silver;
            this.button3.Image = global::WindowsFormsApplication4.Properties.Resources.clear1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(220, 568);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 47);
            this.button3.TabIndex = 14;
            this.button3.Text = "          Clear";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnSnd
            // 
            this.btnSnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSnd.FlatAppearance.BorderSize = 0;
            this.btnSnd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnSnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnd.ForeColor = System.Drawing.Color.Silver;
            this.btnSnd.Image = global::WindowsFormsApplication4.Properties.Resources.icons8_Checked_Checkbox_32;
            this.btnSnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSnd.Location = new System.Drawing.Point(28, 568);
            this.btnSnd.Name = "btnSnd";
            this.btnSnd.Size = new System.Drawing.Size(177, 47);
            this.btnSnd.TabIndex = 13;
            this.btnSnd.Text = "  Send";
            this.btnSnd.UseVisualStyleBackColor = false;
            this.btnSnd.Click += new System.EventHandler(this.btnSnd_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Silver;
            this.btnSend.Image = global::WindowsFormsApplication4.Properties.Resources.icons8_Checked_Checkbox_32;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(483, 568);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(177, 47);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "  Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Gainsboro;
            this.bunifuImageButton1.Image = global::WindowsFormsApplication4.Properties.Resources.icons8_View_Details_32__1_;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(827, 22);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 38);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 126;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(785, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 16);
            this.label16.TabIndex = 125;
            this.label16.Text = "Inbox";
            // 
            // notify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "notify";
            this.Size = new System.Drawing.Size(1043, 632);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSend;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSubject;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCC;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessage;
        private Bunifu.Framework.UI.BunifuCheckbox ChkSSL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSmtp;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtMess;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPhone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnSnd;
        private System.Windows.Forms.Button button3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label16;
    }
}
