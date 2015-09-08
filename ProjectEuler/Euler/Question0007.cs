using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0007 : QuestionRoot {
		public override string GetQuestion() {
			return @"소수를 크기 순으로 나열하면 2, 3, 5, 7, 11, 13, ... 과 같이 됩니다.
이 때 10,001번째의 소수를 구하세요.";
		}

		public override string GetAnswer() {
			int result = 0;

			int cnt = 1;
			int i = 2;
			bool isPrime = true;
			while (cnt <= 10001) {
				isPrime = true;
                for (int j = 2; j < i; j++) {
					if (i % j == 0) {
						isPrime = false;
						break;
					}
				}

				if (isPrime) {
					result = i;
					cnt++;
				}

				i++;
			}

			return result.ToString();
		}
	}
}
