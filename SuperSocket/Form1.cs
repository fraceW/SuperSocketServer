using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;

namespace SuperSocket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer timer;
         bool LockFlag = false;
        //收到心跳包的数量
        int count = 0;

        static AppServer appServer { get; set; }



       private void Form1_Load(object sender, EventArgs e)
        {
            appServer = new AppServer();


            //Setup the appServer
            if (!appServer.Setup(3666)) //Setup with listening port
            {
                WriteMsg("Failed to setup!");
                
                return;
            }           

            //Try to start the appServer
            if (!appServer.Start())
            {
                WriteMsg("Failed to start!");
                
                return;
            }

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10*1000;
            timer.Tick += timer_tick;
            timer.Start();


            //appServer.NewSessionConnected += new SessionHandler<AppSession>(appServer_NewSessionConnected);
            appServer.NewSessionConnected += appServer_NewSessionConnected;
            //appServer.NewRequestReceived += new RequestHandler<AppSession, StringRequestInfo>(appServer_NewRequestReceived);
            appServer.NewRequestReceived += appServer_NewRequestReceived;
            appServer.SessionClosed += appServer_NewSessionClosed;

           //开启接收心跳包线程
           // HeartBeatThread();
            

            //Stop the appServer
            //appServer.Stop();

            //WriteMsg("The server was stopped!");
            
        }
        
        /// <summary>
        /// 检查是否收到心跳包
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       public void timer_tick(object sender, EventArgs e)
       {

           //判断是否有心跳包 若长时间没有心跳包 说明通讯中断
           if (count==0)
           {
               WriteMsg("故障!!!!锁定");
               LockFlag = true;
           }
           //重置
           count = 0;
       }

       #region  未使用的方法
       
       /// <summary>
       /// 接收心跳包线程
       /// </summary>
       public void HeartBeatThread()
       {
           Task.Run(() => {
               while (true)
               {
                    //TODO
                   
                   
                   Thread.Sleep(1*1000);
               }
           });
       }
       
       #endregion

        
        public void appServer_NewSessionConnected(AppSession session)
        {
            WriteMsg("服务端得到来自客户端的连接成功");
            session.Send("Welcome to SuperSocket Telnet Server");
            if (LockFlag)
            {
                WriteMsg("正常,解锁");
                LockFlag = false;
            }
        }

        public void appServer_NewSessionClosed(AppSession session, SuperSocket.SocketBase.CloseReason aaa)
        {
            WriteMsg("服务端失去来自客户端的连接" + session.SessionID + aaa.ToString());

            Thread.Sleep(5000);
            if (!LockFlag)
            {
                return;
            }
            else
            {
                WriteMsg("故障!!!!锁定");
                LockFlag = true;
            }

        }


        public void appServer_NewRequestReceived(AppSession session, StringRequestInfo requestInfo)
        {
            
            WriteMsg(requestInfo.Key + requestInfo.Body);

            if (requestInfo.Key == "HeartBeat")
            {
                WriteMsg("收到客户端发来的心跳包");
                count++;
                if (LockFlag)
                {

                    WriteMsg("正常,解锁");
                    LockFlag = false;
                }
            }
            //session.Send(requestInfo.Body);
            
        }


         public void WriteMsg(string msg){
            if (this.richTextBox1.InvokeRequired)
            {
                this.richTextBox1.BeginInvoke(new Action<string>(WriteMsg), msg);
            }
            else
            {
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ");
                this.richTextBox1.AppendText(date + msg + Environment.NewLine);
            }
         }

    }
}

 