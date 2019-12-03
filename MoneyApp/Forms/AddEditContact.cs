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
    public partial class AddEditContact : Form
    {
        private Contact contact;
        public AddEditContact()
        {
            InitializeComponent();
            btn_action.Text = "Add contact";
            Text = "Add contact";
            contact = new Contact { UserID = Instances.User.ID };
        }

        public AddEditContact(Contact c)
        {
            InitializeComponent();
            contact = c;
            btn_action.Text = "Edit contact";
            Text = "Edit contact";
            tbx_name.Text = c.Name;
        }

        private void btn_action_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_name.Text))
            {
                MessageBox.Show("Error");
                return;
            }

            contact.Name = tbx_name.Text;
            ContactRepository contactRepository = ContactRepository.Instance();

            bool i = contact.ID > 0 ? contactRepository.EditContact(contact) : contactRepository.AddContact(contact);
            MessageBox.Show(i ? (contact.ID > 0) ? "Edited okay" : "Added okay" : "Error");
            Close();
            Dispose();
        }
    }
}
