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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_contacts
            // 
            this.btn_contacts.Location = new System.Drawing.Point(87, 35);
            this.btn_contacts.Name = "btn_contacts";
            this.btn_contacts.Size = new System.Drawing.Size(75, 23);
            this.btn_contacts.TabIndex = 0;
            this.btn_contacts.Text = "Contacts";
            this.btn_contacts.UseVisualStyleBackColor = true;
            this.btn_contacts.Click += new System.EventHandler(this.btn_contacts_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btn_contacts);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 563);
            this.panel1.TabIndex = 1;
            // 
            // MoneyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Name = "MoneyApp";
            this.Text = "Money App";
            this.Activated += new System.EventHandler(this.MoneyApp_Activated);
            this.SizeChanged += new System.EventHandler(this.MoneyApp_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_contacts;
        private System.Windows.Forms.Panel panel1;
    }
}

