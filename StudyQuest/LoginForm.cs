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
            Dashboard homeForm = new Dashboard();
            homeForm.ShowDialog();
            this.Hide();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("YOU CLICKED ON THIS!!");
            
        }
        
    }

}