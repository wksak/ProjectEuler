using Euler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 프로젝트_오일러 {
	public partial class MainForm : Form {
		private QuestionRoot question = new QuestionRoot();
		public MainForm() {
			InitializeComponent();

			numericUpDown1.Value = 1;
			numericUpDown1.Minimum = 1;
        }

		private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
			question = QuestionCreator.Create((int)numericUpDown1.Value);
			tbQuestion.Text = question.GetQuestion();
        }

		private void btnSolve_Click(object sender, EventArgs e) {
			Stopwatch watch = new Stopwatch();
			watch.Start();
			string result = question.GetAnswer();
			watch.Stop();

			TimeSpan span = watch.Elapsed;
			tbAnswer.Text = string.Format("실행 시간 : {0}", span.ToString(@"mm\:ss\.ffff"));
			tbAnswer.Text += Environment.NewLine;
			tbAnswer.Text += result;
		}
	}
}
