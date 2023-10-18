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
using typingGame;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__JavaTypingGame
{
    public partial class playForm : Form
    {
        //問題出題用ランダム関数
        private Random random = new Random();

        //照合する文字番号
        private int ProblemIndex = 0;

        //ゲームの制限時間
        private const int Time = 0;

        //ミスカウンター
        public static int MissCounter = 0;

        //正解カウンター
        public static int CorrectCouter = 0;

        //タイマー用制限時間
        private int duration = Time;

        public playForm()
        {
            InitializeComponent();

            //テキストボックスへの入力受付を停止
            answerTextBox.Enabled = false;

            //問題の読み込み
            try
            {
                ProblemFileReader pr = new ProblemFileReader();
                pr.FileReader();
            }
            catch (FileNotFoundException) { MessageBox.Show("問題ファイルが見つかりません"); }
            catch (IOException) { MessageBox.Show("問題ファイルの読み取りに問題が起きました"); }
            catch (IndexOutOfRangeException) { MessageBox.Show("問題ファイルの内容に誤りがあります"); }
            catch (Exception e) { MessageBox.Show(e.Message); }
        }

        private void playForm_Load(object sender, EventArgs e) { }

        /// <summary>
        /// 開始ボタンを押す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBottun_Click(object sender, EventArgs e)
        {
            //スタートボタンを非表示
            startBottun.Visible = false;

            //ゲーム開始前カウントダウン
            try { StartCountDown(); }
            catch(Exception excep) { MessageBox.Show($"{excep.Message}"); }

            //テキストボックスの入力を受付
            answerTextBox.Enabled = true;
            answerTextBox.Multiline = true;
            answerTextBox.WordWrap = false;
            answerTextBox.Focus();

            //最初の問題の出題
            try
            {
                questionLabel.Text = ProblemEntry();
                System.Windows.Forms.Application.DoEvents();
            }
            catch (Exception exception) { MessageBox.Show($"{exception.Message}"); }

            //ゲーム制限時間のカウントダウン開始
            CountDownTimer = new System.Windows.Forms.Timer();
            CountDownTimer.Tick += new EventHandler(CountDown);
            CountDownTimer.Interval = 1000;
            try{CountDownTimer.Start();}
            catch(Exception ex) { MessageBox.Show($"{ex.Message}"); }
        }

        /// <summary>
        /// ゲーム開始のカウントダウン
        /// </summary>
        private void StartCountDown()
        {
            //文字サイズと配置の変更
            questionLabel.TextAlign = ContentAlignment.MiddleCenter;
            questionLabel.Font = new Font(questionLabel.Font.FontFamily, 36);

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
            //問題リストの要素数を取り出す
            int i = ProblemFileReader.Problem.Count;

            //リストからランダムに問題を取り出す
            String[] line = ProblemFileReader.Problem[random.Next(0, i)];

            //問題文を整形して返す
            return line[2].Replace("改行", "\n").Replace("\"\"", "\"").Replace(" ", "□").Trim('"'); ;
        }


        /// <summary>
        /// 入力文字の正誤判定を行う
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void answerTextBox_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                //テキストボックスに文字が入力され配列の参照範囲内であれば判定処理に進む
                if (ProblemIndex < questionLabel.Text.Length && answerTextBox.Text.Length >= ProblemIndex + 1)
                {
                    //改行を文字列に含める
                    String[] questions = questionLabel.Text.Split('\n');
                    string question = String.Join(",", questions).Replace("□"," ");

                    //ユーザー回答の取り出し
                    String[] answers = answerTextBox.Text.Split('\n');
                    string ans = String.Join(",", answers);
                    //正解時の処理
                    if (ans[ans.Length - 1] == question[ProblemIndex])
                    {
                        //照合文字を一文字進める
                        ProblemIndex++;
                    }

                    //不正解処理
                    else
                    {
                        //間違えた文字を削除
                        answerTextBox.Text = answerTextBox.Text.Remove(ProblemIndex);

                        //カーソル位置を最後尾へ移動
                        answerTextBox.SelectionStart = answerTextBox.Text.Length;

                        //UIを更新
                        System.Windows.Forms.Application.DoEvents();

                        //ミスカウントアップ
                        MissCounter++;
                    }

                    //全ての文字が正しく入力された時の処理
                    if (ProblemIndex == question.Length)
                    {
                        //正解後の事後処理
                        CorrectProcess();
                    }
                }
                
            }
            catch (Exception exc) { MessageBox.Show($"{exc.Message}"); }
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
            //カウントゼロになった時の処理
            if (duration == 0)
            {
                //タイマー停止
                CountDownTimer.Stop();

                //テキストボックスへの入力受付を停止
                answerTextBox.Enabled = false;

                //入力途中の文字を正解数へカウント
                CorrectCouter += answerTextBox.Text.Length;

                //ゲーム終了の通知
                MessageBox.Show("制限時間終了のためゲームが終了しました。リザルト画面に移行します。");

                //リザルト画面への遷移
                ResultForm result = new ResultForm();
                this.Hide();
                result.ShowDialog();
                this.Close();
            }

            //カウントゼロ以上の処理
            else if (duration > 0)
            {
                duration--;
                timeCountTextBox.Text = duration.ToString();
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }

        private void endBottun_Click(object sender, EventArgs e)
        {
            languageSelectionForm lang = new languageSelectionForm();
            this.Hide();
            lang.ShowDialog();
            this.Close();
        }
    }
}
