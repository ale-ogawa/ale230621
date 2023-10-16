using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__JavaTypingGame
{
    public partial class デバッグ : Form
    {
        public デバッグ()
        {
            InitializeComponent();
        }

        private void entryBottun_Click(object sender, EventArgs e)
        {
            PlayerDTO player = new PlayerDTO(name.Text, pass.Text);
            PlayerDAO dao= new PlayerDAO();

            dao.PlayerEntry(player);
            MessageBox.Show("登録完了");
        }

        private void loginBottun_Click(object sender, EventArgs e)
        {
            PlayerDTO player = new PlayerDTO(name.Text, pass.Text);
            PlayerDAO dao = new PlayerDAO();

            if (dao.PlayerLogin(player)) MessageBox.Show("ログイン成功");
            else MessageBox.Show("ログイン失敗");
        }
    }
}
