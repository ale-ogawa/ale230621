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

        /// <summary>
        /// 画面遷移 引数１閉じる,引数2開く
        /// </summary>
        /// <param name="closeForm"></param>
        /// <param name="openForm"></param>
        static public void CloseAndShow(Form closeForm, Type openForm)
        {
            //開きたいformクラスのインスタンス
            Form oform = (Form)Activator.CreateInstance(openForm);

            //formの開閉
            closeForm.Hide();
            oform.ShowDialog();
            closeForm.Close();
        }
    }
}
