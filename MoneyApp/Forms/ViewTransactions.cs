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
        public ViewTransactions()
        {
            InitializeComponent();
            transactionRepository = TransactionRepository.Instance();
            Instances.MoneyApp.Hide();
        }

        private void AddClick(object sender, EventArgs e)
        {

        }

        private void EditClick(object sender, EventArgs e)
        {

        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if (lv_transactions.SelectedItems.Count > 0)
            {
                Transaction transaction = (Transaction)lv_transactions.SelectedItems[0].Tag;
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool i = transactionRepository.DeleteTransaction(transaction);

                    MessageBox.Show(i ? "Deleted" : "Error");
                }
            }
        }

        private void ViewTransactionsFormClosed(object sender, FormClosedEventArgs e)
        {
            Instances.MoneyApp.Activate();
            Instances.MoneyApp.Show();
            Dispose();
        }

        private void ViewTransactionsActivated(object sender, EventArgs e)
        {
            List<Transaction> transactions = transactionRepository.GetUserTransactions(Instances.User.ID);
            lv_transactions.Items.Clear();
            foreach (Transaction transaction in transactions)
            {
                ListViewItem lvi = new ListViewItem(new string[] { transaction.Name });
                lvi.Tag = transaction;
                lv_transactions.Items.Add(lvi);
            }
        }
    }
}
