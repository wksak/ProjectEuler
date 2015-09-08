using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0010 : QuestionRoot {
		public override string GetQuestion() {
			return @"10 이하의 소수를 모두 더하면 2 + 3 + 5 + 7 = 17 이 됩니다.

이백만(2,000,000) 이하 소수의 합은 얼마입니까?";
		}

		public override string GetAnswer() {
			int i = 3;
			bool isPrime = true;
			List<int> primes = new List<int>();
			primes.Add(2);

			while (i <= 2000000) {
				isPrime = true;

				foreach(int prime in primes) {
					if (i % prime == 0) {
						isPrime = false;
						break;
					}
				}

				if (isPrime) {
					for (int j = primes.Last(); j < i; j++) {
						if (i % j == 0) {
							isPrime = false;
							break;
						}
					}

					if (isPrime) {
						primes.Add(i);
					}
				}

				i += 2;
			}

			long result = 0;
			foreach (int prime in primes)
				result += prime;

			return string.Format("소수 {0}개의 합 : {1}", primes.Count(), result);
		}
	}
}
