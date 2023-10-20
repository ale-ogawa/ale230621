using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupWork
{
	public partial class ItemForm : Form
	{
		public ItemForm()
		{
			InitializeComponent();

			itmLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			dateLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			itemBoxLabel.Font = new Font("Arial", 10, FontStyle.Bold);
			sortLabel.Font = new Font("Arial", 10, FontStyle.Bold);


			backButton.Font = new Font("Arial", 10, FontStyle.Bold);
			itemAddButton.Font = new Font("Arial", 10, FontStyle.Bold);
			itemUpdateButton.Font = new Font("Arial", 10, FontStyle.Bold);
			itemSortButton.Font = new Font("Arial", 10, FontStyle.Bold);
			selectMenuButton.Font = new Font("Arial", 10, FontStyle.Bold);
			deleteButton.Font = new Font("Arial", 10, FontStyle.Bold);
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			HomeForm hm = new HomeForm();
			hm.StartPosition = FormStartPosition.Manual;
			hm.Location = this.Location;
			hm.FormClosing += (s, args) => this.Show();
			hm.Show();
			this.Hide();
		}

		private void itemSortButton_Click(object sender, EventArgs e)
		{

		}
	}
}
