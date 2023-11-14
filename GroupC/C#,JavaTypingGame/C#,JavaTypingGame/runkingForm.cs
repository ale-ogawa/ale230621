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
    //ランキング画面
    public partial class runkingForm : Form
    {
        public runkingForm()
        {
            try
            {
                //データテーブル型のインスタンス生成
                DataTable dataTableC = new DataTable();
                DataTable dataTableJava = new DataTable();

                InitializeComponent();

                //データベースの内容を各インスタンスに挿入
                PlayerDAO playerDAO = new PlayerDAO();
                dataTableC = playerDAO.DetaGetC();
                dataTableJava = playerDAO.DetaGetJava();

                //各データグリッドビューに反映
                CdataGridView.DataSource = dataTableC;
                JavadataGridView.DataSource = dataTableJava;

                //データグリッドビューの内容をテキストに反映
                List<Label> labelC = new List<Label> { CUser1, CUser2, CUser3, CUser4, CUser5, CUser6, CUser7, CUser8, CUser9, Cuser10 };
                List<Label> labelJava = new List<Label> { JavaUser1, JavaUser2, JavaUser3, JavaUser4, JavaUser5, JavaUser6, JavaUser7, JavaUser8, JavaUser9, JavaUser10 };
                for (int i = 0; i < CdataGridView.RowCount-1; i++)
                        labelC[i].Text = CdataGridView.Rows[i].Cells[0].Value.ToString() + ":" + CdataGridView.Rows[i].Cells[1].Value.ToString() + "点";
                for (int i = 0; i < JavadataGridView.RowCount-1; i++)
                    labelJava[i].Text = JavadataGridView.Rows[i].Cells[0].Value.ToString() + ":" + JavadataGridView.Rows[i].Cells[1].Value.ToString() + "点";

            }
            catch (ConstraintException cEx) { MessageBox.Show(cEx.Message); }
            catch (Exception EX) { MessageBox.Show(EX.Message); }
        }
        /// <summary>
        ///　言語選択画面に遷移
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menueButton_Click(object sender, EventArgs e)
        {
            ControlForm.CloseAndShow(this, typeof(languageSelectionForm));
        }
    }
}
