// BitOperator.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。

#include <iostream>

int main()
{
    //2^nを求めるアルゴリズム
    const int MAX_STATION_NUM = 29;


    int startStation = 1 , endStation = 17;
    int stationDifference = std::abs(startStation - endStation);//間にある駅の数を求める

    //1 << (n - 1) == 2^(n - 1)
    int firstShiftResult = (1 << (stationDifference - 1));

    //(1 << (MAX_STATION_NUM - n - 1)) == 2^(MAX_STATION_NUM - n - 1)
    int secondShiftResult = (1 << (MAX_STATION_NUM - stationDifference - 1)); 

    std::cout << ((firstShiftResult + secondShiftResult) -1) << "通り";
}
