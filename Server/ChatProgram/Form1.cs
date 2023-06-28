using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;

namespace ChatProgram
{
    public partial class Form1 : CCSkinMain
    {
        string notify = "";
        bool k = true;//一个标记，用于控制图标闪动
        byte[] message = new byte[1024 * 1024];
        string picPath = "";
        List<Socket> ClientProxSocketList = new List<Socket>();
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 300;//毫秒为单位
            var ip = GetLocalhostIPv4Addresses().First();
            var port = "50000";
            txtIP.Text = ip.ToString();
            txtPort.Text = port.ToString();
            //添加背景图片
            this.BackgroundImage = Image.FromFile("images/12.jpg");
        }

        public static IPAddress[] GetLocalhostIPv4Addresses()
        {
            String LocalhostName = Dns.GetHostName();

            IPHostEntry host = Dns.GetHostEntry(LocalhostName);
            List<IPAddress> addresses = new List<IPAddress>();
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    addresses.Add(ip);
            }
            return addresses.ToArray();
        }

     

        //接受客户端的连接请求
        public void AcceptClientConnect(object socket)
        {
            var serverSocket = socket as Socket;
            this.AppendTextToTxtLog("接收用户2的连接...");
            while (true)
            {
                var proxSocket = serverSocket.Accept();
                this.AppendTextToTxtLog(string.Format("用户2连接上了"));
                ClientProxSocketList.Add(proxSocket);
                //不停地接收当前连接的客户断发送来的消息
                ThreadPool.QueueUserWorkItem(new WaitCallback(ReceiveData), proxSocket);
            }

        }

        public void ReceiveData(object socket)
        {
            var proxSocket = socket as Socket;
            byte[] data = new byte[2048 * 2048];
            while (true)
            {
                int len = 0;
                try
                {
                    len = proxSocket.Receive(data, 0, data.Length, SocketFlags.None);
                }
                catch (Exception ex)
                {
                    AppendTextToTxtLog(string.Format("用户2非正常退出"));
                    ClientProxSocketList.Remove(proxSocket);
                    StopConnect(proxSocket);
                    return;
                }
                if (len <= 0)
                {
                    //客户端正常退出
                    AppendTextToTxtLog(string.Format("用户2正常退出"));
                    ClientProxSocketList.Remove(proxSocket);
                    StopConnect(proxSocket);
                    return;//让方法结束，终结当前接收客户端数据的异步线程
                }
                if (data[0] == 0)
                {
                    SoundPlayer music = new SoundPlayer();
                    music = new SoundPlayer(Directory.GetCurrentDirectory() + "\\qq.wav");
                    music.Play();
                    //把接收到的数据放到文本框上去
                    string str = Encoding.Default.GetString(data, 1, len);
                    AppendTextToTxtLog(string.Format("用户2的消息：{0}", str));

                    message = data;
                    notify = Encoding.Default.GetString(message, 1, len);
                }

                if (data[0] == 1)
                {
                    MemoryStream ms = new MemoryStream();
                    ms.Write(data, 1, len);
                    Image img = Image.FromStream(ms);
                    this.Invoke((EventHandler)delegate
                    {
                        pictureBox1.Image = img; //更新在窗体控件上
                    });
                    ms.SetLength(0);
                }

                if (data[0] == 2)
                {
                    Flash();
                }

                if (data[0] == 3)
                {
                    saveFile(data, len);
                }
                
            }
        }


        public void Flash()
        {
            Point curLocation = this.Location;//获取当前窗体的左上角坐标
            Random r = new Random();
            for (int i = 0; i < 50; ++i)
            {
                this.Invoke(new Action(() =>
                {
                    this.Location = new Point(r.Next(curLocation.X - 10, curLocation.X + 10),
            r.Next(curLocation.Y - 10, curLocation.Y + 10));
                    Thread.Sleep(30);
                    this.Location = curLocation;
                }));

            }

        }

        public void saveFile(byte[] data, int length)
        {
            using (SaveFileDialog sFile = new SaveFileDialog())
            {
                sFile.Filter = "text file(*.txt)|*.txt|picture(*jpg)|*.jpg|word(*docx)|*docx|all file(*.*)|*.*";
                this.Invoke(new Action(() =>
                {
                    if (sFile.ShowDialog(this) != DialogResult.OK)
                        return;

                    byte[] storedData = new byte[length - 1];
                    Buffer.BlockCopy(data, 1, storedData, 0, length - 1);
                    File.WriteAllBytes(sFile.FileName, storedData);
                    MessageBox.Show("保存成功！");
                }));


            }
        }


        private void StopConnect(Socket proxSocket)
        {
            try
            {
                if (proxSocket.Connected)
                {
                    proxSocket.Shutdown(SocketShutdown.Both); proxSocket.Close(100);
                }
            }
            catch (Exception ex)
            {
                //不需处理断开连接时的异常
            }

        }

        //往日志的文本框上追加数据
        public void AppendTextToTxtLog(string txt)
        {
            if (txtLog.InvokeRequired)
            {
                txtLog.BeginInvoke(new Action<string>(s =>
                {
                    this.txtLog.Text = string.Format("{0}\r\n{1}", txtLog.Text, s);
                }), txt);
            }
            else
            {
                this.txtLog.Text = string.Format("{0}\r\n{1}", txtLog.Text, txt);
            }
        }

    
       

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            if (notify.Length > 0)
            {
                notifyIcon1.ShowBalloonTip(3000, "来自用户2的新信息：", notify, ToolTipIcon.Info);
                message = null;//清空传输内容
                notify = "";
                notifyIcon1.Icon = Properties.Resources._3;//初始化显示的图标
            }
            else
            {

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (notify.Length > 0)
            {

                if (k)//k为true时
                {
                    notifyIcon1.Icon = Properties.Resources._1;//托盘图标为1
                    k = false;//设k为false
                }
                else//k为false时
                {
                    notifyIcon1.Icon = Properties.Resources._2;//图盘图标为2，透明的图标
                    k = true;//k为true
                }
            }
            else
            {
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(txtIP.Text);
            //1 创建Socket
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //2 绑定端口ipe'
            socket.Bind(new IPEndPoint(IPAddress.Parse(txtIP.Text), int.Parse(txtPort.Text)));
            //3 开启侦听
            socket.Listen(10);//最多同时建立10个连接
            //4 开始接受客户端的连接，该方法将一个任务项排列到线程池中，实现多线程
            ThreadPool.QueueUserWorkItem(new WaitCallback(AcceptClientConnect), socket);
            notifyIcon1.Icon = Properties.Resources._3;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "(*.jpg,*.png,*.jpeg,*.bmp,*.gif)|*.jpg;*.png;*.jpeg;*.bmp;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picPath = ofd.FileName;
                pictureBox1.Image = Image.FromFile(picPath);

            }
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            foreach (var proxSocket in ClientProxSocketList)
            {
                if (proxSocket.Connected)
                {
                    if (pictureBox1.Image == null)
                    {
                        MessageBox.Show("请先选择图片！");
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream();
                        pictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] data = ms.ToArray();
                        List<byte> list = new List<byte>();
                        list.Add(1);
                        list.AddRange(data);
                        byte[] imgByte = list.ToArray();
                        proxSocket.Send(imgByte);
                    }

                }
            }
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            //打开文件选择对话框
            using (OpenFileDialog file = new OpenFileDialog())
            {
                if (file.ShowDialog() != DialogResult.OK)
                    return;
                byte[] fileData = File.ReadAllBytes(file.FileName);
                byte[] final = new byte[fileData.Length + 1];
                final[0] = 3; //将发送文件标记为3
                Buffer.BlockCopy(fileData, 0, final, 1, fileData.Length);
                foreach (var proxSocket in ClientProxSocketList)
                {
                    if (proxSocket.Connected)
                        proxSocket.Send(final, SocketFlags.None);
                }

            }
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            foreach (var proxSocket in ClientProxSocketList)
            {
                if (proxSocket.Connected)
                {
                    byte[] buffer = Encoding.Default.GetBytes(txtMsg.Text);
                    List<byte> list = new List<byte>();
                    list.Add(0);
                    list.AddRange(buffer);
                    byte[] data = list.ToArray();
                    proxSocket.Send(data, 0, data.Length, SocketFlags.None);
                    txtMsg.Text = "";

                }
            }
        }

        private void btnFlash_Click(object sender, EventArgs e)
        {
            foreach (var proxSocket in ClientProxSocketList)
            {
                if (proxSocket.Connected)
                    proxSocket.Send(new byte[] { 2 }, SocketFlags.None);//定义一个包含一个元素的字节数组作为发送内容
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    InitializeComponent();
        //    //添加背景图片
        //    this.BackgroundImage = Image.FromFile("images/2.jpg");
        //}

        
    }
}
