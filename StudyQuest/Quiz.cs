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

        // sub questions
        public int Question_ID { get; set; }
        public int Question_Points { get; set; }
        public string Question_Q { get; set; }
        public string Question_A { get; set; }
        public string Question_Type { get; set; }
        public string Question_Choices { get; set; }


    }
}
