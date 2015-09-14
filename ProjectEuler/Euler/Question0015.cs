using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0015 : QuestionRoot {
		public override string GetQuestion() {
			return @"20×20 격자의 좌상단에서 우하단으로 가는 경로의 수";
		}

		public override string GetAnswer() {
			BigInteger result = 1;
			int target = 40;

			for (int i=(target / 2) + 1; i <= target; i++) {
				result *= i;
			}

			for (int i = 1; i <= (target / 2); i++)
				result /= i;

			return result.ToString();
		}
	}
}
