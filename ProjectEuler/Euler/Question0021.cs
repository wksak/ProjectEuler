using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Euler.Q0021;

namespace Euler {
	public class Question0021 : QuestionRoot {
		public override string GetQuestion() {
			return @"n의 약수들 중에서 자신을 제외한 것의 합을 d(n)으로 정의했을 때,
 서로 다른 두 정수 a, b에 대하여 d(a) = b 이고 d(b) = a 이면 
a, b는 친화쌍이라 하고 a와 b를 각각 친화수(우애수)라고 합니다. 

예를 들어 220의 약수는 자신을 제외하면 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110 이므로 그 합은 d(220) = 284 입니다.
 또 284의 약수는 자신을 제외하면 1, 2, 4, 71, 142 이므로 d(284) = 220 입니다.
 따라서 220과 284는 친화쌍이 됩니다. 

10000 이하의 친화수들을 모두 찾아서 그 합을 구하세요.";
		}

		public override string GetAnswer() {
			HashSet<int> datas = new HashSet<int>();

			StringBuilder str = new StringBuilder();

			for (int i = 2; i <= 10000; i++) {
				int d1 = functionD(i);
				if (i == functionD(d1) && i != d1) {
					datas.Add(i);
					str.AppendFormat("친화수 쌍 : {0}, {1}", i, d1);
					str.AppendLine();
				}
			}

			str.AppendFormat("친화수 ({0}개) : ", datas.Count);
			foreach(int data in datas) {
				str.AppendFormat("{0}, ", data);
			}
			str.AppendLine();
			str.AppendFormat("총합 : {0}", datas.Sum());

			return str.ToString();
		}

		private int functionD(int val) {
			List<Item> measure = GetMeasure(val);
			int measureTotal = GetMeasureTotal(1, measure, 0);
			return measureTotal - val;
		}

		private int GetMeasureTotal(int parent, List<Item> measure, int pos) {
			if (measure.Count <= pos) {
				return parent;
			}

			int result = 0;

			Item item = measure[pos];
			for (int i = 0; i <= item.count; i++) {
				result += GetMeasureTotal(parent * (int)Math.Pow(item.key, i), measure, pos + 1);
			}

			return result;
		}

		private List<Item> GetMeasure(int val) {
			List<Item> result = new List<Item>();

			int i=1;
			Item tmp = null;
			while (i++ < val) {
				if (val % i == 0) {
					tmp = new Item();
					tmp.key = i;
					result.Add(tmp);
				}
					

                while (val % i == 0) {
					tmp.count++;
					val = val / i;
				}
			}

			return result;
		}
	}
}

namespace Euler.Q0021 {
	public class Item {
		public int key { get; set; }
		public int count { get; set; }
	}
}