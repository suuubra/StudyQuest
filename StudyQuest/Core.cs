using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyQuest
{
    // Class to manage user statistics, information, etc.
    internal class Core
    {
        // Properties for user information
        public string UserId { get; private set; }
        public string Username { get; set; }
        public string Email { get; set; }

        // Properties for user statistics
        public int TotalPoints { get; private set; }
        public int QuizzesCompleted { get; private set; }
        public Dictionary<string, int> CategoryScores { get; private set; }

        // Constructor
        public Core(string userId, string username, string email)
        {
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            TotalPoints = 0;
            QuizzesCompleted = 0;
            CategoryScores = new Dictionary<string, int>();
        }

        // Method to update points
        public void AddPoints(int points)
        {
            if (points < 0)
                throw new ArgumentException("Points cannot be negative.", nameof(points));

            TotalPoints += points;
        }

        // Method to record quiz completion
        public void CompleteQuiz(string category, int score)
        {
            if (string.IsNullOrEmpty(category))
                throw new ArgumentNullException(nameof(category));
            if (score < 0)
                throw new ArgumentException("Score cannot be negative.", nameof(score));

            QuizzesCompleted++;
            AddPoints(score);

            // Update category-specific score
            if (CategoryScores.ContainsKey(category))
                CategoryScores[category] += score;
            else
                CategoryScores[category] = score;
        }

        // Method to get user summary
        public string GetUserSummary()
        {
            StringBuilder summary = new StringBuilder();
            summary.AppendLine($"User: {Username} ({Email})");
            summary.AppendLine($"Total Points: {TotalPoints}");
            summary.AppendLine($"Quizzes Completed: {QuizzesCompleted}");
            summary.AppendLine("Category Scores:");
            foreach (var score in CategoryScores)
            {
                summary.AppendLine($"  {score.Key}: {score.Value}");
            }
            return summary.ToString();
        }

        // Method to reset statistics
        public void ResetStats()
        {
            TotalPoints = 0;
            QuizzesCompleted = 0;
            CategoryScores.Clear();
        }
    }
}