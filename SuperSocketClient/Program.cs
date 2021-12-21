using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace SuperSocketClient
{
    class Program
    {
        static Socket socketClient { get; set; }
        static int timeInterval = 5000;
        static void Main(string[] args)
        {
            //创建实例
            socketClient = new Socket(SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            IPEndPoint point = new IPEndPoint(ip, 3666);
            //进行连接
            socketClient.Connect(point);


            //不停的接收服务器端发送的消息
            Thread thread = new Thread(Recive);
            thread.IsBackground = true;
            thread.Start();


            ////不停的给服务器发送数据
            //Thread thread2 = new Thread(Send);
            //thread2.IsBackground = true;
            //thread2.Start();


            StartHeartBeatThread();

           string s=Console.ReadLine();
           if (s.ToUpper()=="S")
           {
               Console.WriteLine("暂停发送心跳包");
               timeInterval = 30 * 1000;
           }

            Console.ReadKey();

        }
        //发送心跳包
        static void StartHeartBeatThread()
        {
            Byte[] buffter;
            Task.Run(() =>
            {
                while (true)
                {
                    buffter = Encoding.UTF8.GetBytes("6002:1" + "\r\n");
                    //buffter = Encoding.UTF8.GetBytes("asdasd");

                    socketClient.Send(buffter);
                    Console.WriteLine("向服务器发送了一个心跳包");

                    Thread.Sleep(timeInterval);
                }
            });
        }
        /// <summary>
        /// 接收消息
        /// </summary>
        /// <param name="o"></param>
        static void Recive()
        {
            while (true)
            {
                //获取发送过来的消息
                byte[] buffer = new byte[1024 * 1024 * 2];
                var effective = socketClient.Receive(buffer);
                if (effective == 0)
                {
                    break;
                }
                var str = Encoding.UTF8.GetString(buffer, 0, effective);
                Console.WriteLine("来自服务器---" + str);
                Thread.Sleep(1000);
            }
        }


        static void Send()
        {          
            int i = 0;
            while (true)
            {
                i++;
                var buffter = Encoding.UTF8.GetBytes("ClientSend "+i+"\r\n");
                var temp = socketClient.Send(buffter);
                //Console.WriteLine(i);
                Thread.Sleep(1000);
            }

        }
    }
}
