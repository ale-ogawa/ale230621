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
        private const int Time = 60;

        //ミスカウンター
        public static int MissCounter = 0;

        //正解カウンター
        public static int CorrectCouter = 0;

        //タイマー用制限時間
        private int duration = Time;

        //ミスフラグ
        private bool MissFlag=false;

        //コンボカウンター
        private int Conb = 0;

        //照合用問題文
        private string question { get; set; }

        public playForm()
        {
            InitializeComponent();

            //画面の最大化
            this.WindowState = FormWindowState.Maximized;

            //テキストボックスへの入力受付を停止
            answerTextBox.Enabled = false;

            //問題の読み込み
            try
            {
                ProblemFileReader pr = new ProblemFileReader();
                pr.FileReader();
            }

            //例外処理　言語選択画面へ遷移
            catch (FileNotFoundException)
            {
                MessageBox.Show("問題ファイルが見つかりません");
                ControlForm.CloseAndShow(this, typeof(languageSelectionForm));
            }
            catch (IOException) 
            {
                MessageBox.Show("問題ファイルの読み取りに問題が起きました");
                ControlForm.CloseAndShow(this, typeof(languageSelectionForm));
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("問題ファイルの内容に誤りがあります");
                ControlForm.CloseAndShow(this, typeof(languageSelectionForm));
            }
            catch (NotSupportedException)
            { 
                MessageBox.Show("ファイルパスに誤りがあります");
                ControlForm.CloseAndShow(this, typeof(languageSelectionForm));
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
                ControlForm.CloseAndShow(this, typeof(languageSelectionForm));
            }
        }

        /// <summary>
        /// 開始ボタンを押す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startBottun_Click(object sender, EventArgs e)
        {
            //スタートボタンを非表示
            startBottun.Visible = false;

            writer("プレイヤー名:" + PlayerDTO.Name);

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
            String[] lines = ProblemFileReader.Problem[random.Next(0, i)];

            //問題文を整形 「"」、スペース、改行、「&」を適切な表示に変換
            string line= lines[2].Trim('"').Trim(' ').Replace(" ", "□").Replace("改行", "\n").Replace("\"\"", "\"").Replace("\"\"", "\"").Replace("&&", "&&&&");

            //正誤判定ロジック用の問題文整形
            //改行を文字列に含める
            //問題表示用に変換した文字列を戻す
            String[] questions = line.Split('\n');
            question = String.Join(",", questions).Replace("□", " ").Replace("&&&&", "&&");

            writer("問題文" + question);

            return line;
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
                //ユーザーのバックスペース入力は処理をしない
                if (ProblemIndex < questionLabel.Text.Length && answerTextBox.Text.Length >= ProblemIndex + 1)
                {
                    //ユーザー回答の取り出し
                    String[] answers = answerTextBox.Text.Split('\n');
                    string ans = String.Join(",", answers);

                    //プレイログ
                    writer(ans[ans.Length - 1].ToString(), question[ProblemIndex].ToString(), answerTextBox.Text,CorrectCouter.ToString(),MissCounter.ToString(),MissFlag.ToString());

                    //ミスタイプによるループを防ぐ
                    if (MissFlag) { MissFlag = false; return; }

                    //正解時の処理
                    if (ans[ans.Length - 1] == question[ProblemIndex])
                    {
                        //照合文字を一文字進める
                        ProblemIndex++;

                        //コンボを進める
                        Conb++;
                    }

                    //不正解処理
                    else
                    {
                        //ミスカウントアップ
                        MissCounter++;

                        //コンボリセット
                        Conb = 0;

                        //ミスフラグの変更
                        MissFlag = true;

                        //間違えた文字を削除
                        answerTextBox.Text = answerTextBox.Text.Remove(ProblemIndex);

                        //カーソル位置を最後尾へ移動
                        answerTextBox.SelectionStart = answerTextBox.Text.Length;

                        //UIを更新
                        System.Windows.Forms.Application.DoEvents();
                    }

                    //全ての文字が正しく入力された時の処理
                    if (ProblemIndex == question.Length)
                    {
                        //正解後の事後処理
                        CorrectProcess();
                    }

                    //10の倍数コンボ毎に制限時間を1秒増やす
                    if (Conb % 10 == 0 && Conb > 9) Conb++;
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
                ControlForm.CloseAndShow(this,typeof(ResultForm));
            }

            //カウントゼロ以上の処理
            else if (duration > 0)
            {
                //カウントを進める
                duration--;
                timeCountTextBox.Text = duration.ToString();
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void endBottun_Click(object sender, EventArgs e)
        {
            //タイマー停止
            CountDownTimer.Stop();

            //パラメーター初期化
            CorrectCouter = 0;
            MissCounter = 0;
            Conb = 0;

            //言語選択画面へ遷移
            ControlForm.CloseAndShow(this, typeof(languageSelectionForm));
        }
        private void writer(params string[] s)
        {
            using (StreamWriter sr = new StreamWriter(@"C:\GitRepos\ale230621\GroupC\C#,JavaTypingGame\プレイ記録\log.txt", true))
            {
                if (s.Length == 1) sr.WriteLine(s[0]);
                else
                {
                    foreach (string ss in s) { sr.Write(ss); sr.Write(","); }
                    sr.WriteLine();
                }

            }
        }
    }
}
