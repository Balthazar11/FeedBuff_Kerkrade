namespace FeedBuff_Kerkrade
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //private void 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            string username = Username_txtbox.Text;
            string password = Password_txtbox.Text;
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Program.HomePage = new HomePage();
            Program.HomePage.Show();
            this.Hide();
        }
    }
}