namespace FeedBuff_Kerkrade
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_Menu_Logout = new Button();
            Pnl_Menu = new Panel();
            Btn_Menu = new Button();
            Pnl_Menu_Student = new Panel();
            Pnl_Menu_Userdetails = new Panel();
            Lbl_Menu_Userid = new Label();
            Lbl_Menu_Userrole = new Label();
            Lbl_Menu_Username = new Label();
            Temp_Lbl_Size = new Label();
            Btn_Menu_Logbook = new Button();
            Btn_Menu_Feedback = new Button();
            Btn_Menu_Goals = new Button();
            Pnl_Goals_Add = new Panel();
            Goals_Combo_Week_add = new ComboBox();
            Goals_Lbl_week_add = new Label();
            Goals_Btn_Add = new Button();
            Goals_Lbl_Add_Sub = new Label();
            Goals_Text_Sub2 = new TextBox();
            Goals_Lbl_Sub2 = new Label();
            Goals_Text_Sub1 = new TextBox();
            Goals_Lbl_Sub1 = new Label();
            Goals_Text_Add = new TextBox();
            Goals_Lbl_Add = new Label();
            Goals_Combo_Subject = new ComboBox();
            Goals_Lbl_Subject = new Label();
            Pnl_Goals_Menu = new Panel();
            Goals_Menu_Btn_Current = new Button();
            Goals_Menu_Btn_Add = new Button();
            Pnl_Feedback_Menu = new Panel();
            Feedback_Menu_Btn_add = new Button();
            Feedback_Menu_Btn_Current = new Button();
            Feedback_Lbl_Subject = new Label();
            Feedback_Combo_Subject = new ComboBox();
            Feedback_Lbl_Feedback = new Label();
            Feedback_Text_Feedback = new TextBox();
            Feedback_Lbl_Teacher = new Label();
            Pnl_Feedback_Add = new Panel();
            Feedback_Lbl_Week_add = new Label();
            Feedback_Combo_Week_add = new ComboBox();
            Feedback_Combo_Teachers = new ComboBox();
            Feedback_Btn_Add = new Button();
            Pnl_Goals = new Panel();
            Pnl_Goals_Current = new Panel();
            Goals_Lbl_Week = new Label();
            Goals_Combo_Week = new ComboBox();
            Lbl_Goals_Finished = new Label();
            ListBox_Goals_Done = new CheckedListBox();
            Lbl_Goals_Set = new Label();
            ListBox_Goals = new CheckedListBox();
            Pnl_Feedback = new Panel();
            Pnl_Feedback_Current = new Panel();
            Feedback_Lbl_Week = new Label();
            Feedback_Combo_Week = new ComboBox();
            Lbl_Feedback_Goals = new Label();
            Lbl_FeedBack_Requested = new Label();
            checkedListBox1 = new CheckedListBox();
            ListBoxFeedback = new CheckedListBox();
            Pnl_Logbook = new Panel();
            Pnl_Logbook_Menu = new Panel();
            Logbook_Menu_Btn_add = new Button();
            Logbook_Menu_Btn_Current = new Button();
            Pnl_Logbook_Current = new Panel();
            Logbook_Combo_Week = new ComboBox();
            label2 = new Label();
            Pnl_Logbook_Add = new Panel();
            Pnl_Menu.SuspendLayout();
            Pnl_Menu_Student.SuspendLayout();
            Pnl_Menu_Userdetails.SuspendLayout();
            Pnl_Goals_Add.SuspendLayout();
            Pnl_Goals_Menu.SuspendLayout();
            Pnl_Feedback_Menu.SuspendLayout();
            Pnl_Feedback_Add.SuspendLayout();
            Pnl_Goals.SuspendLayout();
            Pnl_Goals_Current.SuspendLayout();
            Pnl_Feedback.SuspendLayout();
            Pnl_Feedback_Current.SuspendLayout();
            Pnl_Logbook.SuspendLayout();
            Pnl_Logbook_Menu.SuspendLayout();
            Pnl_Logbook_Current.SuspendLayout();
            SuspendLayout();
            // 
            // Btn_Menu_Logout
            // 
            Btn_Menu_Logout.Location = new Point(3, 355);
            Btn_Menu_Logout.Name = "Btn_Menu_Logout";
            Btn_Menu_Logout.Size = new Size(125, 39);
            Btn_Menu_Logout.TabIndex = 0;
            Btn_Menu_Logout.Text = "Uitloggen";
            Btn_Menu_Logout.UseVisualStyleBackColor = true;
            Btn_Menu_Logout.Click += Btn_Menu_Logout_Click;
            // 
            // Pnl_Menu
            // 
            Pnl_Menu.BorderStyle = BorderStyle.Fixed3D;
            Pnl_Menu.Controls.Add(Btn_Menu);
            Pnl_Menu.Controls.Add(Pnl_Menu_Student);
            Pnl_Menu.Dock = DockStyle.Left;
            Pnl_Menu.Location = new Point(0, 0);
            Pnl_Menu.Name = "Pnl_Menu";
            Pnl_Menu.Size = new Size(141, 450);
            Pnl_Menu.TabIndex = 1;
            // 
            // Btn_Menu
            // 
            Btn_Menu.Location = new Point(3, 3);
            Btn_Menu.Name = "Btn_Menu";
            Btn_Menu.Size = new Size(131, 39);
            Btn_Menu.TabIndex = 1;
            Btn_Menu.Text = "Menu";
            Btn_Menu.UseVisualStyleBackColor = true;
            Btn_Menu.Click += Btn_Menu_Click;
            // 
            // Pnl_Menu_Student
            // 
            Pnl_Menu_Student.Controls.Add(Pnl_Menu_Userdetails);
            Pnl_Menu_Student.Controls.Add(Temp_Lbl_Size);
            Pnl_Menu_Student.Controls.Add(Btn_Menu_Logbook);
            Pnl_Menu_Student.Controls.Add(Btn_Menu_Feedback);
            Pnl_Menu_Student.Controls.Add(Btn_Menu_Goals);
            Pnl_Menu_Student.Controls.Add(Btn_Menu_Logout);
            Pnl_Menu_Student.Location = new Point(3, 48);
            Pnl_Menu_Student.Name = "Pnl_Menu_Student";
            Pnl_Menu_Student.Size = new Size(131, 396);
            Pnl_Menu_Student.TabIndex = 0;
            // 
            // Pnl_Menu_Userdetails
            // 
            Pnl_Menu_Userdetails.Controls.Add(Lbl_Menu_Userid);
            Pnl_Menu_Userdetails.Controls.Add(Lbl_Menu_Userrole);
            Pnl_Menu_Userdetails.Controls.Add(Lbl_Menu_Username);
            Pnl_Menu_Userdetails.Location = new Point(3, 269);
            Pnl_Menu_Userdetails.Name = "Pnl_Menu_Userdetails";
            Pnl_Menu_Userdetails.Size = new Size(125, 79);
            Pnl_Menu_Userdetails.TabIndex = 8;
            // 
            // Lbl_Menu_Userid
            // 
            Lbl_Menu_Userid.AutoSize = true;
            Lbl_Menu_Userid.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Menu_Userid.ForeColor = Color.Gray;
            Lbl_Menu_Userid.Location = new Point(6, 29);
            Lbl_Menu_Userid.Name = "Lbl_Menu_Userid";
            Lbl_Menu_Userid.Size = new Size(85, 19);
            Lbl_Menu_Userid.TabIndex = 6;
            Lbl_Menu_Userid.Text = "gebruikersId";
            // 
            // Lbl_Menu_Userrole
            // 
            Lbl_Menu_Userrole.AutoSize = true;
            Lbl_Menu_Userrole.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Menu_Userrole.ForeColor = Color.Gray;
            Lbl_Menu_Userrole.Location = new Point(6, 5);
            Lbl_Menu_Userrole.Name = "Lbl_Menu_Userrole";
            Lbl_Menu_Userrole.Size = new Size(92, 19);
            Lbl_Menu_Userrole.TabIndex = 7;
            Lbl_Menu_Userrole.Text = "gebruikersRol";
            // 
            // Lbl_Menu_Username
            // 
            Lbl_Menu_Username.AutoSize = true;
            Lbl_Menu_Username.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_Menu_Username.ForeColor = Color.Gray;
            Lbl_Menu_Username.Location = new Point(6, 53);
            Lbl_Menu_Username.Name = "Lbl_Menu_Username";
            Lbl_Menu_Username.Size = new Size(111, 19);
            Lbl_Menu_Username.TabIndex = 5;
            Lbl_Menu_Username.Text = "GebruikersNaam";
            // 
            // Temp_Lbl_Size
            // 
            Temp_Lbl_Size.AutoSize = true;
            Temp_Lbl_Size.Location = new Point(3, 245);
            Temp_Lbl_Size.Name = "Temp_Lbl_Size";
            Temp_Lbl_Size.Size = new Size(64, 20);
            Temp_Lbl_Size.TabIndex = 4;
            Temp_Lbl_Size.Text = "800, 450";
            // 
            // Btn_Menu_Logbook
            // 
            Btn_Menu_Logbook.Location = new Point(3, 93);
            Btn_Menu_Logbook.Name = "Btn_Menu_Logbook";
            Btn_Menu_Logbook.Size = new Size(125, 39);
            Btn_Menu_Logbook.TabIndex = 3;
            Btn_Menu_Logbook.Text = "Logboek";
            Btn_Menu_Logbook.UseVisualStyleBackColor = true;
            Btn_Menu_Logbook.Click += Btn_Menu_Logbook_Click;
            // 
            // Btn_Menu_Feedback
            // 
            Btn_Menu_Feedback.Location = new Point(3, 48);
            Btn_Menu_Feedback.Name = "Btn_Menu_Feedback";
            Btn_Menu_Feedback.Size = new Size(125, 39);
            Btn_Menu_Feedback.TabIndex = 2;
            Btn_Menu_Feedback.Text = "Feedback";
            Btn_Menu_Feedback.UseVisualStyleBackColor = true;
            Btn_Menu_Feedback.Click += Btn_Menu_Feedback_Click;
            // 
            // Btn_Menu_Goals
            // 
            Btn_Menu_Goals.Location = new Point(3, 3);
            Btn_Menu_Goals.Name = "Btn_Menu_Goals";
            Btn_Menu_Goals.Size = new Size(125, 39);
            Btn_Menu_Goals.TabIndex = 1;
            Btn_Menu_Goals.Text = "Doelen";
            Btn_Menu_Goals.UseVisualStyleBackColor = true;
            Btn_Menu_Goals.Click += Btn_Menu_Goals_Click;
            // 
            // Pnl_Goals_Add
            // 
            Pnl_Goals_Add.BorderStyle = BorderStyle.FixedSingle;
            Pnl_Goals_Add.Controls.Add(Goals_Combo_Week_add);
            Pnl_Goals_Add.Controls.Add(Goals_Lbl_week_add);
            Pnl_Goals_Add.Controls.Add(Goals_Btn_Add);
            Pnl_Goals_Add.Controls.Add(Goals_Lbl_Add_Sub);
            Pnl_Goals_Add.Controls.Add(Goals_Text_Sub2);
            Pnl_Goals_Add.Controls.Add(Goals_Lbl_Sub2);
            Pnl_Goals_Add.Controls.Add(Goals_Text_Sub1);
            Pnl_Goals_Add.Controls.Add(Goals_Lbl_Sub1);
            Pnl_Goals_Add.Controls.Add(Goals_Text_Add);
            Pnl_Goals_Add.Controls.Add(Goals_Lbl_Add);
            Pnl_Goals_Add.Controls.Add(Goals_Combo_Subject);
            Pnl_Goals_Add.Controls.Add(Goals_Lbl_Subject);
            Pnl_Goals_Add.Location = new Point(3, 48);
            Pnl_Goals_Add.Name = "Pnl_Goals_Add";
            Pnl_Goals_Add.Size = new Size(629, 389);
            Pnl_Goals_Add.TabIndex = 2;
            Pnl_Goals_Add.Visible = false;
            // 
            // Goals_Combo_Week_add
            // 
            Goals_Combo_Week_add.DropDownStyle = ComboBoxStyle.DropDownList;
            Goals_Combo_Week_add.FormattingEnabled = true;
            Goals_Combo_Week_add.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            Goals_Combo_Week_add.Location = new Point(94, 43);
            Goals_Combo_Week_add.Margin = new Padding(3, 4, 3, 4);
            Goals_Combo_Week_add.Name = "Goals_Combo_Week_add";
            Goals_Combo_Week_add.Size = new Size(151, 28);
            Goals_Combo_Week_add.TabIndex = 14;
            // 
            // Goals_Lbl_week_add
            // 
            Goals_Lbl_week_add.AutoSize = true;
            Goals_Lbl_week_add.Location = new Point(3, 43);
            Goals_Lbl_week_add.Name = "Goals_Lbl_week_add";
            Goals_Lbl_week_add.Size = new Size(48, 20);
            Goals_Lbl_week_add.TabIndex = 13;
            Goals_Lbl_week_add.Text = "Week:";
            // 
            // Goals_Btn_Add
            // 
            Goals_Btn_Add.Location = new Point(93, 205);
            Goals_Btn_Add.Name = "Goals_Btn_Add";
            Goals_Btn_Add.Size = new Size(154, 39);
            Goals_Btn_Add.TabIndex = 12;
            Goals_Btn_Add.Text = "Add";
            Goals_Btn_Add.UseVisualStyleBackColor = true;
            Goals_Btn_Add.Click += Goals_Btn_Add_Click;
            // 
            // Goals_Lbl_Add_Sub
            // 
            Goals_Lbl_Add_Sub.AutoSize = true;
            Goals_Lbl_Add_Sub.ForeColor = Color.FromArgb(0, 0, 192);
            Goals_Lbl_Add_Sub.Location = new Point(93, 184);
            Goals_Lbl_Add_Sub.Name = "Goals_Lbl_Add_Sub";
            Goals_Lbl_Add_Sub.Size = new Size(128, 20);
            Goals_Lbl_Add_Sub.TabIndex = 8;
            Goals_Lbl_Add_Sub.Text = "Nieuw Subdoel + ";
            Goals_Lbl_Add_Sub.Click += Goals_Lbl_Add_Sub_Click;
            // 
            // Goals_Text_Sub2
            // 
            Goals_Text_Sub2.Location = new Point(93, 151);
            Goals_Text_Sub2.Name = "Goals_Text_Sub2";
            Goals_Text_Sub2.Size = new Size(154, 27);
            Goals_Text_Sub2.TabIndex = 7;
            // 
            // Goals_Lbl_Sub2
            // 
            Goals_Lbl_Sub2.AutoSize = true;
            Goals_Lbl_Sub2.Location = new Point(2, 151);
            Goals_Lbl_Sub2.Name = "Goals_Lbl_Sub2";
            Goals_Lbl_Sub2.Size = new Size(75, 20);
            Goals_Lbl_Sub2.TabIndex = 6;
            Goals_Lbl_Sub2.Text = "Subdoel2:";
            // 
            // Goals_Text_Sub1
            // 
            Goals_Text_Sub1.Location = new Point(93, 115);
            Goals_Text_Sub1.Name = "Goals_Text_Sub1";
            Goals_Text_Sub1.Size = new Size(154, 27);
            Goals_Text_Sub1.TabIndex = 5;
            // 
            // Goals_Lbl_Sub1
            // 
            Goals_Lbl_Sub1.AutoSize = true;
            Goals_Lbl_Sub1.Location = new Point(2, 115);
            Goals_Lbl_Sub1.Name = "Goals_Lbl_Sub1";
            Goals_Lbl_Sub1.Size = new Size(75, 20);
            Goals_Lbl_Sub1.TabIndex = 4;
            Goals_Lbl_Sub1.Text = "Subdoel1:";
            // 
            // Goals_Text_Add
            // 
            Goals_Text_Add.Location = new Point(93, 79);
            Goals_Text_Add.Name = "Goals_Text_Add";
            Goals_Text_Add.Size = new Size(154, 27);
            Goals_Text_Add.TabIndex = 3;
            // 
            // Goals_Lbl_Add
            // 
            Goals_Lbl_Add.AutoSize = true;
            Goals_Lbl_Add.Location = new Point(3, 79);
            Goals_Lbl_Add.Name = "Goals_Lbl_Add";
            Goals_Lbl_Add.Size = new Size(90, 20);
            Goals_Lbl_Add.TabIndex = 2;
            Goals_Lbl_Add.Text = "Nieuw Doel:";
            // 
            // Goals_Combo_Subject
            // 
            Goals_Combo_Subject.DropDownStyle = ComboBoxStyle.DropDownList;
            Goals_Combo_Subject.FormattingEnabled = true;
            Goals_Combo_Subject.Items.AddRange(new object[] { "B1A3 - Project Management", "B1C2 - Intro to Development", "B1F3 - Data Structure Basics" });
            Goals_Combo_Subject.Location = new Point(94, 3);
            Goals_Combo_Subject.Name = "Goals_Combo_Subject";
            Goals_Combo_Subject.Size = new Size(151, 28);
            Goals_Combo_Subject.TabIndex = 1;
            // 
            // Goals_Lbl_Subject
            // 
            Goals_Lbl_Subject.AutoSize = true;
            Goals_Lbl_Subject.Location = new Point(3, 3);
            Goals_Lbl_Subject.Name = "Goals_Lbl_Subject";
            Goals_Lbl_Subject.Size = new Size(35, 20);
            Goals_Lbl_Subject.TabIndex = 0;
            Goals_Lbl_Subject.Text = "Vak:";
            // 
            // Pnl_Goals_Menu
            // 
            Pnl_Goals_Menu.Controls.Add(Goals_Menu_Btn_Current);
            Pnl_Goals_Menu.Controls.Add(Goals_Menu_Btn_Add);
            Pnl_Goals_Menu.Location = new Point(3, 3);
            Pnl_Goals_Menu.Name = "Pnl_Goals_Menu";
            Pnl_Goals_Menu.Size = new Size(629, 43);
            Pnl_Goals_Menu.TabIndex = 3;
            Pnl_Goals_Menu.Visible = false;
            // 
            // Goals_Menu_Btn_Current
            // 
            Goals_Menu_Btn_Current.Location = new Point(5, 3);
            Goals_Menu_Btn_Current.Name = "Goals_Menu_Btn_Current";
            Goals_Menu_Btn_Current.Size = new Size(137, 35);
            Goals_Menu_Btn_Current.TabIndex = 5;
            Goals_Menu_Btn_Current.Text = "Doelen";
            Goals_Menu_Btn_Current.UseVisualStyleBackColor = true;
            Goals_Menu_Btn_Current.Click += Goals_Menu_Btn_Current_Click;
            // 
            // Goals_Menu_Btn_Add
            // 
            Goals_Menu_Btn_Add.Location = new Point(147, 3);
            Goals_Menu_Btn_Add.Name = "Goals_Menu_Btn_Add";
            Goals_Menu_Btn_Add.Size = new Size(162, 35);
            Goals_Menu_Btn_Add.TabIndex = 4;
            Goals_Menu_Btn_Add.Text = "Doelen Toevoegen";
            Goals_Menu_Btn_Add.UseVisualStyleBackColor = true;
            Goals_Menu_Btn_Add.Click += Goals_Menu_Btn_Add_Click;
            // 
            // Pnl_Feedback_Menu
            // 
            Pnl_Feedback_Menu.Controls.Add(Feedback_Menu_Btn_add);
            Pnl_Feedback_Menu.Controls.Add(Feedback_Menu_Btn_Current);
            Pnl_Feedback_Menu.Location = new Point(3, 3);
            Pnl_Feedback_Menu.Name = "Pnl_Feedback_Menu";
            Pnl_Feedback_Menu.Size = new Size(629, 43);
            Pnl_Feedback_Menu.TabIndex = 5;
            Pnl_Feedback_Menu.Visible = false;
            // 
            // Feedback_Menu_Btn_add
            // 
            Feedback_Menu_Btn_add.Location = new Point(147, 3);
            Feedback_Menu_Btn_add.Name = "Feedback_Menu_Btn_add";
            Feedback_Menu_Btn_add.Size = new Size(162, 35);
            Feedback_Menu_Btn_add.TabIndex = 6;
            Feedback_Menu_Btn_add.Text = "Feedback Toevoegen";
            Feedback_Menu_Btn_add.UseVisualStyleBackColor = true;
            Feedback_Menu_Btn_add.Click += Feedback_Menu_Btn_add_Click;
            // 
            // Feedback_Menu_Btn_Current
            // 
            Feedback_Menu_Btn_Current.Location = new Point(5, 3);
            Feedback_Menu_Btn_Current.Name = "Feedback_Menu_Btn_Current";
            Feedback_Menu_Btn_Current.Size = new Size(137, 35);
            Feedback_Menu_Btn_Current.TabIndex = 5;
            Feedback_Menu_Btn_Current.Text = "Feedback";
            Feedback_Menu_Btn_Current.UseVisualStyleBackColor = true;
            Feedback_Menu_Btn_Current.Click += Feedback_Menu_Btn_Current_Click;
            // 
            // Feedback_Lbl_Subject
            // 
            Feedback_Lbl_Subject.AutoSize = true;
            Feedback_Lbl_Subject.Location = new Point(5, 5);
            Feedback_Lbl_Subject.Name = "Feedback_Lbl_Subject";
            Feedback_Lbl_Subject.Size = new Size(35, 20);
            Feedback_Lbl_Subject.TabIndex = 4;
            Feedback_Lbl_Subject.Text = "Vak:";
            // 
            // Feedback_Combo_Subject
            // 
            Feedback_Combo_Subject.DropDownStyle = ComboBoxStyle.DropDownList;
            Feedback_Combo_Subject.FormattingEnabled = true;
            Feedback_Combo_Subject.Location = new Point(95, 5);
            Feedback_Combo_Subject.Name = "Feedback_Combo_Subject";
            Feedback_Combo_Subject.Size = new Size(151, 28);
            Feedback_Combo_Subject.TabIndex = 5;
            // 
            // Feedback_Lbl_Feedback
            // 
            Feedback_Lbl_Feedback.AutoSize = true;
            Feedback_Lbl_Feedback.Location = new Point(5, 89);
            Feedback_Lbl_Feedback.Name = "Feedback_Lbl_Feedback";
            Feedback_Lbl_Feedback.Size = new Size(75, 20);
            Feedback_Lbl_Feedback.TabIndex = 6;
            Feedback_Lbl_Feedback.Text = "Feedback:";
            // 
            // Feedback_Text_Feedback
            // 
            Feedback_Text_Feedback.Location = new Point(95, 89);
            Feedback_Text_Feedback.Multiline = true;
            Feedback_Text_Feedback.Name = "Feedback_Text_Feedback";
            Feedback_Text_Feedback.Size = new Size(151, 160);
            Feedback_Text_Feedback.TabIndex = 7;
            // 
            // Feedback_Lbl_Teacher
            // 
            Feedback_Lbl_Teacher.AutoSize = true;
            Feedback_Lbl_Teacher.Location = new Point(5, 256);
            Feedback_Lbl_Teacher.Name = "Feedback_Lbl_Teacher";
            Feedback_Lbl_Teacher.Size = new Size(60, 20);
            Feedback_Lbl_Teacher.TabIndex = 9;
            Feedback_Lbl_Teacher.Text = "Docent:";
            // 
            // Pnl_Feedback_Add
            // 
            Pnl_Feedback_Add.BorderStyle = BorderStyle.FixedSingle;
            Pnl_Feedback_Add.Controls.Add(Feedback_Lbl_Week_add);
            Pnl_Feedback_Add.Controls.Add(Feedback_Combo_Week_add);
            Pnl_Feedback_Add.Controls.Add(Feedback_Combo_Teachers);
            Pnl_Feedback_Add.Controls.Add(Feedback_Btn_Add);
            Pnl_Feedback_Add.Controls.Add(Feedback_Lbl_Teacher);
            Pnl_Feedback_Add.Controls.Add(Feedback_Text_Feedback);
            Pnl_Feedback_Add.Controls.Add(Feedback_Lbl_Feedback);
            Pnl_Feedback_Add.Controls.Add(Feedback_Combo_Subject);
            Pnl_Feedback_Add.Controls.Add(Feedback_Lbl_Subject);
            Pnl_Feedback_Add.Location = new Point(3, 48);
            Pnl_Feedback_Add.Name = "Pnl_Feedback_Add";
            Pnl_Feedback_Add.Size = new Size(629, 389);
            Pnl_Feedback_Add.TabIndex = 4;
            Pnl_Feedback_Add.Visible = false;
            // 
            // Feedback_Lbl_Week_add
            // 
            Feedback_Lbl_Week_add.AutoSize = true;
            Feedback_Lbl_Week_add.Location = new Point(5, 41);
            Feedback_Lbl_Week_add.Name = "Feedback_Lbl_Week_add";
            Feedback_Lbl_Week_add.Size = new Size(48, 20);
            Feedback_Lbl_Week_add.TabIndex = 13;
            Feedback_Lbl_Week_add.Text = "Week:";
            // 
            // Feedback_Combo_Week_add
            // 
            Feedback_Combo_Week_add.DropDownStyle = ComboBoxStyle.DropDownList;
            Feedback_Combo_Week_add.FormattingEnabled = true;
            Feedback_Combo_Week_add.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            Feedback_Combo_Week_add.Location = new Point(95, 41);
            Feedback_Combo_Week_add.Name = "Feedback_Combo_Week_add";
            Feedback_Combo_Week_add.Size = new Size(151, 28);
            Feedback_Combo_Week_add.TabIndex = 12;
            // 
            // Feedback_Combo_Teachers
            // 
            Feedback_Combo_Teachers.DropDownStyle = ComboBoxStyle.DropDownList;
            Feedback_Combo_Teachers.FormattingEnabled = true;
            Feedback_Combo_Teachers.Location = new Point(95, 256);
            Feedback_Combo_Teachers.Margin = new Padding(3, 4, 3, 4);
            Feedback_Combo_Teachers.Name = "Feedback_Combo_Teachers";
            Feedback_Combo_Teachers.Size = new Size(151, 28);
            Feedback_Combo_Teachers.TabIndex = 11;
            // 
            // Feedback_Btn_Add
            // 
            Feedback_Btn_Add.Location = new Point(95, 293);
            Feedback_Btn_Add.Name = "Feedback_Btn_Add";
            Feedback_Btn_Add.Size = new Size(153, 29);
            Feedback_Btn_Add.TabIndex = 10;
            Feedback_Btn_Add.Text = "Add";
            Feedback_Btn_Add.UseVisualStyleBackColor = true;
            // 
            // Pnl_Goals
            // 
            Pnl_Goals.Controls.Add(Pnl_Goals_Menu);
            Pnl_Goals.Controls.Add(Pnl_Goals_Current);
            Pnl_Goals.Controls.Add(Pnl_Goals_Add);
            Pnl_Goals.Location = new Point(147, 0);
            Pnl_Goals.Name = "Pnl_Goals";
            Pnl_Goals.Size = new Size(658, 444);
            Pnl_Goals.TabIndex = 6;
            Pnl_Goals.Visible = false;
            // 
            // Pnl_Goals_Current
            // 
            Pnl_Goals_Current.BorderStyle = BorderStyle.FixedSingle;
            Pnl_Goals_Current.Controls.Add(Goals_Lbl_Week);
            Pnl_Goals_Current.Controls.Add(Goals_Combo_Week);
            Pnl_Goals_Current.Controls.Add(Lbl_Goals_Finished);
            Pnl_Goals_Current.Controls.Add(ListBox_Goals_Done);
            Pnl_Goals_Current.Controls.Add(Lbl_Goals_Set);
            Pnl_Goals_Current.Controls.Add(ListBox_Goals);
            Pnl_Goals_Current.Location = new Point(3, 48);
            Pnl_Goals_Current.Name = "Pnl_Goals_Current";
            Pnl_Goals_Current.Size = new Size(629, 389);
            Pnl_Goals_Current.TabIndex = 4;
            // 
            // Goals_Lbl_Week
            // 
            Goals_Lbl_Week.AutoSize = true;
            Goals_Lbl_Week.Location = new Point(3, 5);
            Goals_Lbl_Week.Name = "Goals_Lbl_Week";
            Goals_Lbl_Week.Size = new Size(45, 20);
            Goals_Lbl_Week.TabIndex = 9;
            Goals_Lbl_Week.Text = "Week";
            // 
            // Goals_Combo_Week
            // 
            Goals_Combo_Week.DropDownStyle = ComboBoxStyle.DropDownList;
            Goals_Combo_Week.FormattingEnabled = true;
            Goals_Combo_Week.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            Goals_Combo_Week.Location = new Point(53, 3);
            Goals_Combo_Week.Name = "Goals_Combo_Week";
            Goals_Combo_Week.Size = new Size(153, 28);
            Goals_Combo_Week.TabIndex = 8;
            // 
            // Lbl_Goals_Finished
            // 
            Lbl_Goals_Finished.AutoSize = true;
            Lbl_Goals_Finished.Location = new Point(319, 47);
            Lbl_Goals_Finished.Name = "Lbl_Goals_Finished";
            Lbl_Goals_Finished.Size = new Size(46, 20);
            Lbl_Goals_Finished.TabIndex = 7;
            Lbl_Goals_Finished.Text = "Taken";
            // 
            // ListBox_Goals_Done
            // 
            ListBox_Goals_Done.FormattingEnabled = true;
            ListBox_Goals_Done.Items.AddRange(new object[] { "subtask1", "subtask2", "subtask3" });
            ListBox_Goals_Done.Location = new Point(319, 72);
            ListBox_Goals_Done.Name = "ListBox_Goals_Done";
            ListBox_Goals_Done.Size = new Size(305, 290);
            ListBox_Goals_Done.TabIndex = 5;
            // 
            // Lbl_Goals_Set
            // 
            Lbl_Goals_Set.AutoSize = true;
            Lbl_Goals_Set.Location = new Point(3, 47);
            Lbl_Goals_Set.Name = "Lbl_Goals_Set";
            Lbl_Goals_Set.Size = new Size(57, 20);
            Lbl_Goals_Set.TabIndex = 6;
            Lbl_Goals_Set.Text = "Doelen";
            // 
            // ListBox_Goals
            // 
            ListBox_Goals.FormattingEnabled = true;
            ListBox_Goals.Items.AddRange(new object[] { "goal1", "goal3", "goal5", "goal8" });
            ListBox_Goals.Location = new Point(3, 72);
            ListBox_Goals.Name = "ListBox_Goals";
            ListBox_Goals.Size = new Size(305, 290);
            ListBox_Goals.TabIndex = 4;
            // 
            // Pnl_Feedback
            // 
            Pnl_Feedback.Controls.Add(Pnl_Feedback_Menu);
            Pnl_Feedback.Controls.Add(Pnl_Feedback_Current);
            Pnl_Feedback.Controls.Add(Pnl_Feedback_Add);
            Pnl_Feedback.Location = new Point(147, 0);
            Pnl_Feedback.Name = "Pnl_Feedback";
            Pnl_Feedback.Size = new Size(658, 444);
            Pnl_Feedback.TabIndex = 7;
            Pnl_Feedback.Visible = false;
            // 
            // Pnl_Feedback_Current
            // 
            Pnl_Feedback_Current.BorderStyle = BorderStyle.FixedSingle;
            Pnl_Feedback_Current.Controls.Add(Feedback_Lbl_Week);
            Pnl_Feedback_Current.Controls.Add(Feedback_Combo_Week);
            Pnl_Feedback_Current.Controls.Add(Lbl_Feedback_Goals);
            Pnl_Feedback_Current.Controls.Add(Lbl_FeedBack_Requested);
            Pnl_Feedback_Current.Controls.Add(checkedListBox1);
            Pnl_Feedback_Current.Controls.Add(ListBoxFeedback);
            Pnl_Feedback_Current.Location = new Point(3, 48);
            Pnl_Feedback_Current.Name = "Pnl_Feedback_Current";
            Pnl_Feedback_Current.Size = new Size(629, 389);
            Pnl_Feedback_Current.TabIndex = 6;
            // 
            // Feedback_Lbl_Week
            // 
            Feedback_Lbl_Week.AutoSize = true;
            Feedback_Lbl_Week.Location = new Point(3, 5);
            Feedback_Lbl_Week.Name = "Feedback_Lbl_Week";
            Feedback_Lbl_Week.Size = new Size(48, 20);
            Feedback_Lbl_Week.TabIndex = 10;
            Feedback_Lbl_Week.Text = "Week:";
            // 
            // Feedback_Combo_Week
            // 
            Feedback_Combo_Week.DropDownStyle = ComboBoxStyle.DropDownList;
            Feedback_Combo_Week.FormattingEnabled = true;
            Feedback_Combo_Week.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            Feedback_Combo_Week.Location = new Point(53, 3);
            Feedback_Combo_Week.Name = "Feedback_Combo_Week";
            Feedback_Combo_Week.Size = new Size(151, 28);
            Feedback_Combo_Week.TabIndex = 9;
            // 
            // Lbl_Feedback_Goals
            // 
            Lbl_Feedback_Goals.AutoSize = true;
            Lbl_Feedback_Goals.Location = new Point(319, 47);
            Lbl_Feedback_Goals.Name = "Lbl_Feedback_Goals";
            Lbl_Feedback_Goals.Size = new Size(124, 20);
            Lbl_Feedback_Goals.TabIndex = 3;
            Lbl_Feedback_Goals.Text = "Feedback Doelen";
            // 
            // Lbl_FeedBack_Requested
            // 
            Lbl_FeedBack_Requested.AutoSize = true;
            Lbl_FeedBack_Requested.Location = new Point(3, 47);
            Lbl_FeedBack_Requested.Name = "Lbl_FeedBack_Requested";
            Lbl_FeedBack_Requested.Size = new Size(148, 20);
            Lbl_FeedBack_Requested.TabIndex = 2;
            Lbl_FeedBack_Requested.Text = "Gevraagde Feedback";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "a", "b", "c", "d", "e", "f", "g" });
            checkedListBox1.Location = new Point(319, 72);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(305, 290);
            checkedListBox1.TabIndex = 1;
            // 
            // ListBoxFeedback
            // 
            ListBoxFeedback.FormattingEnabled = true;
            ListBoxFeedback.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            ListBoxFeedback.Location = new Point(3, 72);
            ListBoxFeedback.Name = "ListBoxFeedback";
            ListBoxFeedback.Size = new Size(305, 290);
            ListBoxFeedback.TabIndex = 0;
            // 
            // Pnl_Logbook
            // 
            Pnl_Logbook.Controls.Add(Pnl_Logbook_Menu);
            Pnl_Logbook.Controls.Add(Pnl_Logbook_Current);
            Pnl_Logbook.Controls.Add(Pnl_Logbook_Add);
            Pnl_Logbook.Location = new Point(147, 0);
            Pnl_Logbook.Name = "Pnl_Logbook";
            Pnl_Logbook.Size = new Size(658, 444);
            Pnl_Logbook.TabIndex = 8;
            // 
            // Pnl_Logbook_Menu
            // 
            Pnl_Logbook_Menu.Controls.Add(Logbook_Menu_Btn_add);
            Pnl_Logbook_Menu.Controls.Add(Logbook_Menu_Btn_Current);
            Pnl_Logbook_Menu.Location = new Point(3, 3);
            Pnl_Logbook_Menu.Name = "Pnl_Logbook_Menu";
            Pnl_Logbook_Menu.Size = new Size(629, 43);
            Pnl_Logbook_Menu.TabIndex = 6;
            Pnl_Logbook_Menu.Visible = false;
            // 
            // Logbook_Menu_Btn_add
            // 
            Logbook_Menu_Btn_add.Location = new Point(147, 3);
            Logbook_Menu_Btn_add.Name = "Logbook_Menu_Btn_add";
            Logbook_Menu_Btn_add.Size = new Size(162, 35);
            Logbook_Menu_Btn_add.TabIndex = 6;
            Logbook_Menu_Btn_add.Text = "Log Toevoegen";
            Logbook_Menu_Btn_add.UseVisualStyleBackColor = true;
            Logbook_Menu_Btn_add.Click += Logbook_Menu_Btn_add_Click;
            // 
            // Logbook_Menu_Btn_Current
            // 
            Logbook_Menu_Btn_Current.Location = new Point(5, 3);
            Logbook_Menu_Btn_Current.Name = "Logbook_Menu_Btn_Current";
            Logbook_Menu_Btn_Current.Size = new Size(137, 35);
            Logbook_Menu_Btn_Current.TabIndex = 5;
            Logbook_Menu_Btn_Current.Text = "Logboek";
            Logbook_Menu_Btn_Current.UseVisualStyleBackColor = true;
            Logbook_Menu_Btn_Current.Click += Logbook_Menu_Btn_Current_Click;
            // 
            // Pnl_Logbook_Current
            // 
            Pnl_Logbook_Current.BorderStyle = BorderStyle.FixedSingle;
            Pnl_Logbook_Current.Controls.Add(Logbook_Combo_Week);
            Pnl_Logbook_Current.Controls.Add(label2);
            Pnl_Logbook_Current.Location = new Point(3, 48);
            Pnl_Logbook_Current.Name = "Pnl_Logbook_Current";
            Pnl_Logbook_Current.Size = new Size(629, 389);
            Pnl_Logbook_Current.TabIndex = 7;
            Pnl_Logbook_Current.Visible = false;
            // 
            // Logbook_Combo_Week
            // 
            Logbook_Combo_Week.DropDownStyle = ComboBoxStyle.DropDownList;
            Logbook_Combo_Week.FormattingEnabled = true;
            Logbook_Combo_Week.Location = new Point(53, 5);
            Logbook_Combo_Week.Name = "Logbook_Combo_Week";
            Logbook_Combo_Week.Size = new Size(151, 28);
            Logbook_Combo_Week.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 5);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 11;
            label2.Text = "Week";
            // 
            // Pnl_Logbook_Add
            // 
            Pnl_Logbook_Add.BorderStyle = BorderStyle.FixedSingle;
            Pnl_Logbook_Add.Location = new Point(3, 48);
            Pnl_Logbook_Add.Name = "Pnl_Logbook_Add";
            Pnl_Logbook_Add.Size = new Size(629, 389);
            Pnl_Logbook_Add.TabIndex = 8;
            Pnl_Logbook_Add.Visible = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Pnl_Menu);
            Controls.Add(Pnl_Feedback);
            Controls.Add(Pnl_Goals);
            Controls.Add(Pnl_Logbook);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            Pnl_Menu.ResumeLayout(false);
            Pnl_Menu_Student.ResumeLayout(false);
            Pnl_Menu_Student.PerformLayout();
            Pnl_Menu_Userdetails.ResumeLayout(false);
            Pnl_Menu_Userdetails.PerformLayout();
            Pnl_Goals_Add.ResumeLayout(false);
            Pnl_Goals_Add.PerformLayout();
            Pnl_Goals_Menu.ResumeLayout(false);
            Pnl_Feedback_Menu.ResumeLayout(false);
            Pnl_Feedback_Add.ResumeLayout(false);
            Pnl_Feedback_Add.PerformLayout();
            Pnl_Goals.ResumeLayout(false);
            Pnl_Goals_Current.ResumeLayout(false);
            Pnl_Goals_Current.PerformLayout();
            Pnl_Feedback.ResumeLayout(false);
            Pnl_Feedback_Current.ResumeLayout(false);
            Pnl_Feedback_Current.PerformLayout();
            Pnl_Logbook.ResumeLayout(false);
            Pnl_Logbook_Menu.ResumeLayout(false);
            Pnl_Logbook_Current.ResumeLayout(false);
            Pnl_Logbook_Current.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Menu_Logout;
        private Panel Pnl_Menu;
        private Button Btn_Menu;
        private Panel Pnl_Menu_Student;
        private Button Btn_Menu_Goals;
        private Button Btn_Menu_Logbook;
        private Button Btn_Menu_Feedback;
        private Panel Pnl_Goals_Add;
        private Label Goals_Lbl_Add_Sub;
        private TextBox Goals_Text_Sub2;
        private Label Goals_Lbl_Sub2;
        private TextBox Goals_Text_Sub1;
        private Label Goals_Lbl_Sub1;
        private TextBox Goals_Text_Add;
        private Label Goals_Lbl_Add;
        private ComboBox Goals_Combo_Subject;
        private Label Goals_Lbl_Subject;
        private Panel Pnl_Goals_Menu;
        private Button Goals_Menu_Btn_Current;
        private Button Goals_Menu_Btn_Add;
        private Panel Pnl_Feedback_Menu;
        private Button Feedback_Menu_Btn_add;
        private Button Feedback_Menu_Btn_Current;
        private Label Feedback_Lbl_Subject;
        private ComboBox Feedback_Combo_Subject;
        private Label Feedback_Lbl_Feedback;
        private TextBox Feedback_Text_Feedback;
        private Label Feedback_Lbl_Teacher;
        private Panel Pnl_Feedback_Add;
        private Button Feedback_Btn_Add;
        private Button Goals_Btn_Add;
        private Label Temp_Lbl_Size;
        private Panel Pnl_Goals;
        private Panel Pnl_Feedback;
        private Panel Pnl_Feedback_Current;
        private Panel Pnl_Goals_Current;
        private CheckedListBox ListBoxFeedback;
        private Label Lbl_Feedback_Goals;
        private Label Lbl_FeedBack_Requested;
        private CheckedListBox checkedListBox1;
        private Label Lbl_Goals_Finished;
        private CheckedListBox ListBox_Goals_Done;
        private Label Lbl_Goals_Set;
        private CheckedListBox ListBox_Goals;
        private ComboBox Goals_Combo_Week;
        private ComboBox Feedback_Combo_Week;
        private Label Goals_Lbl_Week;
        private Label Feedback_Lbl_Week;
        private Panel Pnl_Logbook;
        private Panel Pnl_Logbook_Current;
        private Panel Pnl_Logbook_Menu;
        private Button Logbook_Menu_Btn_add;
        private Button Logbook_Menu_Btn_Current;
        private Panel Pnl_Logbook_Add;
        private Label label2;
        private ComboBox Logbook_Combo_Week;
        private Label Lbl_Menu_Userrole;
        private Label Lbl_Menu_Userid;
        private Label Lbl_Menu_Username;
        private Panel Pnl_Menu_Userdetails;
        private Label Goals_Lbl_week_add;
        private ComboBox Goals_Combo_Week_add;
        private ComboBox Feedback_Combo_Teachers;
        private Label Feedback_Lbl_Week_add;
        private ComboBox Feedback_Combo_Week_add;
    }
}