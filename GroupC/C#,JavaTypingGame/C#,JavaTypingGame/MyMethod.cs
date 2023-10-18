using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C__JavaTypingGame
{
    internal class MyMethod
    {
        /// <summary>
        /// 文字列が英数字かどうかを判定します
        /// </summary>
        /// <remarks>大文字・小文字を区別しません</remarks>
        /// <param name="target">対象の文字列</param>
        /// <returns>文字列が英数字の場合はtrue、それ以外はfalse</returns>
        public static bool IsAlphanumeric(string target)
        {
            return new Regex("^[0-9a-zA-Z]+$").IsMatch(target);
        }
    }
}
