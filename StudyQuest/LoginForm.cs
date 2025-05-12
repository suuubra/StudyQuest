namespace StudyQuest
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Home homeForm = new Home();
            homeForm.ShowDialog();
            this.Hide();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("YOU CLICKED ON THIS!!");
            
        }
        
    }

}