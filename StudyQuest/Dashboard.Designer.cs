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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelChem = new System.Windows.Forms.Label();
            this.panelThermo = new System.Windows.Forms.Panel();
            this.labelThermo = new System.Windows.Forms.Label();
            this.panelOrganic = new System.Windows.Forms.Panel();
            this.labelOrganic = new System.Windows.Forms.Label();
            this.panelEquilibrium = new System.Windows.Forms.Panel();
            this.labelEquilibrium = new System.Windows.Forms.Label();
            this.labelQuiz = new System.Windows.Forms.Label();
            this.labelNoQuizImport = new System.Windows.Forms.Label();
            this.buttonImport = new System.Windows.Forms.Button();
            this.listBoxQuizzes = new System.Windows.Forms.ListBox();
            this.dataGridViewAttempts = new System.Windows.Forms.DataGridView();
            this.Quiz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelThermo.SuspendLayout();
            this.panelOrganic.SuspendLayout();
            this.panelEquilibrium.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttempts)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Verdana", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(27, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(450, 78);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "StudyQuest";
            // 
            // labelChem
            // 
            this.labelChem.AutoSize = true;
            this.labelChem.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelChem.Location = new System.Drawing.Point(1046, 40);
            this.labelChem.Name = "labelChem";
            this.labelChem.Size = new System.Drawing.Size(523, 59);
            this.labelChem.TabIndex = 2;
            this.labelChem.Text = "Chemistry Quizzes";
            // 
            // panelThermo
            // 
            this.panelThermo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(215)))), ((int)(((byte)(198)))));
            this.panelThermo.Controls.Add(this.labelThermo);
            this.panelThermo.Location = new System.Drawing.Point(764, 138);
            this.panelThermo.Name = "panelThermo";
            this.panelThermo.Size = new System.Drawing.Size(313, 163);
            this.panelThermo.TabIndex = 3;
            // 
            // labelThermo
            // 
            this.labelThermo.AutoSize = true;
            this.labelThermo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelThermo.Location = new System.Drawing.Point(31, 62);
            this.labelThermo.Name = "labelThermo";
            this.labelThermo.Size = new System.Drawing.Size(233, 40);
            this.labelThermo.TabIndex = 0;
            this.labelThermo.Text = "Thermochemistry";
            // 
            // panelOrganic
            // 
            this.panelOrganic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(215)))), ((int)(((byte)(198)))));
            this.panelOrganic.Controls.Add(this.labelOrganic);
            this.panelOrganic.Location = new System.Drawing.Point(1133, 138);
            this.panelOrganic.Name = "panelOrganic";
            this.panelOrganic.Size = new System.Drawing.Size(313, 163);
            this.panelOrganic.TabIndex = 4;
            // 
            // labelOrganic
            // 
            this.labelOrganic.AutoSize = true;
            this.labelOrganic.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelOrganic.Location = new System.Drawing.Point(25, 62);
            this.labelOrganic.Name = "labelOrganic";
            this.labelOrganic.Size = new System.Drawing.Size(252, 40);
            this.labelOrganic.TabIndex = 1;
            this.labelOrganic.Text = "Organic Chemistry";
            // 
            // panelEquilibrium
            // 
            this.panelEquilibrium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(215)))), ((int)(((byte)(198)))));
            this.panelEquilibrium.Controls.Add(this.labelEquilibrium);
            this.panelEquilibrium.Location = new System.Drawing.Point(1494, 138);
            this.panelEquilibrium.Name = "panelEquilibrium";
            this.panelEquilibrium.Size = new System.Drawing.Size(313, 163);
            this.panelEquilibrium.TabIndex = 4;
            // 
            // labelEquilibrium
            // 
            this.labelEquilibrium.AutoSize = true;
            this.labelEquilibrium.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.labelEquilibrium.Location = new System.Drawing.Point(10, 62);
            this.labelEquilibrium.Name = "labelEquilibrium";
            this.labelEquilibrium.Size = new System.Drawing.Size(291, 40);
            this.labelEquilibrium.TabIndex = 2;
            this.labelEquilibrium.Text = "Equilibrium Principles";
            // 
            // labelQuiz
            // 
            this.labelQuiz.AutoSize = true;
            this.labelQuiz.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelQuiz.Location = new System.Drawing.Point(1111, 384);
            this.labelQuiz.Name = "labelQuiz";
            this.labelQuiz.Size = new System.Drawing.Size(376, 59);
            this.labelQuiz.TabIndex = 5;
            this.labelQuiz.Text = "Your Quizzes";
            // 
            // labelNoQuizImport
            // 
            this.labelNoQuizImport.AutoSize = true;
            this.labelNoQuizImport.Font = new System.Drawing.Font("Yu Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNoQuizImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(7)))), ((int)(((byte)(7)))));
            this.labelNoQuizImport.Location = new System.Drawing.Point(1111, 479);
            this.labelNoQuizImport.Name = "labelNoQuizImport";
            this.labelNoQuizImport.Size = new System.Drawing.Size(346, 42);
            this.labelNoQuizImport.TabIndex = 6;
            this.labelNoQuizImport.Text = "Please import an quiz.";
            // 
            // buttonImport
            // 
            this.buttonImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(112)))), ((int)(((byte)(114)))));
            this.buttonImport.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonImport.Location = new System.Drawing.Point(1167, 538);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(243, 70);
            this.buttonImport.TabIndex = 7;
            this.buttonImport.Text = "Import";
            this.buttonImport.UseVisualStyleBackColor = false;
            this.buttonImport.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxQuizzes
            // 
            this.listBoxQuizzes.FormattingEnabled = true;
            this.listBoxQuizzes.ItemHeight = 15;
            this.listBoxQuizzes.Location = new System.Drawing.Point(27, 138);
            this.listBoxQuizzes.Name = "listBoxQuizzes";
            this.listBoxQuizzes.Size = new System.Drawing.Size(731, 199);
            this.listBoxQuizzes.TabIndex = 8;
            this.listBoxQuizzes.DoubleClick += new System.EventHandler(this.listBoxQuizzes_DoubleClick);
            // 
            // dataGridViewAttempts
            // 
            this.dataGridViewAttempts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAttempts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Quiz,
            this.Score,
            this.Total,
            this.Date});
            this.dataGridViewAttempts.Location = new System.Drawing.Point(27, 371);
            this.dataGridViewAttempts.Name = "dataGridViewAttempts";
            this.dataGridViewAttempts.RowTemplate.Height = 25;
            this.dataGridViewAttempts.Size = new System.Drawing.Size(768, 150);
            this.dataGridViewAttempts.TabIndex = 9;
            // 
            // Quiz
            // 
            this.Quiz.HeaderText = "Quiz";
            this.Quiz.Name = "Quiz";
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.dataGridViewAttempts);
            this.Controls.Add(this.listBoxQuizzes);
            this.Controls.Add(this.buttonImport);
            this.Controls.Add(this.labelNoQuizImport);
            this.Controls.Add(this.labelQuiz);
            this.Controls.Add(this.panelOrganic);
            this.Controls.Add(this.panelEquilibrium);
            this.Controls.Add(this.panelThermo);
            this.Controls.Add(this.labelChem);
            this.Controls.Add(this.labelTitle);
            this.Name = "Dashboard";
            this.Text = "Home";
            this.panelThermo.ResumeLayout(false);
            this.panelThermo.PerformLayout();
            this.panelOrganic.ResumeLayout(false);
            this.panelOrganic.PerformLayout();
            this.panelEquilibrium.ResumeLayout(false);
            this.panelEquilibrium.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttempts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Button buttonImport;
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