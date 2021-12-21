namespace SocketClient
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
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.txt_Log = new System.Windows.Forms.TextBox();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_CloseConnect = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(12, 12);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(116, 21);
            this.txt_IP.TabIndex = 0;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(147, 12);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(125, 21);
            this.txt_Port.TabIndex = 1;
            // 
            // txt_Log
            // 
            this.txt_Log.Location = new System.Drawing.Point(12, 57);
            this.txt_Log.Multiline = true;
            this.txt_Log.Name = "txt_Log";
            this.txt_Log.Size = new System.Drawing.Size(441, 178);
            this.txt_Log.TabIndex = 2;
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(12, 241);
            this.txt_Msg.Multiline = true;
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.Size = new System.Drawing.Size(441, 178);
            this.txt_Msg.TabIndex = 3;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(366, 12);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "连接";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_CloseConnect
            // 
            this.btn_CloseConnect.Location = new System.Drawing.Point(499, 12);
            this.btn_CloseConnect.Name = "btn_CloseConnect";
            this.btn_CloseConnect.Size = new System.Drawing.Size(75, 23);
            this.btn_CloseConnect.TabIndex = 5;
            this.btn_CloseConnect.Text = "断开连接";
            this.btn_CloseConnect.UseVisualStyleBackColor = true;
            this.btn_CloseConnect.Click += new System.EventHandler(this.btn_CloseConnect_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(499, 438);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 6;
            this.btn_Send.Text = "发送";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 486);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_CloseConnect);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.txt_Msg);
            this.Controls.Add(this.txt_Log);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.txt_IP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.TextBox txt_Log;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_CloseConnect;
        private System.Windows.Forms.Button btn_Send;
    }
}

