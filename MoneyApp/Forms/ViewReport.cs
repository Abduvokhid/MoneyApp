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
        private List<Transaction> transactions;
        public ViewReport()
        {
            InitializeComponent();
            transactionRepository = TransactionRepository.Instance();
            cbx_show.SelectedIndex = 0;
        }

        private void BtnGenerateClick(object sender, EventArgs e)
        {
            dt_start.Value = dt_start.Value.Date + new TimeSpan();
            dt_end.Value = dt_end.Value.Date + new TimeSpan(23, 59, 59);

            if (dt_start.Value > dt_end.Value)
            {
                MessageBox.Show("Start date cannot be later then end date.");
                return;
            }

            if (transactions == null)
            {
                transactions = transactionRepository.GetUserTransactions(Instances.User.ID);
            }

            lv_report.Items.Clear();
            lv_report.Columns.Clear();

            List<Transaction> tempList = new List<Transaction>();

            tempList = transactions.Where((t) => t.CreatedDate >= dt_start.Value && t.CreatedDate <= dt_end.Value).ToList();

            if (cbx_show.Text.Equals("Transactions"))
            {
                lv_report.Columns.Add("Name", 100);
                lv_report.Columns.Add("Contact", 80);
                lv_report.Columns.Add("Type", 50);
                lv_report.Columns.Add("Amount", 80);
                lv_report.Columns.Add("Created date", 100);
                lv_report.Columns.Add("Note", 200);

                tempList.ForEach((t) =>
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        t.Name, t.ContactName, t.TypeName, t.Amount.ToString("0.00"), t.CreatedDate.ToString(), t.Note
                    });
                    //listViewItem.BackColor = t.Type ? Color.FromArgb(200, 230, 201) : Color.FromArgb(255, 205, 210);
                    listViewItem.ForeColor = t.Type ? Color.FromArgb(67, 160, 71) : Color.FromArgb(229, 57, 53);
                    lv_report.Items.Add(listViewItem);
                });
            }
            else if (cbx_show.Text.Equals("Days"))
            {
                List<DateTime> dateList = new List<DateTime>();
                List<decimal> incomeList = new List<decimal>();
                List<decimal> expenseList = new List<decimal>();

                foreach (Transaction transaction in tempList)
                {
                    int z = 0;

                    for (int x = 0; x < dateList.Count; x++)
                    {
                        if (dateList[0].Date == transaction.CreatedDate.Date)
                        {
                            z = x;
                            break;
                        }
                    }
                    
                    if (z < 0)
                    {
                        dateList.Add(transaction.CreatedDate);
                        incomeList.Add(0);
                        expenseList.Add(0);
                        z = dateList.Count - 1;
                    }
                    if (transaction.Type) incomeList[z] += transaction.Amount;
                    else expenseList[z] += transaction.Amount;
                }

                lv_report.Columns.Add("Date", 100);
                lv_report.Columns.Add("Income", 80);
                lv_report.Columns.Add("Expense", 80);

                for (int i = 0; i < dateList.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        dateList[i].ToShortDateString(),
                        incomeList[i].ToString("0.00"),
                        expenseList[i].ToString("0.00")
                    });
                    lv_report.Items.Add(listViewItem);
                }

            }
        }
    }
}
