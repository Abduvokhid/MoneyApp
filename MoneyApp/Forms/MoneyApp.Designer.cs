namespace MoneyApp
{
    partial class MoneyApp
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
            this.btn_contacts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_contacts
            // 
            this.btn_contacts.Location = new System.Drawing.Point(151, 82);
            this.btn_contacts.Name = "btn_contacts";
            this.btn_contacts.Size = new System.Drawing.Size(75, 23);
            this.btn_contacts.TabIndex = 0;
            this.btn_contacts.Text = "Contacts";
            this.btn_contacts.UseVisualStyleBackColor = true;
            this.btn_contacts.Click += new System.EventHandler(this.btn_contacts_Click);
            // 
            // MoneyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_contacts);
            this.Name = "MoneyApp";
            this.Text = "Money App";
            this.Activated += new System.EventHandler(this.MoneyApp_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_contacts;
    }
}

