using C__JavaTypingGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typingGame
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm(string user, string pass)
        {
            InitializeComponent();
            this.userName.Text = user;
            this.password.Text = pass;
        }

        private void passCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheck.Checked == false)
                password.Visible = false;
            if (passCheck.Checked == true)
                password.Visible = true;
        }


        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            newRegistrationForm nr = new newRegistrationForm();
            nr.ShowDialog();
            this.Close();
        }

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                //tableに新規登録
                PlayerDTO player = new PlayerDTO(this.userName.Text, this.password.Text);
                PlayerDAO dao = new PlayerDAO();
                dao.PlayerRegistration(player);
                //画面遷移
                this.Hide();
                languageSelectionForm ls = new languageSelectionForm();
                newRegistrationForm nr = new newRegistrationForm();
                ls.ShowDialog();
                this.Close();

            }
            catch (MySql.Data.MySqlClient.MySqlException MyEx) { MessageBox.Show("このユーザー名は既に使われています"); }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.Message);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }
    }
}
