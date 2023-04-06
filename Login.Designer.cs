namespace FeedBuff_Kerkrade
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Login_User_Txt = new TextBox();
            Login_Pass_Txt = new TextBox();
            Login_Lbl_User = new Label();
            Login_Lbl_Pass = new Label();
            Close_btn = new Button();
            Login_btn = new Button();
            Register_btn = new Button();
            Login_Lbl_Error = new Label();
            Login_Pnl_Login = new Panel();
            Login_Pnl_Register = new Panel();
            Register_Lbl_Error = new Label();
            Register_Pass_Txt = new TextBox();
            Register_Lbl_Pass = new Label();
            Register_User_Txt = new TextBox();
            Register_Mail_Txt = new TextBox();
            Register_Btn_Cancel = new Button();
            Register_Lbl_User = new Label();
            Register_Btn_Signup = new Button();
            Register_Lbl_Mail = new Label();
            Login_Pnl_Login.SuspendLayout();
            Login_Pnl_Register.SuspendLayout();
            SuspendLayout();
            // 
            // Login_User_Txt
            // 
            Login_User_Txt.Location = new Point(84, 94);
            Login_User_Txt.Name = "Login_User_Txt";
            Login_User_Txt.Size = new Size(185, 27);
            Login_User_Txt.TabIndex = 0;
            // 
            // Login_Pass_Txt
            // 
            Login_Pass_Txt.Location = new Point(84, 144);
            Login_Pass_Txt.Name = "Login_Pass_Txt";
            Login_Pass_Txt.Size = new Size(185, 27);
            Login_Pass_Txt.TabIndex = 1;
            // 
            // Login_Lbl_User
            // 
            Login_Lbl_User.AutoSize = true;
            Login_Lbl_User.Location = new Point(84, 72);
            Login_Lbl_User.Name = "Login_Lbl_User";
            Login_Lbl_User.Size = new Size(75, 20);
            Login_Lbl_User.TabIndex = 2;
            Login_Lbl_User.Text = "Username";
            // 
            // Login_Lbl_Pass
            // 
            Login_Lbl_Pass.AutoSize = true;
            Login_Lbl_Pass.Location = new Point(84, 123);
            Login_Lbl_Pass.Name = "Login_Lbl_Pass";
            Login_Lbl_Pass.Size = new Size(70, 20);
            Login_Lbl_Pass.TabIndex = 3;
            Login_Lbl_Pass.Text = "Password";
            // 
            // Close_btn
            // 
            Close_btn.Location = new Point(713, 12);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(75, 29);
            Close_btn.TabIndex = 4;
            Close_btn.Text = "Close";
            Close_btn.UseVisualStyleBackColor = true;
            Close_btn.Click += Close_btn_Click;
            // 
            // Login_btn
            // 
            Login_btn.DialogResult = DialogResult.OK;
            Login_btn.Location = new Point(84, 177);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(185, 29);
            Login_btn.TabIndex = 5;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click;
            // 
            // Register_btn
            // 
            Register_btn.Location = new Point(84, 212);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(185, 29);
            Register_btn.TabIndex = 6;
            Register_btn.Text = "Register";
            Register_btn.UseVisualStyleBackColor = true;
            Register_btn.Click += Register_btn_Click;
            // 
            // Login_Lbl_Error
            // 
            Login_Lbl_Error.AutoSize = true;
            Login_Lbl_Error.ForeColor = Color.Red;
            Login_Lbl_Error.Location = new Point(84, 244);
            Login_Lbl_Error.Name = "Login_Lbl_Error";
            Login_Lbl_Error.Size = new Size(0, 20);
            Login_Lbl_Error.TabIndex = 7;
            // 
            // Login_Pnl_Login
            // 
            Login_Pnl_Login.Controls.Add(Login_User_Txt);
            Login_Pnl_Login.Controls.Add(Login_Lbl_Error);
            Login_Pnl_Login.Controls.Add(Login_Pass_Txt);
            Login_Pnl_Login.Controls.Add(Register_btn);
            Login_Pnl_Login.Controls.Add(Login_Lbl_User);
            Login_Pnl_Login.Controls.Add(Login_btn);
            Login_Pnl_Login.Controls.Add(Login_Lbl_Pass);
            Login_Pnl_Login.Location = new Point(218, 60);
            Login_Pnl_Login.Name = "Login_Pnl_Login";
            Login_Pnl_Login.Size = new Size(353, 316);
            Login_Pnl_Login.TabIndex = 8;
            // 
            // Login_Pnl_Register
            // 
            Login_Pnl_Register.Controls.Add(Register_Lbl_Error);
            Login_Pnl_Register.Controls.Add(Register_Pass_Txt);
            Login_Pnl_Register.Controls.Add(Register_Lbl_Pass);
            Login_Pnl_Register.Controls.Add(Register_User_Txt);
            Login_Pnl_Register.Controls.Add(Register_Mail_Txt);
            Login_Pnl_Register.Controls.Add(Register_Btn_Cancel);
            Login_Pnl_Register.Controls.Add(Register_Lbl_User);
            Login_Pnl_Register.Controls.Add(Register_Btn_Signup);
            Login_Pnl_Register.Controls.Add(Register_Lbl_Mail);
            Login_Pnl_Register.Location = new Point(218, 60);
            Login_Pnl_Register.Name = "Login_Pnl_Register";
            Login_Pnl_Register.Size = new Size(353, 316);
            Login_Pnl_Register.TabIndex = 9;
            Login_Pnl_Register.Visible = false;
            // 
            // Register_Lbl_Error
            // 
            Register_Lbl_Error.AutoSize = true;
            Register_Lbl_Error.ForeColor = Color.Red;
            Register_Lbl_Error.Location = new Point(84, 244);
            Register_Lbl_Error.Name = "Register_Lbl_Error";
            Register_Lbl_Error.Size = new Size(0, 20);
            Register_Lbl_Error.TabIndex = 15;
            // 
            // Register_Pass_Txt
            // 
            Register_Pass_Txt.Location = new Point(84, 145);
            Register_Pass_Txt.Name = "Register_Pass_Txt";
            Register_Pass_Txt.Size = new Size(185, 27);
            Register_Pass_Txt.TabIndex = 13;
            // 
            // Register_Lbl_Pass
            // 
            Register_Lbl_Pass.AutoSize = true;
            Register_Lbl_Pass.Location = new Point(84, 124);
            Register_Lbl_Pass.Name = "Register_Lbl_Pass";
            Register_Lbl_Pass.Size = new Size(70, 20);
            Register_Lbl_Pass.TabIndex = 14;
            Register_Lbl_Pass.Text = "Password";
            // 
            // Register_User_Txt
            // 
            Register_User_Txt.Location = new Point(84, 45);
            Register_User_Txt.Name = "Register_User_Txt";
            Register_User_Txt.Size = new Size(185, 27);
            Register_User_Txt.TabIndex = 7;
            // 
            // Register_Mail_Txt
            // 
            Register_Mail_Txt.Location = new Point(84, 95);
            Register_Mail_Txt.Name = "Register_Mail_Txt";
            Register_Mail_Txt.Size = new Size(185, 27);
            Register_Mail_Txt.TabIndex = 8;
            // 
            // Register_Btn_Cancel
            // 
            Register_Btn_Cancel.Location = new Point(84, 212);
            Register_Btn_Cancel.Name = "Register_Btn_Cancel";
            Register_Btn_Cancel.Size = new Size(185, 29);
            Register_Btn_Cancel.TabIndex = 12;
            Register_Btn_Cancel.Text = "Cancel";
            Register_Btn_Cancel.UseVisualStyleBackColor = true;
            Register_Btn_Cancel.Click += Register_Btn_Cancel_Click;
            // 
            // Register_Lbl_User
            // 
            Register_Lbl_User.AutoSize = true;
            Register_Lbl_User.Location = new Point(84, 23);
            Register_Lbl_User.Name = "Register_Lbl_User";
            Register_Lbl_User.Size = new Size(75, 20);
            Register_Lbl_User.TabIndex = 9;
            Register_Lbl_User.Text = "Username";
            // 
            // Register_Btn_Signup
            // 
            Register_Btn_Signup.Location = new Point(84, 177);
            Register_Btn_Signup.Name = "Register_Btn_Signup";
            Register_Btn_Signup.Size = new Size(185, 29);
            Register_Btn_Signup.TabIndex = 11;
            Register_Btn_Signup.Text = "Sign Up";
            Register_Btn_Signup.UseVisualStyleBackColor = true;
            Register_Btn_Signup.Click += Register_Btn_Signup_Click;
            // 
            // Register_Lbl_Mail
            // 
            Register_Lbl_Mail.AutoSize = true;
            Register_Lbl_Mail.Location = new Point(84, 74);
            Register_Lbl_Mail.Name = "Register_Lbl_Mail";
            Register_Lbl_Mail.Size = new Size(46, 20);
            Register_Lbl_Mail.TabIndex = 10;
            Register_Lbl_Mail.Text = "Email";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Close_btn);
            Controls.Add(Login_Pnl_Login);
            Controls.Add(Login_Pnl_Register);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            Login_Pnl_Login.ResumeLayout(false);
            Login_Pnl_Login.PerformLayout();
            Login_Pnl_Register.ResumeLayout(false);
            Login_Pnl_Register.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox Login_User_Txt;
        private TextBox Login_Pass_Txt;
        private Label Login_Lbl_User;
        private Label Login_Lbl_Pass;
        private Button Close_btn;
        private Button Login_btn;
        private Button Register_btn;
        private Label Login_Lbl_Error;
        private Panel Login_Pnl_Login;
        private Panel Login_Pnl_Register;
        private TextBox Register_Pass_Txt;
        private Label Register_Lbl_Pass;
        private TextBox Register_User_Txt;
        private TextBox Register_Mail_Txt;
        private Button Register_Btn_Cancel;
        private Label Register_Lbl_User;
        private Button Register_Btn_Signup;
        private Label Register_Lbl_Mail;
        private Label Register_Lbl_Error;
    }
}