using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0003 : QuestionRoot {
		public override string GetQuestion() {
			return @"어떤 수를 소수의 곱으로만 나타내는 것을 소인수분해라 하고, 이 소수들을 그 수의 소인수라고 합니다.
예를 들면 13195의 소인수는 5, 7, 13, 29 입니다.

600851475143의 소인수 중에서 가장 큰 수를 구하세요.";
        }

		public override string GetAnswer() {
			long result = 0;
			long target = 600851475143;
			//target = 16;

			int i=1;
			while (i++ < target) {
				while (target % i == 0) {
					result = i;
					target = target / i;
				}
			}

			return result.ToString();
		}
	}
}
