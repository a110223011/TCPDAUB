using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;//匯入網路通訊協定相關函數
using System.Net.Sockets;//匯入網路插座功能函數
using System.Threading;//匯入多執行緒功能函數
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Security.Cryptography;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TCPDAUB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //公用變數

        Socket T;//通訊物件
        Thread Th;//網路監聽執行緒
        string User;//使用者
        Pen pen;//畫筆
        int penPoint;//筆畫粗細
        Color penColor;//畫筆顏色
        Bitmap bmp;//畫布
        Graphics g;//繪畫圖形
        string send;
        static bool drawer;//畫家身分
        static string question;
        //監聽 Server 訊息 (Listening to the Server)
        public int duration = 60;//倒數計時時長

        public void ControlGame()
        {
            pictureBox1.Enabled = true;
            lblTime.Enabled = true;
            lblTopic.Enabled = true;
            tBPenPoint.Enabled = false;
            btnStart.Enabled = false;
            btnCheck.Enabled = false;
            btnClear.Enabled = false;
            lbOnlineUser.Enabled = true;
            rdbtnRed.Enabled = false;
            rdbtnBlue.Enabled = false;
            rdbtnGreen.Enabled = false;
            rdbtnBlack.Enabled = false;
            rdbtnEraser.Enabled = false;
        }
        //登入伺服器
        private void Button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false; //忽略跨執行緒錯誤
            User = txtName.Text;//使用者名稱
            string IP = txtIP.Text;//伺服器IP
            int Port = int.Parse(txtPort.Text);//伺服器Port
            //建立通訊物件，參數代表可以雙向通訊的TCP連線
            try
            {
                IPEndPoint EP = new IPEndPoint(IPAddress.Parse(IP), Port);//伺服器的連線端點資訊
                T = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                T.Connect(EP); //連上伺服器的端點EP(類似撥號給電話總機)
                Th = new Thread(Listen); //建立監聽執行緒
                Th.IsBackground = true; //設定為背景執行緒
                Th.Start(); //開始監聽
                MessageBox.Show("已連線伺服器！");
                Send("0" + User);  //連線後隨即傳送自己的名稱給伺服器
                ControlGame();
            }
            catch (Exception)
            {
                MessageBox.Show("無法連上伺服器！"); //連線失敗時顯示訊息
                return;
            }
            btnLogin.Enabled = false; //讓連線按鍵失效，避免重複連線
        }
        #region About Game
        //題目
        public string Topic()
        {
            List<string> topic = new List<string>() { "鐮刀", "雞毛撣子", "水錶", "扳手", "螺絲刀", "指甲剪", "梳子", "電鑽", "錘子"
            , "雞", "豬", "犀牛", "兔子", "長頸鹿", "眼鏡蛇", "獅子", "鱷魚", "恐龍"
            , "雙截棍", "匕首", "青龍偃月刀", "坦克", "步槍", "航空母艦", "手槍", "弓箭", "金箍棒"
            , "葡萄", "椰子", "火龍果", "鳳梨", "西瓜", "芒果", "草莓", "橘子", "哈密瓜" };

            string random = topic.PickRandom();

            MessageBox.Show(random);

            lblTopic.Text = random;
            string send;
            send = "Q" + random;//紀錄題目寄給對方
            Send(send);
            return random;
        }
        //遊戲開始 開始計時 抽取題目
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Tick += new EventHandler(count_down);
            timer1.Interval = 1000;
            timer1.Stop();
            timer1.Start();
            Topic();
            txtAnswer.Enabled = false;
            btnCheck.Enabled = false;
            txtAnswer.Clear();
            g.Clear(Color.White);
            btnStart.Enabled = false;
        }

        public void WhoCantSeeTopic(string _first)
        {
            if (_first == "猜題者")
            {
                int length = lblTopic.Text.Length;
                //在猜題者的form中題目變成底線*題目數字
                lblTopic.Text = "";
                for (int i = 0; i < length; i++)
                {
                    lblTopic.Text += "_ ";
                }
            }
        }

        // 倒數計時
        public void count_down(object sender, EventArgs e)
        {
            if (duration == 0)
            {
                timer1.Stop();
                MessageBox.Show("時間到了!!");
                txtAnswer.Enabled = false;
                btnCheck.Enabled = false;
            }
            else if (duration > 0)
            {
                duration--;
                lblTime.Text = duration.ToString();
                byte[] F = new byte[1023];
                F = Encoding.Default.GetBytes("T" + lblTime.Text);
                T.Send(F, 0, F.Length, SocketFlags.None);
            }
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text == question)
            {
                MessageBox.Show("Correct");
                timer1.Stop();
                btnCheck.Enabled = false;
                string send;
                send = "A";//紀錄開始繪圖座標
                Send(send);

            }
            else
            {
                MessageBox.Show("False");
            }
        }
        #endregion

        #region 監聽
        private void Listen()
        {
            EndPoint ServerEP = (EndPoint)T.RemoteEndPoint; //Server 的 EndPoint
            byte[] B = new byte[1023]; //接收用的 Byte 陣列
            int inLen = 0; //接收的位元組數目
            string Msg; //接收到的完整訊息
            string St; //命令碼
            string Str; //訊息內容(不含命令碼)
            int penpoint;
            Color Color;

            while (true)//無限次監聽迴圈
            {
                try
                {
                    inLen = T.ReceiveFrom(B, ref ServerEP);//收聽資訊並取得位元組數
                }
                catch (Exception)//產生錯誤時
                {
                    T.Close();//關閉通訊器
                    lbOnlineUser.Items.Clear();//清除線上名單
                    MessageBox.Show("伺服器斷線了！");//顯示斷線
                    btnLogin.Enabled = true;//連線按鍵恢復可用
                    Th.Abort();//刪除執行緒
                }
                Msg = Encoding.Default.GetString(B, 0, inLen); //解讀完整訊息
                St = Msg.Substring(0, 1); //取出命令碼 (第一個字)
                Str = Msg.Substring(1); //取出命令碼之後的訊息   
                switch (St)//依命令碼執行功能
                {
                    case "L"://接收線上名單
                        lbOnlineUser.Items.Clear(); //清除名單
                        string[] M = Str.Split(','); //拆解名單成陣列
                        for (int i = 0; i < M.Length; i++)
                        {
                            lbOnlineUser.Items.Add(M[i]); //逐一加入名單
                        }
                        break;
                    case "1"://接收廣播訊息
                        txtIP.SelectionStart = txtIP.Text.Length; //游標移到最後
                        txtIP.ScrollToCaret(); //捲動到游標位置
                        break;
                    case "D"://接收畫圖
                        string[] E = Str.Split('-'); //拆解名單成陣列
                        string[] Z = E[1].Split('*');//切割顏色與座標資訊
                        string[] Q = Z[1].Split('/');//切割座標點資訊

                        Point[] R = new Point[Q.Length];//宣告座標點陣列
                        Color = Color.FromName(E[0].ToString());
                        penpoint = int.Parse(Z[0]);
                        pen = new Pen(Color, penpoint);
                        int o = 0, ex = 0, ey = 0;
                        for (int i = 0; i < Q.Length - 1; i++)
                        {
                            string[] K = Q[i].Split(',');//切割X與Y座標
                            R[i].X = int.Parse(K[0]);//定義第i點X座標
                            R[i].Y = int.Parse(K[1]);//定義第i點Y座標
                            string[] KK = Q[i + 1].Split(',');
                            ex = int.Parse(KK[0]);
                            ey = int.Parse(KK[1]);
                            o += 1;
                            g.DrawLine(pen, R[i].X, R[i].Y, ex, ey);
                        }
                        g = Graphics.FromImage(bmp);
                        pictureBox1.Image = bmp;
                        break;
                    case "C":
                        clear();
                        break;
                    case "W"://伺服器指派畫家
                        MessageBox.Show("你是畫家");
                        tBPenPoint.Enabled = true;
                        btnStart.Enabled = true;
                        btnClear.Enabled = true;
                        rdbtnRed.Enabled = true;
                        rdbtnBlue.Enabled = true;
                        rdbtnGreen.Enabled = true;
                        rdbtnBlack.Enabled = true;
                        rdbtnEraser.Enabled = true;
                        drawer = true;
                        break;
                    case "F"://伺服器指派猜謎者
                        MessageBox.Show("你是猜謎者");
                        drawer = false;
                        lblTopic.Visible = false;
                        btnCheck.Enabled = true;
                        break;
                    case "Q":
                        MessageBox.Show("收到題目:" + Str);
                        txtAnswer.Enabled = true;
                        question = Str;
                        break;
                    case "A":
                        timer1.Stop();
                        break;
                    case "T"://更新
                        lblTime.Text = Str;
                        break;
                }
            }
        }
        #endregion

        #region 傳訊息Send
        //傳送訊息給 Server (Send Message to the Server)
        private void Send(string Str)
        {
            string sendd = "D" + color + "-" + penPoint + "*";
            string sendtwo = "";
            byte[] B = Encoding.Default.GetBytes(Str); //翻譯文字為Byte陣列
            int find = 0;
            string send = "";

            if (B.Length > 1023)
            {
                //MessageBox.Show(B.Length.ToString());
                for (int i = 1000; i <= B.Length; i++)
                {
                    char c = (char)B[i];
                    //MessageBox.Show(c.ToString());
                    if (((char)B[i]) == '/')
                    {
                        find = i;
                        //MessageBox.Show("找到切點" + find);
                        break;
                    }

                }
                for (int i = 0; i < find; i++)
                {
                    send += (char)B[i];
                    //send += B[i];
                }
                //MessageBox.Show("send1完成" + send);
                byte[] C = Encoding.Default.GetBytes(send);

                for (int i = find + 1; i < B.Length; i++)
                {
                    sendtwo += (char)B[i];
                    //send += B[find - 1];
                    //send += send;//紀錄開始繪圖座標
                    //MessageBox.Show();                    
                }
                sendtwo = sendd + sendtwo;
                //MessageBox.Show("sendtwo完成" + sendtwo);
                byte[] D = Encoding.Default.GetBytes(sendtwo);
                T.Send(C, 0, C.Length, SocketFlags.None); //使用連線物件傳送資料
                T.Send(D, 0, D.Length, SocketFlags.None); //使用連線物件傳送資料               
            }
            else
            {
                T.Send(B, 0, B.Length, SocketFlags.None); //使用連線物件傳送資料
            }

        }
        #endregion

        #region Form
        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            pen = new Pen(Color.Black, 5);
            bmp = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(bmp);
            penPoint = 3;
            penColor = Color.Black;
            g.Clear(Color.White);
            pictureBox1.Image = bmp;
            pictureBox1.Refresh();
        }
        #endregion

        #region 畫布 畫畫
        int oldx, oldy;
        string color;
        //下筆
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (drawer == true)
            {

                if (rdbtnRed.Checked) { penColor = Color.Red; color = "Red"; }//紅筆
                if (rdbtnBlue.Checked) { penColor = Color.Blue; color = "Blue"; }//亮綠色筆
                if (rdbtnGreen.Checked) { penColor = Color.Lime; color = "Lime"; }//藍筆
                if (rdbtnBlack.Checked) { penColor = Color.Black; color = "Black"; }//黑筆
                if (rdbtnEraser.Checked) { penColor = Color.White; color = "White"; }//擦布
                penPoint = tBPenPoint.Value;//筆畫粗細
                pen = new Pen(penColor, penPoint);//畫筆設定
                oldx = e.X;//起點
                oldy = e.Y;//起點

                send = oldx + "," + oldy;//起點座標紀錄
            }
        }

        //動筆
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && drawer == true)
            {
                //建立線段物件
                g = Graphics.FromImage(bmp);
                g.DrawLine(pen, oldx, oldy, e.X, e.Y);
                pictureBox1.Image = bmp;
                oldx = e.X;
                oldy = e.Y;
                send += "/" + oldx + "," + oldy;
            }
        }

        //結束筆畫
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (drawer == true)
            {
                send = "D" + color + "-" + penPoint + "*" + send;//紀錄開始繪圖座標
                Send(send);
            }
        }

        //Clear
        private void button4_Click(object sender, EventArgs e)
        {
            clear();
            Send("C");
        }

        private void clear()
        {
            pictureBox1.Image = null;
            g.Clear(Color.White);
        }
        #endregion

        #region 視窗可拖動
        private bool beginMove = false;
        private int currentXPosition;
        private int currentYPosition;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X; //滑鼠的 X 座標為當前窗體左上角 X 座標參考
                currentYPosition = MousePosition.Y; //滑鼠的 Y 座標為當前窗體左上角 Y 座標參考
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition; //根據滑鼠的 X 座標確定窗體的 X 座標
                this.Top += MousePosition.Y - currentYPosition; //根據滑鼠的 Y 座標確定窗體的 Y 座標
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //設定初始狀態
                currentYPosition = 0; //設定初始狀態
                beginMove = false;
            }
        }
        #endregion

        #region 關閉遊戲
        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //視窗關閉，代表離線
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnLogin.Enabled == false)
            {
                Send("9" + User); //傳送自己的離線訊息給伺服器
                T.Close(); //關閉網路通訊器
            }
        }
        #endregion

    }

    public static class Extensions
    {
        private static Random rnd = new Random();

        public static T PickRandom<T>(this IList<T> source)
        {
            int randIndex = rnd.Next(source.Count);
            return source[randIndex];
        }
    }
}
