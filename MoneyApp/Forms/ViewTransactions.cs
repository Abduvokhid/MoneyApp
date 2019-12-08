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
            //Instances.MoneyApp.Hide();
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
                Transaction transaction = (Transaction)lv_transactions.SelectedItems[0].Tag;
                AddUpdateTransaction addEditTransaction = new AddUpdateTransaction(transaction);
                addEditTransaction.Activate();
                addEditTransaction.ShowDialog();
            }
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
            Instances.MoneyApp.UnBlur();
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
