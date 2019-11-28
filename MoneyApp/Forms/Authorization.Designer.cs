namespace MoneyApp.Forms
{
    partial class Authorization
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
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btn_sign_in = new System.Windows.Forms.Button();
            this.lbl_new_name = new System.Windows.Forms.Label();
            this.lbl_new_username = new System.Windows.Forms.Label();
            this.lbl_new_password = new System.Windows.Forms.Label();
            this.tbx_new_name = new System.Windows.Forms.TextBox();
            this.tbx_new_username = new System.Windows.Forms.TextBox();
            this.tbx_new_password = new System.Windows.Forms.TextBox();
            this.lbl_new_repeat_password = new System.Windows.Forms.Label();
            this.tbx_new_repeat_password = new System.Windows.Forms.TextBox();
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(24, 85);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(24, 111);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password:";
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(88, 82);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(131, 20);
            this.tbx_username.TabIndex = 2;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(88, 108);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(131, 20);
            this.tbx_password.TabIndex = 3;
            this.tbx_password.UseSystemPasswordChar = true;
            // 
            // btn_sign_in
            // 
            this.btn_sign_in.Location = new System.Drawing.Point(88, 134);
            this.btn_sign_in.Name = "btn_sign_in";
            this.btn_sign_in.Size = new System.Drawing.Size(75, 23);
            this.btn_sign_in.TabIndex = 4;
            this.btn_sign_in.Text = "Sign in";
            this.btn_sign_in.UseVisualStyleBackColor = true;
            this.btn_sign_in.Click += new System.EventHandler(this.SignInClick);
            // 
            // lbl_new_name
            // 
            this.lbl_new_name.AutoSize = true;
            this.lbl_new_name.Location = new System.Drawing.Point(352, 63);
            this.lbl_new_name.Name = "lbl_new_name";
            this.lbl_new_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_new_name.TabIndex = 5;
            this.lbl_new_name.Text = "Name:";
            // 
            // lbl_new_username
            // 
            this.lbl_new_username.AutoSize = true;
            this.lbl_new_username.Location = new System.Drawing.Point(332, 89);
            this.lbl_new_username.Name = "lbl_new_username";
            this.lbl_new_username.Size = new System.Drawing.Size(58, 13);
            this.lbl_new_username.TabIndex = 6;
            this.lbl_new_username.Text = "Username:";
            // 
            // lbl_new_password
            // 
            this.lbl_new_password.AutoSize = true;
            this.lbl_new_password.Location = new System.Drawing.Point(332, 115);
            this.lbl_new_password.Name = "lbl_new_password";
            this.lbl_new_password.Size = new System.Drawing.Size(56, 13);
            this.lbl_new_password.TabIndex = 7;
            this.lbl_new_password.Text = "Password:";
            // 
            // tbx_new_name
            // 
            this.tbx_new_name.Location = new System.Drawing.Point(396, 60);
            this.tbx_new_name.Name = "tbx_new_name";
            this.tbx_new_name.Size = new System.Drawing.Size(131, 20);
            this.tbx_new_name.TabIndex = 8;
            // 
            // tbx_new_username
            // 
            this.tbx_new_username.Location = new System.Drawing.Point(396, 86);
            this.tbx_new_username.Name = "tbx_new_username";
            this.tbx_new_username.Size = new System.Drawing.Size(131, 20);
            this.tbx_new_username.TabIndex = 9;
            // 
            // tbx_new_password
            // 
            this.tbx_new_password.Location = new System.Drawing.Point(396, 112);
            this.tbx_new_password.Name = "tbx_new_password";
            this.tbx_new_password.Size = new System.Drawing.Size(131, 20);
            this.tbx_new_password.TabIndex = 10;
            this.tbx_new_password.UseSystemPasswordChar = true;
            // 
            // lbl_new_repeat_password
            // 
            this.lbl_new_repeat_password.AutoSize = true;
            this.lbl_new_repeat_password.Location = new System.Drawing.Point(297, 141);
            this.lbl_new_repeat_password.Name = "lbl_new_repeat_password";
            this.lbl_new_repeat_password.Size = new System.Drawing.Size(93, 13);
            this.lbl_new_repeat_password.TabIndex = 11;
            this.lbl_new_repeat_password.Text = "Repeat password:";
            // 
            // tbx_new_repeat_password
            // 
            this.tbx_new_repeat_password.Location = new System.Drawing.Point(396, 138);
            this.tbx_new_repeat_password.Name = "tbx_new_repeat_password";
            this.tbx_new_repeat_password.Size = new System.Drawing.Size(131, 20);
            this.tbx_new_repeat_password.TabIndex = 12;
            this.tbx_new_repeat_password.UseSystemPasswordChar = true;
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.Location = new System.Drawing.Point(396, 164);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(75, 23);
            this.btn_sign_up.TabIndex = 13;
            this.btn_sign_up.Text = "Sign up";
            this.btn_sign_up.UseVisualStyleBackColor = true;
            this.btn_sign_up.Click += new System.EventHandler(this.SignUpClick);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 208);
            this.Controls.Add(this.btn_sign_up);
            this.Controls.Add(this.tbx_new_repeat_password);
            this.Controls.Add(this.lbl_new_repeat_password);
            this.Controls.Add(this.tbx_new_password);
            this.Controls.Add(this.tbx_new_username);
            this.Controls.Add(this.tbx_new_name);
            this.Controls.Add(this.lbl_new_password);
            this.Controls.Add(this.lbl_new_username);
            this.Controls.Add(this.lbl_new_name);
            this.Controls.Add(this.btn_sign_in);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btn_sign_in;
        private System.Windows.Forms.Label lbl_new_name;
        private System.Windows.Forms.Label lbl_new_username;
        private System.Windows.Forms.Label lbl_new_password;
        private System.Windows.Forms.TextBox tbx_new_name;
        private System.Windows.Forms.TextBox tbx_new_username;
        private System.Windows.Forms.TextBox tbx_new_password;
        private System.Windows.Forms.Label lbl_new_repeat_password;
        private System.Windows.Forms.TextBox tbx_new_repeat_password;
        private System.Windows.Forms.Button btn_sign_up;
    }
}