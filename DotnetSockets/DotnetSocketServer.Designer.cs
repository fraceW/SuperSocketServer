namespace SuperSocket
{
    partial class DotnetSocketServer
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
            this.btn_StartListen = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.cmb_socketlist = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_StartListen
            // 
            this.btn_StartListen.Location = new System.Drawing.Point(274, 24);
            this.btn_StartListen.Name = "btn_StartListen";
            this.btn_StartListen.Size = new System.Drawing.Size(75, 23);
            this.btn_StartListen.TabIndex = 0;
            this.btn_StartListen.Text = "开启监听";
            this.btn_StartListen.UseVisualStyleBackColor = true;
            this.btn_StartListen.Click += new System.EventHandler(this.btn_StartListen_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(542, 254);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(12, 328);
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(461, 21);
            this.txt_send.TabIndex = 2;
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(479, 326);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 3;
            this.btn_send.Text = "发送数据";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(27, 26);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(100, 21);
            this.txt_ip.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "ip";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "端口";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(168, 26);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 21);
            this.txt_port.TabIndex = 7;
            // 
            // cmb_socketlist
            // 
            this.cmb_socketlist.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmb_socketlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_socketlist.FormattingEnabled = true;
            this.cmb_socketlist.Location = new System.Drawing.Point(434, 26);
            this.cmb_socketlist.Name = "cmb_socketlist";
            this.cmb_socketlist.Size = new System.Drawing.Size(121, 20);
            this.cmb_socketlist.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "客户端列";
            // 
            // DotnetSocketServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_socketlist);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_StartListen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DotnetSocketServer";
            this.Text = "SocketServer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DotnetSocketServer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_StartListen;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.ComboBox cmb_socketlist;
        private System.Windows.Forms.Label label3;
    }
}

