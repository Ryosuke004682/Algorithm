// NumeralConversion_CPP.cpp : このファイルには 'main' 関数が含まれています。プログラム実行の開始と終了がそこで行われます。


//ローマ数字の変換規則

#include <iostream>
#include <string>
#include <vector>
#include <cmath>

const int N = 12;

/// <summary>
/// 1桁分の変換
/// </summary>
/// <param name="n">変換する数</param>
/// <param name="i">単位の文字</param>
/// <param name="v">5単位の文字</param>
/// <param name="x">次の10単位の文字</param>
/// <returns>ローマ数字文字列</returns>
std::string conv(int n, char i, char v, char x) {
    std::string result = "";

    if (n == 9) {
        result += i;
        result += x;
    }
    else if (n == 4) {
        result += i;
        result += v;
    }
    else {
        if (n >= 5) {
            result += v;
            n -= 5;
        }
        for (int j = 0; j < n; j++) {
            result += i;
        }
    }

    return result;
}

/// <summary>
/// 繰り返し文字列を生成
/// </summary>
/// <param name="str">繰り返す文字列</param>
/// <param name="times">繰り返し回数</param>
/// <returns>繰り返し文字列</returns>
std::string repeat(const std::string& str, int times) {
    if (times <= 0) {
        return "";
    }

    std::string result;
    result.reserve(str.size() * times); // 最初に適切なサイズを予約してパフォーマンスの向上を図る

    for (int i = 0; i < times; ++i) {
        result += str;
    }
    return result;
}

/// <summary>
/// 数値をローマ数字に変換
/// </summary>
/// <param name="n">変換する数値</param>
/// <returns>ローマ数字文字列</returns>
std::string roman(int n) {
    int m = std::floor(n / 1000);
    n %= 1000;
    int c = std::floor(n / 100);
    n %= 100;
    int x = std::floor(n / 10);
    n %= 10;

    std::string result = repeat("M", m);
    result += conv(c, 'C', 'D', 'M');
    result += conv(x, 'X', 'L', 'C');
    result += conv(n, 'I', 'V', 'X');
    return result;
}

int main() {
    std::vector<int> cnt(N + 1, 0);

    for (int i = 1; i < 4000; i++) {
        int len = roman(i).length();
        if (len <= N) {
            cnt[len] += 1;
        }
    }

    std::cout << cnt[N] << "通り" << std::endl;

    return 0;
}