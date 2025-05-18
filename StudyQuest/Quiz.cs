using System.Collections.Generic;
using Newtonsoft.Json;

namespace StudyQuest
{
    public class Quiz
    {
        [JsonProperty("version")]
        public double Version { get; set; }

        [JsonProperty("quizId")]
        public int QuizId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("totalPoints")]
        public int TotalPoints { get; set; }

        [JsonProperty("totalQuestions")]
        public int TotalQuestions { get; set; }

        [JsonProperty("questions")]
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("answer")]
        public string Answer { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("choices")]
        public List<string> Choices { get; set; }
    }
}