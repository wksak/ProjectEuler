using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0025 : QuestionRoot {
		public override string GetQuestion() {
			return @"피보나치 수열은 아래와 같은 점화식으로 정의됩니다.
Fn = Fn-1 + Fn-2  (단, F1 = 1, F2 = 1).
이에 따라 수열을 12번째 항까지 차례대로 계산하면 다음과 같습니다.
F1 = 1
F2 = 1
F3 = 2
F4 = 3
F5 = 5
F6 = 8
F7 = 13
F8 = 21
F9 = 34
F10 = 55
F11 = 89
F12 = 144 
수열의 값은 F12에서 처음으로 3자리가 됩니다.
피보나치 수열에서 값이 처음으로 1000자리가 되는 것은 몇번째 항입니까?";
		}

		public override string GetAnswer() {
			BigInteger sum = new BigInteger(1);
			BigInteger pre = new BigInteger(1);

			int cnt = 2;
			do {
				BigInteger tmp = sum;
				sum = sum + pre;
				pre = tmp;
				cnt++;
			} while (BigInteger.Log10(sum) < 999);

			return $"{cnt} 번째 항" + Environment.NewLine +
				$"{sum}";
		}
	}
}
