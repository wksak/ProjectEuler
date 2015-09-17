﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class Question0019 : QuestionRoot {
		public override string GetQuestion() {
			return @"다음은 달력에 관한 몇 가지 일반적인 정보입니다 (필요한 경우 좀 더 연구를 해 보셔도 좋습니다).
  •1900년 1월 1일은 월요일이다.
  •4월, 6월, 9월, 11월은 30일까지 있고, 1월, 3월, 5월, 7월, 8월, 10월, 12월은 31일까지 있다.
  •2월은 28일이지만, 윤년에는 29일까지 있다.
  •윤년은 연도를 4로 나누어 떨어지는 해를 말한다. 하지만 400으로 나누어 떨어지지 않는 매 100년째는 윤년이 아니며, 400으로 나누어 떨어지면 윤년이다

20세기 (1901년 1월 1일 ~ 2000년 12월 31일) 에서, 매월 1일이 일요일인 경우는 총 몇 번입니까?";
		}

		public override string GetAnswer() {
			DateTime now = new DateTime(1901, 1, 1);
			DateTime end = new DateTime(2000, 12, 31);

			int result = 0;
			while (now < end) {
				if (now.DayOfWeek == DayOfWeek.Sunday)
					result++;
				now = now.AddMonths(1);
			}

			return result.ToString();
		}
	}
}
