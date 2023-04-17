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
        // Create panellists
        List<Panel> ExcludedChildPanels = new();
        List<Panel> ExcludedPanels = new();

        // Assign classes
        PanelControl panels = new();
        DAL dal = new();

        public HomePage()
        {
            InitializeComponent();
            // Assign which panels shouldn't be affected by toggles
            ExcludedPanels.Add(Pnl_Menu);
            ExcludedPanels.Add(Pnl_Menu_Student);
            ExcludedChildPanels.Add(Pnl_Goals_Menu);
            ExcludedChildPanels.Add(Pnl_Feedback_Menu);
            ExcludedChildPanels.Add(Pnl_Logbook_Menu);
        }

        private void Btn_Menu_Logout_Click(object sender, EventArgs e)
        {
            // Close HomePage form clear userdata and open Login form
            Program.Login = new Login();
            Program.Login.Show();
            this.Close();
            Lbl_Menu_Userid.Text = "";
            Lbl_Menu_Userrole.Text = "";
            Lbl_Menu_Username.Text = "";
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            // Disable all panels except for the menu
            panels.TogglePanels(this, ExcludedPanels, Pnl_Menu);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Fill all comboboxes with designated data
            dal.LoadSubjectsIntoComboBox(Goals_Combo_Subject);
            dal.LoadWeekIntoComboBox(Feedback_Combo_Week_add);
            dal.LoadWeekIntoComboBox(Feedback_Combo_Week);
            dal.LoadWeekIntoComboBox(Goals_Combo_Week);
            dal.LoadWeekIntoComboBox(Goals_Combo_Week_add);
            dal.LoadWeekIntoComboBox(Logbook_Combo_Week);
            Lbl_Menu_Username.Text = "Name: " + Program.CurrentUser;
            Lbl_Menu_Userid.Text = "ID: " + Program.CurrentUser_ID.ToString();
            Lbl_Menu_Userrole.Text = "Role: " + Program.CurrentUser_Role;
            dal.FillListboxGoals(ListBox_Goals);
        }

        private void Btn_Menu_Goals_Click(object sender, EventArgs e)
        {
            // Toggle goals panel
            panels.TogglePanels(this, ExcludedPanels, Pnl_Goals);
            panels.ToggleChildPanel(Pnl_Goals, Pnl_Goals_Current, ExcludedChildPanels);
        }

        private void Goals_Menu_Btn_Current_Click(object sender, EventArgs e)
        {
            // Toggle the Goal Display panel
            panels.ToggleChildPanel(Pnl_Goals, Pnl_Goals_Current, ExcludedChildPanels);
        }

        private void Goals_Menu_Btn_Add_Click(object sender, EventArgs e)
        {
            // toggle the Goal Add panel
            panels.ToggleChildPanel(Pnl_Goals, Pnl_Goals_Add, ExcludedChildPanels);
        }

        private void Btn_Menu_Feedback_Click(object sender, EventArgs e)
        {
            // Toggle Feedback panel
            panels.TogglePanels(this, ExcludedPanels, Pnl_Feedback);
            panels.ToggleChildPanel(Pnl_Feedback, Pnl_Feedback_Current, ExcludedChildPanels);
        }

        private void Feedback_Menu_Btn_add_Click(object sender, EventArgs e)
        {
            // Toggle Feedback Add panel
            panels.ToggleChildPanel(Pnl_Feedback, Pnl_Feedback_Add, ExcludedChildPanels);
        }

        private void Feedback_Menu_Btn_Current_Click(object sender, EventArgs e)
        {
            // Toggle Feedback Display panel
            panels.ToggleChildPanel(Pnl_Feedback, Pnl_Feedback_Current, ExcludedChildPanels);
        }

        private void Btn_Menu_Logbook_Click(object sender, EventArgs e)
        {
            // Toggle Logbook panel
            panels.TogglePanels(this, ExcludedPanels, Pnl_Logbook);
        }

        private void Logbook_Menu_Btn_Current_Click(object sender, EventArgs e)
        {
            // Toggle Logbook Display panel
            panels.ToggleChildPanel(Pnl_Logbook, Pnl_Logbook_Current, ExcludedChildPanels);
        }

        private void Logbook_Menu_Btn_add_Click(object sender, EventArgs e)
        {
            // Toggle Logbook Add panel
            panels.ToggleChildPanel(Pnl_Logbook, Pnl_Logbook_Add, ExcludedChildPanels);
        }

        private int Subtasknumber = 3;   // Starting number for the new subtasks
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

                // Create new Label
                Label newLabel = new Label();
                newLabel.Location = newLabelLocation;
                newLabel.Size = new Size(75, 20);
                newLabel.Text = "Subdoel" + Subtasknumber + ":";
                newLabel.Name = "Goals_Lbl_Sub" + Subtasknumber;

                // Create new Textbox
                TextBox newTextBox = new TextBox();
                newTextBox.Location = newTextBoxLocation;
                newTextBox.Size = new Size(151, 27);
                newTextBox.Name = "Goals_Text_Sub" + Subtasknumber;

                // Add new controls to the panel
                Pnl_Goals_Add.Controls.Add(newLabel);
                Pnl_Goals_Add.Controls.Add(newTextBox);

                // Move the add subtask label and add button down
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

        private void Goals_Btn_Add_Click(object sender, EventArgs e)
        {
            string Goals_Desc = Goals_Text_Add.Text;
            string vakid = Goals_Combo_Subject.Text;
            // extract Weeknr From string in combobox
            string weekText = Goals_Combo_Week_add.Text.ToString();
            string[] weekTextSplit = weekText.Split(' ');

            // assign int Weeknr with the selected value from combobox
            int weeknr = int.Parse(weekTextSplit[1]);

            Goal goal = new Goal(weeknr, Goals_Desc);
            dal.FillListboxGoals(ListBox_Goals);
        }

        private void Feedback_Btn_Add_Click(object sender, EventArgs e)
        {
            // Get the values from the UI controls
            string feedbackDesc = Feedback_Text_Feedback.Text;
            int weekNr = Convert.ToInt32(Feedback_Combo_Week_add.Text);
            bool validated = Feedback_Check_Validated.Checked;
            string userName = Feedback_Combo_Teachers.Text;

            // Call the Add_Feedback method on the DAL instance
            dal.Add_Feedback(feedbackDesc, weekNr.ToString(), validated, userName);

            // Display a message indicating that the feedback was added
            MessageBox.Show("Feedback added successfully.");

        }

        private void Feedback_Btn_Delete_Click(object sender, EventArgs e)
        {
            dal.Delete_feedback_database();
        }

        private void Pnl_Feedback_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Feedback_Check_Validated_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Feedback_Combo_Week_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWeek = Feedback_Combo_Week.SelectedItem.ToString();
            int weekNr;
            if (Int32.TryParse(selectedWeek, out weekNr))
            {
                dal.FillListBoxFeedback(ListBoxFeedback, weekNr);
            }
            string docent_name = Docent_naam_box.Text;
            string subject = Vak_naam_box.Text;
            string weeknr = Feedback_Combo_Week_add.SelectedText;
            // docent wordt niet gebruikt in database wel opvragen in ui?
            string New_feedback = Feedback_Text_Feedback.Text;
            int weeknrInt = int.Parse(weeknr);
            Subject Vak = new Subject(subject);
            dal.subject_insert_database(Vak);
            Feedback feedback = new Feedback(subject, New_feedback, weeknrInt, Validate_checkbox.Checked, Program.CurrentUser_ID);
            dal.Feedback_insert_database(feedback);

        }

        private void Confirm_alter_btn_Click(object sender, EventArgs e)
        {
            //manier nodig om hiernaar toe te komen
            //kunnen kiezen welke je aanpast dus feedback id achterhalen
            string altered_feedback = Alter_feedback_lsbox.Text;
            dal.Alter_feedback_database(altered_feedback);
        }
    }
}
