using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0018 : QuestionRoot {
		public override string GetQuestion() {
			return @"삼각형을 따라 내려가면서 합이 최대가 되는 경로 찾기";
		}

		public override string GetAnswer() {
			List<int[]> datas = new List<int[]>();

			/*
			datas.Add(new int[] { 3 });
			datas.Add(new int[] { 7, 4 });
			datas.Add(new int[] { 2, 4, 6 });
			datas.Add(new int[] { 8, 5, 9, 3 });
			/*/
			datas.Add(new int[] { 75 });
			datas.Add(new int[] { 95, 64 });
			datas.Add(new int[] { 17, 47, 82 });
			datas.Add(new int[] { 18, 35, 87, 10 });
			datas.Add(new int[] { 20, 04, 82, 47, 65 });
			datas.Add(new int[] { 19, 01, 23, 75, 03, 34 });
			datas.Add(new int[] { 88, 02, 77, 73, 07, 63, 67 });
			datas.Add(new int[] { 99, 65, 04, 28, 06, 16, 70, 92 });
			datas.Add(new int[] { 41, 41, 26, 56, 83, 40, 80, 70, 33 });
			datas.Add(new int[] { 41, 48, 72, 33, 47, 32, 37, 16, 94, 29 });
			datas.Add(new int[] { 53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14 });
			datas.Add(new int[] { 70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57 });
			datas.Add(new int[] { 91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48 });
			datas.Add(new int[] { 63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31 });
			datas.Add(new int[] { 04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23 });
			//*/

			int[] before = null;
			foreach (int[] now in datas) {
				if (before == null) {
					before = now;
					continue;
				}

				for (int i = 0; i < now.Length; i++) {
					if (i == 0)
						now[i] = before[i] + now[i];
					else if (i == now.Length - 1)
						now[i] = before[i - 1] + now[i];
					else
						now[i] = Math.Max(before[i - 1] + now[i], before[i] + now[i]);
				}
				before = now;
			}

			return datas.Last().Max().ToString();
		}
	}
}
