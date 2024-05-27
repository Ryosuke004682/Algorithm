using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2^nを求めるアルゴリズム
            const int MAX_STATION_NUM = 29;


            int startStation = 1, endStation = 17;

            int stationDifference = Math.Abs(startStation - endStation);//間にある駅の数を求める

            //1 << (n - 1) == 2^(n - 1)
            int firstShiftResult = (1 << (stationDifference - 1));

            //(1 << (MAX_STATION_NUM - n - 1)) == 2^(MAX_STATION_NUM - n - 1)
            int secondShiftResult = (1 << (MAX_STATION_NUM - stationDifference - 1));

            Console.WriteLine ((firstShiftResult + secondShiftResult) - 1 + "通り");

            while (true) { }
        }
    }
}
