namespace User
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtMsg = new CCWin.SkinControl.SkinTextBox();
            this.btnFlash = new CCWin.SkinControl.SkinButton();
            this.btnSendMsg = new CCWin.SkinControl.SkinButton();
            this.btnSendFile = new CCWin.SkinControl.SkinButton();
            this.btnPic = new CCWin.SkinControl.SkinButton();
            this.btnSelect = new CCWin.SkinControl.SkinButton();
            this.btnConnect = new CCWin.SkinControl.SkinButton();
            this.pictureBox1 = new CCWin.SkinControl.SkinPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "显示图片";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(51, 93);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(296, 284);
            this.txtLog.TabIndex = 26;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(405, 43);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 25);
            this.txtPort.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "端口:";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(98, 43);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(199, 25);
            this.txtIP.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "IP:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "用户2";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.Color.Transparent;
            this.txtMsg.DownBack = null;
            this.txtMsg.Icon = null;
            this.txtMsg.IconIsButton = false;
            this.txtMsg.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtMsg.IsPasswordChat = '\0';
            this.txtMsg.IsSystemPasswordChar = false;
            this.txtMsg.Lines = new string[0];
            this.txtMsg.Location = new System.Drawing.Point(51, 397);
            this.txtMsg.Margin = new System.Windows.Forms.Padding(0);
            this.txtMsg.MaxLength = 32767;
            this.txtMsg.MinimumSize = new System.Drawing.Size(28, 28);
            this.txtMsg.MouseBack = null;
            this.txtMsg.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.NormlBack = null;
            this.txtMsg.Padding = new System.Windows.Forms.Padding(5);
            this.txtMsg.ReadOnly = false;
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMsg.Size = new System.Drawing.Size(296, 90);
            // 
            // 
            // 
            this.txtMsg.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMsg.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMsg.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.txtMsg.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.txtMsg.SkinTxt.Multiline = true;
            this.txtMsg.SkinTxt.Name = "BaseText";
            this.txtMsg.SkinTxt.Size = new System.Drawing.Size(286, 80);
            this.txtMsg.SkinTxt.TabIndex = 0;
            this.txtMsg.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtMsg.SkinTxt.WaterText = "";
            this.txtMsg.TabIndex = 35;
            this.txtMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMsg.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.txtMsg.WaterText = "";
            this.txtMsg.WordWrap = true;
            // 
            // btnFlash
            // 
            this.btnFlash.BackColor = System.Drawing.Color.Transparent;
            this.btnFlash.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnFlash.DownBack = null;
            this.btnFlash.Location = new System.Drawing.Point(58, 531);
            this.btnFlash.MouseBack = null;
            this.btnFlash.Name = "btnFlash";
            this.btnFlash.NormlBack = null;
            this.btnFlash.Size = new System.Drawing.Size(75, 23);
            this.btnFlash.TabIndex = 34;
            this.btnFlash.Text = "抖动";
            this.btnFlash.UseVisualStyleBackColor = false;
            this.btnFlash.Click += new System.EventHandler(this.btnFlash_Click);
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.BackColor = System.Drawing.Color.Transparent;
            this.btnSendMsg.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSendMsg.DownBack = null;
            this.btnSendMsg.Location = new System.Drawing.Point(272, 531);
            this.btnSendMsg.MouseBack = null;
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.NormlBack = null;
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 33;
            this.btnSendMsg.Text = "发送信息";
            this.btnSendMsg.UseVisualStyleBackColor = false;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btnSendFile
            // 
            this.btnSendFile.BackColor = System.Drawing.Color.Transparent;
            this.btnSendFile.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSendFile.DownBack = null;
            this.btnSendFile.Location = new System.Drawing.Point(161, 531);
            this.btnSendFile.MouseBack = null;
            this.btnSendFile.Name = "btnSendFile";
            this.btnSendFile.NormlBack = null;
            this.btnSendFile.Size = new System.Drawing.Size(75, 23);
            this.btnSendFile.TabIndex = 32;
            this.btnSendFile.Text = "发送文件";
            this.btnSendFile.UseVisualStyleBackColor = false;
            this.btnSendFile.Click += new System.EventHandler(this.btnSendFile_Click);
            // 
            // btnPic
            // 
            this.btnPic.BackColor = System.Drawing.Color.Transparent;
            this.btnPic.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnPic.DownBack = null;
            this.btnPic.Location = new System.Drawing.Point(745, 531);
            this.btnPic.MouseBack = null;
            this.btnPic.Name = "btnPic";
            this.btnPic.NormlBack = null;
            this.btnPic.Size = new System.Drawing.Size(75, 23);
            this.btnPic.TabIndex = 31;
            this.btnPic.Text = "发送图片";
            this.btnPic.UseVisualStyleBackColor = false;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSelect.DownBack = null;
            this.btnSelect.Location = new System.Drawing.Point(528, 531);
            this.btnSelect.MouseBack = null;
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.NormlBack = null;
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 30;
            this.btnSelect.Text = "选择图片";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnConnect.DownBack = null;
            this.btnConnect.Location = new System.Drawing.Point(558, 42);
            this.btnConnect.MouseBack = null;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.NormlBack = null;
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 29;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(462, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 594);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnFlash);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.btnSendFile);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "汪嘉靖_User";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private CCWin.SkinControl.SkinTextBox txtMsg;
        private CCWin.SkinControl.SkinButton btnFlash;
        private CCWin.SkinControl.SkinButton btnSendMsg;
        private CCWin.SkinControl.SkinButton btnSendFile;
        private CCWin.SkinControl.SkinButton btnPic;
        private CCWin.SkinControl.SkinButton btnSelect;
        private CCWin.SkinControl.SkinButton btnConnect;
        private CCWin.SkinControl.SkinPictureBox pictureBox1;

    }
}

