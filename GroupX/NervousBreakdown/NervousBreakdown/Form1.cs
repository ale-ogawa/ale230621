#region using類 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

#endregion

namespace NervousBreakdown {
    public partial class Form1 : Form {
        #region ゲーム詳細
        // 遊ぶカードの束
        private Card[] playingCards;

        // プレイヤー
        private Player player;

        // ゲーム時間
        // ストップウォッチの時間の挿入
        DateTime time = new DateTime();

        #endregion
        public Form1() {
            InitializeComponent();
        }

        #region フォーム画面
        /// <summary>
        /// フォーム画面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e) {
            // カードの生成
            createCards(ref playingCards);

            // プレイヤーの生成
            player = new Player();

            // カードをFormに並べる
            SuspendLayout();

            const int offsetX = 30, offsetY = 50;

            for (int i = 0; i < playingCards.Length; i++) {
                // カード(ボタン)のプロパティを設定する
                playingCards[i].Name = "card" + i;

                int sizeW = playingCards[i].Size.Width;
                int sizeH = playingCards[i].Size.Height;

                playingCards[i].Location =
                new Point(offsetX + i % 8 * sizeW, offsetY + i / 8 * sizeH);

                // イベントハンドラに関連付け
                playingCards[i].Click += new EventHandler(cardButtons_Click);
            }

            Controls.AddRange(playingCards);
            ResumeLayout(false);

            // 上の画面のラベルを表示
            labelGuidance.Text = "右下の「ゲームスタート」ボタンをクリックしてゲームを神経衰弱を開始してください。\nゲームを中断するときは、「中断」ボタンを押して中断してください。";
        }
        #endregion

        #region カードの詳細
        /// <summary>
        /// カードの生成
        /// カードの種類を決める (今現在カードの枚数 56枚)
        /// </summary>
        /// <param name="cards">カード配列への参照</param>
        private void createCards(ref Card[] cards) {
            // 神経衰弱のカードの種類を決める
            // 今現在 28種類56枚
            string[] picture = {
                                "○", "●" , "◎" , "△" , "▲", "▼" , "▽",
                                "□", "■" , "◇" , "◆" ,"☆"  ,"★", "×" ,
                                "※" , "?"  , "$"  , "%"  , "1"  , "2" , "3" ,
                                "4"  , "5" ,"6" , "7"  , "8"  , "9"  , "0"
                               };

            // カードのインスタンスの生成
            cards = new Card[picture.Length * 2];

            for (int i = 0, j = 0; i < cards.Length; i += 2, j++) {
                cards[i] = new Card(picture[j]);
                cards[i + 1] = new Card(picture[j]);
            }
            // 画像ファイルのパスを指定して読み込む
            //Image buttonImage = Image.FromFile("path_to_your_image.jpg"); 
            //myButton.Image = buttonImage;
        }
        #endregion

        #region カードを混ぜ、ゲームをスタートさせる
        /// <summary>
        /// カードを混ぜてゲームを開始する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void buttonStart_Click(object sender, EventArgs e) {
            // カードを混ぜる。
            shuffleCard(playingCards);


            // 全部のカードを処理。
            foreach (Card c in playingCards) {
                c.Open();
            }
            await Task.Delay(3000);
            // 3秒後に伏せる
            foreach (Card c in playingCards) {
                c.Close();
            }

            // スタートの選択不可
            buttonStart.Enabled = false;

            // ゲームをスタートさせるときに、タイマーを開始する。
            timer1.Start();

            // 上の画面のラベルを表示
            labelGuidance.Text = "クリックしてカードをクリックしてめくってください。";

            // 「中断」ボタン,「終了」ボタンの最初のスタートする前のときに、ボタンを押すことができず、神経衰弱の
            //　ゲームを開始したときに、「中断」,「終了」を押すことができるようにする。
            buttonfinish.Enabled = true;
            buttonpretermit.Enabled = true;
        }
        #endregion

        #region カードを混ぜる
        /// <summary>
        /// カードを混ぜる
        /// </summary>
        /// <param name="cards">カード配列</param>
        private void shuffleCard(Card[] cards) {
            // カードを混ぜるときの設定
            Random r = new Random();

            int n = cards.Length - 1;

            while (n > 0) {
                int w = r.Next(0, n);
                string s = cards[n].Picture;
                cards[n].Picture = cards[w].Picture;
                cards[w].Picture = s;
                n--;
            }
        }

        #endregion

        #region 神経衰弱のゲーム時間を追加する
        /// <summary>
        /// 経過時間
        /// テキストボックスの中のタイマーの表示形式を変える。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) {
            // ゲーム時間を1秒ずつ追加する。
            time = time.AddMilliseconds(1000);

            // 左上のテキストボックスの中に表示する
            textBox1.Text = time.ToLongTimeString();
        }
        #endregion

        #region 神経衰弱のカードについて
        /// <summary>
        /// カード操作
        /// 1枚目,2枚目のカードを引く
        /// カードが一致した場合、カードが不一致の場合
        /// カードがすべてめくるとタイマーが停止し、メッセージボックスを表示する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cardButtons_Click(object sender, EventArgs e) {
            // textBox2.Text = "56";
            // int left = 56;

            // めくるのは1枚目か?
            if (player.OpenCounter == 0) {
                // 前回のカードが不一致ならカードを伏せる。
                int b1 = player.BeforeOpenCardIndex1;
                int b2 = player.BeforeOpenCardIndex2;

                // 神経衰弱のカードが不一致の場合1枚目と2枚目のカードを閉じる
                if (b1 != -1 && b2 != -1 && matchCard(playingCards, b1, b2) == false) {
                    playingCards[b1].Close();
                    playingCards[b2].Close();
                }

                // クリックしたボタンのNameからカードの添え字を取得する。
                int n1 = int.Parse(((Button)sender).Name.Substring(4));

                // 1枚目のカードを開く。
                playingCards[n1].Open();
                player.NowOpenCardIndex1 = n1;

                // 上の画面のラベルを表示
                labelGuidance.Text = "もう一枚クリックしてカードをめくってください。";
            }

            // めくるのは2枚目か？
            else if (player.OpenCounter == 1) {
                // クリックしたボタンのNameから添え字を取得する。
                int n2 = int.Parse(((Button)sender).Name.Substring(4));

                // 2枚目を開く。
                playingCards[n2].Open();
                player.NowOpenCardIndex2 = n2;

                // 1枚目と2枚目のカードは一致したか?
                if (matchCard(playingCards, player.NowOpenCardIndex1, player.NowOpenCardIndex2) == true) {
                    // カードが一致した場合
                    // 上の画面のラベルを表示
                    labelGuidance.Text = "カードが一致しました。クリックして次のカードをめくってください。";
                } else {
                    // left = 0;
                    // カードが一致しなかった場合
                    // 上の画面のラベルを表示
                    labelGuidance.Text = "カードは不一致です。クリックして次のカードをめくってください。";
                }

                // プレイヤーのカード情報をリセットする。
                player.Reset();

                // 全カードをめくったか?
                if (allOpenCard(playingCards)) {
                    // 上の画面のラベルを表示
                    labelGuidance.Text = "カードがすべて一致しました。";

                    // タイマーがストップ(停止)
                    timer1.Stop();

                    // メッセージボックスで「全部のカードが揃いました。時間は??分??秒でした。お疲れ様でした。」が表示される。
                    MessageBox.Show("全部のカードが揃いました。時間は" + time.Minute + "分" + time.Second + "秒でした。\nお疲れ様でした。"
                        , "ゲーム結果", MessageBoxButtons.OK);

                    // 神経衰弱のゲームをもう一回するかをメッセージボックスで表示する
                    DialogResult tuduki;
                    tuduki = MessageBox.Show("1回リセットし、最初から始めますか？", "コンティニュー", MessageBoxButtons.YesNo);
                    if (tuduki == DialogResult.Yes) {
                        Application.Restart();
                    } else {
                        // 神経衰弱のゲームを終了し、神経衰弱と下記のメッセージボックスとともにフォームを閉じる
                        MessageBox.Show("神経衰弱のゲームを終了します。", "終了", MessageBoxButtons.OK);
                        this.Close();
                    }
                    // スタートボタン選択可
                    buttonStart.Enabled = true;
                }
            }
        }

        #endregion

        #region カードは全部開いているか
        /// <summary>
        /// カードの配列
        /// </summary>
        /// <param name="cards"></param>
        /// <returns>true:全部表 false:1枚以上の裏のカードがある</returns>
        private bool allOpenCard(Card[] cards) {
            foreach (Card c in cards) {
                if (c.State == false) {
                    // 終了する
                    return false;
                }
            }
            // 続行する
            return true;
        }

        #endregion

        #region カードは一致しているか
        /// <summary>
        /// カードは一致したか
        /// </summary>
        /// <param name="cards"></param>
        /// <param name="index1">1枚目のカードの添え字</param>
        /// <param name="index2">2枚目のカードの添え字</param>
        /// <returns>true:一致 false:不一致</returns>
        private bool matchCard(Card[] cards, int index1, int index2) {
            if (index1 < 0 || index1 >= cards.Length || index2 >= cards.Length) {
                // カードが不一致
                return false;
            } else if (cards[index1].Picture == cards[index2].Picture) {
                // カードが一致
                return true;
            } else {
                // その他
                return false;
            }
        }
        #endregion

        #region 神経衰弱を途中で終了か？ 続行か？

        /// <summary>
        /// 途中で終了するか続行するか
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonfinish_Click(object sender, EventArgs e) {
            // タイマーを一旦ストップし、神経衰弱のゲームを終了するか、メッセージボックスで質問する。
            timer1.Stop();

            DialogResult finish;

            // メッセージボックスを表示
            finish = MessageBox.Show("神経衰弱をこのまま終了していいですか?", "終了", MessageBoxButtons.YesNo);

            if (finish == DialogResult.Yes) {
                // 神経衰弱のゲーム終了のメッセージボックスを表示する
                MessageBox.Show("神経衰弱を終了します。", "終了メッセージ", MessageBoxButtons.OK);
                // 神経衰弱のフォームを閉じる
                this.Close();
            } else {
                // 神経衰弱のゲームが始まるとともにタイマーが再起動する。
                timer1.Start();
            }
        }

        #endregion

        #region 神経衰弱を途中で中断し、ボタンを押すと再開する
        /// <summary>
        /// 途中で中断し、神経衰弱を再開する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonpretermit_Click(object sender, EventArgs e) {
            // タイマーをストップし、メッセージボックスで「今、神経衰弱を中断しています。」を表示し、質問する。
            timer1.Stop();

            // メッセージボックスを表示
            MessageBox.Show("今、神経衰弱を中断しています。", "中断中", MessageBoxButtons.OK);

            // 神経衰弱のゲームが始まるとともにタイマーが再起動する
            timer1.Start();
        }

        #endregion

        #region 神経衰弱のルールの説明をする
        /// <summary>
        /// ルールを説明
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e) {
            // 神経衰弱のゲームを開始する前や、神経衰弱のゲームをしているときに、分からなくなったときにメッセージボックスで表示し、
            // 神経衰弱のゲームをしているときに、タイマーを一時的にストップし、メッセージボックスで表示する。
            timer1.Stop();

            // メッセージボックスでルールを表示
            MessageBox.Show("今あるカードは数字と記号が混ざって56枚のカードがあります。\n プレイヤーは選ぶカードをマウスでクリックしてください。\nそのときタイマーはスタートし、神経衰弱を開始しています。\n神経衰弱はの56枚のカードが合うまでタイマーは止まりません。"
                , "神経衰弱のルール", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}