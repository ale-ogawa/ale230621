using C__JavaTypingGame;
using MySql.Data.MySqlClient;
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
    //新規登録確認画面
    public partial class RegistrationForm : Form
    {
        public RegistrationForm(string user, string pass)
        {
            InitializeComponent();
            this.userName.Text = user;
            this.password.Text = pass;
        }
        /// <summary>
        /// パスワードの目隠
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheck.Checked == false)
                password.Visible = false;
            if (passCheck.Checked == true)
                password.Visible = true;
        }
        /// <summary>
        /// 新規登録画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            ControlForm.CloseAndShow(this,typeof(newRegistrationForm));
        }
        /// <summary>
        /// ユーザー登録の実行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ConstraintException"></exception>
        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                //tableに新規登録
                PlayerDTO player = new PlayerDTO(this.userName.Text, this.password.Text);
                PlayerDAO dao = new PlayerDAO();
                dao.PlayerRegistration(player);

                //画面遷移
                ControlForm.CloseAndShow(this,typeof(languageSelectionForm));
            }
            catch (MySqlException sqlex) { MessageBox.Show(sqlex.Message); }
            catch (ConstraintException conEX) { MessageBox.Show(conEX.Message); }
            catch (ArgumentException ae){MessageBox.Show(ae.Message);}
            catch (Exception ex){MessageBox.Show(ex.Message);}
        }
    }
}
