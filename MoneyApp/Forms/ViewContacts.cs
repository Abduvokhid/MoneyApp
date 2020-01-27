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
    public partial class ViewContacts : Form
    {
        private ContactRepository contactRepository;
        public ViewContacts()
        {
            InitializeComponent();
            contactRepository = ContactRepository.Instance;
            lv_contacts.Columns[0].Width = lv_contacts.Width - 20;
        }

        private async void ViewContactsActivated(object sender, EventArgs e)
        {
            List<Contact> contacts = await Task.Run(() => contactRepository.GetUserContacts(Instances.User.ID));
            lv_contacts.Items.Clear();
            foreach (Contact contact in contacts)
            {
                ListViewItem lvi = new ListViewItem(new string[] { contact.Name })
                {
                    Tag = contact
                };
                lv_contacts.Items.Add(lvi);
            }
        }

        private void ViewContactsFormClosed(object sender, FormClosedEventArgs e)
        {
            Instances.MoneyApp.Activate();
            Instances.MoneyApp.Show();
            Dispose();
        }

        private void AddClick(object sender, EventArgs e)
        {
            AddEditContact addEditContact = new AddEditContact();
            addEditContact.Activate();
            addEditContact.ShowDialog();
        }

        private void EditClick(object sender, EventArgs e)
        {
            if (lv_contacts.SelectedItems.Count > 0)
            {
                Contact contact = (Contact)lv_contacts.SelectedItems[0].Tag;
                AddEditContact addEditContact = new AddEditContact(contact);
                addEditContact.Activate();
                addEditContact.ShowDialog();
            }
        }

        private async void DeleteClick(object sender, EventArgs e)
        {
            if (lv_contacts.SelectedItems.Count > 0)
            {
                Contact contact = (Contact)lv_contacts.SelectedItems[0].Tag;
                DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    bool i = await Task.Run(() => contactRepository.DeleteContact(contact));

                    MessageBox.Show(i ? "Deleted" : "Error");
                }
            }
        }

        private void ContactsSizeChanged(object sender, EventArgs e)
        {
            lv_contacts.Columns[0].Width = lv_contacts.Width - 20;
        }
    }
}
