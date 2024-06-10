// SevenSegmentDisplay_CPP.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
//

// NumeralConversion_CPP.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。
#include <iostream>
#include <vector>

const int N = 30;

int check(int num) {
    int light[] = { 6 , 2 , 5 , 5 , 4 , 5 , 6 , 3 , 7 , 6 };
    return light[num / 10] + light[num % 10];
}

int main() {
    int cnt = 0;
    for (int h = 0; h < 24; h++) {
        for (int m = 0; m < 60; m++) {
            for (int s = 0; s < 60; s++) {
                if (check(h) + check(m) + check(s) == N) {
                    cnt++;
                }
            }
        }
    }

    std::cout << cnt << std::endl;
    return 0;
}
