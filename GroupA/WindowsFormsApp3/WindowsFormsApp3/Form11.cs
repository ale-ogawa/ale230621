﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp3
{
    public partial class Form11 : Form
        //1週間のカロリー履歴表示画面
    {
        public Form11()
        {
            InitializeComponent();
        }

        //戻る
        private void returnHomeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Form8 form8 = new Form8();
            form8.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            //フォルダの存在確認
            if (Directory.Exists(@"C:\healthcare\") == false)
            {
                MessageBox.Show("healthcareフォルダが存在しません");
                this.Close();
                return;
            }
            //ファイルの存在確認
            string str = "";
            if (File.Exists(@"C:\healthcare\week_mealRecord.txt") == false)
            {
                str += $"week_mealRecordファイルが存在しません\n";
            }
            if (File.Exists(@"C:\healthcare\week_exerciseRecord.txt") == false)
            {
                str += $"week_exerciseRecordファイルが存在しません\n";
            }
            if (File.Exists(@"C:\healthcare\week_energyRecord.txt") == false)
            {
                str += $"week_energyRecordファイルが存在しません\n";
            }

            if (str != "")
            {
                MessageBox.Show(str);
                this.Close();
                return;
            }

            //データグリッドビューの項目設定
            energyDataGridView.ColumnCount = 4;
            energyDataGridView.Columns[0].HeaderText = "日付";
            energyDataGridView.Columns[1].HeaderText = "摂取カロリー";
            energyDataGridView.Columns[2].HeaderText = "消費カロリー";
            energyDataGridView.Columns[3].HeaderText = "摂取カロリーと消費カロリーの差";

            try
            {
                //1日の推奨カロリーを表示
                recommendEnergyLabel.Text = "あなたの一日の必要エネルギー量は" + LoginAccount.RecommendEnergy + "kcalです。";
                //1週間分のカロリー履歴ファイルをすべてクリア
                using (var fileStream = new FileStream(@"C:\healthcare\week_energyRecord.txt", FileMode.Open))
                {
                    fileStream.SetLength(0);
                }
                //1週間分のカロリー履歴算出、カロリー履歴ファイルに書き出し
                this.EnergyCalc(DateTime.Now.AddDays(-6).ToString("MM/dd"));
                this.EnergyCalc(DateTime.Now.AddDays(-5).ToString("MM/dd"));
                this.EnergyCalc(DateTime.Now.AddDays(-4).ToString("MM/dd"));
                this.EnergyCalc(DateTime.Now.AddDays(-3).ToString("MM/dd"));
                this.EnergyCalc(DateTime.Now.AddDays(-2).ToString("MM/dd"));
                this.EnergyCalc(DateTime.Now.AddDays(-1).ToString("MM/dd"));
                this.EnergyCalc(DateTime.Now.ToString("MM/dd"));
                //ファイルから読み込んだ内容をデータグリッドビューに表示
                using (StreamReader reader = new StreamReader(@"C:\healthcare\week_energyRecord.txt", Encoding.GetEncoding("utf-8")))
                {
                    while (reader.Peek() >= 0)
                    {
                        string[] record = reader.ReadLine().Split(',');
                        energyDataGridView.Rows.Add(record[1], record[2], record[3], record[4]);
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        //1日分のエネルギー計算
        private void EnergyCalc(string day)
        {
            try
            {
                //摂取カロリー計算
                int inputEnergy = 0;
                List<string> mRecord = File.ReadAllLines(@"C:\healthcare\week_mealRecord.txt", Encoding.GetEncoding("utf-8")).ToList();
                foreach (var n in mRecord)
                {
                    string[] list = n.Split(',');
                    if (list[0] == LoginAccount.UserId && list[1] == day)
                    {
                        inputEnergy += int.Parse(list[3].Replace("kcal", ""));
                    }
                }
                //消費カロリー計算
                int outputEnergy = 0;
                List<string> eRecord = File.ReadAllLines(@"C:\healthcare\week_exerciseRecord.txt", Encoding.GetEncoding("utf-8")).ToList();
                foreach (var n in eRecord)
                {
                    string[] list = n.Split(',');
                    if (list[0] == LoginAccount.UserId && list[1] == day)
                    {
                        outputEnergy += int.Parse(list[4].Replace("kcal", ""));
                    }
                }
                //差し引きカロリー計算
                int totalEnergy = inputEnergy - outputEnergy;
                //1週間のカロリー履歴ファイルに書き込み
                using (StreamWriter writer = new StreamWriter(@"C:\healthcare\week_energyRecord.txt", true, Encoding.GetEncoding("utf-8")))
                {
                    writer.WriteLine(LoginAccount.UserId + "," + day + "," + inputEnergy + "kcal," + outputEnergy + "kcal," + totalEnergy + "kcal");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
    }
}
