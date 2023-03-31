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
            this.Username_txtbox = new System.Windows.Forms.TextBox();
            this.Password_txtbox = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.Close_btn = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.Register_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Username_txtbox
            // 
            this.Username_txtbox.Location = new System.Drawing.Point(315, 159);
            this.Username_txtbox.Name = "Username_txtbox";
            this.Username_txtbox.Size = new System.Drawing.Size(186, 27);
            this.Username_txtbox.TabIndex = 0;
            // 
            // Password_txtbox
            // 
            this.Password_txtbox.Location = new System.Drawing.Point(315, 207);
            this.Password_txtbox.Name = "Password_txtbox";
            this.Password_txtbox.Size = new System.Drawing.Size(186, 27);
            this.Password_txtbox.TabIndex = 1;
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(316, 131);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(75, 20);
            this.label_user.TabIndex = 2;
            this.label_user.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(318, 186);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(70, 20);
            this.label_password.TabIndex = 3;
            this.label_password.Text = "Password";
            // 
            // Close_btn
            // 
            this.Close_btn.Location = new System.Drawing.Point(694, 12);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(94, 29);
            this.Close_btn.TabIndex = 4;
            this.Close_btn.Text = "Close";
            this.Close_btn.UseVisualStyleBackColor = true;
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(315, 265);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(94, 29);
            this.Login_btn.TabIndex = 5;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // Register_btn
            // 
            this.Register_btn.Location = new System.Drawing.Point(428, 265);
            this.Register_btn.Name = "Register_btn";
            this.Register_btn.Size = new System.Drawing.Size(94, 29);
            this.Register_btn.TabIndex = 6;
            this.Register_btn.Text = "Register";
            this.Register_btn.UseVisualStyleBackColor = true;
            this.Register_btn.Click += new System.EventHandler(this.Register_btn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Register_btn);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.Close_btn);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.Password_txtbox);
            this.Controls.Add(this.Username_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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