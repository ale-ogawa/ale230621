using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__JavaTypingGame
{
    internal class ControlForm
    {
        static public void CloseAndShow(Form closeForm, Type openForm)
        {
            Form oform = (Form)Activator.CreateInstance(openForm);
            closeForm.Hide();
            oform.ShowDialog();
            closeForm.Close();
        }
    }
}
