using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0012 : QuestionRoot {
		public override string GetQuestion() {
			return @"500개 이상의 약수를 갖는 가장 작은 삼각수는? ";
		}

		public override string GetAnswer() {
			int result = 0;

			long val = 0;
			for (int i=1; i<int.MaxValue; i++) {
				val += i;
				if (check(val) >= 500)
					return val.ToString();
			}
			return result.ToString();
		}

		private int check(long val) {
			int cnt = 0;
			int result = 1;
			int i = 1;
			while (i++ < val) {
				cnt = 0;
				while (val % i == 0) {
					cnt++;
					val = val / i;
				}

				if (cnt > 0)
					result *= (cnt+1);
			}
			return result;
		}
	}
}
