using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureMatching
{
    public partial class StartForm : Form
    {
        int pushedIndexX;
        int pushedIndexY;
        Image image = Image.FromFile("Start.png");
        SoundPlayer p1 = new SoundPlayer("StartPushSound.wav");
        SoundPlayer bgm1 = new SoundPlayer("Halloween!_2 (online-audio-converter.com).wav");

        public StartForm()
        {
            InitializeComponent();
            bgm1.Play();
        }

        private void StartForm_Paint(object sender, PaintEventArgs e)
        {
            Rectangle destinationRectangle = new Rectangle(0, 0, 457, 500);
            e.Graphics.DrawImage(image, destinationRectangle);
        }

        private void StartForm_MouseDown(object sender, MouseEventArgs e)
        {
            p1.Play();
            pushedIndexX = e.Location.X;
            pushedIndexY = e.Location.Y;
        }

        private void StartForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (((70 <= pushedIndexX && pushedIndexX <= 370) && (295 <= pushedIndexY && pushedIndexY <= 400)))
            {
                using(ModeForm f2 = new ModeForm())
                {
                    f2.ShowDialog();
                }
            }
        }
    }
}
