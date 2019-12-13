using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyApp.Forms;
using MoneyApp.Models;
using MoneyApp.Repositories;
using System.Runtime.InteropServices;
using System.Threading;

namespace MoneyApp
{
    public partial class MoneyApp : Form
    {
        private bool isTagged = false;
        private PictureBox pb;
        Bitmap bmp;
        public MoneyApp()
        {
            InitializeComponent();
            Instances.MoneyApp = this;
            /*pb = new PictureBox();
            panel.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;*/
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            SetPanelSize();

            SetMenu();
        }

        private void SetMenu()
        {
            int width = pl_menu.Width / 5;
            int width_last = pl_menu.Width - (width * 4);

            Button transactions = new Button();
            transactions.Width = width;
            transactions.BackColor = pl_menu.BackColor;
            transactions.Text = "Transactions";
            transactions.Height = 40;
            transactions.FlatStyle = FlatStyle.Flat;
            transactions.Location = new Point(0,0);
            pl_menu.Controls.Add(transactions);

            Button events = new Button();
            events.Width = width;
            events.BackColor = pl_menu.BackColor;
            events.Text = "Events";
            events.FlatStyle = FlatStyle.Flat;
            events.Height = 40;
            events.Location = new Point(transactions.Location.X + transactions.Width, 0);
            pl_menu.Controls.Add(events);

            Button contacts = new Button();
            contacts.Width = width;
            contacts.BackColor = pl_menu.BackColor;
            contacts.Text = "Contacts";
            contacts.FlatStyle = FlatStyle.Flat;
            contacts.Height = 40;
            contacts.Location = new Point(events.Location.X + events.Width, 0);
            pl_menu.Controls.Add(contacts);

            Button reports = new Button();
            reports.Width = width;
            reports.BackColor = pl_menu.BackColor;
            reports.Text = "Reports";
            reports.FlatStyle = FlatStyle.Flat;
            reports.Height = 40;
            reports.Location = new Point(contacts.Location.X + contacts.Width, 0);
            pl_menu.Controls.Add(reports);

            Button settings = new Button();
            settings.Width = width_last;
            settings.BackColor = pl_menu.BackColor;
            settings.Text = "Settings";
            settings.FlatStyle = FlatStyle.Flat;
            settings.Height = 40;
            settings.Location = new Point(reports.Location.X + reports.Width, 0);
            pl_menu.Controls.Add(settings);


        }

        private void MoneyApp_Activated(object sender, EventArgs e)
        {
            Instances.User = new User { ID = 7, Name = "Abdu", Username = "Abduvokhid" };
            if (Instances.User == null)
            {
                Authorization auth = new Authorization();
                auth.Activate();
                auth.Show();
            }

            if (!bw_recurring.IsBusy) bw_recurring.RunWorkerAsync();
        }

        private void Blur()
        {
            /*bmp = Screenshot.TakeSnapshot(panel);
            BitmapFilter.GaussianBlur(bmp, 1);
            
            pb.Image = bmp;
            pb.BringToFront();*/
        }

        public void UnBlur()
        {
            /*pb.Image = null;
            pb.SendToBack();
            bmp.Dispose();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();*/
        }

        private void MoneyApp_SizeChanged(object sender, EventArgs e)
        {
            SetPanelSize();
        }

        private void SetPanelSize()
        {
           panel.Size = new Size(Width, Height - 20);
        }

        private void ContactsClick(object sender, EventArgs e)
        {
            Blur();
            ViewContacts contactsView = new ViewContacts();
            contactsView.Activate();
            contactsView.Show();
        }

        private void TransactionsClick(object sender, EventArgs e)
        {
            //Blur();
            ViewTransactions transactionsView = new ViewTransactions();
            transactionsView.Activate();
            transactionsView.Show();
        }

        private void btn_transactions_MouseHover(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Padding = new Padding(5);
            label.AutoSize = false;
            label.Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc volutpat hendrerit consectetur. Cras dapibus ipsum eu nibh venenatis, sed interdum sem efficitur. Vivamus fermentum auctor sodales nullam.";
            label.Width = 250;
            int a = label.Text.Length * 6 / 260;
            label.Height += a * 13;
            btn_transactions.Tag = label;
            label.Location = new Point(btn_transactions.Location.X + btn_transactions.Width + 5, btn_transactions.Location.Y + (btn_transactions.Height / 2) - (label.Height / 2));
            label.BringToFront();
            label.BackColor = Color.White;
            label.ForeColor = Color.Black;
            label.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(label);
            isTagged = true;
        }

        private void btn_transactions_MouseLeave(object sender, EventArgs e)
        {
            if (isTagged) ((Label)btn_transactions.Tag).Dispose();
        }

        private void btn_recurring_transactions_Click(object sender, EventArgs e)
        {
            ViewTransactions transactionsView = new ViewTransactions(true);
            transactionsView.Activate();
            transactionsView.Show();
        }

        private bool move = false;
        private Point startPoint;
        private void RightMouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            startPoint = MousePosition;
        }

        private void RightMouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                Point nowPoint = MousePosition;
                int o = startPoint.X;
                int n = nowPoint.X;
                int t = n - o;
                Size = new Size(Width + t, Height);
                startPoint = nowPoint;
            }
        }

        private void RightMouseUp(object sender, MouseEventArgs e)
        {
            if (move) move = false;
        }

        private void AllMouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            startPoint = MousePosition;
        }

        private void AllMouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                Point nowPoint = MousePosition;
                int Xo = startPoint.X;
                int Xn = nowPoint.X;
                int Xt = Xn - Xo;
                int Yo = startPoint.Y;
                int Yn = nowPoint.Y;
                int Yt = Yn - Yo;
                Size = new Size(Width + Xt, Height + Yt);
                startPoint = nowPoint;
            }
        }

        private void AllMouseUp(object sender, MouseEventArgs e)
        {
            if (move) move = false;
        }

        private void ReportClick(object sender, EventArgs e)
        {
            ViewReport viewReport = new ViewReport();
            viewReport.Activate();
            viewReport.Show();
        }

        private void btn_predict_Click(object sender, EventArgs e)
        {
            ViewPrediction viewPrediction = new ViewPrediction();
            viewPrediction.Activate();
            viewPrediction.Show();
        }

        private void bw_recurring_DoWork(object sender, DoWorkEventArgs e)
        {
            for (var i = 0; i < 100; i++)
            {
                bw_recurring.ReportProgress(i);
                Thread.Sleep(500);
            }
        }

        private void bw_recurring_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            btn_all.Text = "Progress: " + e.ProgressPercentage;
        }
    }
}
