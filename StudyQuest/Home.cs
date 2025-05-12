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
namespace StudyQuest
{//test
    public partial class Home : Form
    {
        const string THERMO_QUIZ = @"thermoquiz.csv";
        const string ORGANIC_QUIZ = @"\organicquiz.csv";
        const string EQUILIBRIUM_QUIZ = @"\equilibriumquiz.csv";

        public Home()
        {
            InitializeComponent();
            ImportChemistryQuiz();
        }


        public void ImportChemistryQuiz()
        {
            if (File.Exists(THERMO_QUIZ)) {

                MessageBox.Show("HELLO");
            } else
            {
                File.Create(THERMO_QUIZ).Close();

                MessageBox.Show("Created");
            }

        }


     
    }
}
