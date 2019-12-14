using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyApp.Forms;
using MoneyApp.Models;
using MoneyApp.Repositories;
using System.Runtime.InteropServices;
using System.Threading;
using Tulpep.NotificationWindow;

namespace MoneyApp
{
    public partial class MoneyApp : Form
    {
        private bool isTagged = false;
        private bool isFirst = true;

        //private PictureBox pb;
        //Bitmap bmp;
        public MoneyApp()
        {
            InitializeComponent();
            Instances.MoneyApp = this;
            /*pb = new PictureBox();
            panel.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;*/
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            SetPanelSize();
            SetMenu();
        }

        private void MoneyApp_Activated(object sender, EventArgs e)
        {
            if (Instances.User == null)
            {
                Instances.User = new User { ID = 7, Name = "Abdu", Username = "Abduvokhid", LastAccessDate = DateTime.Now.AddDays(-99).AddHours(5) };
            }
            if (Instances.User == null)
            {
                Authorization auth = new Authorization();
                auth.Activate();
                auth.Show();
            } else
            {
                if (!bw_recurring.IsBusy) bw_recurring.RunWorkerAsync();
            }
        }

        #region All shit is here
        private void SetMenu()
        {
            int width = pl_menu.Width / 5;
            int width_last = pl_menu.Width - (width * 4);

            Button transactions = new Button();
            transactions.Width = width;
            transactions.BackColor = pl_menu.BackColor;
            transactions.Text = "Transactions";
            transactions.Height = 40;
            transactions.FlatStyle = FlatStyle.Flat;
            transactions.Location = new Point(0,0);
            pl_menu.Controls.Add(transactions);

            Button events = new Button();
            events.Width = width;
            events.BackColor = pl_menu.BackColor;
            events.Text = "Events";
            events.FlatStyle = FlatStyle.Flat;
            events.Height = 40;
            events.Location = new Point(transactions.Location.X + transactions.Width, 0);
            pl_menu.Controls.Add(events);

            Button contacts = new Button();
            contacts.Width = width;
            contacts.BackColor = pl_menu.BackColor;
            contacts.Text = "Contacts";
            contacts.FlatStyle = FlatStyle.Flat;
            contacts.Height = 40;
            contacts.Location = new Point(events.Location.X + events.Width, 0);
            pl_menu.Controls.Add(contacts);

            Button reports = new Button();
            reports.Width = width;
            reports.BackColor = pl_menu.BackColor;
            reports.Text = "Reports";
            reports.FlatStyle = FlatStyle.Flat;
            reports.Height = 40;
            reports.Location = new Point(contacts.Location.X + contacts.Width, 0);
            pl_menu.Controls.Add(reports);

            Button settings = new Button();
            settings.Width = width_last;
            settings.BackColor = pl_menu.BackColor;
            settings.Text = "Settings";
            settings.FlatStyle = FlatStyle.Flat;
            settings.Height = 40;
            settings.Location = new Point(reports.Location.X + reports.Width, 0);
            pl_menu.Controls.Add(settings);


        }


        private void Blur()
        {
            /*bmp = Screenshot.TakeSnapshot(panel);
            BitmapFilter.GaussianBlur(bmp, 1);
            
            pb.Image = bmp;
            pb.BringToFront();*/
        }

        public void UnBlur()
        {
            /*pb.Image = null;
            pb.SendToBack();
            bmp.Dispose();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();*/
        }

        private void MoneyApp_SizeChanged(object sender, EventArgs e)
        {
            SetPanelSize();
        }

        private void SetPanelSize()
        {
           panel.Size = new Size(Width, Height - 20);
        }

        private void ContactsClick(object sender, EventArgs e)
        {
            Blur();
            ViewContacts contactsView = new ViewContacts();
            contactsView.Activate();
            contactsView.Show();
        }

        private void TransactionsClick(object sender, EventArgs e)
        {
            //Blur();
            ViewTransactions transactionsView = new ViewTransactions();
            transactionsView.Activate();
            transactionsView.Show();
        }

        private void btn_transactions_MouseHover(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Padding = new Padding(5);
            label.AutoSize = false;
            label.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc volutpat hendrerit consectetur. Cras dapibus ipsum eu nibh venenatis, sed interdum sem efficitur. Vivamus fermentum auctor sodales nullam.";
            label.Width = 250;
            int a = label.Text.Length * 6 / 260;
            label.Height += a * 13;
            btn_transactions.Tag = label;
            label.Location = new Point(btn_transactions.Location.X + btn_transactions.Width + 5, btn_transactions.Location.Y + (btn_transactions.Height / 2) - (label.Height / 2));
            label.BringToFront();
            label.BackColor = Color.White;
            label.ForeColor = Color.Black;
            label.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(label);
            isTagged = true;
        }

        private void btn_transactions_MouseLeave(object sender, EventArgs e)
        {
            if (isTagged) ((Label)btn_transactions.Tag).Dispose();
        }

        private void btn_recurring_transactions_Click(object sender, EventArgs e)
        {
            ViewTransactions transactionsView = new ViewTransactions(true);
            transactionsView.Activate();
            transactionsView.Show();
        }

        private bool move = false;
        private Point startPoint;
        private void RightMouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            startPoint = MousePosition;
        }

        private void RightMouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                Point nowPoint = MousePosition;
                int o = startPoint.X;
                int n = nowPoint.X;
                int t = n - o;
                Size = new Size(Width + t, Height);
                startPoint = nowPoint;
            }
        }

        private void RightMouseUp(object sender, MouseEventArgs e)
        {
            if (move) move = false;
        }

        private void AllMouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            startPoint = MousePosition;
        }

        private void AllMouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                Point nowPoint = MousePosition;
                int Xo = startPoint.X;
                int Xn = nowPoint.X;
                int Xt = Xn - Xo;
                int Yo = startPoint.Y;
                int Yn = nowPoint.Y;
                int Yt = Yn - Yo;
                Size = new Size(Width + Xt, Height + Yt);
                startPoint = nowPoint;
            }
        }

        private void AllMouseUp(object sender, MouseEventArgs e)
        {
            if (move) move = false;
        }

        private void ReportClick(object sender, EventArgs e)
        {
            ViewReport viewReport = new ViewReport();
            viewReport.Activate();
            viewReport.Show();
        }

        private void btn_predict_Click(object sender, EventArgs e)
        {
            ViewPrediction viewPrediction = new ViewPrediction();
            viewPrediction.Activate();
            viewPrediction.Show();
        }

        #endregion

        private void bw_recurring_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;
            while (!bw.CancellationPending)
            {
                DoRecurringTransaction();
                DoRecurringEvent();
                if (isFirst) isFirst = false;
                Instances.User.LastAccessDate = DateTime.Now;
                UserRepository.Instance().EditLastAccessDate(Instances.User);
            }
        }

        private async void DoRecurringTransaction()
        {
            TransactionRepository transactionRepository = TransactionRepository.Instance();
            RecurringTransactionRepository recurringTransactionRepository = RecurringTransactionRepository.Instance();
            List<RecurringTransaction> recurringTransactions = recurringTransactionRepository.GetUserTransactions(Instances.User.ID);
            foreach(RecurringTransaction recurringTransaction in recurringTransactions)
            {
                if (DateTime.Now > recurringTransaction.EndDate && recurringTransaction.EndDate != DateTime.MinValue) continue;
                DateTime accTime = Instances.User.LastAccessDate;
                DateTime nowTime = DateTime.Now;
                int days = (nowTime - accTime).Days;
                DateTime recTime = Instances.User.LastAccessDate;
                TimeSpan ts = new TimeSpan(
                    recurringTransaction.CreatedDate.Hour, 
                    recurringTransaction.CreatedDate.Minute, 
                    recurringTransaction.CreatedDate.Second
                    );
                recTime = recTime.Date + ts;
                for (int i = 0; i <= days; i++)
                {
                    if (recurringTransaction.Status.Equals("Weekly"))
                    {
                        if (recTime.DayOfWeek != recurringTransaction.CreatedDate.DayOfWeek)
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (recurringTransaction.Status.Equals("Monthly"))
                    {
                        if (recTime.Day != recurringTransaction.CreatedDate.Day)
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (recurringTransaction.Status.Equals("Yearly"))
                    {
                        string recTimeString = recTime.ToString("dd/MM");
                        string createdDateString = recurringTransaction.CreatedDate.ToString("dd/MM");
                        if (!recTimeString.Equals(createdDateString))
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (recTime > accTime && recTime <= nowTime && recTime > recurringTransaction.CreatedDate)
                    {
                        await Task.Run(() => transactionRepository.AddTransaction(new Transaction {
                            Name = recurringTransaction.Name,
                            UserID = recurringTransaction.UserID,
                            ContactID = recurringTransaction.ContactID,
                            Type = recurringTransaction.Type,
                            Amount = recurringTransaction.Amount,
                            Note = recurringTransaction.Note,
                            CreatedDate = recTime
                        }));
                        bw_recurring.ReportProgress(1, "New transaction has been added!");
                    }
                    recTime = recTime.AddDays(1);
                }
            }
        }

        private async void DoRecurringEvent()
        {
            EventRepository transactionRepository = EventRepository.Instance();
            RecurringEventRepository recurringEventRepository = RecurringEventRepository.Instance();
            List<RecurringEvent> recurringEvents = recurringEventRepository.GetRecEvents(Instances.User.ID);
            foreach (RecurringEvent recurringEvent in recurringEvents)
            {
                if (DateTime.Now > recurringEvent.EndDate && recurringEvent.EndDate != DateTime.MinValue) continue;
                DateTime accTime = Instances.User.LastAccessDate;
                DateTime nowTime = DateTime.Now;
                int days = (nowTime - accTime).Days;
                DateTime recTime = Instances.User.LastAccessDate;
                TimeSpan ts = new TimeSpan(
                    recurringEvent.CreatedDate.Hour,
                    recurringEvent.CreatedDate.Minute,
                    recurringEvent.CreatedDate.Second
                    );
                recTime = recTime.Date + ts;
                for (int i = 0; i <= days; i++)
                {
                    if (recurringEvent.Status.Equals("Weekly"))
                    {
                        if (recTime.DayOfWeek != recurringEvent.CreatedDate.DayOfWeek)
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (recurringEvent.Status.Equals("Monthly"))
                    {
                        if (recTime.Day != recurringEvent.CreatedDate.Day)
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (recurringEvent.Status.Equals("Yearly"))
                    {
                        string recTimeString = recTime.ToString("dd/MM");
                        string createdDateString = recurringEvent.CreatedDate.ToString("dd/MM");
                        if (!recTimeString.Equals(createdDateString))
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (recTime > accTime && recTime <= nowTime && recTime > recurringEvent.CreatedDate)
                    {
                        await Task.Run(() => transactionRepository.AddEvent(new Event
                        {
                            Name = recurringEvent.Name,
                            UserID = recurringEvent.UserID,
                            ContactID = recurringEvent.ContactID,
                            Type = recurringEvent.Type,
                            Location = recurringEvent.Location,
                            Note = recurringEvent.Note,
                            CreatedDate = recTime
                        }));
                        bw_recurring.ReportProgress(1, "New event has been added!");
                    }
                    recTime = recTime.AddDays(1);
                }
            }
        }


        private void bw_recurring_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!isFirst)
            {
                string text = (string)e.UserState;
                new Notification(text).Show();
            }
        }

        private void btn_event_Click(object sender, EventArgs e)
        {

            ViewEvents viewEvents = new ViewEvents();
            viewEvents.Activate();
            viewEvents.Show();
        }

        private void btn_recurring_events_Click(object sender, EventArgs e)
        {
            ViewEvents viewEvents = new ViewEvents(true);
            viewEvents.Activate();
            viewEvents.Show();
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            AddEditTransaction viewEvents = new AddEditTransaction();
            viewEvents.Activate();
            viewEvents.Show();
        }
    }
}
