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
            Username_txtbox = new TextBox();
            Password_txtbox = new TextBox();
            label_user = new Label();
            label_password = new Label();
            Close_btn = new Button();
            Login_btn = new Button();
            Register_btn = new Button();
            SuspendLayout();
            // 
            // Username_txtbox
            // 
            Username_txtbox.Location = new Point(315, 159);
            Username_txtbox.Name = "Username_txtbox";
            Username_txtbox.Size = new Size(186, 27);
            Username_txtbox.TabIndex = 0;
            // 
            // Password_txtbox
            // 
            Password_txtbox.Location = new Point(315, 207);
            Password_txtbox.Name = "Password_txtbox";
            Password_txtbox.Size = new Size(186, 27);
            Password_txtbox.TabIndex = 1;
            // 
            // label_user
            // 
            label_user.AutoSize = true;
            label_user.Location = new Point(316, 131);
            label_user.Name = "label_user";
            label_user.Size = new Size(75, 20);
            label_user.TabIndex = 2;
            label_user.Text = "Username";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(318, 186);
            label_password.Name = "label_password";
            label_password.Size = new Size(70, 20);
            label_password.TabIndex = 3;
            label_password.Text = "Password";
            // 
            // Close_btn
            // 
            Close_btn.Location = new Point(694, 12);
            Close_btn.Name = "Close_btn";
            Close_btn.Size = new Size(94, 29);
            Close_btn.TabIndex = 4;
            Close_btn.Text = "Close";
            Close_btn.UseVisualStyleBackColor = true;
            Close_btn.Click += Close_btn_Click;
            // 
            // Login_btn
            // 
            Login_btn.Location = new Point(315, 265);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(94, 29);
            Login_btn.TabIndex = 5;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click;
            // 
            // Register_btn
            // 
            Register_btn.Location = new Point(428, 265);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(94, 29);
            Register_btn.TabIndex = 6;
            Register_btn.Text = "Register";
            Register_btn.UseVisualStyleBackColor = true;
            Register_btn.Click += Register_btn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Register_btn);
            Controls.Add(Login_btn);
            Controls.Add(Close_btn);
            Controls.Add(label_password);
            Controls.Add(label_user);
            Controls.Add(Password_txtbox);
            Controls.Add(Username_txtbox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Username_txtbox;
        private TextBox Password_txtbox;
        private Label label_user;
        private Label label_password;
        private Button Close_btn;
        private Button Login_btn;
        private Button Register_btn;
    }
}