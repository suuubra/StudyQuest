using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyQuest
{
//Quiz panel
    internal class Quiz
    {
        public string Quiz_Name { get; set; }
        public string Quiz_TotalPoints { get; set; }
        public string Quiz_TotalNoQuestions { get; set; }

        //questions
        public int Question_ID { get; set; }
        public int Question_Points { get; set; }
        public string Question_Q { get; set; }
        public string Question_A { get; set; }
        public string Question_Type { get; set; }
        public string Question_Choices { get; set; }

        /*
        public Quiz(string quiz_Name, string quiz_TotalPoints, string quiz_TotalNoQuestions, int question_ID, int question_Points, string question_Q, string question_A, string question_Type, string question_Choices)
        {
            Quiz_Name = quiz_Name;
            Quiz_TotalPoints = quiz_TotalPoints;
            Quiz_TotalNoQuestions = quiz_TotalNoQuestions;
            Question_ID = question_ID;
            Question_Points = question_Points;
            Question_Q = question_Q;
            Question_A = question_A;
            Question_Type = question_Type;
            Question_Choices = question_Choices;
        }*/
        public void AddQuiz(string quiz_Name, string quiz_TotalPoints, string quiz_TotalNoQuestions)
        {
            Quiz_Name = quiz_Name;
            Quiz_TotalPoints = quiz_TotalPoints;
            Quiz_TotalNoQuestions = quiz_TotalNoQuestions;
        }
    }
}
