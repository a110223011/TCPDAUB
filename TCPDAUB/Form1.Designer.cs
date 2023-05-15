namespace TCPDAUB
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbOnlineUser = new System.Windows.Forms.ListBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tBPenPoint = new System.Windows.Forms.TrackBar();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblTopic = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.rdbtnEraser = new System.Windows.Forms.RadioButton();
            this.rdbtnBlack = new System.Windows.Forms.RadioButton();
            this.rdbtnGreen = new System.Windows.Forms.RadioButton();
            this.rdbtnBlue = new System.Windows.Forms.RadioButton();
            this.rdbtnRed = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tBPenPoint)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(194)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.btnLogin.Location = new System.Drawing.Point(447, 108);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(323, 33);
            this.btnLogin.TabIndex = 110;
            this.btnLogin.Text = "Connect to Server";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.txtPort.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(188, 113);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(217, 28);
            this.txtPort.TabIndex = 109;
            this.txtPort.Text = "2013";
            this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.lbl3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.lbl3.Location = new System.Drawing.Point(32, 116);
            this.lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(145, 25);
            this.lbl3.TabIndex = 108;
            this.lbl3.Text = "Clent Port：";
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.txtIP.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.Location = new System.Drawing.Point(188, 69);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(217, 28);
            this.txtIP.TabIndex = 107;
            this.txtIP.Text = "172.23.208.24";
            this.txtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.lbl2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.lbl2.Location = new System.Drawing.Point(32, 72);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(130, 25);
            this.lbl2.TabIndex = 106;
            this.lbl2.Text = "Clent IP ：";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.txtName.Font = new System.Drawing.Font("Verdana", 12F);
            this.txtName.Location = new System.Drawing.Point(605, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 32);
            this.txtName.TabIndex = 105;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.lbl4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.lbl4.Location = new System.Drawing.Point(442, 68);
            this.lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(155, 25);
            this.lbl4.TabIndex = 104;
            this.lbl4.Text = "User Name：";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.lbl5.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.lbl5.Location = new System.Drawing.Point(611, 548);
            this.lbl5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(135, 20);
            this.lbl5.TabIndex = 103;
            this.lbl5.Text = "Online Users：";
            // 
            // lbOnlineUser
            // 
            this.lbOnlineUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.lbOnlineUser.Enabled = false;
            this.lbOnlineUser.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbOnlineUser.FormattingEnabled = true;
            this.lbOnlineUser.ItemHeight = 18;
            this.lbOnlineUser.Location = new System.Drawing.Point(612, 579);
            this.lbOnlineUser.Margin = new System.Windows.Forms.Padding(4);
            this.lbOnlineUser.Name = "lbOnlineUser";
            this.lbOnlineUser.Size = new System.Drawing.Size(177, 166);
            this.lbOnlineUser.TabIndex = 102;
            // 
            // tBPenPoint
            // 
            this.tBPenPoint.Enabled = false;
            this.tBPenPoint.LargeChange = 1;
            this.tBPenPoint.Location = new System.Drawing.Point(3, 40);
            this.tBPenPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tBPenPoint.Maximum = 20;
            this.tBPenPoint.Minimum = 1;
            this.tBPenPoint.Name = "tBPenPoint";
            this.tBPenPoint.Size = new System.Drawing.Size(170, 56);
            this.tBPenPoint.TabIndex = 120;
            this.tBPenPoint.Value = 1;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.lblTime.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.lblTime.Location = new System.Drawing.Point(525, 182);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(61, 25);
            this.lblTime.TabIndex = 122;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.lblTopic.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.lblTopic.Location = new System.Drawing.Point(31, 182);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(102, 25);
            this.lblTopic.TabIndex = 123;
            this.lblTopic.Text = "Question";
            this.lblTopic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAnswer
            // 
            this.txtAnswer.AcceptsReturn = true;
            this.txtAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.txtAnswer.Enabled = false;
            this.txtAnswer.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAnswer.Location = new System.Drawing.Point(20, 716);
            this.txtAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(492, 22);
            this.txtAnswer.TabIndex = 124;
            this.txtAnswer.Text = "Type Your Anwser";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(194)))));
            this.btnCheck.Enabled = false;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.btnCheck.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnCheck.ForeColor = System.Drawing.Color.Black;
            this.btnCheck.Location = new System.Drawing.Point(518, 710);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(80, 38);
            this.btnCheck.TabIndex = 125;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(194)))));
            this.btnStart.Enabled = false;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.btnStart.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Location = new System.Drawing.Point(618, 168);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(172, 39);
            this.btnStart.TabIndex = 126;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(194)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 52);
            this.panel1.TabIndex = 127;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Image = global::TCPDAUB.Properties.Resources.drawing;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 40);
            this.label1.TabIndex = 128;
            this.label1.Text = " ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(194)))));
            this.lbl1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl1.Location = new System.Drawing.Point(46, 9);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl1.Size = new System.Drawing.Size(178, 36);
            this.lbl1.TabIndex = 129;
            this.lbl1.Text = "DRAW And GUESS";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(194)))));
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(19)))), ((int)(((byte)(44)))));
            this.lblClose.Location = new System.Drawing.Point(760, 10);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(31, 29);
            this.lblClose.TabIndex = 128;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.rdbtnEraser);
            this.groupBox1.Controls.Add(this.rdbtnBlack);
            this.groupBox1.Controls.Add(this.rdbtnGreen);
            this.groupBox1.Controls.Add(this.rdbtnBlue);
            this.groupBox1.Controls.Add(this.rdbtnRed);
            this.groupBox1.Controls.Add(this.tBPenPoint);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(614, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 318);
            this.groupBox1.TabIndex = 128;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Draw Tools";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(197)))), ((int)(((byte)(194)))));
            this.btnClear.BackgroundImage = global::TCPDAUB.Properties.Resources.trash;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(85, 245);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(60, 50);
            this.btnClear.TabIndex = 119;
            this.btnClear.Text = "   ";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.button4_Click);
            // 
            // rdbtnEraser
            // 
            this.rdbtnEraser.AutoSize = true;
            this.rdbtnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdbtnEraser.Enabled = false;
            this.rdbtnEraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnEraser.ForeColor = System.Drawing.Color.LightGray;
            this.rdbtnEraser.Image = global::TCPDAUB.Properties.Resources.eraser;
            this.rdbtnEraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbtnEraser.Location = new System.Drawing.Point(16, 245);
            this.rdbtnEraser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnEraser.Name = "rdbtnEraser";
            this.rdbtnEraser.Size = new System.Drawing.Size(74, 50);
            this.rdbtnEraser.TabIndex = 118;
            this.rdbtnEraser.TabStop = true;
            this.rdbtnEraser.Text = "   ";
            this.rdbtnEraser.UseVisualStyleBackColor = true;
            // 
            // rdbtnBlack
            // 
            this.rdbtnBlack.AutoSize = true;
            this.rdbtnBlack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdbtnBlack.Checked = true;
            this.rdbtnBlack.Enabled = false;
            this.rdbtnBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnBlack.ForeColor = System.Drawing.Color.LightGray;
            this.rdbtnBlack.Image = global::TCPDAUB.Properties.Resources.blackbrush;
            this.rdbtnBlack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbtnBlack.Location = new System.Drawing.Point(16, 100);
            this.rdbtnBlack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnBlack.Name = "rdbtnBlack";
            this.rdbtnBlack.Size = new System.Drawing.Size(63, 50);
            this.rdbtnBlack.TabIndex = 117;
            this.rdbtnBlack.TabStop = true;
            this.rdbtnBlack.Text = "  ";
            this.rdbtnBlack.UseVisualStyleBackColor = true;
            // 
            // rdbtnGreen
            // 
            this.rdbtnGreen.AutoSize = true;
            this.rdbtnGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdbtnGreen.Enabled = false;
            this.rdbtnGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnGreen.ForeColor = System.Drawing.Color.LightGray;
            this.rdbtnGreen.Image = global::TCPDAUB.Properties.Resources.greenbrush;
            this.rdbtnGreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbtnGreen.Location = new System.Drawing.Point(85, 174);
            this.rdbtnGreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnGreen.Name = "rdbtnGreen";
            this.rdbtnGreen.Size = new System.Drawing.Size(63, 50);
            this.rdbtnGreen.TabIndex = 116;
            this.rdbtnGreen.TabStop = true;
            this.rdbtnGreen.Text = "  ";
            this.rdbtnGreen.UseVisualStyleBackColor = true;
            // 
            // rdbtnBlue
            // 
            this.rdbtnBlue.AutoSize = true;
            this.rdbtnBlue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdbtnBlue.Enabled = false;
            this.rdbtnBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnBlue.ForeColor = System.Drawing.Color.LightGray;
            this.rdbtnBlue.Image = global::TCPDAUB.Properties.Resources.bluebrush;
            this.rdbtnBlue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbtnBlue.Location = new System.Drawing.Point(16, 174);
            this.rdbtnBlue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnBlue.Name = "rdbtnBlue";
            this.rdbtnBlue.Size = new System.Drawing.Size(74, 50);
            this.rdbtnBlue.TabIndex = 115;
            this.rdbtnBlue.TabStop = true;
            this.rdbtnBlue.Text = "   ";
            this.rdbtnBlue.UseVisualStyleBackColor = true;
            // 
            // rdbtnRed
            // 
            this.rdbtnRed.AutoSize = true;
            this.rdbtnRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdbtnRed.Enabled = false;
            this.rdbtnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnRed.ForeColor = System.Drawing.Color.LightGray;
            this.rdbtnRed.Image = global::TCPDAUB.Properties.Resources.redbrush;
            this.rdbtnRed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbtnRed.Location = new System.Drawing.Point(85, 100);
            this.rdbtnRed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdbtnRed.Name = "rdbtnRed";
            this.rdbtnRed.Size = new System.Drawing.Size(74, 50);
            this.rdbtnRed.TabIndex = 114;
            this.rdbtnRed.TabStop = true;
            this.rdbtnRed.Text = "   ";
            this.rdbtnRed.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(254)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(20, 169);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 366);
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(230)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(802, 769);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbOnlineUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TCP聊天室客戶端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBPenPoint)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnLogin;
        internal System.Windows.Forms.TextBox txtPort;
        internal System.Windows.Forms.Label lbl3;
        internal System.Windows.Forms.TextBox txtIP;
        internal System.Windows.Forms.Label lbl2;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label lbl4;
        internal System.Windows.Forms.Label lbl5;
        internal System.Windows.Forms.ListBox lbOnlineUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.RadioButton rdbtnRed;
        private System.Windows.Forms.RadioButton rdbtnBlue;
        private System.Windows.Forms.RadioButton rdbtnGreen;
        private System.Windows.Forms.RadioButton rdbtnBlack;
        private System.Windows.Forms.RadioButton rdbtnEraser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TrackBar tBPenPoint;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label lbl1;
        internal System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

