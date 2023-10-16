using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace C__JavaTypingGame
{
    public partial class playForm : Form
    {
        //問題出題用ランダム関数
        private Random random = new Random();

        //照合する文字番号
        private int ProblemIndex = 0;

        //ゲームの制限時間
        private const int Time = 60;

        //ミスカウンター
        public static int MissCounter = 0;

        //正解カウンター
        public static int CorrectCouter = 0;

        //タイマー用制限時間
        private int duration = Time;

        public playForm()
        {
            InitializeComponent();

            //問題の読み込み
            ProblemFileReader pr = new ProblemFileReader();
            pr.FileReader();
        }

        private void playForm_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 開始ボタンを押す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBottun_Click(object sender, EventArgs e)
        {
            startBottun.Visible = false;

            //ゲーム開始前カウントダウン
            StartCountDown();

            //最初の問題の出題
            questionLabel.Text = ProblemEntry();
            System.Windows.Forms.Application.DoEvents();

            //ゲーム制限時間のカウントダウン開始
            CountDownTimer = new System.Windows.Forms.Timer();
            CountDownTimer.Tick += new EventHandler(CountDown);
            CountDownTimer.Interval = 1000;
            CountDownTimer.Start();

            PlayerDAO playerDAO = new PlayerDAO();
        }

        /// <summary>
        /// ゲーム開始のカウントダウン
        /// </summary>
        private void StartCountDown()
        {
            //文字サイズと配置の変更
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            questionLabel.Font=new Font(questionLabel.Font.FontFamily,36);

            //カウントダウン
            for (int i = 3; i > -1; i--)
            {
                if (i != 0) questionLabel.Text = i.ToString();
                else questionLabel.Text = "Start!!";
                System.Windows.Forms.Application.DoEvents();
                Thread.Sleep(1000);
            }

            //元の文字の仕様に戻す
            questionLabel.TextAlign = ContentAlignment.TopLeft;
            questionLabel.Font = new Font(questionLabel.Font.FontFamily, 20);
            System.Windows.Forms.Application.DoEvents();

        }

        /// <summary>
        /// 問題出題メソッド
        /// </summary>
        /// <returns></returns>
        private string ProblemEntry()
        {
            int i = ProblemFileReader.Problem.Count;
            //String[] line = ProblemFileReader.Problem[random.Next(0, i)];
            string[] line = ProblemFileReader.Problem[156];
            return line[2];
        }


        /// <summary>
        /// 入力文字の正誤判定を行う
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            //テキストボックスに文字が入力され配列の参照範囲内であれば判定処理に進む
            if (ProblemIndex < questionLabel.Text.Length && answerTextBox.Text.Length >= ProblemIndex + 1)
            {
                //正解時の処理
                if (answerTextBox.Text[ProblemIndex] == questionLabel.Text[ProblemIndex])
                {
                    //照合文字を一文字進める
                    ProblemIndex++;

                }
                //不正解処理
                else
                {
                    MissCounter++;
                }

                //全ての文字が正しく入力されたか確認
                if (ProblemIndex == questionLabel.Text.Length)
                {
                    //正解後の事後処理
                    CorrectProcess();
                }
            }

        }

        /// <summary>
        ///　正解後の事後処理
        /// </summary>
        private void CorrectProcess()
        {
            //各パラメーターの初期化
            ProblemIndex = 0;
            answerTextBox.Text = "";
            System.Windows.Forms.Application.DoEvents();

            //正解のポイント付与
            CorrectCouter += questionLabel.Text.Length;

            //新しい問題の出題
            questionLabel.Text = ProblemEntry();
            System.Windows.Forms.Application.DoEvents();

            
        }

        /// <summary>
        /// ゲームプレイ中のカウントダウン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountDown(object sender, EventArgs e)
        {
            if (duration == 0)
            {
                CountDownTimer.Stop();
                ResultForm result =new ResultForm();
                result.Show();
                this.Hide();   
            }
            else if (duration > 0)
            {
                duration--;
                timeCountTextBox.Text = duration.ToString();
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            デバッグ d=new デバッグ();
            d.Show();
        }
    }
}
