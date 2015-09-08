using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class QuestionCreator {
		public static QuestionRoot Create(int num) {
			switch (num) {
				case 1:
					return new Euler.Question0001();
				case 2:
					return new Euler.Question0002();
				case 3:
					return new Euler.Question0003();
				case 4:
					return new Euler.Question0004();
				case 5:
					return new Euler.Question0005();
				default:
					return new QuestionRoot();
			}
		}
	}
}
