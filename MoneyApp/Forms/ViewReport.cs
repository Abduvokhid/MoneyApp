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
        private string reportType = "";
        private int nowY = 0;
        public ViewReport()
        {
            InitializeComponent();
            transactionRepository = TransactionRepository.Instance;
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

            List<Transaction> tempList = new List<Transaction>();

            tempList = transactions.Where((t) => t.CreatedDate >= dt_start.Value && t.CreatedDate <= dt_end.Value).ToList();

            if (cbx_show.Text.Equals("Transactions"))
            {
                reportType = "transactions";
                plList.Controls.Clear();
                plList.AutoScroll = false;
                nowY = 0;
                AddNewTransactionControl(new Transaction());
                if (tempList != null)
                {
                    foreach (Transaction t in tempList)
                    {
                        AddNewTransactionControl(t);
                    }
                }
                plList.AutoScroll = true;
            }
            else if (cbx_show.Text.Equals("Days"))
            {
                reportType = "days";
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

                plList.Controls.Clear();
                plList.AutoScroll = false;
                nowY = 0;
                AddNewOtherControl(DateTime.MinValue, 0, 0, -1);
                if (tempList != null)
                {
                    for (int i = 0; i < dateList.Count; i++)
                    {
                        AddNewOtherControl(dateList[i], incomeList[i], expenseList[i], i);
                    }
                }
                plList.AutoScroll = true;

            }
            else if (cbx_show.Text.Equals("Months"))
            {
                reportType = "months";
                List<DateTime> dateList = new List<DateTime>();
                List<decimal> incomeList = new List<decimal>();
                List<decimal> expenseList = new List<decimal>();

                foreach (Transaction transaction in tempList)
                {
                    int z = -1;

                    for (int x = 0; x < dateList.Count; x++)
                    {
                        if (dateList[x].Equals(new DateTime(transaction.CreatedDate.Year, transaction.CreatedDate.Month, 1)))
                        {
                            z = x;
                            break;
                        }
                    }

                    if (z == -1)
                    {
                        dateList.Add(new DateTime(transaction.CreatedDate.Year, transaction.CreatedDate.Month, 1));
                        incomeList.Add(0);
                        expenseList.Add(0);
                        z = dateList.Count - 1;
                    }
                    if (transaction.Type) incomeList[z] += transaction.Amount;
                    else expenseList[z] += transaction.Amount;
                }

                plList.Controls.Clear();
                plList.AutoScroll = false;
                nowY = 0;
                AddNewOtherControl(DateTime.MinValue, 0, 0, -1);
                if (tempList != null)
                {
                    for (int i = 0; i < dateList.Count; i++)
                    {
                        AddNewOtherControl(dateList[i], incomeList[i], expenseList[i], i);
                    }
                }
                plList.AutoScroll = true;
            }
            else if (cbx_show.Text.Equals("Years"))
            {
                reportType = "years";
                List<DateTime> dateList = new List<DateTime>();
                List<decimal> incomeList = new List<decimal>();
                List<decimal> expenseList = new List<decimal>();

                foreach (Transaction transaction in tempList)
                {
                    int z = -1;

                    for (int x = 0; x < dateList.Count; x++)
                    {
                        if (dateList[x].Equals(new DateTime(transaction.CreatedDate.Year, 1, 1)))
                        {
                            z = x;
                            break;
                        }
                    }

                    if (z == -1)
                    {
                        dateList.Add(new DateTime(transaction.CreatedDate.Year, 1, 1));
                        incomeList.Add(0);
                        expenseList.Add(0);
                        z = dateList.Count - 1;
                    }
                    if (transaction.Type) incomeList[z] += transaction.Amount;
                    else expenseList[z] += transaction.Amount;
                }

                plList.Controls.Clear();
                plList.AutoScroll = false;
                nowY = 0;
                AddNewOtherControl(DateTime.MinValue, 0, 0, -1);
                if (tempList != null)
                {
                    for (int i = 0; i < dateList.Count; i++)
                    {
                        AddNewOtherControl(dateList[i], incomeList[i], expenseList[i], i);
                    }
                }
                plList.AutoScroll = true;


            }
        }

        private void PanelSizeChanged(object sender, EventArgs e)
        {
            Panel plItem = (Panel)sender;

            int height = plItem.Height / 2;
            int widthAll = (int)(plItem.Size.Width * 0.25);
            int widthOne = plItem.Size.Width - (widthAll * 3);

            List<Panel> panels = plItem.Controls.OfType<Panel>().ToList();
            for (int i = 0; i < panels.Count; i++)
            {
                int id = (int)panels[i].Tag;
                switch (id)
                {
                    case 1:
                        panels[i].Width = widthOne;
                        panels[i].Location = new Point(0, 0);
                        break;
                    case 5:
                        panels[i].Width = plItem.Size.Width;
                        break;
                    default:
                        panels[i].Width = widthAll;
                        panels[i].Location = new Point((id - 1) * widthAll, 0);
                        break;
                }
            }
        }

        private void AddNewTransactionControl(Transaction t)
        {
            string transactionTitle = "Transaction Name";
            string contactTitle = "Contact Name";
            string dateTitle = "Date and Time";
            string dayOfWeekTitle = "Day of Week";
            string amountTitle = "Amount";
            string typeTitle = "Type";

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
            if (t.ID == 0) {
                lblItemName.Text = transactionTitle;
                lblItemName.BackColor = Color.FromArgb(249, 250, 252);
            }
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
            if (t.ID == 0)
            {
                lblItemContact.Text = contactTitle;
                lblItemContact.BackColor = Color.FromArgb(249, 250, 252);
            }
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
            if (t.ID == 0)
            {
                lblItemDateTime.Text = dateTitle;
                lblItemDateTime.BackColor = Color.FromArgb(249, 250, 252);
            }
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
            if (t.ID == 0)
            {
                lblItemDayOfWeek.Text = dayOfWeekTitle;
                lblItemDayOfWeek.BackColor = Color.FromArgb(249, 250, 252);
            }
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
            if (t.ID == 0)
            {
                lblItemAmount.Text = amountTitle;
                lblItemAmount.BackColor = Color.FromArgb(249, 250, 252);
            }
            // 
            // lblItemType
            // 
            lblItemType.AutoSize = false;
            lblItemType.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            if (t.Type == true)
            {
                lblItemType.ForeColor = Color.FromArgb(46, 125, 50);
            } else
            {
                lblItemType.ForeColor = Color.FromArgb(211, 47, 47);
            }
            lblItemType.Location = new Point(widthLeft + widthMiddle, height);
            lblItemType.TextAlign = ContentAlignment.TopCenter;
            lblItemType.Size = new Size(widthRight, height);
            lblItemType.Anchor = AnchorStyles.Right;
            lblItemType.Name = "lblItemType" + t.ID;
            lblItemType.Text = t.TypeName;
            if (t.ID == 0)
            {
                lblItemType.ForeColor = Color.FromArgb(109, 116, 129);
                lblItemType.Text = typeTitle;
                lblItemType.BackColor = Color.FromArgb(249, 250, 252);
            }

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

        private void AddNewOtherControl(DateTime dateTime, decimal income, decimal expense, int id)
        {
            string dateTitle = "";
            string incomeTitle = "Income";
            string expenseTitle = "Expense";
            string totalTitle = "Total";

            if (reportType.Equals("days")) dateTitle = "Days";
            else if (reportType.Equals("months")) dateTitle = "Months";
            else if (reportType.Equals("years")) dateTitle = "Years";

            Panel plItem = new Panel();

            Panel plOne = new Panel();
            Panel plTwo = new Panel();
            Panel plThree = new Panel();
            Panel plFour = new Panel();

            Label lblItemDateTime = new Label();
            Label lblItemDayOfWeek = new Label();
            Label lblItemIncome = new Label();
            Label lblItemExpense = new Label();
            Label lblItemTotal = new Label();
            Panel plBorder = new Panel();

            plOne.Controls.Add(lblItemDateTime);
            if (dateTime != DateTime.MinValue && reportType.Equals("years") == false)
            {
                plOne.Controls.Add(lblItemDayOfWeek);
            }
            plTwo.Controls.Add(lblItemIncome);
            plThree.Controls.Add(lblItemExpense);
            plFour.Controls.Add(lblItemTotal);

            plItem.Controls.Add(plOne);
            plItem.Controls.Add(plTwo);
            plItem.Controls.Add(plThree);
            plItem.Controls.Add(plFour);
            plItem.Controls.Add(plBorder);

            plItem.Name = "plItem" + id;
            plItem.Size = new Size(plList.Width, 60);
            plItem.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

            int height = plItem.Height / 2;
            int widthAll = (int)(plItem.Width * 0.25);
            int widthOne = plItem.Width - (widthAll * 3);

            plOne.Height = plItem.Height;
            plTwo.Height = plItem.Height;
            plThree.Height = plItem.Height;
            plFour.Height = plItem.Height;

            plOne.Tag = 1;
            plTwo.Tag = 2;
            plThree.Tag = 3;
            plFour.Tag = 4;

            plOne.Width = widthOne;
            plTwo.Width = widthAll;
            plThree.Width = widthAll;
            plFour.Width = widthAll;

            plOne.Anchor = AnchorStyles.Right;
            plTwo.Anchor = AnchorStyles.Right;
            plThree.Anchor = AnchorStyles.Right;
            plFour.Anchor = AnchorStyles.Right;

            plOne.Location = new Point(0, 0);
            plTwo.Location = new Point(widthOne, 0);
            plThree.Location = new Point(widthOne + widthAll, 0);
            plFour.Location = new Point(widthOne + widthAll + widthAll, 0);


            // 
            // lblItemDateTime
            // 
            lblItemDateTime.AutoSize = false;
            lblItemDateTime.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblItemDateTime.ForeColor = Color.FromArgb(43, 56, 75);
            lblItemDateTime.Location = new Point(0, 0);
            lblItemDateTime.TextAlign = ContentAlignment.BottomCenter;
            lblItemDateTime.Size = new Size(widthOne, height);
            lblItemDateTime.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            lblItemDateTime.TabIndex = 0;
            lblItemDateTime.Name = "lblItemDateTime" + id;
            switch (reportType)
            {
                case "days":
                    lblItemDateTime.Text = dateTime.ToString("dd/MM/yyyy");
                    break;
                case "months":
                    lblItemDateTime.Text = dateTime.ToString("MMMM");
                    break;
                case "years":
                    lblItemDateTime.Text = dateTime.ToString("yyyy");
                    lblItemDateTime.Size = new Size(widthOne, plItem.Height);
                    lblItemDateTime.TextAlign = ContentAlignment.MiddleCenter;
                    break;
            }
            if (dateTime == DateTime.MinValue)
            {
                lblItemDateTime.TextAlign = ContentAlignment.MiddleCenter;
                lblItemDateTime.Size = new Size(widthOne, plItem.Height);
                lblItemDateTime.Text = dateTitle;
                lblItemDateTime.BackColor = Color.FromArgb(249, 250, 252);
            }
            // 
            // lblItemDayOfWeek
            // 
            lblItemDayOfWeek.AutoSize = false;
            lblItemDayOfWeek.Font = new Font("Arial Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemDayOfWeek.ForeColor = Color.FromArgb(109, 116, 129);
            lblItemDayOfWeek.Location = new Point(0, height);
            lblItemDayOfWeek.TextAlign = ContentAlignment.TopCenter;
            lblItemDayOfWeek.Size = new Size(widthOne, height);
            lblItemDayOfWeek.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            lblItemDayOfWeek.TabIndex = 1;
            lblItemDayOfWeek.Name = "lblItemDayOfWeek" + id;
            lblItemDayOfWeek.Text = dateTime.DayOfWeek.ToString();
            if (reportType.Equals("months"))
            {
                lblItemDayOfWeek.Text = dateTime.ToString("yyyy");
            }
            // 
            // lblItemIncome
            // 
            lblItemIncome.AutoSize = false;
            lblItemIncome.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblItemIncome.ForeColor = Color.FromArgb(46, 125, 50);
            lblItemIncome.Location = new Point(0, 0);
            lblItemIncome.TextAlign = ContentAlignment.MiddleCenter;
            lblItemIncome.Size = new Size(widthAll, plItem.Height);
            lblItemIncome.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            lblItemIncome.TabIndex = 2;
            lblItemIncome.Name = "lblItemIncome" + id;
            lblItemIncome.Text = income.ToString("£0.00");
            if (dateTime == DateTime.MinValue)
            {
                lblItemIncome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
                lblItemIncome.Text = incomeTitle;
                lblItemIncome.BackColor = Color.FromArgb(249, 250, 252);
            }
            // 
            // lblItemExpense
            // 
            lblItemExpense.AutoSize = false;
            lblItemExpense.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblItemExpense.ForeColor = Color.FromArgb(211, 47, 47);
            lblItemExpense.Location = new Point(0, 0);
            lblItemExpense.TextAlign = ContentAlignment.MiddleCenter;
            lblItemExpense.Size = new Size(widthAll, plItem.Height);
            lblItemExpense.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            lblItemExpense.Name = "lblItemExpense" + id;
            lblItemExpense.Text = expense.ToString("£0.00");
            if (dateTime == DateTime.MinValue)
            {
                lblItemExpense.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
                lblItemExpense.Text = expenseTitle;
                lblItemExpense.BackColor = Color.FromArgb(249, 250, 252);
            }
            // 
            // lblItemTotal
            // 
            decimal total = income - expense;
            lblItemTotal.AutoSize = false;
            lblItemTotal.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            if (total < 0)
            {
                lblItemTotal.ForeColor = Color.FromArgb(211, 47, 47);
            } else if (total > 0)
            {
                lblItemTotal.ForeColor = Color.FromArgb(46, 125, 50);
            } else
            {
                lblItemTotal.ForeColor = Color.FromArgb(109, 116, 129);
            }
            lblItemTotal.Location = new Point(0, 0);
            lblItemTotal.TextAlign = ContentAlignment.MiddleCenter;
            lblItemTotal.Size = new Size(widthAll, plItem.Height);
            lblItemTotal.Anchor = AnchorStyles.Right | AnchorStyles.Left;
            lblItemTotal.Name = "lblItemTotal" + id;
            lblItemTotal.Text = total.ToString("£0.00");
            if (dateTime == DateTime.MinValue)
            {
                lblItemTotal.Text = totalTitle;
                lblItemTotal.BackColor = Color.FromArgb(249, 250, 252);
            }

            plBorder.Width = plItem.Width;
            plBorder.Height = 1;
            plBorder.BackColor = Color.FromArgb(228, 232, 241);
            plBorder.Location = new Point(0, plItem.Height - 1);
            plBorder.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            plBorder.Tag = 5;
            plBorder.BringToFront();

            plItem.Location = new Point(0, nowY);
            nowY += plItem.Height;

            plItem.SizeChanged += new EventHandler(PanelSizeChanged);

            plList.Controls.Add(plItem);
        }
    }
}
