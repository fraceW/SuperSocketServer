using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using SuperSocket;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket
{
    public partial class SuperSocketServer : Form
    {
        public SuperSocketServer()
        {
            InitializeComponent();
        }

        private void SuperSocketServer_Load(object sender, EventArgs e)
        {
            txt_ip.Text = "192.168.6.68";
            txt_port.Text = "3333";
        } 

        //AppServer 代表了监听客户端连接，承载TCP连接的服务器实例。理想情况下，我们可以通过AppServer实例获取任何你想要的客户端连接，服务器级别的操作和逻辑应该定义在此类之中。
        AppServer appServer;
        //缓冲字节数组
        byte[] buffer = new byte[2048];

        string ipAddress_Connect;
        string ipAddress_Close;
        string ipAddress_Receive;

        //存储session和对应ip端口号的泛型集合
        Dictionary<string, AppSession> sessionList = new Dictionary<string, AppSession>();

        enum OperateType
        {

            Add = 1,  //添加
            Remove = 2  //移除
        }

        /// <summary>
        /// 开启服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_StartListen_Click(object sender, EventArgs e)
        {
            appServer = new AppServer();
            if (!appServer.Setup(int.Parse(txt_port.Text)))
            {
                SetMessage("Failed to Setup");
                return;
            }
            if (!appServer.Start())
            {
                SetMessage("Failed to Start");
                return;
            }
            else
            {
                SetMessage("开启监听");
            }
            //SuperSocket自定义了三个事件 ,连接事件,接收事件,关闭事件
            appServer.NewSessionConnected += appServer_NewSessionConnected;
            appServer.NewRequestReceived += appServer_NewRequestReceived;
            appServer.SessionClosed += appServer_SessionClosed;
        }

        /// <summary>
        /// 接收连接
        /// </summary>
        /// <param name="session"></param>
        void appServer_NewSessionConnected(AppSession session)
        {
            //有新连接的时候,添加记录  session.LocalEndPoint属性获取当前session的ip和端口号
            //AppSession 代表一个和客户端的逻辑连接，基于连接的操作应该定于在该类之中。你可以用该类的实例发送数据到客户端，接收客户端发送的数据或者关闭连接。

            //获取远程客户端的ip端口号
            ipAddress_Connect = session.RemoteEndPoint.ToString();
            ComboboxHandle(ipAddress_Connect, OperateType.Add);
            sessionList.Add(ipAddress_Connect, session);
            SetMessage(ipAddress_Connect + "已连接!");
        }

        /// <summary>
        /// 接收数据
        /// </summary>
        /// <param name="session"></param>
        /// <param name="requestInfo"></param>
        void appServer_NewRequestReceived(AppSession session, StringRequestInfo requestInfo)
        {
            //requestInfo.Key 是请求的命令行用空格分隔开的第一部分
            //requestInfo.Parameters 是用空格分隔开的其余部分
            //requestInfo.Body 是出了请求头之外的所有内容
            
            ipAddress_Receive = session.RemoteEndPoint.ToString();
            SetMessage("收到" + ipAddress_Receive + "数据: "+requestInfo.Key +" "+ requestInfo.Body);
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        /// <param name="session"></param>
        /// <param name="value"></param>
        void appServer_SessionClosed(AppSession session, SocketBase.CloseReason value)
        {   
            ipAddress_Close = session.RemoteEndPoint.ToString();
            ComboboxHandle(ipAddress_Close, OperateType.Remove);
            sessionList.Remove(ipAddress_Close);
            SetMessage(ipAddress_Close + "已关闭连接!");
        }
        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e)
        {
            //从客户端列获取想要发送数据的客户端的ip和端口号,然后从sessionList中获取对应session然后调用send()发送数据
            if (cmb_socketlist.Items.Count != 0)
            {
                if (cmb_socketlist.SelectedItem == null)
                {
                    MessageBox.Show("请选择一个客户端发送数据!");
                    return;
                }
                else
                {
                    sessionList[cmb_socketlist.SelectedItem.ToString()].Send(txt_send.Text);
                }
            }
            else
            {
                SetMessage("当前没有正在连接的客户端!");
            }
            txt_send.Clear();
        }

        /// <summary>
        /// 添加信息
        /// </summary>
        /// <param name="str"></param>
        private void SetMessage(string str)
        {
            richTextBox1.Invoke(new Action(() => { richTextBox1.AppendText(str + "\r\n"); }));
        }

        /// <summary>
        /// combobox操作
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <param name="operateType">add 添加项/remove 移除项</param>
        private void ComboboxHandle(string ipAddress, OperateType operateType)
        {
            if (operateType == OperateType.Add)
            {
                cmb_socketlist.Invoke(new Action(() => { cmb_socketlist.Items.Add(ipAddress); }));
            }
            if (operateType == OperateType.Remove)
            {
                cmb_socketlist.Invoke(new Action(() => { cmb_socketlist.Items.Remove(ipAddress); }));
            }
        }
        
    }
}
