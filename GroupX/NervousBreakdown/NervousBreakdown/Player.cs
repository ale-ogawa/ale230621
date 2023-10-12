using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;//.Tasks;

namespace NervousBreakdown {
    /// <summary>
    /// プレイヤークラス
    /// </summary>
    class Player {
        /** 1枚目のカードの添え字 */
        private int nowOpenCardIndex1;
        /** 2枚目のカードの添え字 */
        private int nowOpenCardIndex2;
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Player() {
            NowOpenCardIndex1 = NowOpenCardIndex2 = -1;
            BeforeOpenCardIndex1 = BeforeOpenCardIndex2 = -1;
            OpenCounter = 0;
        }

        /// <summary>
        /// 1枚目のカードの添え字
        /// </summary>
        public int NowOpenCardIndex1 {
            get { return nowOpenCardIndex1; }
            set {
                nowOpenCardIndex1 = value;
                OpenCounter++;
            }
        }

        /// <summary>
        /// 2枚目のカードの添え字
        /// </summary>
        public int NowOpenCardIndex2 {
            get { return nowOpenCardIndex2; }
            set {
                nowOpenCardIndex2 = value;
                OpenCounter++;
            }
        }

        /// <summary>
        /// 前回の1枚目のカードの添え字
        /// </summary>
        public int BeforeOpenCardIndex1 { get; set; }

        /// <summary>
        /// 前回の2枚目のカードの添え字
        /// </summary>
        public int BeforeOpenCardIndex2 { get; set; }

        /// <summary>
        /// めくった回数
        /// </summary>
        public int OpenCounter { get; set; }

        /// <summary>
        /// カード情報をリセットする
        /// </summary>
        public void Reset() {
            BeforeOpenCardIndex1 = NowOpenCardIndex1;
            BeforeOpenCardIndex2 = NowOpenCardIndex2;
            NowOpenCardIndex1 = -1;
            NowOpenCardIndex2 = -1;
            OpenCounter = 0;
        }
    }
}
