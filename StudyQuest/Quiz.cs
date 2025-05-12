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
        public string Quiz_Description { get; set; }
        public int Quiz_Points { get; set; }
        public string Quiz_Question { get; set; }
        public string Quiz_Answer { get; set; }

        public Quiz(string quiz_Name, string quiz_Description, int quiz_Points, string quiz_Question, string quiz_Answer)
        {
            Quiz_Name = quiz_Name;
            Quiz_Description = quiz_Description;
            Quiz_Points = quiz_Points;
            Quiz_Question = quiz_Question;
            Quiz_Answer = quiz_Answer;
        }
    }
}
