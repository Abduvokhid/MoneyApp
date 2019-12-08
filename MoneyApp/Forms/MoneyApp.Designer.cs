using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
            this.panel = new System.Windows.Forms.Panel();
            this.btn_transactions = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
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
            this.btn_contacts.Click += new System.EventHandler(this.ContactsClick);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel.Controls.Add(this.btn_transactions);
            this.panel.Controls.Add(this.btn_contacts);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(799, 382);
            this.panel.TabIndex = 1;
            this.panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            this.panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
            this.panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
            // 
            // btn_transactions
            // 
            this.btn_transactions.Location = new System.Drawing.Point(215, 93);
            this.btn_transactions.Name = "btn_transactions";
            this.btn_transactions.Size = new System.Drawing.Size(83, 23);
            this.btn_transactions.TabIndex = 1;
            this.btn_transactions.Text = "Transactions";
            this.btn_transactions.UseVisualStyleBackColor = true;
            this.btn_transactions.Click += new System.EventHandler(this.TransactionsClick);
            this.btn_transactions.MouseLeave += new System.EventHandler(this.btn_transactions_MouseLeave);
            this.btn_transactions.MouseHover += new System.EventHandler(this.btn_transactions_MouseHover);
            // 
            // MoneyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 382);
            this.Controls.Add(this.panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoneyApp";
            this.Text = "Money App";
            this.Activated += new System.EventHandler(this.MoneyApp_Activated);
            this.SizeChanged += new System.EventHandler(this.MoneyApp_SizeChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMouseUp);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region Form move code
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImportAttribute("user32.dll")]
        public static extern bool SetCapture();
        #endregion

        private System.Windows.Forms.Button btn_contacts;
        private System.Windows.Forms.Button btn_transactions;
        private Panel panel;
    }
}

