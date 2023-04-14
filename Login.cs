using System.Windows.Forms;

namespace FeedBuff_Kerkrade
{
    public partial class Login : Form
    {
        PanelControl panels = new();
        List<Panel> ExcludedPanels = new();
        HomePage home = new();

        public Login()
        {
            InitializeComponent();

            if (Login_Pnl_Login.Visible == true)
            {
                // Assign Login_btn to be able to be pressed with "ENTER" key
                this.AcceptButton = Login_btn;
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            string username = Login_User_Txt.Text;
            string password = Login_Pass_Txt.Text;

            // Toggle Register panel and clear fields
            panels.TogglePanels(this, ExcludedPanels, Login_Pnl_Register);
            Register_User_Txt.Text = "";
            Register_Mail_Txt.Text = "";
            Register_Pass_Txt.Text = "";
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            string username = Login_User_Txt.Text;
            string password = Login_Pass_Txt.Text;

            // Check username and password
            if (username == "admin" && password == "admin")
            {
                // Login succes
                Program.HomePage = new();
                Program.HomePage.Show();
                this.Hide();

                Login_Lbl_Error.Text = "";
                Login_Lbl_Error.ForeColor = Color.Red;
            }
            // Check if fields are empty
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                Login_Lbl_Error.Text = "Please fill in the boxes!";
                Login_Lbl_Error.ForeColor = Color.Red;
            }
            else
            {
                // Display error if credentials are incorrect
                Login_Lbl_Error.Text = "Wrong Credentials!";
                Login_Lbl_Error.ForeColor = Color.Red;
            }
            Login_User_Txt.Text = "";
            Login_Pass_Txt.Text = "";
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            // Close application
            Application.Exit();
        }

        private void Register_Btn_Cancel_Click(object sender, EventArgs e)
        {
            // Toggle Login panel and clear fields
            panels.TogglePanels(this, ExcludedPanels, Login_Pnl_Login);
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

            // Check if fields are not empty
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password))
            {
                // Toggle Login panel and change fields correctly
                panels.TogglePanels(this, ExcludedPanels, Login_Pnl_Login);
                Register_Lbl_Error.Text = "";
                Login_Lbl_Error.Text = "Succesfully Signed up!";
                Login_Lbl_Error.ForeColor = Color.Green;
            }
            // Check if fields are empty
            else if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                // Display error if fields are empty
                Register_Lbl_Error.Text = "Please fill in the boxes!";
                Register_Lbl_Error.ForeColor = Color.Red;
            }
            // Clear fields
            Login_User_Txt.Text = "";
            Login_Pass_Txt.Text = "";
        }
    }
}