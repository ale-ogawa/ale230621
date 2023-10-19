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
    public partial class runkingForm : Form
    {
        public runkingForm()
        {
            DataTable dataTableC = new DataTable();
            DataTable dataTableJava = new DataTable();

            InitializeComponent();
            PlayerDAO playerDAO = new PlayerDAO();
            dataTableC = playerDAO.DetaGetC();
            dataTableJava = playerDAO.DetaGetJava();

            CdataGridView.DataSource = dataTableC;
            JavadataGridView.DataSource = dataTableJava;

            List<Label> labelC = new List<Label> { CUser1, CUser2, CUser3, CUser4, CUser5, CUser6, CUser7, CUser8, CUser9, Cuser10 };
            List<Label> labelJava = new List<Label> { JavaUser1, JavaUser2, JavaUser3,JavaUser4,JavaUser5,JavaUser6,JavaUser7,JavaUser8,JavaUser9,JavaUser10 };
            for (int i = 0; i < dataTableC.Rows.Count; i++)
            {
                labelC[i].Text = CdataGridView.Rows[i].Cells[0].Value.ToString() + ":" + CdataGridView.Rows[i].Cells[1].Value.ToString() + "点";
                labelJava[i].Text = JavadataGridView.Rows[i].Cells[0].Value.ToString() + ":" + JavadataGridView.Rows[i].Cells[1].Value.ToString() + "点";
            }
        }

        private void menueButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            languageSelectionForm languageSelectionForm = new languageSelectionForm();
            languageSelectionForm.ShowDialog();
            this.Close();
        }
    }
}
