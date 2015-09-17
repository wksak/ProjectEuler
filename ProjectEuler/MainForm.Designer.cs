namespace 프로젝트_오일러 {
	partial class MainForm {
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.btnSolve = new System.Windows.Forms.Button();
			this.tbQuestion = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbAnswer = new System.Windows.Forms.TextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "문제 번호";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(75, 12);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 21);
			this.numericUpDown1.TabIndex = 1;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
			// 
			// btnSolve
			// 
			this.btnSolve.Location = new System.Drawing.Point(201, 12);
			this.btnSolve.Name = "btnSolve";
			this.btnSolve.Size = new System.Drawing.Size(75, 23);
			this.btnSolve.TabIndex = 2;
			this.btnSolve.Text = "문제 해결";
			this.btnSolve.UseVisualStyleBackColor = true;
			this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
			// 
			// tbQuestion
			// 
			this.tbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbQuestion.Location = new System.Drawing.Point(5, 15);
			this.tbQuestion.Multiline = true;
			this.tbQuestion.Name = "tbQuestion";
			this.tbQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbQuestion.Size = new System.Drawing.Size(257, 131);
			this.tbQuestion.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 4;
			this.label2.Text = "문제";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "답";
			// 
			// tbAnswer
			// 
			this.tbAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbAnswer.Location = new System.Drawing.Point(5, 15);
			this.tbAnswer.MaxLength = 0;
			this.tbAnswer.Multiline = true;
			this.tbAnswer.Name = "tbAnswer";
			this.tbAnswer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbAnswer.Size = new System.Drawing.Size(257, 128);
			this.tbAnswer.TabIndex = 5;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(12, 41);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tbQuestion);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tbAnswer);
			this.splitContainer1.Panel2.Controls.Add(this.label3);
			this.splitContainer1.Size = new System.Drawing.Size(265, 299);
			this.splitContainer1.SplitterDistance = 149;
			this.splitContainer1.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(289, 352);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.btnSolve);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "프로젝트 오일러";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Button btnSolve;
		private System.Windows.Forms.TextBox tbQuestion;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbAnswer;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}

