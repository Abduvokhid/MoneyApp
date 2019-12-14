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
            transactionRepository = TransactionRepository.Instance();
        }
        public ViewTransactions(bool recurring)
        {
            InitializeComponent();
            isRecurring = recurring;
            if (isRecurring)
            {
                lv_transactions.Columns.Add("Status");
                lv_transactions.Columns.Add("End date");
                recurringTransactionRepository = RecurringTransactionRepository.Instance();
            }
            transactionRepository = TransactionRepository.Instance();
        }

        private void AddClick(object sender, EventArgs e)
        {
            AddUpdateTransaction addEditTransaction = new AddUpdateTransaction();
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
                    AddUpdateTransaction addEditTransaction = new AddUpdateTransaction(transaction);
                    addEditTransaction.Activate();
                    addEditTransaction.ShowDialog();
                } else
                {
                    Transaction transaction = (Transaction)lv_transactions.SelectedItems[0].Tag;
                    AddUpdateTransaction addEditTransaction = new AddUpdateTransaction(transaction);
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
            Instances.MoneyApp.UnBlur();
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

        private void ViewTransactions_Resize(object sender, EventArgs e)
        {
            if (Width < 734)
            {
                btn_add.Location = new Point(12, 246);
                btn_edit.Location = new Point(99, 246);
                btn_delete.Location = new Point(186, 246);
            } else
            {
                btn_add.Location = new Point(631, 12);
                btn_edit.Location = new Point(631, 41);
                btn_delete.Location = new Point(631, 70);
            }
            if (Width < 655) Width = 655;
            if (Height < 315) Height = 315;
        }

        private void ViewTransactions_ResizeEnd(object sender, EventArgs e)
        {
        }
    }
}
