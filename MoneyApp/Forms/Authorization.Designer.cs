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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_sign_in = new System.Windows.Forms.Button();
            this.pl_sign_in = new System.Windows.Forms.Panel();
            this.lbl_sign_in_title = new System.Windows.Forms.Label();
            this.tbx_username = new MoneyAppControls.TextBox();
            this.tbx_password = new MoneyAppControls.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_sign_up = new System.Windows.Forms.Button();
            this.lbl_new_validate_password = new System.Windows.Forms.Label();
            this.lbl_new_password = new System.Windows.Forms.Label();
            this.tbx_new_validate_password = new MoneyAppControls.TextBox();
            this.tbx_new_password = new MoneyAppControls.TextBox();
            this.lbl_new_name = new System.Windows.Forms.Label();
            this.lbl_new_username = new System.Windows.Forms.Label();
            this.tbx_new_name = new MoneyAppControls.TextBox();
            this.tbx_new_username = new MoneyAppControls.TextBox();
            this.lbl_sign_up_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pl_sign_in.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_username.Location = new System.Drawing.Point(22, 50);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(68, 15);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_password.Location = new System.Drawing.Point(168, 50);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(67, 15);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "Password:";
            // 
            // btn_sign_in
            // 
            this.btn_sign_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_sign_in.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_sign_in.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_sign_in.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign_in.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sign_in.ForeColor = System.Drawing.Color.White;
            this.btn_sign_in.Location = new System.Drawing.Point(25, 108);
            this.btn_sign_in.Name = "btn_sign_in";
            this.btn_sign_in.Size = new System.Drawing.Size(286, 34);
            this.btn_sign_in.TabIndex = 4;
            this.btn_sign_in.Text = "Sign in";
            this.btn_sign_in.UseVisualStyleBackColor = false;
            this.btn_sign_in.Click += new System.EventHandler(this.SignInClick);
            // 
            // pl_sign_in
            // 
            this.pl_sign_in.BackColor = System.Drawing.Color.White;
            this.pl_sign_in.Controls.Add(this.lbl_sign_in_title);
            this.pl_sign_in.Controls.Add(this.tbx_username);
            this.pl_sign_in.Controls.Add(this.btn_sign_in);
            this.pl_sign_in.Controls.Add(this.lbl_username);
            this.pl_sign_in.Controls.Add(this.tbx_password);
            this.pl_sign_in.Controls.Add(this.lbl_password);
            this.pl_sign_in.Location = new System.Drawing.Point(20, 20);
            this.pl_sign_in.Name = "pl_sign_in";
            this.pl_sign_in.Size = new System.Drawing.Size(334, 167);
            this.pl_sign_in.TabIndex = 14;
            // 
            // lbl_sign_in_title
            // 
            this.lbl_sign_in_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_sign_in_title.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sign_in_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_sign_in_title.Name = "lbl_sign_in_title";
            this.lbl_sign_in_title.Size = new System.Drawing.Size(334, 40);
            this.lbl_sign_in_title.TabIndex = 5;
            this.lbl_sign_in_title.Text = "Sign In";
            this.lbl_sign_in_title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbx_username
            // 
            this.tbx_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.tbx_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.tbx_username.Location = new System.Drawing.Point(25, 68);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Padding = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.tbx_username.Size = new System.Drawing.Size(140, 34);
            this.tbx_username.Status = MoneyAppControls.TextBox.BoxStatus.None;
            this.tbx_username.TabIndex = 1;
            this.tbx_username.UseSystemPasswordChar = false;
            // 
            // tbx_password
            // 
            this.tbx_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.tbx_password.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.tbx_password.Location = new System.Drawing.Point(171, 68);
            this.tbx_password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Padding = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.tbx_password.Size = new System.Drawing.Size(140, 34);
            this.tbx_password.Status = MoneyAppControls.TextBox.BoxStatus.None;
            this.tbx_password.TabIndex = 2;
            this.tbx_password.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_sign_up);
            this.panel1.Controls.Add(this.lbl_new_validate_password);
            this.panel1.Controls.Add(this.lbl_new_password);
            this.panel1.Controls.Add(this.tbx_new_validate_password);
            this.panel1.Controls.Add(this.tbx_new_password);
            this.panel1.Controls.Add(this.lbl_new_name);
            this.panel1.Controls.Add(this.lbl_new_username);
            this.panel1.Controls.Add(this.tbx_new_name);
            this.panel1.Controls.Add(this.tbx_new_username);
            this.panel1.Controls.Add(this.lbl_sign_up_title);
            this.panel1.Location = new System.Drawing.Point(20, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 218);
            this.panel1.TabIndex = 15;
            // 
            // btn_sign_up
            // 
            this.btn_sign_up.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_sign_up.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_sign_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_sign_up.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_sign_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign_up.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sign_up.ForeColor = System.Drawing.Color.White;
            this.btn_sign_up.Location = new System.Drawing.Point(25, 162);
            this.btn_sign_up.Name = "btn_sign_up";
            this.btn_sign_up.Size = new System.Drawing.Size(286, 34);
            this.btn_sign_up.TabIndex = 9;
            this.btn_sign_up.Text = "Sign up";
            this.btn_sign_up.UseVisualStyleBackColor = false;
            this.btn_sign_up.Click += new System.EventHandler(this.SignUpClick);
            // 
            // lbl_new_validate_password
            // 
            this.lbl_new_validate_password.AutoSize = true;
            this.lbl_new_validate_password.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_new_validate_password.Location = new System.Drawing.Point(168, 104);
            this.lbl_new_validate_password.Name = "lbl_new_validate_password";
            this.lbl_new_validate_password.Size = new System.Drawing.Size(115, 15);
            this.lbl_new_validate_password.TabIndex = 8;
            this.lbl_new_validate_password.Text = "Validate password:";
            // 
            // lbl_new_password
            // 
            this.lbl_new_password.AutoSize = true;
            this.lbl_new_password.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_new_password.Location = new System.Drawing.Point(22, 104);
            this.lbl_new_password.Name = "lbl_new_password";
            this.lbl_new_password.Size = new System.Drawing.Size(67, 15);
            this.lbl_new_password.TabIndex = 7;
            this.lbl_new_password.Text = "Password:";
            // 
            // tbx_new_validate_password
            // 
            this.tbx_new_validate_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.tbx_new_validate_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.tbx_new_validate_password.Location = new System.Drawing.Point(171, 122);
            this.tbx_new_validate_password.Name = "tbx_new_validate_password";
            this.tbx_new_validate_password.Padding = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.tbx_new_validate_password.Size = new System.Drawing.Size(140, 34);
            this.tbx_new_validate_password.Status = MoneyAppControls.TextBox.BoxStatus.None;
            this.tbx_new_validate_password.TabIndex = 6;
            this.tbx_new_validate_password.UseSystemPasswordChar = true;
            // 
            // tbx_new_password
            // 
            this.tbx_new_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.tbx_new_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.tbx_new_password.Location = new System.Drawing.Point(25, 122);
            this.tbx_new_password.Name = "tbx_new_password";
            this.tbx_new_password.Padding = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.tbx_new_password.Size = new System.Drawing.Size(140, 34);
            this.tbx_new_password.Status = MoneyAppControls.TextBox.BoxStatus.None;
            this.tbx_new_password.TabIndex = 5;
            this.tbx_new_password.UseSystemPasswordChar = true;
            // 
            // lbl_new_name
            // 
            this.lbl_new_name.AutoSize = true;
            this.lbl_new_name.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_new_name.Location = new System.Drawing.Point(168, 47);
            this.lbl_new_name.Name = "lbl_new_name";
            this.lbl_new_name.Size = new System.Drawing.Size(44, 15);
            this.lbl_new_name.TabIndex = 4;
            this.lbl_new_name.Text = "Name:";
            // 
            // lbl_new_username
            // 
            this.lbl_new_username.AutoSize = true;
            this.lbl_new_username.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_new_username.Location = new System.Drawing.Point(22, 47);
            this.lbl_new_username.Name = "lbl_new_username";
            this.lbl_new_username.Size = new System.Drawing.Size(68, 15);
            this.lbl_new_username.TabIndex = 3;
            this.lbl_new_username.Text = "Username:";
            // 
            // tbx_new_name
            // 
            this.tbx_new_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.tbx_new_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.tbx_new_name.Location = new System.Drawing.Point(171, 65);
            this.tbx_new_name.Name = "tbx_new_name";
            this.tbx_new_name.Padding = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.tbx_new_name.Size = new System.Drawing.Size(140, 34);
            this.tbx_new_name.Status = MoneyAppControls.TextBox.BoxStatus.None;
            this.tbx_new_name.TabIndex = 2;
            this.tbx_new_name.UseSystemPasswordChar = false;
            // 
            // tbx_new_username
            // 
            this.tbx_new_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.tbx_new_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.tbx_new_username.Location = new System.Drawing.Point(25, 65);
            this.tbx_new_username.Name = "tbx_new_username";
            this.tbx_new_username.Padding = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.tbx_new_username.Size = new System.Drawing.Size(140, 34);
            this.tbx_new_username.Status = MoneyAppControls.TextBox.BoxStatus.None;
            this.tbx_new_username.TabIndex = 1;
            this.tbx_new_username.UseSystemPasswordChar = false;
            // 
            // lbl_sign_up_title
            // 
            this.lbl_sign_up_title.BackColor = System.Drawing.Color.White;
            this.lbl_sign_up_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_sign_up_title.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sign_up_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_sign_up_title.Name = "lbl_sign_up_title";
            this.lbl_sign_up_title.Size = new System.Drawing.Size(334, 40);
            this.lbl_sign_up_title.TabIndex = 0;
            this.lbl_sign_up_title.Text = "Sign Up";
            this.lbl_sign_up_title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(146)))), ((int)(((byte)(162)))));
            this.panel2.Location = new System.Drawing.Point(20, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 1);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(146)))), ((int)(((byte)(162)))));
            this.label1.Location = new System.Drawing.Point(178, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 14);
            this.label1.TabIndex = 17;
            this.label1.Text = "OR";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(375, 454);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pl_sign_in);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.Text = "Money App - Sign In / Sign Up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthorizationFormClosed);
            this.pl_sign_in.ResumeLayout(false);
            this.pl_sign_in.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_sign_in;
        private System.Windows.Forms.Panel pl_sign_in;
        private MoneyAppControls.TextBox tbx_password;
        private MoneyAppControls.TextBox tbx_username;
        private System.Windows.Forms.Label lbl_sign_in_title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_sign_up_title;
        private MoneyAppControls.TextBox tbx_new_name;
        private MoneyAppControls.TextBox tbx_new_username;
        private System.Windows.Forms.Label lbl_new_username;
        private System.Windows.Forms.Label lbl_new_name;
        private MoneyAppControls.TextBox tbx_new_validate_password;
        private MoneyAppControls.TextBox tbx_new_password;
        private System.Windows.Forms.Label lbl_new_validate_password;
        private System.Windows.Forms.Label lbl_new_password;
        private System.Windows.Forms.Button btn_sign_up;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}