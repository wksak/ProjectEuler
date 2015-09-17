using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0017 : QuestionRoot {
		private string[] under20 = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
		private string[] over20 = new string[] { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

		public override string GetQuestion() {
			return @"1부터 5까지의 숫자를 영어로 쓰면 one, two, three, four, five 이고,
 각 단어의 길이를 더하면 3 + 3 + 5 + 4 + 4 = 19 이므로 사용된 글자는 모두 19개입니다.

1부터 1,000까지 영어로 썼을 때는 모두 몇 개의 글자를 사용해야 할까요?

참고: 빈 칸이나 하이픈('-')은 셈에서 제외하며, 단어 사이의 and 는 셈에 넣습니다.
   예를 들어 342를 영어로 쓰면 three hundred and forty-two 가 되어서 23 글자,
   115 = one hundred and fifteen 의 경우에는 20 글자가 됩니다.";
		}

		public override string GetAnswer() {
			int result = 0;
			for (int i = 1; i <= 1000; i++)
				result += WordCount(i);
			return result.ToString();
		}

		private int WordCount(int i) {
			int result = 0;

			if (1 <= i && i < 20) {
				result += under20[i].Length;
			}
			else if (20 <= i && i < 100) {
				result += over20[(int)(i / 10)].Length;
				result += WordCount(i % 10);
			}
			else if (100 <= i && i<1000) {
				result += WordCount(i / 100);
				result += 7; // hundred
				if (i % 100 > 0) {
					result += 3; // and
					result += WordCount(i % 100);
				}
			}
			else if (1000 <= i) {
				result += WordCount(i / 1000);
				result += 8; // thousand;
			}

			return result;
		}
	}
}
