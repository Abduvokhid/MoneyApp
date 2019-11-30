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
        public MoneyApp()
        {
            InitializeComponent();
            Instances.MoneyApp = this;
        }

        private void btn_auth_Click(object sender, EventArgs e)
        {
        }

        private void MoneyApp_Activated(object sender, EventArgs e)
        {
            if (Instances.User == null)
            {
                Authorization auth = new Authorization();
                auth.Activate();
                auth.Show();
            }
        }
    }
}
