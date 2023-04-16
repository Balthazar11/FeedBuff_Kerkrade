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
        List<Panel> ExcludedChildPanels = new();
        List<Panel> ExcludedPanels = new();
        PanelControl panels = new();
        private int userid = 12;
        string username = "Harrie";
        string userrole = "Student";
        public HomePage()
        {
            InitializeComponent();
            ExcludedPanels.Add(Pnl_Menu);
            ExcludedPanels.Add(Pnl_Menu_Student);
            ExcludedChildPanels.Add(Pnl_Goals_Menu);
            ExcludedChildPanels.Add(Pnl_Feedback_Menu);
            ExcludedChildPanels.Add(Pnl_Logbook_Menu);
        }

        private void Btn_Menu_Logout_Click(object sender, EventArgs e)
        {
            Program.Login = new Login();
            Program.Login.Show();
            this.Close();
            Lbl_Menu_Userid.Text = "";
            Lbl_Menu_Userrole.Text = "";
            Lbl_Menu_Username.Text = "";
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            panels.TogglePanels(this, ExcludedPanels, Pnl_Menu);
            Lbl_Menu_Userrole.Text = userrole.ToString();
            Lbl_Menu_Userid.Text = userid.ToString();
            Lbl_Menu_Username.Text = username.ToString();


        }

        private void Btn_Menu_Goals_Click(object sender, EventArgs e)
        {
            panels.TogglePanels(this, ExcludedPanels, Pnl_Goals);
            panels.ToggleChildPanel(Pnl_Goals, Pnl_Goals_Current, ExcludedChildPanels);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void Goals_Menu_Btn_Current_Click(object sender, EventArgs e)
        {
            panels.ToggleChildPanel(Pnl_Goals, Pnl_Goals_Current, ExcludedChildPanels);
        }

        private void Goals_Menu_Btn_Add_Click(object sender, EventArgs e)
        {
            panels.ToggleChildPanel(Pnl_Goals, Pnl_Goals_Add, ExcludedChildPanels);
        }

        private void Goals_Text_Sub1_TextChanged(object sender, EventArgs e)
        {

        }

        // Declare this field in your form class
        private int Subtasknumber = 3;
        private int MaxSubtasks = 3 + 2; // Maximum number of subtasks

        private void Goals_Lbl_Add_Sub_Click(object sender, EventArgs e)
        {
            if (Subtasknumber >= MaxSubtasks) // Check if maximum limit has been reached
            {
                MessageBox.Show("Maximum number of subtasks reached.");
                return;
            }

            Console.WriteLine(Subtasknumber);
            Label? clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                // Calculate the position of the new controls
                Point newLabelLocation = new Point(3, clickedLabel.Location.Y + clickedLabel.Height - 15);
                Point newTextBoxLocation = new Point(94, newLabelLocation.Y);

                // Create the new label and textbox
                Label newLabel = new Label();
                newLabel.Location = newLabelLocation;
                newLabel.Size = new Size(75, 20);
                newLabel.Text = "Subdoel" + Subtasknumber + ":";
                newLabel.Name = "Goals_Lbl_Sub" + Subtasknumber;

                TextBox newTextBox = new TextBox();
                newTextBox.Location = newTextBoxLocation;
                newTextBox.Size = new Size(151, 27);
                newTextBox.Name = "Goals_Text_Sub" + Subtasknumber;

                // Add the new controls to the panel
                Pnl_Goals_Add.Controls.Add(newLabel);
                Pnl_Goals_Add.Controls.Add(newTextBox);

                // Move the clicked label and another button down
                clickedLabel.Location = new Point(clickedLabel.Location.X, newTextBoxLocation.Y + newTextBox.Height + 5);

                if (Subtasknumber == MaxSubtasks - 1)
                {
                    clickedLabel.Enabled = false;
                    Goals_Btn_Add.Location = new Point(Goals_Btn_Add.Location.X, clickedLabel.Location.Y + 1);
                }
                else
                {
                    Goals_Btn_Add.Location = new Point(Goals_Btn_Add.Location.X, clickedLabel.Location.Y + clickedLabel.Height + 5);
                }

                // Increment the Subtasknumber for the next label
                Subtasknumber++;
            }
        }

        private void Btn_Menu_Feedback_Click(object sender, EventArgs e)
        {
            panels.TogglePanels(this, ExcludedPanels, Pnl_Feedback);
            panels.ToggleChildPanel(Pnl_Feedback, Pnl_Feedback_Current, ExcludedChildPanels);
        }

        private void Feedback_Menu_Btn_add_Click(object sender, EventArgs e)
        {
            panels.ToggleChildPanel(Pnl_Feedback, Pnl_Feedback_Add, ExcludedChildPanels);
        }

        private void Feedback_Menu_Btn_Current_Click(object sender, EventArgs e)
        {
            panels.ToggleChildPanel(Pnl_Feedback, Pnl_Feedback_Current, ExcludedChildPanels);
        }

        private void Btn_Menu_Logbook_Click(object sender, EventArgs e)
        {
            panels.TogglePanels(this, ExcludedPanels, Pnl_Logbook);
        }

        private void Logbook_Menu_Btn_Current_Click(object sender, EventArgs e)
        {
            panels.ToggleChildPanel(Pnl_Logbook, Pnl_Logbook_Current, ExcludedChildPanels);
        }

        private void Logbook_Menu_Btn_add_Click(object sender, EventArgs e)
        {
            panels.ToggleChildPanel(Pnl_Logbook, Pnl_Logbook_Add, ExcludedChildPanels);
        }

        private void Btn_Menu_Click_1(object sender, EventArgs e)
        {
































        }
    }
}
