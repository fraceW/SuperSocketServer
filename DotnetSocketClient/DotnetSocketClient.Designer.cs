namespace DotnetSocketClient
{
    partial class DotnetSocketClient
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
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(35, 22);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(100, 21);
            this.txt_ip.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(177, 22);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 21);
            this.txt_port.TabIndex = 3;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(406, 20);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 4;
            this.btn_start.Text = "开始连接";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(487, 20);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "关闭连接";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 64);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(548, 256);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(12, 328);
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(469, 21);
            this.txt_send.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(487, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "发送数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DotnetSocketClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DotnetSocketClient";
            this.Text = "SocketClient";
            this.Load += new System.EventHandler(this.DotnetSocketClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Button button1;
    }
}

