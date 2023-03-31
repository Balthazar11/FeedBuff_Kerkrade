using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedBuff_Kerkrade
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            Program.Login = new Login();
            Program.Login.Show();
            this.Close();
        }
    }
}
