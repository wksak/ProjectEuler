using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0005 : QuestionRoot {
		public override string GetQuestion() {
			return @"1 ~ 10 사이의 어떤 수로도 나누어 떨어지는 가장 작은 수는 2520입니다.

그러면 1 ~ 20 사이의 어떤 수로도 나누어 떨어지는 가장 작은 수는 얼마입니까?";
		}

		public override string GetAnswer() {
			long result = 1;

			for (long i = 21; i < 1000000000; i++) {
				if (GetNumber(i)) {
					result = i;
					break;
				}
			}

			return result.ToString();
		}

		private bool GetNumber(long num) {
			for (int i = 2; i < 21; i++) {
				if (num % i != 0)
					return false;
			}
			return true;
		}
	}
}
