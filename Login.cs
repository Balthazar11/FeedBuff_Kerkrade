using System.Windows.Forms;

namespace FeedBuff_Kerkrade
{
    public partial class Login : Form
    {
        PanelControl dal = new();
        List<Panel> ExcludedPanels = new List<Panel>();
        public Login()
        {
            InitializeComponent();
            if (Login_Pnl_Login.Visible == true)
            {
                this.AcceptButton = Login_btn;
            }
        }
        //private void 

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            string username = Login_User_Txt.Text;
            string password = Login_Pass_Txt.Text;
            dal.TogglePanels(this, ExcludedPanels, Login_Pnl_Register);
            Register_User_Txt.Text = "";
            Register_Mail_Txt.Text = "";
            Register_Pass_Txt.Text = "";
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = Login_User_Txt.Text;
            string password = Login_Pass_Txt.Text;

            if (username == "admin" && password == "admin")
            {
                // login succes
                Program.HomePage = new();
                Program.HomePage.Show();
                this.Hide();
                Login_Lbl_Error.Text = "";
                Login_Lbl_Error.ForeColor = Color.Red;
            }
            //check if boxes not empty
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Login_Lbl_Error.Text = "Please fill in the boxes!";
                Login_Lbl_Error.ForeColor = Color.Red;
            }
            else
            {
                Login_Lbl_Error.Text = "Wrong Credentials!";
                Login_Lbl_Error.ForeColor = Color.Red;
            }
            Login_User_Txt.Text = "";
            Login_Pass_Txt.Text = "";
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_Btn_Cancel_Click(object sender, EventArgs e)
        {
            dal.TogglePanels(this, ExcludedPanels, Login_Pnl_Login);
            Login_User_Txt.Text = "";
            Login_Pass_Txt.Text = "";
            Login_Lbl_Error.Text = "";
            Register_Lbl_Error.Text = "";
            Register_Lbl_Error.ForeColor = Color.Red;
        }

        private void Register_Btn_Signup_Click(object sender, EventArgs e)
        {
            string username = Register_User_Txt.Text;
            string email = Register_Mail_Txt.Text;
            string password = Register_Pass_Txt.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                dal.TogglePanels(this, ExcludedPanels, Login_Pnl_Login);
                Register_Lbl_Error.Text = "";
                Login_Lbl_Error.Text = "Succesfully Signed up!";
                Login_Lbl_Error.ForeColor = Color.Green;
            }
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                Register_Lbl_Error.Text = "Please fill in the boxes!";
                Register_Lbl_Error.ForeColor = Color.Red;
            }
            else
            {
                Register_Lbl_Error.Text = "Wrong Credentials!";
                Register_Lbl_Error.ForeColor = Color.Red;
            }
            Login_User_Txt.Text = "";
            Login_Pass_Txt.Text = "";
        }
    }
}