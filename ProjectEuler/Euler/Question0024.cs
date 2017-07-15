﻿using Euler;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0024 : QuestionRoot {
		List<long> result = new List<long>();

		public override string GetQuestion() {
			return @"어떤 대상을 순서에 따라 배열한 것을 순열이라고 합니다. 예를 들어 3124는 숫자 1, 2, 3, 4로 만들 수 있는 순열 중 하나입니다.
이렇게 만들 수 있는 모든 순열을 숫자나 문자 순으로 늘어놓은 것을 사전식(lexicographic) 순서라고 합니다.
0, 1, 2로 만들 수 있는 사전식 순열은 다음과 같습니다.
012   021   102   120   201   210
0, 1, 2, 3, 4, 5, 6, 7, 8, 9로 만들 수 있는 사전식 순열에서 1,000,000번째는 무엇입니까?";
		}

		public override string GetAnswer() {
			List<string> data = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

			foreach(string item in data) {
				List<string> subItems = data.ToList();
				subItems.Remove(item);
				Sub(item, subItems);
			}

			result.Sort();
			long get = result.Skip(999999).FirstOrDefault();

			return $"1,000,000 번째 값 : {get:N0}";
		}

		private void Sub(string parent, List<string> data) {
			if (data.Count == 0) {
				result.Add(long.Parse(parent));
			}

			foreach (string item in data) {
				List<string> subItems = data.ToList();
				subItems.Remove(item);
				Sub(parent + item, subItems);
			}
		}
	}
}
