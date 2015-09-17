using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0020 : QuestionRoot {
		public override string GetQuestion() {
			return @"n! 이라는 표기법은 n × (n − 1) × ... × 3 × 2 × 1을 뜻합니다.

예를 들자면 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800 이 되는데,
 여기서 10!의 각 자리수를 더해 보면 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27 입니다.

100! 의 자리수를 모두 더하면 얼마입니까?";
		}

		public override string GetAnswer() {
			BigInteger pectorial = new BigInteger(1);
			for (int i=1; i<=100; i++) {
				pectorial *= i;
			}

			int result = 0;
			foreach (char c in pectorial.ToString().ToArray()) {
				result += c - 48;
			}

			return string.Format("결과값 {0} 의 자리수를 모두 더한 값 : {1}", pectorial.ToString(), result);
		}
	}
}
