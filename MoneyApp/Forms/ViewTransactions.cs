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
    public partial class ViewTransactions : Form
    {
        private TransactionRepository transactionRepository;
        private RecurringTransactionRepository recurringTransactionRepository;
        private bool isRecurring = false;
        public ViewTransactions()
        {
            InitializeComponent();
            transactionRepository = TransactionRepository.Instance;
            ResizeColumns();
        }
        public ViewTransactions(bool recurring)
        {
            InitializeComponent();
            isRecurring = recurring;
            if (isRecurring)
            {
                lv_transactions.Columns.Add("Status");
                lv_transactions.Columns.Add("End date");
                recurringTransactionRepository = RecurringTransactionRepository.Instance;
            }
            ResizeColumns();
            transactionRepository = TransactionRepository.Instance;
        }

        private void AddClick(object sender, EventArgs e)
        {
            AddEditTransaction addEditTransaction = new AddEditTransaction();
            addEditTransaction.Activate();
            addEditTransaction.ShowDialog();
        }

        private void EditClick(object sender, EventArgs e)
        {
            if (lv_transactions.SelectedItems.Count > 0)
            {
                if (isRecurring)
                {
                    RecurringTransaction transaction = (RecurringTransaction)lv_transactions.SelectedItems[0].Tag;
                    AddEditTransaction addEditTransaction = new AddEditTransaction(transaction);
                    addEditTransaction.Activate();
                    addEditTransaction.ShowDialog();
                } else
                {
                    Transaction transaction = (Transaction)lv_transactions.SelectedItems[0].Tag;
                    AddEditTransaction addEditTransaction = new AddEditTransaction(transaction);
                    addEditTransaction.Activate();
                    addEditTransaction.ShowDialog();
                }
            }
        }

        private async void DeleteClick(object sender, EventArgs e)
        {
            if (lv_transactions.SelectedItems.Count > 0)
            {
                if (isRecurring)
                {
                    RecurringTransaction transaction = (RecurringTransaction)lv_transactions.SelectedItems[0].Tag;
                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool i = await Task.Run(() => recurringTransactionRepository.DeleteTransaction(transaction));

                        MessageBox.Show(i ? "Deleted" : "Error");
                    }
                } else
                {
                    Transaction transaction = (Transaction)lv_transactions.SelectedItems[0].Tag;
                    DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool i = await Task.Run(() => transactionRepository.DeleteTransaction(transaction));

                        MessageBox.Show(i ? "Deleted" : "Error");
                    }
                }
            }
        }

        private void ViewTransactionsFormClosed(object sender, FormClosedEventArgs e)
        {
            Instances.MoneyApp.Activate();
            Instances.MoneyApp.Show();
            Dispose();
        }

        private async void ViewTransactionsActivated(object sender, EventArgs e)
        {
            if (isRecurring)
            {
                List<RecurringTransaction> TransactionList = await Task.Run(() => recurringTransactionRepository.GetUserTransactions(Instances.User.ID));
                lv_transactions.Items.Clear();
                foreach (RecurringTransaction transaction in TransactionList)
                {
                    string endDate = (transaction.EndDate == DateTime.MinValue) ? "Never ends" : transaction.EndDate.ToString();
                    ListViewItem transactionListViewItem = new ListViewItem(
                        new string[] {
                        transaction.Name,
                        transaction.ContactName,
                        transaction.TypeName,
                        "£" + transaction.Amount.ToString("0.00"),
                        transaction.CreatedDate.ToString(),
                        transaction.Note,
                        transaction.Status,
                        endDate
                        });
                    transactionListViewItem.Tag = transaction;
                    lv_transactions.Items.Add(transactionListViewItem);

                }
            } else
            {
                List<Transaction> TransactionList = await Task.Run(() => transactionRepository.GetUserTransactions(Instances.User.ID));
                lv_transactions.Items.Clear();
                foreach (Transaction transaction in TransactionList)
                {
                    ListViewItem transactionListViewItem = new ListViewItem(
                        new string[] {
                        transaction.Name,
                        transaction.ContactName,
                        transaction.TypeName,
                        "£" + transaction.Amount.ToString("0.00"),
                        transaction.CreatedDate.ToString(),
                        transaction.Note
                        });
                    transactionListViewItem.Tag = transaction;
                    lv_transactions.Items.Add(transactionListViewItem);
                }
            }
        }

        private void TransactionsSizeChanged(object sender, EventArgs e)
        {
            ResizeColumns();
        }

        private void ResizeColumns()
        {
            int count = lv_transactions.Columns.Count;
            int per = (lv_transactions.Width - 20) / count;

            for (int i = 0; i < count; i++)
            {
                int width = 0;
                if (i == count - 1)
                {
                    width = lv_transactions.Width - ((count - 1) * per) - 20;
                }
                else
                {
                    width = per;
                }
                lv_transactions.Columns[i].Width = width;
            }
        }
    }
}
