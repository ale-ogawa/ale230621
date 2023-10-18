using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__JavaTypingGame
{
    internal class ProblemFileReader
    {
        //アドレス
        private static String Adrres = @"C:\GitRepos\ale230621\GroupC\C#,JavaTypingGame\問題ファイル\問題.csv";

        //格納リスト
        public static List<string[]> Problem = new List<string[]>();

        /// <summary>
        /// CSVファイルから問題の読み取りとリストへの格納実行メソッド
        /// </summary>
        public void FileReader()
        {
            //リストの初期化
            Problem = null;

            //一時格納用リスト
            List<string[]> list = new List<string[]>();

            //ファイルの読み取りとリストへの追加
            using (StreamReader sr = new StreamReader(Adrres, Encoding.Default))
            {
                string line = null;
                while ((line = sr.ReadLine()) != null)
                {
                    //問題分にカンマが含まれる場合を考慮しSplitLimited()を使用
                    string[] lines = ArraySplit.SplitLimited(line, ',', 3);
                    list.Add(lines);
                }
            }
            //選択した言語と難易度の問題を取り出してリストに格納
            Problem = list.Where(x=>x[0]==PlayerDTO.Lang && x[1]==PlayerDTO.level.ToString()).ToList();
        }
    }
    internal static class ArraySplit
    {
        /// <summary>
        /// 要素数を指定して配列を生成するSplit
        /// </summary>
        /// <param name="input"></param>
        /// <param name="separator"></param>
        /// <param name="limit"></param>
        /// <returns></returns>
        public static string[] SplitLimited(this string input, char separator, int limit)
        {
            //nullなら要素数1で返す
            if (string.IsNullOrEmpty(input))　return new string[0];

            //Splitで指定要素数以下の配列が生成されればそのまま返す
            string[] parts = input.Split(separator);
            if (parts.Length <= limit)　return parts;

            //指定要素数以上の配列が生成された場合、指定要素数の配列を生成し、指定要素分だけpaetsからコピーして格納
            string[] result = new string[limit];
            Array.Copy(parts, result, limit - 1);

            //指定数を超えた要素は、配列の最後の要素に結合　
            //separator.ToString()要素毎の間に入れる文字
            //(parts, limit - 1, parts.Length - limit + 1)結合する配列とその要素範囲を指定
            result[limit - 1] = string.Join(separator.ToString(), parts, limit - 1, parts.Length - limit + 1);

            return result;
        }
    }


}
