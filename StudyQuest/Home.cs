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
    public partial class Home : Form
    {
        List<Quiz> chemQ = new List<Quiz> ();
        Quiz chemistry = new Quiz();
        public Home()
        {
            InitializeComponent();
            ImportChemistryQuiz();
        }


        public void ImportChemistryQuiz()
        {

            string jsonFilePath = Path.Combine(Application.StartupPath, "ChemistryQuiz.json");
            using (StreamReader reader = new StreamReader(jsonFilePath)) {
                string json = reader.ReadToEnd();
#pragma warning disable CS8601 // Possible null reference assignment.
                chemistry = JsonConvert.DeserializeObject<Quiz.AddQuiz>(json);
#pragma warning restore CS8601 // Possible null reference assignment.
                Console.WriteLine($"{chemistry.Name}");


            }


     
    }
}
