using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;


namespace NervousBreakdown {
    class Card : Button {
        // カードの横幅と高さ
        private const int sizeW = 50, sizeH = 70;

        // カード表面の色
        private readonly Color OpenColor = Color.White;

        // カード裏面の色
        private readonly Color CloseColor = Color.DarkGray;

        // カードの詳細
        public Card(string picture) {
            Picture = picture;
            State = false;
            base.Size = new Size(sizeW, sizeH);
            base.BackColor = CloseColor;
            base.Font = new Font("MS UI Gothic", 14, FontStyle.Bold);
            base.Enabled = false;
        }
        // カードの絵柄
        public string Picture { get; set; }

        // カードの状態(true:表 false:裏)
        public bool State { get; set; }

        // カードを表にする
        public void Open() {
            // 表
            State = true;
            base.BackColor = OpenColor;
            base.Text = Picture;

            // 選択不可
            base.Enabled = false;
        }

        // カードを裏にする
        public void Close() {
            // 裏
            State = false;
            base.BackColor = CloseColor;
            base.Text = "";

            // 選択可
            base.Enabled = true;
        }

        // カードをひっくり返す。
        public void Turn() {
            if (State == true) {
                // 裏にする
                Close();
            } else {
                // 表にする
                Open();
            }
        }
    }
}

