using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
namespace StudyQuest
{//test
    public partial class Dashboard : Form
    {
        List<Quiz> quizzes = new List<Quiz>();
        public Dashboard()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1920, 1080);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.BackColor = Color.FromArgb(200, 220, 255);
            ImportChemistryQuiz();
            LoadAttempts();
        }

        public static class CurrentUser
        {
            public static int UserId { get; set; } = 1; // Hardcode for now
        }
        public void ImportChemistryQuiz()
        {
            listBoxQuizzes.Items.Clear();
            Directory.CreateDirectory("Quizzes");
            foreach (var file in Directory.GetFiles("Quizzes", "*.json"))
            {
                try
                {
                    var json = File.ReadAllText(file);
                    var quiz = JsonConvert.DeserializeObject<Quiz>(json);
                    quizzes.Add(quiz);
                    listBoxQuizzes.Items.Add(new { QuizId = quiz.QuizId, Title = quiz.Title, FilePath = file });
                }
                catch { /* Skip invalid files */ }
            }

        }
        private void LoadAttempts()
        {
            dataGridViewAttempts.Rows.Clear();
            if (!File.Exists("Stats.json")) return;
            var attempts = JsonConvert.DeserializeObject<List<dynamic>>(File.ReadAllText("Stats.json"));
            foreach (var attempt in attempts)
            {
                if (attempt.UserId == CurrentUser.UserId)
                {
                    dataGridViewAttempts.Rows.Add(attempt.QuizTitle, attempt.Score, attempt.TotalPoints, attempt.AttemptDate);
                }
            }
        }

        // Select Quiz.


        private void listBoxQuizzes_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxQuizzes.SelectedItem != null)
            {
                var quiz = (dynamic)listBoxQuizzes.SelectedItem;
                var quizForm = new QuizForm(quiz.FilePath);
                quizForm.ShowDialog();
                LoadAttempts();
            }
        }





        private void buttonImport_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog { Filter = "JSON Files|*.json" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var json = File.ReadAllText(dialog.FileName);
                        var quiz = JsonConvert.DeserializeObject<Quiz>(json);
                        if (quiz?.Questions == null || !quiz.Questions.Any())
                        {
                            MessageBox.Show("Invalid quiz file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        var newPath = Path.Combine("Quizzes", $"{quiz.Title}_{Guid.NewGuid()}.json");
                        File.WriteAllText(newPath, json);
                        ImportChemistryQuiz();
                        MessageBox.Show("Quiz imported!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Import failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void panelThermo_Click(object sender, EventArgs e)
        {


            var thermoQuiz = (dynamic)listBoxQuizzes.FindString("Thermochemistry");
            if(thermoQuiz != null)
            {
                var thermoForm = new QuizForm(thermoQuiz.FilePath);
                thermoForm.ShowDialog();
                LoadAttempts();

            } else
            {
                MessageBox.Show("Not found that quiz thermochemistry");
            }
            //This is hardcoded, needs to be updated to find question id of 1 which is thermochemistry.
            //var thermoQuiz = 
            //var thermoForm = new QuizForm(thermoQuiz.FilePath);
            //thermoForm.ShowDialog();
            //    LoadAttempts();
        }
    }
}
