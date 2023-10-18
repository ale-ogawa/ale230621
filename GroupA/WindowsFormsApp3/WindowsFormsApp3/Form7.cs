    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form7 : Form
        //メッセージ表示画面
    {
        public Form7()
        {
            InitializeComponent();
        }

        //ホーム
        private void returnHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //各種メッセージ表示
        private void Form7_Load(object sender, EventArgs e)
        {
            recommendEnergyLabel.Text = "あなたの一日の必要エネルギー量は" + LoginAccount.RecommendEnergy + "kcalです。";
            inputEnergyLabel.Text = "摂取カロリー:"+this.InputEnergyCalc()+"kcal";
            outputEnergyLabel.Text = "消費カロリー:" + this.OutputEnergyCalc() + "kcal";
            if (LoginAccount.RecommendEnergy > this.TotalEnergyCalc())
            {
                messageLabel.Text = "もっと食べましょう！エネルギーが不足しています!";
            }
            else if (LoginAccount.RecommendEnergy == this.TotalEnergyCalc())
            {
                messageLabel.Text = "ぴったり適正量を摂取できています！すごい！";
            }
            else if (LoginAccount.RecommendEnergy < this.TotalEnergyCalc())
            {
                messageLabel.Text = "食べすぎです！一日の必要エネルギーを超過しています!";
            }
        }

        //食事履歴より今日の摂取カロリーを計算
        private int InputEnergyCalc()
        {
            int inputEnergy = 0;
            List<string> mRecord = File.ReadAllLines(@"C:\healthcare\week_mealRecord.txt", Encoding.GetEncoding("utf-8")).ToList();
            foreach (var n in mRecord)
            {
                string[] list = n.Split(',');
                if (list[0] == LoginAccount.UserId && list[1] == DateTime.Now.ToString("MM/dd"))
                {
                    inputEnergy += int.Parse(list[3].Replace("kcal", ""));
                }
            }
            return inputEnergy;
        }

        //運動履歴より今日の消費カロリーを計算
        private int OutputEnergyCalc()
        {
            int outputEnergy = 0;
            List<string> eRecord = File.ReadAllLines(@"C:\healthcare\week_exerciseRecord.txt", Encoding.GetEncoding("utf-8")).ToList();
            foreach (var n in eRecord)
            {
                string[] list = n.Split(',');
                if (list[0] == LoginAccount.UserId && list[1] == DateTime.Now.ToString("MM/dd"))
                {
                    outputEnergy += int.Parse(list[4].Replace("kcal", ""));
                }
            }
            return outputEnergy;
        }

        //1日の摂取カロリーと推奨カロリーの差を計算
        private int TotalEnergyCalc()
        {
            int totalEnergy = 0;
            totalEnergy = this.InputEnergyCalc() - this.OutputEnergyCalc();
            return totalEnergy;
        }

    }
}
