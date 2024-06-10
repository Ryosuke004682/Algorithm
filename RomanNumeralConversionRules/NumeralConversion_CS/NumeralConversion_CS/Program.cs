using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NumeralConversion_CS
{
    internal class Program
    {
        private const int N = 12;

        static void Main(string[] args)
        {
            //ローマ数字の変換規則

            List<int> cnt = new List<int>(new int[N + 1]);

            for(int i = 1; i < 4000; i++)
            {
                int len = Roman(i).Length;
                if(len <= N)
                {
                    cnt[len] += 1;
                }
            }

            Console.WriteLine(cnt[N] + "通り");
            while (true) ;
        }


        /// <summary>
        /// 1桁の整数を対応するローマ数字の部分文字列に変換
        /// </summary>
        /// <param name="n">変換する数</param>
        /// <param name="i">単位の文字</param>
        /// <param name="v">5単位の文字</param>
        /// <param name="x">次の10単位の文字</param>
        /// <returns>ローマ数字文字列</returns>
        static string Conv(int n , char i, char v, char x)
        {
            string result = "";

            if (n == 9)
            {
                result += i;
                result += x;
            }
            else if(n == 4)
            {
                result += i;
                result += x;
            }
            else
            { 
                if (n >= 5)
                {
                    result += v;
                    n -= 5;
                }
                for(int j = 0; j < n; j++)
                {
                    result += i;
                }
            }
            return result;
        }


        /// <summary>
        /// 指定された文字列を指定回数繰り返して新しい文字列を生成する
        /// </summary>
        /// <param name="str"></param>
        /// <param name="timer"></param>
        /// <returns></returns>
        static string Repeat(string str , int timer) 
        {
            if(timer <= 0)
            {
                return string.Empty;
            }

            StringBuilder result = new StringBuilder(str.Length * timer);
            for(int i = 0; i < timer; i++)
            {
                result.Append(str);
            }
            
            return result.ToString();
        }


        /// <summary>
        /// 数値をローマ数字に変換
        /// </summary>
        /// <param name="n">変換する数値</param>
        /// <returns>ローマ数字文字列</returns>
        static string Roman(int n)
        {
            int m = n / 1000;
            n %= 1000;
            int c = n / 100;
            n %= 100;
            int x = n / 10;
            n %= 10;

            string result = Repeat("M" , m);
            result += Conv(c , 'C' , 'D' , 'M');
            result += Conv(x , 'X' , 'L' , 'C');
            result += Conv(n , 'I' , 'V' , 'X');
            return result;
        }
    }
}
