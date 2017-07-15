using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0004 : QuestionRoot {
		public override string GetQuestion() {
			return @"앞에서부터 읽을 때나 뒤에서부터 읽을 때나 모양이 같은 수를 대칭수(palindrome)라고 부릅니다.
두 자리 수를 곱해 만들 수 있는 대칭수 중 가장 큰 수는 9009 (= 91 × 99) 입니다.
세 자리 수를 곱해 만들 수 있는 가장 큰 대칭수는 얼마입니까?";
		}

		public override string GetAnswer() {
			string result = "실패";
			int maxValue = 0;

			for (int i = 999; i > 99; i--) {
				for (int j = 999; j >= i; j--) {
					if (CheckPalindrome(i, j)) {
						if (i * j > maxValue) {
							result = string.Format("{0} * {1} = {2}", i, j, i * j);
							maxValue = i * j;
						}
					}
				}
			}

			return result;
		}

		private bool CheckPalindrome(int i, int j) {
			int check = i * j;

			string tmp = check.ToString();
			string tmp2 = new string(tmp.Reverse().ToArray());

			return string.Compare(tmp, tmp2) == 0 ? true : false;
		}
	}
}
