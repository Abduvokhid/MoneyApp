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
            this.btn_recurring_events = new System.Windows.Forms.Button();
            this.btn_event = new System.Windows.Forms.Button();
            this.btn_predict = new System.Windows.Forms.Button();
            this.pl_menu = new System.Windows.Forms.Panel();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_recurring_transactions = new System.Windows.Forms.Button();
            this.btn_transactions = new System.Windows.Forms.Button();
            this.bw_recurring = new System.ComponentModel.BackgroundWorker();
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
            this.panel.Controls.Add(this.btn_recurring_events);
            this.panel.Controls.Add(this.btn_event);
            this.panel.Controls.Add(this.btn_predict);
            this.panel.Controls.Add(this.pl_menu);
            this.panel.Controls.Add(this.btn_report);
            this.panel.Controls.Add(this.btn_all);
            this.panel.Controls.Add(this.btn_right);
            this.panel.Controls.Add(this.btn_left);
            this.panel.Controls.Add(this.btn_up);
            this.panel.Controls.Add(this.btn_down);
            this.panel.Controls.Add(this.btn_recurring_transactions);
            this.panel.Controls.Add(this.btn_transactions);
            this.panel.Controls.Add(this.btn_contacts);
            this.panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(727, 382);
            this.panel.TabIndex = 1;
            // 
            // btn_recurring_events
            // 
            this.btn_recurring_events.Location = new System.Drawing.Point(51, 148);
            this.btn_recurring_events.Name = "btn_recurring_events";
            this.btn_recurring_events.Size = new System.Drawing.Size(75, 23);
            this.btn_recurring_events.TabIndex = 12;
            this.btn_recurring_events.Text = "Recurring events";
            this.btn_recurring_events.UseVisualStyleBackColor = true;
            this.btn_recurring_events.Click += new System.EventHandler(this.btn_recurring_events_Click);
            // 
            // btn_event
            // 
            this.btn_event.Location = new System.Drawing.Point(71, 92);
            this.btn_event.Name = "btn_event";
            this.btn_event.Size = new System.Drawing.Size(75, 23);
            this.btn_event.TabIndex = 11;
            this.btn_event.Text = "Events";
            this.btn_event.UseVisualStyleBackColor = true;
            this.btn_event.Click += new System.EventHandler(this.btn_event_Click);
            // 
            // btn_predict
            // 
            this.btn_predict.Location = new System.Drawing.Point(215, 199);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Size = new System.Drawing.Size(75, 23);
            this.btn_predict.TabIndex = 10;
            this.btn_predict.Text = "Predict";
            this.btn_predict.UseVisualStyleBackColor = true;
            this.btn_predict.Click += new System.EventHandler(this.btn_predict_Click);
            // 
            // pl_menu
            // 
            this.pl_menu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pl_menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pl_menu.Location = new System.Drawing.Point(0, 342);
            this.pl_menu.Name = "pl_menu";
            this.pl_menu.Size = new System.Drawing.Size(727, 40);
            this.pl_menu.TabIndex = 9;
            // 
            // btn_report
            // 
            this.btn_report.Location = new System.Drawing.Point(215, 170);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(75, 23);
            this.btn_report.TabIndex = 8;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.ReportClick);
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(592, 177);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(135, 23);
            this.btn_all.TabIndex = 7;
            this.btn_all.Text = ".";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllMouseDown);
            this.btn_all.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AllMouseMove);
            this.btn_all.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AllMouseUp);
            // 
            // btn_right
            // 
            this.btn_right.Location = new System.Drawing.Point(592, 96);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(23, 75);
            this.btn_right.TabIndex = 6;
            this.btn_right.Text = ">";
            this.btn_right.UseVisualStyleBackColor = true;
            this.btn_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RightMouseDown);
            this.btn_right.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RightMouseMove);
            this.btn_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RightMouseUp);
            // 
            // btn_left
            // 
            this.btn_left.Location = new System.Drawing.Point(482, 96);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(23, 75);
            this.btn_left.TabIndex = 5;
            this.btn_left.Text = "<";
            this.btn_left.UseVisualStyleBackColor = true;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(511, 93);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(75, 23);
            this.btn_up.TabIndex = 4;
            this.btn_up.Text = "/\\";
            this.btn_up.UseVisualStyleBackColor = true;
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(511, 148);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(75, 23);
            this.btn_down.TabIndex = 3;
            this.btn_down.Text = "\\/";
            this.btn_down.UseVisualStyleBackColor = true;
            // 
            // btn_recurring_transactions
            // 
            this.btn_recurring_transactions.Location = new System.Drawing.Point(215, 122);
            this.btn_recurring_transactions.Name = "btn_recurring_transactions";
            this.btn_recurring_transactions.Size = new System.Drawing.Size(141, 23);
            this.btn_recurring_transactions.TabIndex = 2;
            this.btn_recurring_transactions.Text = "Recurring transactions";
            this.btn_recurring_transactions.UseVisualStyleBackColor = true;
            this.btn_recurring_transactions.Click += new System.EventHandler(this.btn_recurring_transactions_Click);
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
            // bw_recurring
            // 
            this.bw_recurring.WorkerReportsProgress = true;
            this.bw_recurring.WorkerSupportsCancellation = true;
            this.bw_recurring.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_recurring_DoWork);
            this.bw_recurring.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bw_recurring_ProgressChanged);
            // 
            // MoneyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(831, 382);
            this.Controls.Add(this.panel);
            this.Name = "MoneyApp";
            this.Text = "Money App";
            this.Activated += new System.EventHandler(this.MoneyApp_Activated);
            this.SizeChanged += new System.EventHandler(this.MoneyApp_SizeChanged);
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
        #endregion

        private System.Windows.Forms.Button btn_contacts;
        private System.Windows.Forms.Button btn_transactions;
        private Panel panel;
        private Button btn_recurring_transactions;
        private Button btn_right;
        private Button btn_left;
        private Button btn_up;
        private Button btn_down;
        private Button btn_all;
        private Button btn_report;
        private Panel pl_menu;
        private Button btn_predict;
        private System.ComponentModel.BackgroundWorker bw_recurring;
        private Button btn_recurring_events;
        private Button btn_event;
    }
}

