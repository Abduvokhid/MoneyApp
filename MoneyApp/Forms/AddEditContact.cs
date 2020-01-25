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
using Strings = MoneyApp.Properties.Strings;

namespace MoneyApp.Forms
{
    public partial class AddEditContact : Form
    {
        private Contact contact;
        public AddEditContact()
        {
            InitializeComponent();
            btn_action.Text = Strings.Add;
            Text = Strings.AddContact;
            contact = new Contact { UserID = Instances.User.ID };
        }

        public AddEditContact(Contact c)
        {
            InitializeComponent();
            contact = c;
            btn_action.Text = Strings.Edit;
            Text = Strings.EditContact;
            tbx_name.Text = c.Name;
        }

        private async void ActionClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbx_name.Text))
            {
                MessageBox.Show(Strings.ContactNameWrong, Strings.Error);
                return;
            }

            if (tbx_name.Text.Length > 100)
            {
                MessageBox.Show(Strings.ContactNameMaxLengthError, Strings.Error);
                return;
            }

            contact.Name = tbx_name.Text;
            ContactRepository contactRepository = ContactRepository.Instance;

            btn_action.Enabled = false;
            int i = contact.ID > 0 ? await Task.Run(()=> contactRepository.EditContact(contact)) : await Task.Run(() => contactRepository.AddContact(contact));
            string messageText = i > 0 ? (contact.ID > 0) ? Strings.EditContactOkay : Strings.AddContactOkay : Strings.SomethingError;
            string captionText = i > 0 ? Strings.Success : Strings.Error;
            MessageBox.Show(messageText, captionText);
            Dispose();
        }

        private void AddEditContactFormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
        }
    }
}
