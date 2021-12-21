using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace DotnetSocketClient
{
    public partial class DotnetSocketClient : Form
    {
        public DotnetSocketClient()
        {
            InitializeComponent();
        }
        byte[] buffer = new byte[2048];
        Socket socket;
        Thread thread;

        /// <summary>
        /// 连接服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_start_Click(object sender, EventArgs e)
        {
            try
            {
                //实例化socket
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //连接服务器
                socket.Connect(new IPEndPoint(IPAddress.Parse(txt_ip.Text), int.Parse(txt_port.Text)));

                thread = new Thread(StartReceive);
                thread.IsBackground = true;
                thread.Start(socket);
            }
            catch (Exception ex)
            {
                SetMessage("服务器异常:" + ex.Message);
            }

        }
        /// <summary>
        /// 开启接收
        /// </summary>
        /// <param name="obj"></param>
        private void StartReceive(object obj)
        {
            string str;
            while (true)
            {
                Socket receiveSocket = obj as Socket;
                try
                {
                    int result = receiveSocket.Receive(buffer);
                    if (result == 0)
                    {
                        break;
                    }
                    else
                    {
                        str = Encoding.Default.GetString(buffer);
                        SetMessage("接收到服务器数据: " + str);
                    }

                }
                catch (Exception ex)
                {
                    SetMessage("服务器异常:" + ex.Message);

                }
            }

        }
        /// <summary>
        /// 关闭连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            try
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
                thread.Abort();
                SetMessage("关闭与远程服务器的连接!");
            }
            catch (Exception ex)
            {
                SetMessage("异常" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            socket.Send(Encoding.Default.GetBytes(txt_send.Text));
            txt_send.Clear();
        }
        /// <summary>
        /// 添加信息
        /// </summary>
        /// <param name="msg"></param>
        private void SetMessage(string msg)
        {
            richTextBox1.Invoke(new Action(() => { richTextBox1.AppendText(msg+"\r\n"); }));
        }

        private void DotnetSocketClient_Load(object sender, EventArgs e)
        {
            txt_ip.Text = "127.0.0.1";
            txt_port.Text = "3333";
        }
    }
}
