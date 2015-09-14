using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0016 : QuestionRoot {
		public override string GetQuestion() {
			return @"2^15 = 32768 의 각 자리수를 더하면 3 + 2 + 7 + 6 + 8 = 26 입니다.

2^1000의 각 자리수를 모두 더하면 얼마입니까?
";
		}

		public override string GetAnswer() {
			BigInteger data = 1;

			for (int i = 0; i < 1000; i++)
				data *= 2;

			int result = 0;
			foreach (char c in data.ToString().ToArray()) {
				result += c - 48;
			}

			return string.Format("{0}의 자리수 합은 {1}", data.ToString(), result);
		}
	}
}
