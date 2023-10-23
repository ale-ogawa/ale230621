using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GachaSimulator
{
    public partial class LotteryForm : Form
    {
        private Timer displayTimer;

        //■ランダムの値を作るオブジェクトrndを作成
        Random rnd = new Random();

        public LotteryForm()
        {
            InitializeComponent();
            //// Timerコントロールを初期化
            //displayTimer = new Timer();
            //displayTimer.Start();
            //displayTimer.Interval = 3000; //3秒
            //this.Hide();

            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ////テスト用
            //string label = "A";

            //switch (label)
            //{
            //    case "A":
            //        ResultFormA resultFormA = new ResultFormA();
            //        resultFormA.Show();
            //        this.Hide();
            //        break;

            //    case "B":
            //        ResultFormB resultFormB = new ResultFormB();
            //        resultFormB.Show();
            //        this.Hide();
            //        break;

            //    case "C":
            //        ResultFormC resultFormC = new ResultFormC();
            //        resultFormC.Show();
            //        this.Hide();
            //        break;
            //    case "D":
            //        ResultFormD resultFormD = new ResultFormD();
            //        resultFormD.Show();
            //        this.Hide();
            //        break;

            //}
            timer1.Stop();


            //★★★★★★★★仮ガチャ★★★★★★★★★★★★★★★★★★★

            //■0以上100未満のランダムな値
            int rndVal = rnd.Next(100);

            //■ランダム値が10未満の場合はレア度A
            if (rndVal < 10)
            {
                ResultFormA resultFormA = new ResultFormA();
                resultFormA.ShowDialog();
            }
            //■ランダム値が10未満の場合はレア度B
            else if (rndVal < 30)
            {
                ResultFormB resultFormB = new ResultFormB();
                resultFormB.ShowDialog();
            }
            //■ランダム値が30未満の場合はレア度B
            else if (rndVal < 30)
            {
                ResultFormB resultFormB = new ResultFormB();
                resultFormB.ShowDialog();
            }
            //■ランダム値が60未満の場合はレア度C
            else if (rndVal < 60)
            {
                ResultFormC resultFormC = new ResultFormC();
                resultFormC.ShowDialog();
            }
            //■ランダム値が60未満の場合はレア度D
            else if (rndVal < 100)
            {
                ResultFormD resultFormD = new ResultFormD();
                resultFormD.ShowDialog();
            }
            this.Hide();
            //★★★★★★★★仮ガチャ★★★★★★★★★★★★★★★★★★★
        }

    }
}
