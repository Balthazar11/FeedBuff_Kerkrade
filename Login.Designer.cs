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
            this.Login_User_Txt = new System.Windows.Forms.TextBox();
            this.Login_Pass_Txt = new System.Windows.Forms.TextBox();
            this.Login_Lbl_User = new System.Windows.Forms.Label();
            this.Login_Lbl_Pass = new System.Windows.Forms.Label();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Register_btn = new System.Windows.Forms.Button();
            this.Login_Lbl_Error = new System.Windows.Forms.Label();
            this.Login_Pnl_Login = new System.Windows.Forms.Panel();
            this.Login_Pnl_Register = new System.Windows.Forms.Panel();
            this.Register_Lbl_Error = new System.Windows.Forms.Label();
            this.Register_Pass_Txt = new System.Windows.Forms.TextBox();
            this.Register_Lbl_Pass = new System.Windows.Forms.Label();
            this.Register_User_Txt = new System.Windows.Forms.TextBox();
            this.Register_Btn_Cancel = new System.Windows.Forms.Button();
            this.Register_Lbl_User = new System.Windows.Forms.Label();
            this.Register_Btn_Signup = new System.Windows.Forms.Button();
            this.Login_Pnl_Login.SuspendLayout();
            this.Login_Pnl_Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // Login_User_Txt
            // 
            this.Login_User_Txt.Location = new System.Drawing.Point(84, 94);
            this.Login_User_Txt.Name = "Login_User_Txt";
            this.Login_User_Txt.Size = new System.Drawing.Size(185, 27);
            this.Login_User_Txt.TabIndex = 0;
            // 
            // Login_Pass_Txt
            // 
            this.Login_Pass_Txt.Location = new System.Drawing.Point(84, 144);
            this.Login_Pass_Txt.Name = "Login_Pass_Txt";
            this.Login_Pass_Txt.PasswordChar = '*';
            this.Login_Pass_Txt.Size = new System.Drawing.Size(185, 27);
            this.Login_Pass_Txt.TabIndex = 1;
            // 
            // Login_Lbl_User
            // 
            this.Login_Lbl_User.AutoSize = true;
            this.Login_Lbl_User.Location = new System.Drawing.Point(84, 72);
            this.Login_Lbl_User.Name = "Login_Lbl_User";
            this.Login_Lbl_User.Size = new System.Drawing.Size(75, 20);
            this.Login_Lbl_User.TabIndex = 2;
            this.Login_Lbl_User.Text = "Username";
            // 
            // Login_Lbl_Pass
            // 
            this.Login_Lbl_Pass.AutoSize = true;
            this.Login_Lbl_Pass.Location = new System.Drawing.Point(84, 123);
            this.Login_Lbl_Pass.Name = "Login_Lbl_Pass";
            this.Login_Lbl_Pass.Size = new System.Drawing.Size(70, 20);
            this.Login_Lbl_Pass.TabIndex = 3;
            this.Login_Lbl_Pass.Text = "Password";
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(713, 12);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(75, 29);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Login_btn.Location = new System.Drawing.Point(84, 177);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(185, 29);
            this.Login_btn.TabIndex = 5;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.Location = new System.Drawing.Point(84, 212);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(185, 29);
            this.Register_btn.TabIndex = 6;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // Login_Lbl_Error
            // 
            this.Login_Lbl_Error.AutoSize = true;
            this.Login_Lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.Login_Lbl_Error.Location = new System.Drawing.Point(84, 244);
            this.Login_Lbl_Error.Name = "Login_Lbl_Error";
            this.Login_Lbl_Error.Size = new System.Drawing.Size(0, 20);
            this.Login_Lbl_Error.TabIndex = 7;
            // 
            // Login_Pnl_Login
            // 
            this.Login_Pnl_Login.Controls.Add(this.Login_User_Txt);
            this.Login_Pnl_Login.Controls.Add(this.Login_Lbl_Error);
            this.Login_Pnl_Login.Controls.Add(this.Login_Pass_Txt);
            this.Login_Pnl_Login.Controls.Add(this.Register_btn);
            this.Login_Pnl_Login.Controls.Add(this.Login_Lbl_User);
            this.Login_Pnl_Login.Controls.Add(this.Login_btn);
            this.Login_Pnl_Login.Controls.Add(this.Login_Lbl_Pass);
            this.Login_Pnl_Login.Location = new System.Drawing.Point(218, 59);
            this.Login_Pnl_Login.Name = "Login_Pnl_Login";
            this.Login_Pnl_Login.Size = new System.Drawing.Size(353, 316);
            this.Login_Pnl_Login.TabIndex = 8;
            // 
            // Login_Pnl_Register
            // 
            this.Login_Pnl_Register.Controls.Add(this.Register_Lbl_Error);
            this.Login_Pnl_Register.Controls.Add(this.Register_Pass_Txt);
            this.Login_Pnl_Register.Controls.Add(this.Register_Lbl_Pass);
            this.Login_Pnl_Register.Controls.Add(this.Register_User_Txt);
            this.Login_Pnl_Register.Controls.Add(this.Register_Btn_Cancel);
            this.Login_Pnl_Register.Controls.Add(this.Register_Lbl_User);
            this.Login_Pnl_Register.Controls.Add(this.Register_Btn_Signup);
            this.Login_Pnl_Register.Location = new System.Drawing.Point(218, 60);
            this.Login_Pnl_Register.Name = "Login_Pnl_Register";
            this.Login_Pnl_Register.Size = new System.Drawing.Size(353, 316);
            this.Login_Pnl_Register.TabIndex = 9;
            this.Login_Pnl_Register.Visible = false;
            // 
            // Register_Lbl_Error
            // 
            this.Register_Lbl_Error.AutoSize = true;
            this.Register_Lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.Register_Lbl_Error.Location = new System.Drawing.Point(84, 244);
            this.Register_Lbl_Error.Name = "Register_Lbl_Error";
            this.Register_Lbl_Error.Size = new System.Drawing.Size(0, 20);
            this.Register_Lbl_Error.TabIndex = 15;
            // 
            // Register_Pass_Txt
            // 
            this.Register_Pass_Txt.Location = new System.Drawing.Point(84, 145);
            this.Register_Pass_Txt.Name = "Register_Pass_Txt";
            this.Register_Pass_Txt.Size = new System.Drawing.Size(185, 27);
            this.Register_Pass_Txt.TabIndex = 13;
            // 
            // Register_Lbl_Pass
            // 
            this.Register_Lbl_Pass.AutoSize = true;
            this.Register_Lbl_Pass.Location = new System.Drawing.Point(84, 124);
            this.Register_Lbl_Pass.Name = "Register_Lbl_Pass";
            this.Register_Lbl_Pass.Size = new System.Drawing.Size(70, 20);
            this.Register_Lbl_Pass.TabIndex = 14;
            this.Register_Lbl_Pass.Text = "Password";
            // 
            // Register_User_Txt
            // 
            this.Register_User_Txt.Location = new System.Drawing.Point(84, 76);
            this.Register_User_Txt.Name = "Register_User_Txt";
            this.Register_User_Txt.Size = new System.Drawing.Size(185, 27);
            this.Register_User_Txt.TabIndex = 7;
            // 
            // Register_Btn_Cancel
            // 
            this.Register_Btn_Cancel.Location = new System.Drawing.Point(84, 212);
            this.Register_Btn_Cancel.Name = "Register_Btn_Cancel";
            this.Register_Btn_Cancel.Size = new System.Drawing.Size(185, 29);
            this.Register_Btn_Cancel.TabIndex = 12;
            this.Register_Btn_Cancel.Text = "Cancel";
            this.Register_Btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // Register_Lbl_User
            // 
            this.Register_Lbl_User.AutoSize = true;
            this.Register_Lbl_User.Location = new System.Drawing.Point(84, 54);
            this.Register_Lbl_User.Name = "Register_Lbl_User";
            this.Register_Lbl_User.Size = new System.Drawing.Size(75, 20);
            this.Register_Lbl_User.TabIndex = 9;
            this.Register_Lbl_User.Text = "Username";
            // 
            // Register_Btn_Signup
            // 
            this.Register_Btn_Signup.Location = new System.Drawing.Point(84, 177);
            this.Register_Btn_Signup.Name = "Register_Btn_Signup";
            this.Register_Btn_Signup.Size = new System.Drawing.Size(185, 29);
            this.Register_Btn_Signup.TabIndex = 11;
            this.Register_Btn_Signup.Text = "Sign Up";
            this.Register_Btn_Signup.UseVisualStyleBackColor = true;
            this.Register_Btn_Signup.Click += new System.EventHandler(this.Register_Btn_Signup_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.Login_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.Login_Pnl_Login);
            this.Controls.Add(this.Login_Pnl_Register);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.Login_Pnl_Login.ResumeLayout(false);
            this.Login_Pnl_Login.PerformLayout();
            this.Login_Pnl_Register.ResumeLayout(false);
            this.Login_Pnl_Register.PerformLayout();
            this.ResumeLayout(false);
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
        private Button Register_Btn_Cancel;
        private Label Register_Lbl_User;
        private Button Register_Btn_Signup;
        private Label Register_Lbl_Error;
    }
}