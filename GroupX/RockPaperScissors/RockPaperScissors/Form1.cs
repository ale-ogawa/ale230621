using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RockPaperScissors {
    /// <summary>
    /// じゃんけんゲーム
    /// </summary>
    public partial class Form1 : Form {
        // じゃんけんの種類をenumで定義
        enum JankenType {
            Rock,
            Scissors,
            Paper
        }

        // コンピュータの手
        JankenType cpResult;

        // ランダムオブジェクト（コンピュータの手で利用）
        Random rdm;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1() {
            InitializeComponent();
        }

        /// <summary>
        /// ロード
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e) {
            // コンピュータのスピード(1000で1秒)
            Timer1.Interval = 10;

            // ランダムオブジェクトを使用
            rdm = new Random();

            PicGu.Image = Image.FromFile("../../ROCK.png");
            PicCh.Image = Image.FromFile("../../SCISSORS.png");
            PicPa.Image = Image.FromFile("../../PAPER.png");

            PicCPU.Image = Image.FromFile("../../CP_ROCK.png");
        }

        /// <summary>
        /// 勝敗判定
        /// </summary>
        /// <param name="playerChoice">自分の選択</param>
        private void Result(JankenType playerChoice) {
            Timer1.Enabled = false;
            StartButton.Enabled = true;

            if (playerChoice == cpResult) {
                billLabel.Text = "あいこです";
                drowLab.Text = (int.Parse(drowLab.Text) + 1).ToString();
            } else if ((playerChoice == JankenType.Rock && cpResult == JankenType.Scissors)
                    || (playerChoice == JankenType.Scissors && cpResult == JankenType.Paper)
                    || (playerChoice == JankenType.Paper && cpResult == JankenType.Rock)) {
                billLabel.Text = "勝ちました";
                winLab.Text = (int.Parse(winLab.Text) + 1).ToString();
            } else {
                billLabel.Text = "負けました・・・";
                loseLab.Text = (int.Parse(loseLab.Text) + 1).ToString();
            }
            // スタートボタンを使用可能にする
            StartButton.Enabled = true;
            StartButton.Text = "ＳＴＡＲＴ！！";

            // 自分の手が使えるようにする
            PicGu.Enabled = false;
            PicCh.Enabled = false;
            PicPa.Enabled = false;
        }

        /// <summary>
        /// タイマーを動かす
        /// </summary>
        private void GameStart() {
            Timer1.Enabled = true;
            // スタートボタンを使用できなくする
            StartButton.Enabled = false;

            // 最初の絵を表示
            cpResult = JankenType.Rock;

            // ラベルのクリア
            billLabel.Text = "";
            PicGu.Enabled = true;
            PicCh.Enabled = true;
            PicPa.Enabled = true;

            StartButton.Text = "じゃんけん・・";
        }

        /// <summary>
        /// コンピュータの絵をまわす
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {
            cpResult = (JankenType)rdm.Next(0, 3);

            switch (cpResult) {
                case JankenType.Rock:
                    // 「ぐー」
                    PicCPU.Image = Image.FromFile("../../CP_ROCK.png");
                    break;
                case JankenType.Scissors:
                    // 「ちょき」
                    PicCPU.Image = Image.FromFile("../../CP_SCISSORS.png");
                    break;
                case JankenType.Paper:
                    // 「ぱー」
                    PicCPU.Image = Image.FromFile("../../CP_PAPER.png");
                    break;
            }
        }

        /// <summary>
        /// スタートボタンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e) {
            GameStart();
        }

        /// <summary>
        /// 「ぐー」クリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicGu_Click(object sender, EventArgs e) {
            Result(JankenType.Rock);
        }

        /// <summary>
        /// 「ちょき」クリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicCh_Click(object sender, EventArgs e) {
            Result(JankenType.Scissors);
        }

        /// <summary>
        /// 「ぱー」クリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PicPa_Click(object sender, EventArgs e) {
            Result(JankenType.Paper);
        }
    }
}
