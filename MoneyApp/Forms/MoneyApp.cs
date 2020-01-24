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
using LiveCharts.Wpf;
using LiveCharts;

namespace MoneyApp
{
    public partial class MoneyApp : Form
    {
        private bool isFirst = true;

        public MoneyApp()
        {
            InitializeComponent();
            Instances.MoneyApp = this;
            mc_calendar.MinDate = DateTime.Now.Date;
            mc_calendar.SelectionStart = DateTime.Now;
        }

        private void MoneyAppActivated(object sender, EventArgs e)
        {
            if (Instances.User == null)
            {
                Authorization auth = new Authorization();
                auth.Activate();
                auth.Show();
            } else
            {
                GenerateInfo();
                if (!bw_recurring.IsBusy) bw_recurring.RunWorkerAsync();
            }
        }

        private void ContactsClick(object sender, EventArgs e)
        {
            ViewContacts contactsView = new ViewContacts();
            contactsView.Activate();
            contactsView.Show();
        }

        private void TransactionsClick(object sender, EventArgs e)
        {
            ViewTransactions transactionsView = new ViewTransactions();
            transactionsView.Activate();
            transactionsView.Show();
        }

        private void RecurringTransactionsClick(object sender, EventArgs e)
        {
            ViewTransactions transactionsView = new ViewTransactions(true);
            transactionsView.Activate();
            transactionsView.Show();
        }

        private void ReportClick(object sender, EventArgs e)
        {
            ViewReport viewReport = new ViewReport();
            viewReport.Activate();
            viewReport.Show();
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
                DoRecurringTransaction();
                DoRecurringEvent();
                if (isFirst) isFirst = false;
                Instances.User.LastAccessDate = DateTime.Now;
                UserRepository userRepository = UserRepository.Instance;
                userRepository.EditLastAccessDate(Instances.User);
            }
        }

        private void BackgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!isFirst)
            {
                string text = (string)e.UserState;
                new Notification(text).Show();
            }
        }

        private void EventsClick(object sender, EventArgs e)
        {

            ViewEvents viewEvents = new ViewEvents();
            viewEvents.Activate();
            viewEvents.Show();
        }

        private void RecurringEventsClick(object sender, EventArgs e)
        {
            ViewEvents viewEvents = new ViewEvents(true);
            viewEvents.Activate();
            viewEvents.Show();
        }

        private void DashboardDateSelected(object sender, DateRangeEventArgs e)
        {
            ShowEventsForDate(mc_calendar.SelectionStart);
        }

        private async void DoRecurringTransaction()
        {
            TransactionRepository transactionRepository = TransactionRepository.Instance;
            RecurringTransactionRepository recurringTransactionRepository = RecurringTransactionRepository.Instance;
            List<RecurringTransaction> recurringTransactions = recurringTransactionRepository.GetUserTransactions(Instances.User.ID);
            foreach (RecurringTransaction recurringTransaction in recurringTransactions)
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
            List<RecurringEvent> recurringEvents = recurringEventRepository.GetRecurringEvents(Instances.User.ID);
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

        private void ShowEventsForDate(DateTime d)
        {

            pl_right.Controls.OfType<Panel>().ToList().ForEach(p => p.Dispose());

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

            newList = newList.OrderBy(e => e.CreatedDate).ToList();

            int now = 180;

            newList.ForEach(e =>
            {
                Panel p = new Panel();
                p.Width = pl_right.Width - 20;
                p.Height = 25;
                p.Location = new Point(0, now);
                now += p.Height;

                Label name = new Label();
                name.Text = e.Name;
                name.ForeColor = Color.FromArgb(109, 116, 129);
                name.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 204);
                name.Location = new Point(10, 10);
                name.Size = new Size(p.Width, p.Height);
                p.Controls.Add(name);

                Panel b = new Panel();
                b.Width = p.Width;
                b.Height = 1;
                b.Location = new Point(0, p.Height - 1);
                b.BackColor = Color.FromArgb(228, 232, 241);
                b.BringToFront();
                p.Controls.Add(b);

                pl_right.Controls.Add(p);
            });

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
    }
}
