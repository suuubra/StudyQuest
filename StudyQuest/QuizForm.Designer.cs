namespace StudyQuest
{
    partial class QuizForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuestion = new Label();
            panelAnswers = new Panel();
            btnNext = new Button();
            lblProgress = new Label();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(302, 66);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(55, 15);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Question";
            // 
            // panelAnswers
            // 
            panelAnswers.Location = new Point(225, 143);
            panelAnswers.Name = "panelAnswers";
            panelAnswers.Size = new Size(200, 100);
            panelAnswers.TabIndex = 1;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(351, 271);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 2;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(232, 282);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(55, 15);
            lblProgress.TabIndex = 3;
            lblProgress.Text = "Progress:";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(207, 300);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(100, 23);
            progressBar.TabIndex = 4;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar);
            Controls.Add(lblProgress);
            Controls.Add(btnNext);
            Controls.Add(panelAnswers);
            Controls.Add(lblQuestion);
            Name = "QuizForm";
            Text = "QuizForm";
            ResumeLayout(false);
            PerformLayout();
            this.Controls.AddRange(new Control[] { lblQuestion, panelAnswers, btnNext, lblProgress, progressBar });
        }

        #endregion

        private Label lblQuestion;
        private Panel panelAnswers;
        private Button btnNext;
        private Label lblProgress;
        private ProgressBar progressBar;
    }
}