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
    }
}
