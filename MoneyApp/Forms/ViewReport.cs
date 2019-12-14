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

using LiveCharts; //Core of the library
using LiveCharts.Wpf; //The WPF controls
using LiveCharts.WinForms; //the WinForm wrappers

namespace MoneyApp.Forms
{
    public partial class ViewReport : Form
    {
        private TransactionRepository transactionRepository;
        private List<Transaction> transactions;
        private List<Transaction> tempList;
        int nowY = 0;
        public ViewReport()
        {
            InitializeComponent();
            transactionRepository = TransactionRepository.Instance();
            cbx_show.SelectedIndex = 0;
        }

        private async void BtnGenerateClick(object sender, EventArgs e)
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
                transactions = await Task.Run(() => transactionRepository.GetUserTransactions(Instances.User.ID));
            }

            lv_report.Items.Clear();
            lv_report.Columns.Clear();

            tempList = new List<Transaction>();

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
                GenerateItems();
            }
            else if (cbx_show.Text.Equals("Days"))
            {
                List<DateTime> dateList = new List<DateTime>();
                List<decimal> incomeList = new List<decimal>();
                List<decimal> expenseList = new List<decimal>();

                foreach (Transaction transaction in tempList)
                {
                    int z = -1;

                    for (int x = 0; x < dateList.Count; x++)
                    {
                        if (dateList[x].Date == transaction.CreatedDate.Date)
                        {
                            z = x;
                            break;
                        }
                    }
                    
                    if (z == -1)
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
            else if (cbx_show.Text.Equals("Months"))
            {
                List<string> dateList = new List<string>();
                List<decimal> incomeList = new List<decimal>();
                List<decimal> expenseList = new List<decimal>();

                foreach (Transaction transaction in tempList)
                {
                    int z = -1;

                    for (int x = 0; x < dateList.Count; x++)
                    {
                        if (dateList[x].Equals(transaction.CreatedDate.ToString("MM/yyyy")))
                        {
                            z = x;
                            break;
                        }
                    }

                    if (z == -1)
                    {
                        dateList.Add(transaction.CreatedDate.ToString("MM/yyyy"));
                        incomeList.Add(0);
                        expenseList.Add(0);
                        z = dateList.Count - 1;
                    }
                    if (transaction.Type) incomeList[z] += transaction.Amount;
                    else expenseList[z] += transaction.Amount;
                }

                lv_report.Columns.Add("Month", 100);
                lv_report.Columns.Add("Income", 80);
                lv_report.Columns.Add("Expense", 80);

                for (int i = 0; i < dateList.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        dateList[i],
                        incomeList[i].ToString("0.00"),
                        expenseList[i].ToString("0.00")
                    });
                    lv_report.Items.Add(listViewItem);
                }
            }
            else if (cbx_show.Text.Equals("Years"))
            {
                List<string> dateList = new List<string>();
                List<decimal> incomeList = new List<decimal>();
                List<decimal> expenseList = new List<decimal>();

                foreach (Transaction transaction in tempList)
                {
                    int z = -1;

                    for (int x = 0; x < dateList.Count; x++)
                    {
                        if (dateList[x].Equals(transaction.CreatedDate.ToString("yyyy")))
                        {
                            z = x;
                            break;
                        }
                    }

                    if (z == -1)
                    {
                        dateList.Add(transaction.CreatedDate.ToString("yyyy"));
                        incomeList.Add(0);
                        expenseList.Add(0);
                        z = dateList.Count - 1;
                    }
                    if (transaction.Type) incomeList[z] += transaction.Amount;
                    else expenseList[z] += transaction.Amount;
                }

                lv_report.Columns.Add("Year", 100);
                lv_report.Columns.Add("Income", 80);
                lv_report.Columns.Add("Expense", 80);

                for (int i = 0; i < dateList.Count; i++)
                {
                    ListViewItem listViewItem = new ListViewItem(new string[] {
                        dateList[i],
                        incomeList[i].ToString("0.00"),
                        expenseList[i].ToString("0.00")
                    });
                    lv_report.Items.Add(listViewItem);
                }

            }

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<decimal>(transactions.Select(t => t.Amount))
                }
            };
        }

        private void GenerateItems()
        {
            plList.Controls.Clear();
            plList.AutoScroll = false;
            nowY = 0;
            if (tempList != null)
            {
                foreach (Transaction t in tempList)
                {
                    AddNewControl(t);
                }
            }
            plList.AutoScroll = true;
        }

        private void AddNewControl(Transaction t)
        {
            Panel plItem = new Panel();
            Label lblItemDayOfWeek = new Label();
            Label lblItemDateTime = new Label();
            Label lblItemContact = new Label();
            Label lblItemName = new Label();
            Label lblItemType = new Label();
            Label lblItemAmount = new Label();
            Panel plBorder = new Panel();
            
            plItem.Controls.Add(lblItemType);
            plItem.Controls.Add(lblItemAmount);
            plItem.Controls.Add(lblItemDayOfWeek);
            plItem.Controls.Add(lblItemDateTime);
            plItem.Controls.Add(lblItemContact);
            plItem.Controls.Add(lblItemName);
            plItem.Controls.Add(plBorder);
            plItem.Name = "plItem" + t.ID;
            plItem.Size = new Size(plList.Width, 60);
            plItem.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            //plItem.BackColor = Color.LightGray;

            int height = plItem.Height / 2;
            int widthRight = (int)(plItem.Width * 0.3);
            int widthMiddle = (int)(plItem.Width * 0.3);
            int widthLeft = plItem.Width - widthRight - widthMiddle;

            // 
            // lblItemName
            // 
            lblItemName.AutoSize = false;
            lblItemName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblItemName.ForeColor = Color.FromArgb(43, 56, 75);
            lblItemName.Location = new Point(0, 0);
            lblItemName.TextAlign = ContentAlignment.BottomCenter;
            lblItemName.Size = new Size(widthLeft, height);
            lblItemName.Anchor = AnchorStyles.Left;
            lblItemName.Name = "lblItemName" + t.ID;
            lblItemName.Text = t.Name;
            // 
            // lblItemContact
            // 
            lblItemContact.AutoSize = false;
            lblItemContact.Font = new Font("Arial Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemContact.ForeColor = Color.FromArgb(109, 116, 129);
            lblItemContact.Location = new Point(0, height);
            lblItemContact.TextAlign = ContentAlignment.TopCenter;
            lblItemContact.Size = new Size(widthLeft, height);
            lblItemContact.Anchor = AnchorStyles.Left;
            lblItemContact.Name = "lblItemContact" + t.ID;
            lblItemContact.Text = t.ContactName;
            // 
            // lblItemDateTime
            // 
            lblItemDateTime.AutoSize = false;
            lblItemDateTime.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblItemDateTime.ForeColor = Color.FromArgb(43, 56, 75);
            lblItemDateTime.Location = new Point(widthLeft, 0);
            lblItemDateTime.TextAlign = ContentAlignment.BottomCenter;
            lblItemDateTime.Size = new Size(widthMiddle, height);
            lblItemDateTime.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblItemDateTime.Name = "lblItemDateTime" + t.ID;
            lblItemDateTime.Text = t.CreatedDate.ToString("dd/MM/yyyy hh:mm");
            // 
            // lblItemDayOfWeek
            // 
            lblItemDayOfWeek.AutoSize = false;
            lblItemDayOfWeek.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblItemDayOfWeek.ForeColor = Color.FromArgb(109, 116, 129);
            lblItemDayOfWeek.Location = new Point(widthLeft, height);
            lblItemDayOfWeek.TextAlign = ContentAlignment.TopCenter;
            lblItemDayOfWeek.Size = new Size(widthMiddle, height);
            lblItemDayOfWeek.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblItemDayOfWeek.Name = "lblItemDayOfWeek" + t.ID;
            lblItemDayOfWeek.Text = t.CreatedDate.DayOfWeek.ToString();
            // 
            // lblItemAmount
            // 
            lblItemAmount.AutoSize = false;
            lblItemAmount.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblItemAmount.ForeColor = Color.FromArgb(43, 56, 75);
            lblItemAmount.Location = new Point(widthLeft + widthMiddle, 0);
            lblItemAmount.TextAlign = ContentAlignment.BottomCenter;
            lblItemAmount.Size = new Size(widthRight, height);
            lblItemAmount.Anchor = AnchorStyles.Right;
            lblItemAmount.Name = "lblItemAmount" + t.ID;
            lblItemAmount.Text = t.Amount.ToString("£0.00");
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = false;
            lblItemType.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            if (t.Type == true)
            {
                lblItemType.ForeColor = Color.FromArgb(211, 47, 47);
            } else
            {
                lblItemType.ForeColor = Color.FromArgb(46, 125, 50);
            }
            lblItemType.Location = new Point(widthLeft + widthMiddle, height);
            lblItemType.TextAlign = ContentAlignment.TopCenter;
            lblItemType.Size = new Size(widthRight, height);
            lblItemType.Anchor = AnchorStyles.Right;
            lblItemType.Name = "lblItemType" + t.ID;
            lblItemType.Text = t.TypeName;

            plBorder.Width = plItem.Width;
            plBorder.Height = 1;
            plBorder.BackColor = Color.FromArgb(228, 232, 241);
            plBorder.Location = new Point(0, plItem.Height - 1);
            plBorder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            plBorder.BringToFront();
            
            plItem.Location = new Point(0, nowY);
            nowY += plItem.Height;

            plList.Controls.Add(plItem);
        }
    }
}
