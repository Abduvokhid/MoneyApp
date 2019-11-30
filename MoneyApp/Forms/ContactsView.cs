﻿using MoneyApp.Models;
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
    public partial class ContactsView : Form
    {
        private ContactRepository contactRepository;
        public ContactsView()
        {
            InitializeComponent();
            contactRepository = new ContactRepository();
        }

        private void ContactsView_Activated(object sender, EventArgs e)
        {
            List<Contact> contacts = contactRepository.GetUserContacts(Instances.User.ID);
            lv_contacts.Items.Clear();
            foreach (Contact contact in contacts)
            {
                ListViewItem lvi = new ListViewItem(new string[]{ contact.Name });
                lvi.Tag = contact;
                lv_contacts.Items.Add(lvi);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lv_contacts.SelectedItems.Count > 0)
            {
                Contact contact = (Contact)lv_contacts.SelectedItems[0].Tag;
                bool i = contactRepository.DeleteContact(contact);
               
                MessageBox.Show(i ? "Deleted" : "Error");
            }
        }
    }
}
