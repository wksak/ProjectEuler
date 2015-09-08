using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler {
	public class QuestionCreator {
		public static QuestionRoot Create(int num) {
			string name = string.Format("Euler.Question{0:0000}", num);
			Type customerType = Type.GetType(name);

			if (customerType == null)
				return new QuestionRoot();
			else
				return (QuestionRoot)Activator.CreateInstance(customerType);
		}
	}
}
