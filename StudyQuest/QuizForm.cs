using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyQuest
{
    public partial class QuizForm : Form
    {
        public static class CurrentUser
        {
            public static int UserId { get; set; } = 1; // Hardcode for now
        }
        private Quiz quiz;
        private int currentQuestionIndex = 0;
        private Dictionary<int, string> userAnswers = new Dictionary<int, string>();
        private string quizFilePath;
        public QuizForm(string quizFilePath)
        {
            InitializeComponent();
            this.quizFilePath = quizFilePath;
            this.Size = new System.Drawing.Size(800, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(200, 220, 255);
            LoadQuiz();
            if (quiz != null) DisplayQuestion();
        }
        private void LoadQuiz()
        {
            try
            {
                string json = File.ReadAllText(quizFilePath);
                quiz = JsonConvert.DeserializeObject<Quiz>(json);
                if (quiz?.Questions == null || !quiz.Questions.Any())
                {
                    MessageBox.Show("Invalid or empty quiz file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load quiz: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < 0 || currentQuestionIndex >= quiz.Questions.Count) return;
            var question = quiz.Questions[currentQuestionIndex];
            lblQuestion.Text = question.Text;

            // Clear previous radio buttons
            panelAnswers.Controls.Clear();
            int yPos = 20;
            for (int i = 0; i < question.Choices.Count; i++)
            {
                var radio = new RadioButton
                {
                    Text = question.Choices[i],
                    Location = new System.Drawing.Point(20, yPos),
                    Size = new System.Drawing.Size(200, 30)
                };
                panelAnswers.Controls.Add(radio);
                yPos += 40;
            }

            lblProgress.Text = $"Question {currentQuestionIndex + 1} of {quiz.Questions.Count}";
            progressBar.Value = (currentQuestionIndex + 1) * 100 / quiz.Questions.Count;
        }


          private void SubmitQuiz()
            {
                int score = 0;
                int totalPoints = 0;
                foreach (var answer in userAnswers)
                {
                    var question = quiz.Questions.First(q => q.Id == answer.Key);
                    if (question.Answer.Equals(answer.Value, StringComparison.OrdinalIgnoreCase))
                    {
                        score += question.Points;
                    }
                    totalPoints += question.Points;
                }
                SaveQuizAttempt(score);
                MessageBox.Show($"Quiz completed! Your score: {score + 1}/{totalPoints}", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


            private void SaveQuizAttempt(int score)
            {
                var attempt = new
                {
                    UserId = 1, // Assume CurrentUser set after login
                    QuizId = quiz.QuizId,
                    QuizTitle = quiz.Title,
                    Score = score,
                    TotalPoints = quiz.TotalPoints,
                    AttemptDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                };
                var attempts = File.Exists("Stats.json") ?
                    JsonConvert.DeserializeObject<List<object>>(File.ReadAllText("Stats.json")) :
                    new List<object>();
                attempts.Add(attempt);
                File.WriteAllText("Stats.json", JsonConvert.SerializeObject(attempts, Formatting.Indented));
            }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var question = quiz.Questions[currentQuestionIndex];
            var selectedRadio = panelAnswers.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (selectedRadio == null)
            {
                MessageBox.Show("Please select an answer.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            userAnswers[question.Id] = selectedRadio.Text;
            currentQuestionIndex++;
            if (currentQuestionIndex < quiz.Questions.Count)
            {
                DisplayQuestion();
            }
            else
            {
                SubmitQuiz();
            }
        }
    }
    }

