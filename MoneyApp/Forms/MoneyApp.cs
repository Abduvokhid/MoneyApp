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
using LiveCharts.Wpf;
using LiveCharts;

namespace MoneyApp
{
    public partial class MoneyApp : Form
    {
        private bool isFirst = true;
        private bool isOpen = false;

        private int idleSeconds = 60;
        
        public MoneyApp()
        {
            InitializeComponent();
            Instances.MoneyApp = this;
            mc_calendar.MinDate = DateTime.Now.Date;
            mc_calendar.SelectionStart = DateTime.Now;
        }

        #region Auto log out methods
        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO Dummy);
        [DllImport("Kernel32.dll")]
        private static extern uint GetLastError();

        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }

        public static long GetLastInputTime()
        {
            LASTINPUTINFO LastUserAction = new LASTINPUTINFO();
            LastUserAction.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(LastUserAction);
            if (!GetLastInputInfo(ref LastUserAction))
            {
                throw new Exception(GetLastError().ToString());
            }

            return LastUserAction.dwTime;
        }

        public static uint GetIdleTime()
        {
            LASTINPUTINFO LastUserAction = new LASTINPUTINFO();
            LastUserAction.cbSize = (uint)System.Runtime.InteropServices.Marshal.SizeOf(LastUserAction);
            GetLastInputInfo(ref LastUserAction);
            return ((uint)Environment.TickCount - LastUserAction.dwTime);
        }

        private void LogOutTimerTick(object sender, EventArgs e)
        {
            if (GetIdleTime() > idleSeconds * 1000)
            {
                tm_auto_log_out.Enabled = false;
                bw_recurring.CancelAsync();
                Instances.User = null;
                Authorization auth = new Authorization();
                auth.Activate();
                auth.ShowDialog();
            }
        }
        #endregion
        
        private void MoneyAppActivated(object sender, EventArgs e)
        {
            //if (Instances.User == null) { Instances.User = new User { ID = 7, LastAccessDate = DateTime.Now, Name = "Abduvokhid" }; }
            if (Instances.User == null)
            {
                Authorization auth = new Authorization();
                auth.Activate();
                auth.ShowDialog();
            } else
            {
                btn_first_name.Text = Instances.User.Name;
                GenerateInfo();
                if (!tm_auto_log_out.Enabled) tm_auto_log_out.Enabled = true;
                if (!bw_recurring.IsBusy) bw_recurring.RunWorkerAsync();
                ShowEventsForDate(mc_calendar.SelectionStart);
            }
        }

        private void ContactsClick(object sender, EventArgs e)
        {
            ViewContacts contactsView = new ViewContacts();
            contactsView.Activate();
            contactsView.ShowDialog();
        }

        private void TransactionsClick(object sender, EventArgs e)
        {
            ViewTransactions transactionsView = new ViewTransactions();
            transactionsView.Activate();
            transactionsView.ShowDialog();
        }

        private void RecurringTransactionsClick(object sender, EventArgs e)
        {
            ViewTransactions transactionsView = new ViewTransactions(true);
            transactionsView.Activate();
            transactionsView.ShowDialog();
        }

        private void ReportClick(object sender, EventArgs e)
        {
            ViewReport viewReport = new ViewReport();
            viewReport.Activate();
            viewReport.ShowDialog();
        }

        private void PredictClick(object sender, EventArgs e)
        {
            ViewPrediction viewPrediction = new ViewPrediction();
            viewPrediction.Activate();
            viewPrediction.ShowDialog();
        }
        
        private void BackgroundWorkerDoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;
            while (!bw.CancellationPending)
            {
                if (Instances.User == null) continue;
                DoRecurringTransaction();
                if (Instances.User == null) continue;
                DoRecurringEvent();
                if (isFirst) isFirst = false;
                if (Instances.User == null) continue;
                Instances.User.LastAccessDate = DateTime.Now;
                UserRepository userRepository = UserRepository.Instance;
                if (Instances.User == null) continue;
                userRepository.EditLastAccessDate(Instances.User);
            }
        }

        private void BackgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!isFirst)
            {
                string text = (string)e.UserState;
                if (Instances.User == null) return;
                new Notification(text).Show();
            }
        }

        private void EventsClick(object sender, EventArgs e)
        {

            ViewEvents viewEvents = new ViewEvents();
            viewEvents.Activate();
            viewEvents.ShowDialog();
        }

        private void RecurringEventsClick(object sender, EventArgs e)
        {
            ViewEvents viewEvents = new ViewEvents(true);
            viewEvents.Activate();
            viewEvents.ShowDialog();
        }

        private void DashboardDateSelected(object sender, DateRangeEventArgs e)
        {
            ShowEventsForDate(mc_calendar.SelectionStart);
        }

        private async void DoRecurringTransaction()
        {
            TransactionRepository transactionRepository = TransactionRepository.Instance;
            RecurringTransactionRepository recurringTransactionRepository = RecurringTransactionRepository.Instance;
            if (Instances.User == null) return;
            List<RecurringTransaction> recurringTransactions = recurringTransactionRepository.GetUserTransactions(Instances.User.ID);
            foreach (RecurringTransaction recurringTransaction in recurringTransactions)
            {
                if (Instances.User == null) return;
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
                        if (Instances.User == null) return;
                        await Task.Run(() => transactionRepository.AddTransaction(new Transaction
                        {
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
            EventRepository transactionRepository = EventRepository.Instance;
            RecurringEventRepository recurringEventRepository = RecurringEventRepository.Instance;
            if (Instances.User == null) return;
            List<RecurringEvent> recurringEvents = recurringEventRepository.GetRecurringEvents(Instances.User.ID);
            foreach (RecurringEvent recurringEvent in recurringEvents)
            {
                if (Instances.User == null) return;
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
                        if (Instances.User == null) return;
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

        private void ShowEventsForDate(DateTime d)
        {
            pl_events.Controls.OfType<Panel>().ToList().ForEach(p => p.Dispose());

            pl_events.VerticalScroll.Maximum = 0;
            pl_events.AutoScroll = false;
            pl_events.HorizontalScroll.Maximum = 0;
            pl_events.HorizontalScroll.Visible = false;
            pl_events.AutoScroll = true;

            RecurringEventRepository recurringEventRepository = RecurringEventRepository.Instance;
            List<RecurringEvent> events = recurringEventRepository.GetRecurringEvents(Instances.User.ID);

            List<RecurringEvent> newList = new List<RecurringEvent>();

            events.ForEach(e =>
            {
                switch (e.Status)
                {
                    case "Daily":
                        newList.Add(e);
                        break;
                    case "Weekly":
                        if (e.CreatedDate.DayOfWeek == d.DayOfWeek) newList.Add(e);
                        break;
                    case "Monthly":
                        if (e.CreatedDate.Day == d.Day) newList.Add(e);
                        break;
                    case "Yearly":
                        if (e.CreatedDate.Month == d.Month && e.CreatedDate.Day == d.Day) newList.Add(e);
                        break;
                }
            });

            newList = newList.OrderBy(e => e.CreatedDate.TimeOfDay).ToList();

            if (newList.Count == 0) newList.Add(new RecurringEvent());

            int now = 0;

            newList.ForEach(e =>
            {
                Panel p = new Panel();
                p.Width = pl_events.Width;
                p.Height = 40;
                p.Location = new Point(0, now);
                now += p.Height;

                Label name = new Label();
                name.TextAlign = ContentAlignment.MiddleLeft;
                string nameText = "";
                if (e.ID > 0)
                {
                    nameText = e.Name;
                    if (e.Type) nameText += " at ";
                    else nameText += " by ";
                    nameText += e.CreatedDate.ToString("HH:mm");
                } else
                {
                    nameText = d.Date == DateTime.Now.Date ? "No events for today!" : "No events for this day!";
                    name.TextAlign = ContentAlignment.MiddleCenter;
                }
                name.Text = nameText;
                name.ForeColor = Color.FromArgb(109, 116, 129);
                name.Font = new Font("Roboto", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
                name.Location = new Point(0, 0);
                name.Size = new Size(p.Width, p.Height);
                name.Padding = new Padding(15, 0, 0, 0);
                p.Controls.Add(name);

                Panel b = new Panel();
                b.Width = p.Width;
                b.Height = 1;
                b.Location = new Point(0, 0);
                b.BackColor = Color.FromArgb(228, 232, 241);
                p.Controls.Add(b);
                b.BringToFront();

                pl_events.Controls.Add(p);
            });

            Panel line = new Panel();
            line.Width = pl_events.Width;
            line.Height = 1;
            line.Location = new Point(0, now);
            line.BackColor = Color.FromArgb(228, 232, 241);
            pl_events.Controls.Add(line);
            line.BringToFront();

        }

        private void GenerateInfo()
        {
            TransactionRepository transactionRepository = TransactionRepository.Instance;
            List<Transaction> transactions = transactionRepository.GetUserTransactions(Instances.User.ID);
            List<DateTime> dates = new List<DateTime>();
            List<decimal> totalIncomes = new List<decimal>();
            List<decimal> totalExpenses = new List<decimal>();
            for (int i = 0; i < DateTime.Now.Day; i++)
            {
                dates.Add(new DateTime(DateTime.Now.Year, DateTime.Now.Month, i + 1));
                totalIncomes.Add(0);
                totalExpenses.Add(0);
            }
            decimal income = 0;
            decimal expense = 0;
            transactions = transactions.Where(t => t.CreatedDate.Month == DateTime.Now.Month).ToList();
            transactions.ForEach(t =>
            {
                if (t.Type)
                {
                    income += t.Amount;
                    totalIncomes[t.CreatedDate.Day - 1] += t.Amount;
                }
                else
                {
                    expense += t.Amount;
                    totalExpenses[t.CreatedDate.Day - 1] += t.Amount;
                }
            });
            lbl_income_amount.Text = "£" + income.ToString("0.00");
            lbl_expense_amount.Text = "£" + expense.ToString("0.00");

            cch_month.Series = new LiveCharts.SeriesCollection
            {
                new LineSeries { Title = "Income", Values = new ChartValues<decimal>(totalIncomes)},
                new LineSeries { Title = "Expense", Values = new ChartValues<decimal>(totalExpenses)}
            };

            List<string> vs = new List<string>();
            foreach (DateTime d in dates)
            {
                vs.Add(d.Day.ToString());
            }

            cch_month.AxisX.Clear();

            cch_month.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = vs.ToArray()
            });
        }

        private void UserPanelMouseEnter(object sender, EventArgs e)
        {
            isOpen = true;
            Timer timer = new Timer();
            timer.Interval = 15;
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (isOpen)
            {
                if (pl_user.Top > pl_left.Height - 80)
                {
                    pl_user.Top -= 5;
                } else
                {
                    Timer timer = (Timer)sender;
                    timer.Stop();
                }
            } else
            {
                if (pl_user.Top < pl_left.Height - 40)
                {
                    pl_user.Top += 5;
                } else
                {
                    Timer timer = (Timer)sender;
                    timer.Stop();
                }
            }
        }

        private void UserPanelMouseLeave(object sender, EventArgs e)
        {
            isOpen = false;
            Timer timer = new Timer();
            timer.Interval = 10;
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void LogOutClick(object sender, EventArgs e)
        {
            bw_recurring.CancelAsync();
            Instances.User = null;
            Authorization auth = new Authorization();
            auth.Activate();
            auth.ShowDialog();
        }

        private void FormSizeChanged(object sender, EventArgs e)
        {
            pl_events.VerticalScroll.Maximum = 0;
            pl_events.AutoScroll = false;
            pl_events.HorizontalScroll.Maximum = 0;
            pl_events.HorizontalScroll.Visible = false;
            pl_events.AutoScroll = true;
        }
    }
}
