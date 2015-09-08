using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0001 : QuestionRoot {
		public override string GetQuestion() {
			return @"10보다 작은 자연수 중에서 3 또는 5의 배수는 3, 5, 6, 9 이고, 이것을 모두 더하면 23입니다.

1000보다 작은 자연수 중에서 3 또는 5의 배수를 모두 더하면 얼마일까요?";
		}

		public override string GetAnswer() {
			int result = 0;

			for (int i = 0; i < 1000; i += 3) {
				result += i;
			}

			for (int i = 0; i < 1000; i += 5) {
				result += i;
			}

			for (int i = 0; i < 1000; i += 15) {
				result -= i;
			}

			return result.ToString();
		}
	}
}
