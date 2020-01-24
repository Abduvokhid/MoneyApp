namespace MoneyApp.Forms
{
    partial class AddEditContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditContact));
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_action = new System.Windows.Forms.Button();
            this.tbx_name = new MoneyAppControls.TextBox();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.Location = new System.Drawing.Point(9, 6);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 15);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // btn_action
            // 
            this.btn_action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_action.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_action.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_action.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_action.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_action.ForeColor = System.Drawing.Color.White;
            this.btn_action.Location = new System.Drawing.Point(198, 24);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(100, 34);
            this.btn_action.TabIndex = 2;
            this.btn_action.Text = "Action";
            this.btn_action.UseVisualStyleBackColor = false;
            // 
            // tbx_name
            // 
            this.tbx_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.tbx_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(198)))), ((int)(((byte)(205)))));
            this.tbx_name.Location = new System.Drawing.Point(12, 24);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Padding = new System.Windows.Forms.Padding(10, 10, 10, 8);
            this.tbx_name.Size = new System.Drawing.Size(180, 34);
            this.tbx_name.Status = MoneyAppControls.TextBox.BoxStatus.None;
            this.tbx_name.TabIndex = 1;
            this.tbx_name.UseSystemPasswordChar = false;
            // 
            // AddEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(310, 69);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditContact";
            this.Text = "AddEditContact";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddEditContactFormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_action;
        private MoneyAppControls.TextBox tbx_name;
    }
}