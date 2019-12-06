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

namespace MoneyApp
{
    public partial class MoneyApp : Form
    {
        private PictureBox pb;
        Bitmap bmp;
        public MoneyApp()
        {
            InitializeComponent();
            Instances.MoneyApp = this;
            pb = new PictureBox();
            panel1.Controls.Add(pb);
            pb.Dock = DockStyle.Fill;
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

        private void btn_contacts_Click(object sender, EventArgs e)
        {
            Blur();
            ViewContacts contactsView = new ViewContacts();
            contactsView.Activate();
            contactsView.Show();
        }

        private void Blur()
        {
            bmp = Screenshot.TakeSnapshot(panel1);
            BitmapFilter.GaussianBlur(bmp, 1);
            
            pb.Image = bmp;
            pb.BringToFront();
        }

        public void UnBlur()
        {
            pb.Image = null;
            pb.SendToBack();
            bmp.Dispose();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();
        }

        private void MoneyApp_SizeChanged(object sender, EventArgs e)
        {
            SetPanelSize();
        }

        private void SetPanelSize()
        {
            panel1.Size = Size;
        }
    }
}
