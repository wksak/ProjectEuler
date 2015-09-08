using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0002 : QuestionRoot {
		public override string GetQuestion() {
			return @"피보나치 수열의 각 항은 바로 앞의 항 두 개를 더한 것이 됩니다. 1과 2로 시작하는 경우 이 수열은 아래와 같습니다.

1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ... 

짝수이면서 4백만 이하인 모든 항을 더하면 얼마가 됩니까?";
        }

		public override string GetAnswer() {
			long atom1 = 1;
			long atom2 = 2;
			long sum = 0;

			long result = atom2;

			for (int i=0; i<100000; i++) {
				sum = atom1 + atom2;
				atom1 = atom2;
				atom2 = sum;

				if (sum > 4000000)
					break;

				if (sum % 2 == 0)
					result += sum;
			}

			return result.ToString();
		}
	}
}
