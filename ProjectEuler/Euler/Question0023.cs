using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Euler.Q0023;

namespace Euler {
	public class Question0023 : QuestionRoot {
		private string strLock = "test";

		public override string GetQuestion() {
			return @"자신을 제외한 약수(진약수)를 모두 더하면 자기 자신이 되는 수를 완전수라고 합니다.
 예를 들어 28은 1 + 2 + 4 + 7 + 14 = 28 이므로 완전수입니다.
 또, 진약수의 합이 자신보다 작으면 부족수, 자신보다 클 때는 초과수라고 합니다.

12는 1 + 2 + 3 + 4 + 6 = 16 > 12 로서 초과수 중에서는 가장 작습니다.
 따라서 초과수 두 개의 합으로 나타낼 수 있는 수 중 가장 작은 수는 24 (= 12 + 12) 입니다.

해석학적인 방법을 사용하면, 28123을 넘는 모든 정수는 두 초과수의 합으로 표현 가능함을 보일 수가 있습니다.
 두 초과수의 합으로 나타낼 수 없는 가장 큰 수는 실제로는 이 한계값보다 작지만, 해석학적인 방법으로는 더 이상 이 한계값을 낮출 수 없다고 합니다.

그렇다면, 초과수 두 개의 합으로 나타낼 수 없는 모든 양의 정수의 합은 얼마입니까?";
		}

		public override string GetAnswer() {
			List<int> overNumbers = new List<int>();
			Dictionary<int, bool> result = new Dictionary<int, bool>();
			for (int i = 1; i < 30000; i++) {
				result.Add(i, false);
			}

			ParallelLoopResult pResult = Parallel.For(1, 30000, val => {
				if (OverNumber(val)) {
					lock (strLock)
						overNumbers.Add(val);
				}
			});

			overNumbers = overNumbers.OrderBy(o => o).ToList();

			var items = (from t1 in overNumbers
						 from t2 in overNumbers
						 where t1 + t2 < 30000
						 select t1 + t2)
						.Distinct()
						.OrderBy(o => 0)
						;

			foreach (var item in items) {
				result[item] = true;
			}

			var data = from p in result
					   where p.Value == false
					   orderby p.Key
					   select p.Key
					   ;

			return data.Sum().ToString();
		}

		private bool CheckNone(List<int> overNumbers, int val) {
			bool result = true;
			foreach (int a in overNumbers) {
				if (val < a)
					break;

				int c = val - a;
				if (overNumbers.Contains(c)) {
					result = false;
					break;
				}
			}

			return result;
		}

		private bool OverNumber(int i) {
			List<Item> measure = GetMeasure(i);
			int measureTotal = GetMeasureTotal(1, measure, 0);

			return measureTotal - i > i;
		}

		private bool OverNumber2(int i) {
			List<Item> measure = GetMeasure(i);
			int measureTotal = GetMeasureTotal(1, measure, 0);

			Debug.WriteLine(string.Format("{0} : {1}", i, measureTotal - i));

			return measureTotal - i > i;
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

			int i = 1;
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

namespace Euler.Q0023 {
	public class Item {
		public int key { get; set; }
		public int count { get; set; }
	}
}