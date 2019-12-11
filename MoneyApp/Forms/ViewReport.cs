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
            cbx_show.SelectedIndex = 1;
        }

        private void BtnGenerateClick(object sender, EventArgs e)
        {
            dt_start.Value = dt_start.Value.Date + new TimeSpan();
            dt_end.Value = dt_end.Value.Date + new TimeSpan(23, 59, 50);

            if (dt_start.Value > dt_end.Value)
            {
                MessageBox.Show("Start date cannot be later then end date.");
                return;
            }

            List<Transaction> transactions = transactionRepository.GetUserTransactions(Instances.User.ID);
            
            transactions.Where((t) => t.CreatedDate >= dt_start.Value && t.CreatedDate <= dt_end.Value);

            if (cbx_show.Text.Equals("Transactions"))
            {
                lv_report.Columns.Add("Name", 100);
                lv_report.Columns.Add("Contact", 80);
                lv_report.Columns.Add("Type", 50);
                lv_report.Columns.Add("Amount", 80);
                lv_report.Columns.Add("Created date", 100);
                lv_report.Columns.Add("Note", 200);

                transactions.ForEach((t) => {
                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        t.Name, t.ContactName, t.TypeName, t.Amount.ToString("0.00"), t.CreatedDate.ToString(), t.Note
                    });
                    listViewItem.BackColor = t.Type ? Color.FromArgb(200, 230, 201) : Color.FromArgb(255, 205, 210);
                    lv_report.Items.Add(listViewItem);
                });
            }

        }
    }
}
