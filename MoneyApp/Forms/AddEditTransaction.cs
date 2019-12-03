using MoneyApp.Models;
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
    public partial class AddEditTransaction : Form
    {
        public AddEditTransaction()
        {
            InitializeComponent();
            cbx_type.SelectedItem = cbx_type.Items[0];
            dtp_date.Value = DateTime.Now;
        }

        public AddEditTransaction(Transaction transaction)
        {
            InitializeComponent();
        }
    }
}
