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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyApp));
            this.btn_predict = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_recurring_transactions = new System.Windows.Forms.Button();
            this.btn_transactions = new System.Windows.Forms.Button();
            this.bw_recurring = new System.ComponentModel.BackgroundWorker();
            this.btn_contacts = new System.Windows.Forms.Button();
            this.btn_event = new System.Windows.Forms.Button();
            this.btn_recurring_events = new System.Windows.Forms.Button();
            this.pl_left = new System.Windows.Forms.Panel();
            this.pl_right = new System.Windows.Forms.Panel();
            this.mc_calendar = new System.Windows.Forms.MonthCalendar();
            this.pl_middle = new System.Windows.Forms.Panel();
            this.pl_income = new System.Windows.Forms.Panel();
            this.lbl_income_amount = new System.Windows.Forms.Label();
            this.lbl_income = new System.Windows.Forms.Label();
            this.pl_expense = new System.Windows.Forms.Panel();
            this.lbl_expense_amount = new System.Windows.Forms.Label();
            this.lbl_expense = new System.Windows.Forms.Label();
            this.pl_graph = new System.Windows.Forms.Panel();
            this.cch_month = new LiveCharts.WinForms.CartesianChart();
            this.pl_left.SuspendLayout();
            this.pl_right.SuspendLayout();
            this.pl_middle.SuspendLayout();
            this.pl_income.SuspendLayout();
            this.pl_expense.SuspendLayout();
            this.pl_graph.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_predict
            // 
            this.btn_predict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_predict.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_predict.FlatAppearance.BorderSize = 0;
            this.btn_predict.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_predict.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_predict.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_predict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_predict.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_predict.ForeColor = System.Drawing.Color.White;
            this.btn_predict.Location = new System.Drawing.Point(0, 240);
            this.btn_predict.Margin = new System.Windows.Forms.Padding(0);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Size = new System.Drawing.Size(160, 40);
            this.btn_predict.TabIndex = 10;
            this.btn_predict.Text = "Predict";
            this.btn_predict.UseVisualStyleBackColor = false;
            this.btn_predict.Click += new System.EventHandler(this.PredictClick);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_report.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Location = new System.Drawing.Point(0, 200);
            this.btn_report.Margin = new System.Windows.Forms.Padding(0);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(160, 40);
            this.btn_report.TabIndex = 8;
            this.btn_report.Text = "Report";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.ReportClick);
            // 
            // btn_recurring_transactions
            // 
            this.btn_recurring_transactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_recurring_transactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_recurring_transactions.FlatAppearance.BorderSize = 0;
            this.btn_recurring_transactions.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_recurring_transactions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_recurring_transactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_recurring_transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recurring_transactions.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_recurring_transactions.ForeColor = System.Drawing.Color.White;
            this.btn_recurring_transactions.Location = new System.Drawing.Point(0, 120);
            this.btn_recurring_transactions.Margin = new System.Windows.Forms.Padding(0);
            this.btn_recurring_transactions.Name = "btn_recurring_transactions";
            this.btn_recurring_transactions.Size = new System.Drawing.Size(160, 40);
            this.btn_recurring_transactions.TabIndex = 2;
            this.btn_recurring_transactions.Text = "Recurring transactions";
            this.btn_recurring_transactions.UseVisualStyleBackColor = false;
            this.btn_recurring_transactions.Click += new System.EventHandler(this.RecurringTransactionsClick);
            // 
            // btn_transactions
            // 
            this.btn_transactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_transactions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_transactions.FlatAppearance.BorderSize = 0;
            this.btn_transactions.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_transactions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_transactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transactions.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_transactions.ForeColor = System.Drawing.Color.White;
            this.btn_transactions.Location = new System.Drawing.Point(0, 0);
            this.btn_transactions.Margin = new System.Windows.Forms.Padding(0);
            this.btn_transactions.Name = "btn_transactions";
            this.btn_transactions.Size = new System.Drawing.Size(160, 40);
            this.btn_transactions.TabIndex = 1;
            this.btn_transactions.Text = "Transactions";
            this.btn_transactions.UseVisualStyleBackColor = false;
            this.btn_transactions.Click += new System.EventHandler(this.TransactionsClick);
            // 
            // bw_recurring
            // 
            this.bw_recurring.WorkerReportsProgress = true;
            this.bw_recurring.WorkerSupportsCancellation = true;
            this.bw_recurring.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerDoWork);
            this.bw_recurring.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorkerProgressChanged);
            // 
            // btn_contacts
            // 
            this.btn_contacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_contacts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_contacts.FlatAppearance.BorderSize = 0;
            this.btn_contacts.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_contacts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_contacts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_contacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contacts.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_contacts.ForeColor = System.Drawing.Color.White;
            this.btn_contacts.Location = new System.Drawing.Point(0, 80);
            this.btn_contacts.Margin = new System.Windows.Forms.Padding(0);
            this.btn_contacts.Name = "btn_contacts";
            this.btn_contacts.Size = new System.Drawing.Size(160, 40);
            this.btn_contacts.TabIndex = 0;
            this.btn_contacts.Text = "Contacts";
            this.btn_contacts.UseVisualStyleBackColor = false;
            this.btn_contacts.Click += new System.EventHandler(this.ContactsClick);
            // 
            // btn_event
            // 
            this.btn_event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_event.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_event.FlatAppearance.BorderSize = 0;
            this.btn_event.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_event.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_event.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_event.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_event.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_event.ForeColor = System.Drawing.Color.White;
            this.btn_event.Location = new System.Drawing.Point(0, 40);
            this.btn_event.Margin = new System.Windows.Forms.Padding(0);
            this.btn_event.Name = "btn_event";
            this.btn_event.Size = new System.Drawing.Size(160, 40);
            this.btn_event.TabIndex = 11;
            this.btn_event.Text = "Events";
            this.btn_event.UseVisualStyleBackColor = false;
            this.btn_event.Click += new System.EventHandler(this.EventsClick);
            // 
            // btn_recurring_events
            // 
            this.btn_recurring_events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_recurring_events.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_recurring_events.FlatAppearance.BorderSize = 0;
            this.btn_recurring_events.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_recurring_events.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_recurring_events.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_recurring_events.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recurring_events.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_recurring_events.ForeColor = System.Drawing.Color.White;
            this.btn_recurring_events.Location = new System.Drawing.Point(0, 160);
            this.btn_recurring_events.Margin = new System.Windows.Forms.Padding(0);
            this.btn_recurring_events.Name = "btn_recurring_events";
            this.btn_recurring_events.Size = new System.Drawing.Size(160, 40);
            this.btn_recurring_events.TabIndex = 12;
            this.btn_recurring_events.Text = "Recurring events";
            this.btn_recurring_events.UseVisualStyleBackColor = false;
            this.btn_recurring_events.Click += new System.EventHandler(this.RecurringEventsClick);
            // 
            // pl_left
            // 
            this.pl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.pl_left.Controls.Add(this.btn_transactions);
            this.pl_left.Controls.Add(this.btn_recurring_events);
            this.pl_left.Controls.Add(this.btn_recurring_transactions);
            this.pl_left.Controls.Add(this.btn_event);
            this.pl_left.Controls.Add(this.btn_report);
            this.pl_left.Controls.Add(this.btn_predict);
            this.pl_left.Controls.Add(this.btn_contacts);
            this.pl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pl_left.Location = new System.Drawing.Point(0, 0);
            this.pl_left.Margin = new System.Windows.Forms.Padding(0);
            this.pl_left.Name = "pl_left";
            this.pl_left.Size = new System.Drawing.Size(160, 411);
            this.pl_left.TabIndex = 13;
            // 
            // pl_right
            // 
            this.pl_right.AutoScroll = true;
            this.pl_right.BackColor = System.Drawing.Color.White;
            this.pl_right.Controls.Add(this.mc_calendar);
            this.pl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pl_right.Location = new System.Drawing.Point(540, 0);
            this.pl_right.Name = "pl_right";
            this.pl_right.Size = new System.Drawing.Size(244, 411);
            this.pl_right.TabIndex = 14;
            // 
            // mc_calendar
            // 
            this.mc_calendar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mc_calendar.BackColor = System.Drawing.Color.White;
            this.mc_calendar.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mc_calendar.Location = new System.Drawing.Point(8, 9);
            this.mc_calendar.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.mc_calendar.MaxSelectionCount = 1;
            this.mc_calendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.mc_calendar.Name = "mc_calendar";
            this.mc_calendar.TabIndex = 0;
            this.mc_calendar.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.mc_calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.DashboardDateSelected);
            // 
            // pl_middle
            // 
            this.pl_middle.Controls.Add(this.pl_income);
            this.pl_middle.Controls.Add(this.pl_expense);
            this.pl_middle.Controls.Add(this.pl_graph);
            this.pl_middle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_middle.Location = new System.Drawing.Point(160, 0);
            this.pl_middle.Name = "pl_middle";
            this.pl_middle.Size = new System.Drawing.Size(380, 411);
            this.pl_middle.TabIndex = 15;
            // 
            // pl_income
            // 
            this.pl_income.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_income.BackColor = System.Drawing.Color.White;
            this.pl_income.Controls.Add(this.lbl_income_amount);
            this.pl_income.Controls.Add(this.lbl_income);
            this.pl_income.Location = new System.Drawing.Point(30, 30);
            this.pl_income.Name = "pl_income";
            this.pl_income.Size = new System.Drawing.Size(320, 50);
            this.pl_income.TabIndex = 2;
            // 
            // lbl_income_amount
            // 
            this.lbl_income_amount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_income_amount.AutoSize = true;
            this.lbl_income_amount.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_income_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.lbl_income_amount.Location = new System.Drawing.Point(217, 13);
            this.lbl_income_amount.Name = "lbl_income_amount";
            this.lbl_income_amount.Size = new System.Drawing.Size(87, 24);
            this.lbl_income_amount.TabIndex = 1;
            this.lbl_income_amount.Text = "Unknown";
            // 
            // lbl_income
            // 
            this.lbl_income.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_income.AutoSize = true;
            this.lbl_income.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_income.Location = new System.Drawing.Point(15, 16);
            this.lbl_income.Name = "lbl_income";
            this.lbl_income.Size = new System.Drawing.Size(65, 20);
            this.lbl_income.TabIndex = 0;
            this.lbl_income.Text = "Income:";
            // 
            // pl_expense
            // 
            this.pl_expense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_expense.BackColor = System.Drawing.Color.White;
            this.pl_expense.Controls.Add(this.lbl_expense_amount);
            this.pl_expense.Controls.Add(this.lbl_expense);
            this.pl_expense.Location = new System.Drawing.Point(30, 110);
            this.pl_expense.Name = "pl_expense";
            this.pl_expense.Size = new System.Drawing.Size(320, 50);
            this.pl_expense.TabIndex = 1;
            // 
            // lbl_expense_amount
            // 
            this.lbl_expense_amount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_expense_amount.AutoSize = true;
            this.lbl_expense_amount.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_expense_amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lbl_expense_amount.Location = new System.Drawing.Point(217, 13);
            this.lbl_expense_amount.Name = "lbl_expense_amount";
            this.lbl_expense_amount.Size = new System.Drawing.Size(87, 24);
            this.lbl_expense_amount.TabIndex = 3;
            this.lbl_expense_amount.Text = "Unknown";
            // 
            // lbl_expense
            // 
            this.lbl_expense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_expense.AutoSize = true;
            this.lbl_expense.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_expense.Location = new System.Drawing.Point(15, 16);
            this.lbl_expense.Name = "lbl_expense";
            this.lbl_expense.Size = new System.Drawing.Size(72, 20);
            this.lbl_expense.TabIndex = 2;
            this.lbl_expense.Text = "Expense:";
            // 
            // pl_graph
            // 
            this.pl_graph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pl_graph.BackColor = System.Drawing.Color.White;
            this.pl_graph.Controls.Add(this.cch_month);
            this.pl_graph.Location = new System.Drawing.Point(30, 190);
            this.pl_graph.Name = "pl_graph";
            this.pl_graph.Size = new System.Drawing.Size(320, 195);
            this.pl_graph.TabIndex = 0;
            // 
            // cch_month
            // 
            this.cch_month.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cch_month.Location = new System.Drawing.Point(0, 0);
            this.cch_month.Name = "cch_month";
            this.cch_month.Padding = new System.Windows.Forms.Padding(10);
            this.cch_month.Size = new System.Drawing.Size(320, 195);
            this.cch_month.TabIndex = 0;
            this.cch_month.Text = "cartesianChart1";
            // 
            // MoneyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.pl_middle);
            this.Controls.Add(this.pl_right);
            this.Controls.Add(this.pl_left);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "MoneyApp";
            this.Text = "Money App";
            this.Activated += new System.EventHandler(this.MoneyAppActivated);
            this.pl_left.ResumeLayout(false);
            this.pl_right.ResumeLayout(false);
            this.pl_middle.ResumeLayout(false);
            this.pl_income.ResumeLayout(false);
            this.pl_income.PerformLayout();
            this.pl_expense.ResumeLayout(false);
            this.pl_expense.PerformLayout();
            this.pl_graph.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_transactions;
        private Button btn_recurring_transactions;
        private Button btn_report;
        private Button btn_predict;
        private System.ComponentModel.BackgroundWorker bw_recurring;
        private Button btn_contacts;
        private Button btn_event;
        private Button btn_recurring_events;
        private Panel pl_left;
        private Panel pl_right;
        private MonthCalendar mc_calendar;
        private Panel pl_middle;
        private Panel pl_graph;
        private Panel pl_income;
        private Panel pl_expense;
        private Label lbl_income;
        private Label lbl_income_amount;
        private Label lbl_expense_amount;
        private Label lbl_expense;
        private LiveCharts.WinForms.CartesianChart cch_month;
    }
}

