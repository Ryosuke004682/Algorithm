using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MajorityVote_CS
{
    internal class Program
    {
        private const int MAXPEOPLE = 100;

        /// <summary>
        /// 一発で決まる多数決は何通り出来るか
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int count = 0;

            for (int rock = 0; rock <= MAXPEOPLE; rock++){ //グーだった場合
                for (int scissors = 0; scissors <= MAXPEOPLE - rock; scissors++){//チョキだった場合
                    int paper = MAXPEOPLE - rock - scissors;//パーだった場合

                    if (rock > scissors){
                        if (rock != paper){
                            count++;
                        }
                    }
                    else if (rock < scissors){
                        if (scissors != paper){
                            count++;
                        }
                    }
                    else{
                        if (rock < paper){
                            count++;
                        }
                    }
                }
                Console.WriteLine(count);
            }
            while (true) ;
        }
    }
}
