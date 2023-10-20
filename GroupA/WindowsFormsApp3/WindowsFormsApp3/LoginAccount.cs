using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    //ログインしているアカウント情報を保持するクラス
    internal class LoginAccount
    {
        public static string UserId;
        public static int RecommendEnergy;

        public LoginAccount(User user)
        {
            UserId = user.userId;
            RecommendEnergy = this.RecommendEnergyCalc(user.gender, user.birthday);
        }

        //ログインアカウントの一日の推奨カロリー量を計算
        private int RecommendEnergyCalc(char gender, string birthday)
        {
            if (gender == '男')
            {
                int today = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                int age = (today - int.Parse(birthday)) / 10000;
                RecommendEnergy = (18 <= age && age <= 49) ? 2295 : 2220;

                return RecommendEnergy;
            }
            else
            {
                int today = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
                int age = (today - int.Parse(birthday)) / 10000;
                RecommendEnergy = (18 <= age && age <= 29) || (50 <= age && age <= 64) ? 1665 : 1740;

                return RecommendEnergy;
            }
        }
    }
}
