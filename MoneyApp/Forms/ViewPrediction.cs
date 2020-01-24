using MoneyApp.Models;
using MoneyApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyApp.Forms
{
    public partial class ViewPrediction : Form
    {
        private List<Transaction> transactions;
        private List<RecurringTransaction> recurringTransactions;
        private TransactionRepository transactionRepository;
        private RecurringTransactionRepository recurringTransactionRepository;

        public ViewPrediction()
        {
            InitializeComponent();
            transactionRepository = TransactionRepository.Instance;
            recurringTransactionRepository = RecurringTransactionRepository.Instance;
            dtp_date.MinDate = DateTime.Now.AddDays(1);
        }

        private decimal GetAverage()
        {
            decimal totalDayOfWeek = 0;
            decimal totalDayOfMonth = 0;
            decimal totalLastMonth = 0;
            List<DateTime> datesDoW = new List<DateTime>();
            List<DateTime> datesDoM = new List<DateTime>();
            List<DateTime> datesLM = new List<DateTime>();

            DateTime predictDate = dtp_date.Value.Date;

            DateTime lastMonth = predictDate.AddMonths(-1);

            foreach (Transaction transaction in transactions)
            {
                if (transaction.CreatedDate.DayOfWeek == predictDate.DayOfWeek)
                {
                    totalDayOfWeek += transaction.Amount;
                    if (!datesDoW.Contains(transaction.CreatedDate.Date))
                    {
                        datesDoW.Add(transaction.CreatedDate.Date);
                    }
                }

                if (transaction.CreatedDate.Day == predictDate.Day)
                {
                    totalDayOfMonth += transaction.Amount;
                    if (!datesDoM.Contains(transaction.CreatedDate.Date))
                    {
                        datesDoM.Add(transaction.CreatedDate.Date);
                    }
                }

                if (transaction.CreatedDate >= lastMonth)
                {
                    totalLastMonth += transaction.Amount;
                    if (!datesLM.Contains(transaction.CreatedDate.Date))
                    {
                        datesLM.Add(transaction.CreatedDate.Date);
                    }
                }
            }

            decimal totalAverage = 0;
            int number = 0;

            if (datesDoW.Count > 0)
            {
                number++;
                totalAverage += totalDayOfWeek / datesDoW.Count;
            }

            if (datesDoM.Count > 0)
            {
                number++;
                totalAverage += totalDayOfMonth / datesDoM.Count;
            }

            if (datesLM.Count > 0)
            {
                number++;
                totalAverage += totalLastMonth / datesLM.Count;
            }

            decimal average = 0;

            if (number > 0)
            {
                average = totalAverage / number;
            }

            return average;
        }

        private decimal GetRecurringAmount()
        {
            decimal totalRecurringAmount = 0;

            DateTime predictDate = dtp_date.Value.Date;

            foreach (RecurringTransaction recurringTransaction in recurringTransactions)
            {
                string transactionDateString = recurringTransaction.CreatedDate.ToString("dd/MM");
                string predictDateString = predictDate.ToString("dd/MM");
                if (recurringTransaction.Status.Equals("Yearly"))
                {
                    if (transactionDateString.Equals(predictDate))
                    {
                        totalRecurringAmount += recurringTransaction.Amount;
                    }
                }

                if (recurringTransaction.Status.Equals("Monthly"))
                {
                    if (recurringTransaction.CreatedDate.Day == predictDate.Day)
                    {
                        totalRecurringAmount += recurringTransaction.Amount;
                    }
                }

                if (recurringTransaction.Status.Equals("Weekly"))
                {
                    if (recurringTransaction.CreatedDate.DayOfWeek == predictDate.DayOfWeek)
                    {
                        totalRecurringAmount += recurringTransaction.Amount;
                    }
                }

                if (recurringTransaction.Status.Equals("Daily"))
                {
                    totalRecurringAmount += recurringTransaction.Amount;
                }
            }

            return totalRecurringAmount;
        }

        private async void btn_predict_Click(object sender, EventArgs e)
        {
            if (transactions == null)
            {
                transactions = await Task.Run(() => transactionRepository.GetUserTransactions(Instances.User.ID));
                List<Transaction> tempList = new List<Transaction>();
                foreach (Transaction transaction in transactions)
                {
                    if (transaction.Type == false)
                    {
                        tempList.Add(transaction);
                    }
                }
                transactions = tempList;
            }
            if (recurringTransactions == null)
            {
                recurringTransactions = await Task.Run(() => recurringTransactionRepository.GetUserTransactions(Instances.User.ID));
                List<RecurringTransaction> tempList = new List<RecurringTransaction>();
                foreach (RecurringTransaction transaction in recurringTransactions)
                {
                    if (transaction.Type == false)
                    {
                        tempList.Add(transaction);
                    }
                }
                recurringTransactions = tempList;
            }

            decimal average = GetAverage();
            decimal totalRecurring = GetRecurringAmount();
            
            if (average > totalRecurring)
            {
                lbl_result.Text = "£" + average.ToString("0.00");
            } else
            {
                lbl_result.Text = "£" + totalRecurring.ToString("0.00");
            }

        }

        private void FormClosedEvent(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
