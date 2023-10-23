using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GachaSimulator
{
    public partial class RollForm : Form
    {
        /*■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■*/

        //■ガチャを回す画面が立ち上がった時に実行する部分

        //■ジュエル数の初期値を設定
        int juelNum = 3000;

        //■１回分のジュエル消費数
        const int juelGacha1time = 300;
        const int juelGacha10times = 3000;
        const int juelGachaDebug = 0;
        const int juelAdd = 1000;

        //■ガチャを回す回数のカウント
        int gachaTimes = 0;

        //■ランダムの値を作るオブジェクトrndを作成
        Random rnd = new Random();

        /*■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■*/

        //■コンストラクタ
        public RollForm()
        {
            InitializeComponent();

            //■ジュエル数表示のラベルにジュエル数を反映
            juelsNum.Text = juelNum.ToString();

            //■ジュエル数が足りないボタンを灰色表示にする
            if (juelNum < juelGacha10times)
            {
                roll10timesButton.ForeColor = Color.Gray;
            }
            if (juelNum < juelGacha1time)
            {
                rollOnceButton.ForeColor = Color.Gray;
            }

            ////■ガチャ設定csvファイルを読み込む

            ////■Gachaクラス型のリストgachasを作成
            //var gachas = new List<Gacha>();
            //string id = "";
            //string rarity = "";
            //string name = "";

            ////■CSVファイルのパスを指定
            //string filePath = "C:\\gachacsv\\gachasetting.csv";

            ////■StreamReaderを使用してファイルを開く
            //using (StreamReader reader = new StreamReader(filePath))
            //{
            //    while (!reader.EndOfStream)
            //    {
            //        // 1行ずつ読み込む
            //        string line = reader.ReadLine();

            //        // CSVのカラムを分割
            //        string[] values = line.Split(',');

            //        // 各カラムのデータを処理する
            //        foreach (string value in values)
            //        {
            //            gachas = value;
            //        }
            //        Console.WriteLine();
            //    }
            //}
        }

        /*■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■*/

        //■１回ガチャボタンを押した時
        private void rollOnceButton_Click(object sender, EventArgs e)
        {
            //■所持ジュエル数が1回ガチャに必要なジュエル数より多ければ実行
            if (juelNum >= juelGacha1time)
            {
                //■ジュエル数を１回分減らす
                juelNum -= juelGacha1time;

                //■ジュエル数表示のラベルにジュエル数を反映
                juelsNum.Text = juelNum.ToString();

                //■ガチャカウントを１回分追加する
                gachaTimes = 1;

                //■ガチャカウントを１回分減らす
                gachaTimes--;

                ////★★★★★★★★仮ガチャ★★★★★★★★★★★★★★★★★★★

                ////■0以上100未満のランダムな値
                //int rndVal = rnd.Next(100);

                ////■ランダム値が10未満の場合はレア度A
                //if (rndVal < 10)
                //{
                //    ResultFormA resultFormA = new ResultFormA();
                //    resultFormA.ShowDialog();
                //}
                ////■ランダム値が10未満の場合はレア度B
                //else if (rndVal < 30)
                //{
                //    ResultFormB resultFormB = new ResultFormB();
                //    resultFormB.ShowDialog();
                //}
                ////■ランダム値が30未満の場合はレア度B
                //else if (rndVal < 30)
                //{
                //    ResultFormB resultFormB = new ResultFormB();
                //    resultFormB.ShowDialog();
                //}
                ////■ランダム値が60未満の場合はレア度C
                //else if (rndVal < 60)
                //{
                //    ResultFormC resultFormC = new ResultFormC();
                //    resultFormC.ShowDialog();
                //}
                ////■ランダム値が60未満の場合はレア度D
                //else if (rndVal < 100)
                //{
                //    ResultFormD resultFormD = new ResultFormD();
                //    resultFormD.ShowDialog();
                //}
                ////★★★★★★★★仮ガチャ★★★★★★★★★★★★★★★★★★★


                //■ガチャ抽選中画面を立ち上げる
                LotteryForm lotteryForm = new LotteryForm();
                lotteryForm.ShowDialog();

            }
            //■所持ジュエル数が1回ガチャに必要なジュエル数より少ない場合はこちら
            else
            {
                MessageBox.Show("ジュエルが足りません。ジュエルを追加してください");
            }

            //■このボタンを押してジュエル数が足りなくなったボタンを灰色表示にする
            if (juelNum < juelGacha10times)
            {
                roll10timesButton.ForeColor = Color.Gray;
            }
            if (juelNum < juelGacha1time)
            {
                rollOnceButton.ForeColor = Color.Gray;
            }
            //■ジュエルを追加してもジュエル数が最大値を超えなくなった場合に
            //　ジュエル数を黒文字表示にする
            if (juelNum <= 99000)
            {
                addJuelsButton.ForeColor = Color.Black;
            }
        }

        /*■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■*/

        //■10回ガチャボタンを押した時
        private void roll10timesButton_Click(object sender, EventArgs e)
        {
            //■所持ジュエル数が1回ガチャに必要なジュエル数より多ければ実行
            if (juelNum >= juelGacha10times)
            {
                //■ジュエル数を10回分減らす
                juelNum -= juelGacha10times;

                //■ジュエル数表示のラベルにジュエル数を反映
                juelsNum.Text = juelNum.ToString();

                //■ガチャカウントを10回分追加する
                gachaTimes = 10;

                //■ガチャカウントを１回分減らす
                gachaTimes--;

                //■ガチャ抽選中画面を立ち上げる
                LotteryForm lotteryForm = new LotteryForm();
                lotteryForm.ShowDialog();

            }
            //■所持ジュエル数が1回ガチャに必要なジュエル数より少ない場合はこちら
            else
            {
                MessageBox.Show("ジュエルが足りません。ジュエルを追加してください");
            }

            //■このボタンを押してジュエル数が足りなくなったボタンを灰色表示にする
            if (juelNum < juelGacha10times)
            {
                roll10timesButton.ForeColor = Color.Gray;
            }
            if (juelNum < juelGacha1time)
            {
                rollOnceButton.ForeColor = Color.Gray;
            }
            //■ジュエルを追加してもジュエル数が最大値を超えなくなった場合に
            //　ジュエル数を黒文字表示にする
            if (juelNum <= 99000)
            {
                addJuelsButton.ForeColor = Color.Black;
            }
        }

        /*■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■*/

        //■デバッグ用100回ガチャボタンを押した時
        private void rollForDebugButtonClicked_Click(object sender, EventArgs e)
        {
            //■ジュエル数をデバッグ分減らす
            juelNum -= juelGachaDebug;

            //■ジュエル数表示のラベルにジュエル数を反映
            juelsNum.Text = juelNum.ToString();

            //■ガチャカウントを100回分追加する
            gachaTimes = 100;

            //■ガチャカウントを１回分減らす
            gachaTimes--;

            //■ガチャ抽選中画面を立ち上げる
            LotteryForm lotteryForm = new LotteryForm();
            lotteryForm.ShowDialog();
        }

        /*■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■*/

        //■ジュエル追加ボタンを押した時
        private void addJuelsButton_Click(object sender, EventArgs e)
        {
            //■所持ジュエル数が1000足しても10万を超えない場合ジュエルを1000追加
            if (juelNum <= 99000)
            {
                //■ジュエルを1000追加する
                juelNum += juelAdd;

                //■ジュエル数表示のラベルにジュエル数を反映
                juelsNum.Text = juelNum.ToString();
            }
            else
            {
                MessageBox.Show("所持ジュエルが最大値の10万を超えるため追加できません。");
            }

            //■ジュエル数が必要数を超えると各ボタンを黒文字表示にする
            if (juelNum >= juelGacha10times)
            {
                roll10timesButton.ForeColor = Color.Black;
            }
            if (juelNum >= juelGacha1time)
            {
                rollOnceButton.ForeColor = Color.Black;
            }
            //■ジュエル数が最大値を超える場合ジュエル追加ボタンを灰色文字表示にする
            if (juelNum > 99000)
            {
                addJuelsButton.ForeColor = Color.Gray;
            }
        }

        /*■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■*/

        //■閉じるボタンを押した時
        private void returnTopButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
