namespace StudyQuest
{
    partial class Dashboard
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
            panelMenu = new Panel();
            linkLabel2 = new LinkLabel();
            labelTitle = new Label();
            labelChem = new Label();
            panelThermo = new Panel();
            labelThermo = new Label();
            panelOrganic = new Panel();
            labelOrganic = new Label();
            panelEquilibrium = new Panel();
            labelEquilibrium = new Label();
            labelQuiz = new Label();
            labelNoQuizImport = new Label();
            button1 = new Button();
            listBoxQuizzes = new ListBox();
            dataGridViewAttempts = new DataGridView();
            Quiz = new DataGridViewTextBoxColumn();
            Score = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            btnImport = new Button();
            btnExport = new Button();
            panelMenu.SuspendLayout();
            panelThermo.SuspendLayout();
            panelOrganic.SuspendLayout();
            panelEquilibrium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttempts).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(217, 217, 217);
            panelMenu.BorderStyle = BorderStyle.FixedSingle;
            panelMenu.Controls.Add(btnExport);
            panelMenu.Controls.Add(btnImport);
            panelMenu.Controls.Add(linkLabel2);
            panelMenu.Location = new Point(82, 274);
            panelMenu.MaximumSize = new Size(424, 470);
            panelMenu.MinimumSize = new Size(424, 470);
            panelMenu.Name = "panelMenu";
            panelMenu.Padding = new Padding(75);
            panelMenu.Size = new Size(424, 470);
            panelMenu.TabIndex = 0;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.FromArgb(155, 89, 182);
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Microsoft Sans Serif", 45F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel2.LinkColor = Color.FromArgb(51, 51, 51);
            linkLabel2.Location = new Point(94, 229);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(167, 69);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Stats";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Verdana", 48F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(27, 21);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(450, 78);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "StudyQuest";
            // 
            // labelChem
            // 
            labelChem.AutoSize = true;
            labelChem.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelChem.Location = new Point(1046, 40);
            labelChem.Name = "labelChem";
            labelChem.Size = new Size(523, 59);
            labelChem.TabIndex = 2;
            labelChem.Text = "Chemistry Quizzes";
            // 
            // panelThermo
            // 
            panelThermo.BackColor = Color.FromArgb(17, 215, 198);
            panelThermo.Controls.Add(labelThermo);
            panelThermo.Location = new Point(764, 138);
            panelThermo.Name = "panelThermo";
            panelThermo.Size = new Size(313, 163);
            panelThermo.TabIndex = 3;
            // 
            // labelThermo
            // 
            labelThermo.AutoSize = true;
            labelThermo.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelThermo.Location = new Point(31, 62);
            labelThermo.Name = "labelThermo";
            labelThermo.Size = new Size(233, 40);
            labelThermo.TabIndex = 0;
            labelThermo.Text = "Thermochemistry";
            // 
            // panelOrganic
            // 
            panelOrganic.BackColor = Color.FromArgb(17, 215, 198);
            panelOrganic.Controls.Add(labelOrganic);
            panelOrganic.Location = new Point(1133, 138);
            panelOrganic.Name = "panelOrganic";
            panelOrganic.Size = new Size(313, 163);
            panelOrganic.TabIndex = 4;
            // 
            // labelOrganic
            // 
            labelOrganic.AutoSize = true;
            labelOrganic.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelOrganic.Location = new Point(25, 62);
            labelOrganic.Name = "labelOrganic";
            labelOrganic.Size = new Size(252, 40);
            labelOrganic.TabIndex = 1;
            labelOrganic.Text = "Organic Chemistry";
            // 
            // panelEquilibrium
            // 
            panelEquilibrium.BackColor = Color.FromArgb(17, 215, 198);
            panelEquilibrium.Controls.Add(labelEquilibrium);
            panelEquilibrium.Location = new Point(1494, 138);
            panelEquilibrium.Name = "panelEquilibrium";
            panelEquilibrium.Size = new Size(313, 163);
            panelEquilibrium.TabIndex = 4;
            // 
            // labelEquilibrium
            // 
            labelEquilibrium.AutoSize = true;
            labelEquilibrium.Font = new Font("Segoe UI", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelEquilibrium.Location = new Point(10, 62);
            labelEquilibrium.Name = "labelEquilibrium";
            labelEquilibrium.Size = new Size(291, 40);
            labelEquilibrium.TabIndex = 2;
            labelEquilibrium.Text = "Equilibrium Principles";
            // 
            // labelQuiz
            // 
            labelQuiz.AutoSize = true;
            labelQuiz.Font = new Font("Verdana", 36F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuiz.Location = new Point(1111, 384);
            labelQuiz.Name = "labelQuiz";
            labelQuiz.Size = new Size(376, 59);
            labelQuiz.TabIndex = 5;
            labelQuiz.Text = "Your Quizzes";
            // 
            // labelNoQuizImport
            // 
            labelNoQuizImport.AutoSize = true;
            labelNoQuizImport.Font = new Font("Yu Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point);
            labelNoQuizImport.ForeColor = Color.FromArgb(156, 7, 7);
            labelNoQuizImport.Location = new Point(1111, 479);
            labelNoQuizImport.Name = "labelNoQuizImport";
            labelNoQuizImport.Size = new Size(346, 42);
            labelNoQuizImport.TabIndex = 6;
            labelNoQuizImport.Text = "Please import an quiz.";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(245, 112, 114);
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(15, 255, 255, 255);
            button1.Location = new Point(1167, 538);
            button1.Name = "button1";
            button1.Size = new Size(243, 70);
            button1.TabIndex = 7;
            button1.Text = "Import";
            button1.UseVisualStyleBackColor = false;
            // 
            // listBoxQuizzes
            // 
            listBoxQuizzes.FormattingEnabled = true;
            listBoxQuizzes.ItemHeight = 15;
            listBoxQuizzes.Location = new Point(616, 299);
            listBoxQuizzes.Name = "listBoxQuizzes";
            listBoxQuizzes.Size = new Size(120, 94);
            listBoxQuizzes.TabIndex = 8;
            listBoxQuizzes.DoubleClick += listBoxQuizzes_DoubleClick;
            // 
            // dataGridViewAttempts
            // 
            dataGridViewAttempts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttempts.Columns.AddRange(new DataGridViewColumn[] { Quiz, Score, Total, Date });
            dataGridViewAttempts.Location = new Point(583, 423);
            dataGridViewAttempts.Name = "dataGridViewAttempts";
            dataGridViewAttempts.RowTemplate.Height = 25;
            dataGridViewAttempts.Size = new Size(445, 150);
            dataGridViewAttempts.TabIndex = 9;
            // 
            // Quiz
            // 
            Quiz.HeaderText = "Quiz";
            Quiz.Name = "Quiz";
            // 
            // Score
            // 
            Score.HeaderText = "Score";
            Score.Name = "Score";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // btnImport
            // 
            btnImport.Location = new Point(78, 78);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(240, 72);
            btnImport.TabIndex = 4;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = true;
            btnImport.Click += btnImport_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(78, 156);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(240, 70);
            btnExport.TabIndex = 5;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 245);
            ClientSize = new Size(1904, 1041);
            Controls.Add(dataGridViewAttempts);
            Controls.Add(listBoxQuizzes);
            Controls.Add(button1);
            Controls.Add(labelNoQuizImport);
            Controls.Add(labelQuiz);
            Controls.Add(panelOrganic);
            Controls.Add(panelEquilibrium);
            Controls.Add(panelThermo);
            Controls.Add(labelChem);
            Controls.Add(labelTitle);
            Controls.Add(panelMenu);
            Name = "Home";
            Text = "Home";
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            panelThermo.ResumeLayout(false);
            panelThermo.PerformLayout();
            panelOrganic.ResumeLayout(false);
            panelOrganic.PerformLayout();
            panelEquilibrium.ResumeLayout(false);
            panelEquilibrium.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttempts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelMenu;
        private LinkLabel linkLabel2;
        private Label labelTitle;
        private Label labelChem;
        private Panel panelThermo;
        private Label labelThermo;
        private Panel panelOrganic;
        private Label labelOrganic;
        private Panel panelEquilibrium;
        private Label labelEquilibrium;
        private Label labelQuiz;
        private Label labelNoQuizImport;
        private Button button1;
        private ListBox listBoxQuizzes;
        private DataGridView dataGridViewAttempts;
        private DataGridViewTextBoxColumn Quiz;
        private DataGridViewTextBoxColumn Score;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn Date;
        private Button btnExport;
        private Button btnImport;
    }
}