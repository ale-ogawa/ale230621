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

        public LotteryForm()
        {
            InitializeComponent();

            // Timerコントロールを初期化
            displayTimer = new Timer();
            displayTimer.Interval = 3000; //3秒


        }

    }
}
