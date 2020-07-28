using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using XYZrobot;
using System.Threading;

namespace TCPIPClient
{
    public partial class Form1 : Form
    {
        XYZrobot.XYZrobot joyrobot;
        
        //string message;
        bool isConnect=false;
        public Form1()
        {
            InitializeComponent();
            joyrobot = new XYZrobot.XYZrobot();
            joyrobot.Show();

            textIP.Text = "163.18.48.90";// "127.0.0.1";

            textport.Text = "13000";


        }

        TcpClient myTcpClient = new TcpClient();

        NetworkStream myNetworkStream;//宣告網路資料流變數



        private void buttonconnect_Click(object sender, EventArgs e)
        {
            myTcpClient = new TcpClient();
            int port;//port型態
            String IP = "";//IP型態
            textmes.Text = "";//message 一開始為空白

            IP = Convert.ToString(textIP.Text);//IP輸入
            port = Convert.ToInt32(textport.Text);//port輸入
            try
            {
                myTcpClient.Connect(IP, port);
                
                textmes.Text = "connect successful";//顯示連線成功
                myNetworkStream = myTcpClient.GetStream();
                isConnect = true;
            }
            catch
            {
                textmes.Text = "主機 {0} 通訊埠 {1} 無法連接  !!" + IP + port;//連線失敗
                isConnect = false;
            }
        }
        bool btn = false;
        private void buttonenter_Click(object sender, EventArgs e)
        {
            btn = true;
        }
        //寫入資料
        void WriteData()
        {

            String strTest = textenter.Text.ToString();
            //將字串轉byte陣列，使用ASCII編碼
            Byte[] myBytes = Encoding.ASCII.GetBytes(strTest);
            this.Invoke(new EventHandler(delegate { textmes.Text = "將資料寫入資料流"; }));//將字串寫入資料流
            try
            {
                myNetworkStream.Write(myBytes, 0, myBytes.Length);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR");
            }
        }
        void WriteData(String data)
        {
            this.Invoke(new EventHandler(delegate
            {
                textenter.Text = data;
            }));
            
            Byte[] myBytes = new byte[1];
            myBytes[0] =byte.Parse(data);
            
            try
            {
                myNetworkStream.Write(myBytes, 0, myBytes.Length);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR");
                isConnect = false;
                myTcpClient.Client.Close();
            }
        }
        //讀取資料
        void ReadData()
        {
            if (myTcpClient.Available >= 1)//是否有資料
            {
                this.Invoke(new EventHandler(delegate { 
                    textmes.Text = "從網路資料流讀取資料" + Environment.NewLine;//從網路資料流讀取資料
                    if (myTcpClient.Connected)
                    {
                        int bufferSize = myTcpClient.Available;
                        if (bufferSize != 0)
                        {
                            byte[] myBufferBytes = new byte[bufferSize];
                            myNetworkStream.Read(myBufferBytes, 0, bufferSize);//取得資料並解讀文字
                            StringBuilder sb = new StringBuilder();
                            foreach (byte item in myBufferBytes)
                            {
                                sb.Append(item); sb.Append(" ");
                            }
                            textmes.Text+=sb.ToString();
                        } 
                    }
                    else
                    {
                        textmes.Text += "DisConnected";
                    }
                    
                    
                }));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isConnect = false;
            myTcpClient.Client.Close();

            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (checkBox1.Checked)
                {
                    if (isConnect)
                    {
                        ReadData();
                        if (btn)
                        {
                            WriteData();
                            btn = false;
                        }
                        else
                        {
                            WriteData(joyrobot.message);
                        }
                    }
                }
                Thread.Sleep(100);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }
    }
}
