using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class User
    {
        public User() { }
        public User(string userId, string password, string birthday, string gender)
        {
            this.userId = userId;
            this.password = password;
            this.birthday = birthday;
            this.gender = gender;
        }

        public string userId { get; set; }
        public string password { get; set; }
        public string birthday { get; set; }
        public string gender { get; set; }

        public void UserAdd(User user)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(@"C:\healthcare\userList.txt", true, Encoding.GetEncoding("shift-jis")))
                {
                    file.WriteLine(user.userId + "," + user.password + "," + user.birthday + "," + user.gender);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("ファイルが存在しません");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }
    }
}
