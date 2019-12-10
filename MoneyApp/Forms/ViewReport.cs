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
    public partial class ViewReport : Form
    {
        private TransactionRepository transactionRepository;
        public ViewReport()
        {
            InitializeComponent();
            transactionRepository = TransactionRepository.Instance();
        }

        private void BtnGenerateClick(object sender, EventArgs e)
        {
            if (dt_start.Value > dt_end.Value)
            {
                MessageBox.Show("Start date cannot be later then end date.");
                return;
            }

            List<Transaction> transactions = transactionRepository.GetUserTransactions(Instances.User.ID);
            
            transactions.Where((t) => t.CreatedDate >= dt_start.Value && t.CreatedDate <= dt_end.Value);


        }
    }
}
