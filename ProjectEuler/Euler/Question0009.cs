using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0009 : QuestionRoot {
		public override string GetQuestion() {
			return @"세 자연수 a, b, c 가 피타고라스 정리 a^2 + b^2 = c^2 를 만족하면 피타고라스 수라고 부릅니다 (여기서 a < b < c ).
 예를 들면 3^2 + 4^2 = 9 + 16 = 25 = 5^2이므로 3, 4, 5는 피타고라스 수입니다.

a + b + c = 1000  인 피타고라스 수 a, b, c는 한 가지 뿐입니다. 이 때, a × b × c 는 얼마입니까?
";
		}

		public override string GetAnswer() {
			int a,b;
			double c = 0;
			for (a = 2; a < 500; a++) {
				for (b = 2; b < 500; b++) {
					c = Math.Sqrt((a * a) + (b * b));
					if ((a + b + c) == 1000) {
						return string.Format("{0} X {1} X {2} = {3}", a, b, c, a * b * c);
					}
				}
			}

			return "실패";
		}
	}
}
