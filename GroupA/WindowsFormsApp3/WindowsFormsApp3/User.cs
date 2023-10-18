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
            string path = @"C:\healthcare\userList.txt";
            using (StreamWriter file = new StreamWriter(path, true, Encoding.GetEncoding("shift-jis")))
            {
                file.WriteLine(user.userId + "," + user.password + "," + user.birthday + "," + user.gender);
            }
        }
    }
}
