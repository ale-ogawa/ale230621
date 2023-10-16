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
        private String Adrres = @"\\192.168.1.251\エール3f教室生徒\01_授業\10_グループ開発\GroupC\問題ファイル\問題デバッグ用.csv";

        //格納リスト
        public static List<string[]> Problem = new List<string[]>();

        public void FileReader()
        {
            Problem = null;
            List<string[]> list = new List<string[]>();

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                //カンマ区切り
                Delimiter = ",",
                //ヘッダー行
                HasHeaderRecord = true,
                //空行無視
                IgnoreBlankLines = true,
                //空白をトリム
                TrimOptions = TrimOptions.Trim,
            };

            using (StreamReader sr = new StreamReader(Adrres, Encoding.Default))
            using (var csv = new CsvReader(sr,config))
            {
                while (csv.Read())
                {
                    var record = csv.GetRecord<string>();
                    String[] line = record.ToString().Split(',');
                    if (line.Length > 3)
                    {
                        for (int i = 3; i < line.Length - 3; i++)
                        {
                            line[2] += "," + line[i];
                        }
                    }
                    //line[2] = line[2].Trim('/');
                    //line[2] = line[2].Trim('"');
                    //line[2] = line[2].Trim('/');
                    //line[2] = line[2].Trim('"');
                    list.Add(line);
                }
            }

            //Problem=list.Where(x => x[0] == "C#" && x[1] == "初級").ToList();
            Problem = list;
        }
    }
}
