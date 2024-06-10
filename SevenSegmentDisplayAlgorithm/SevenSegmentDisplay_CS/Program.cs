using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevenSegmentDisplay_CS {
	internal class Program {
		const int N = 30;

		static void Main(string[] args) {
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
			Console.WriteLine(cnt);
			while (true) ;
		}

		static int check(int num) {
			int[] light = { 6, 2, 5, 5, 4, 5, 6, 3, 7, 6 };
			return light[num / 10] + light[num % 10];
		}
	}
}
