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
using MoneyApp.Repositories;
using Strings = MoneyApp.Properties.Strings;

namespace MoneyApp.Forms
{
    public partial class AddEditTransaction : Form
    {
        private Transaction transaction;
        private RecurringTransaction recurringTransaction;
        private bool isRecurring = false;
        public AddEditTransaction()
        {
            InitializeComponent();
            btn_action.Text = Strings.Add;
            transaction = new Transaction
            {
                UserID = Instances.User.ID
            };
            lbl_title.Text = Strings.AddTransaction;
            Text = Strings.AddTransaction;
            cbx_frequency.SelectedIndex = 0;
            cbx_type.SelectedIndex = 0;
            Height -= 100;
        }

        public AddEditTransaction(Transaction temporaryTransaction)
        {
            InitializeComponent();
            transaction = temporaryTransaction;
            lbl_title.Text = Strings.EditTransaction;
            Text = Strings.EditTransaction;
            btn_action.Text = Strings.Edit;
            tbx_name.Text = temporaryTransaction.Name;
            cbx_type.Text = temporaryTransaction.TypeName;
            nud_amount.Value = temporaryTransaction.Amount;
            dtp_date.Value = temporaryTransaction.CreatedDate;
            rtbx_note.Text = temporaryTransaction.Note;

            gbx_recurring.Visible = false;
            chbx_recurring.Visible = false;
            Height -= 120;
            btn_action.Top -= 20;
        }

        public AddEditTransaction(RecurringTransaction temporaryRecurringTransaction)
        {
            InitializeComponent();
            isRecurring = true;
            recurringTransaction = temporaryRecurringTransaction;
            lbl_title.Text = Strings.EditRecurringTransaction;
            Text = Strings.EditRecurringTransaction;
            btn_action.Text = Strings.Edit;
            tbx_name.Text = temporaryRecurringTransaction.Name;
            cbx_type.Text = temporaryRecurringTransaction.TypeName;
            nud_amount.Value = temporaryRecurringTransaction.Amount;
            dtp_date.Value = temporaryRecurringTransaction.CreatedDate;
            rtbx_note.Text = temporaryRecurringTransaction.Note;
            cbx_frequency.Text = temporaryRecurringTransaction.Status;
            if (temporaryRecurringTransaction.EndDate == DateTime.MinValue)
            {
                dtp_end_date.Enabled = false;
                chbx_infinite.Checked = true;
            } else
            {
                dtp_end_date.Value = temporaryRecurringTransaction.EndDate;
            }

            gbx_recurring.Visible = true;
            chbx_recurring.Visible = false;
            btn_action.Top -= 10;
        }
        
        private void ActionClick(object sender, EventArgs e)
        {
            if (isRecurring) EditRecurringTransaction();
            else AddTransaction();
        }

        private async void AddTransaction()
        {
            if (tbx_name.Text.Equals(""))
            {
                MessageBox.Show(Strings.ErrorEmptyName, Strings.Error);
                return;
            }

            TransactionRepository transactionRepository = TransactionRepository.Instance;

            transaction.Name = tbx_name.Text;
            transaction.TypeName = cbx_type.Text;
            transaction.Amount = nud_amount.Value;
            transaction.CreatedDate = dtp_date.Value;
            transaction.Note = rtbx_note.Text;
            transaction.Type = transaction.TypeName.Equals("Income") ? true : false;

            Contact contact = (Contact)cbx_contact.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(cbx_contact.Text)) transaction.ContactID = 0;
                else
                {
                    ContactRepository contactRepository = ContactRepository.Instance;
                    transaction.ContactID = contactRepository.AddContact(new Contact { Name = cbx_contact.Text, UserID = Instances.User.ID });
                }
            }
            else transaction.ContactID = contact.ID;

            if (chbx_recurring.Checked && transaction.ID == 0)
            {
                RecurringTransaction temporaryRecurringTransaction = new RecurringTransaction
                {
                    Name = transaction.Name,
                    Amount = transaction.Amount,
                    UserID = transaction.UserID,
                    Type = transaction.Type,
                    CreatedDate = transaction.CreatedDate,
                    Note = transaction.Note,
                    ContactID = transaction.ContactID
                };

                if (chbx_infinite.Checked) temporaryRecurringTransaction.EndDate = DateTime.MinValue;
                else temporaryRecurringTransaction.EndDate = dtp_end_date.Value;

                temporaryRecurringTransaction.Status = cbx_frequency.Text;

                RecurringTransactionRepository recurringTransactionRepository = RecurringTransactionRepository.Instance;

                bool i = await Task.Run(() => recurringTransactionRepository.AddTransaction(temporaryRecurringTransaction));
                if (i == false)
                {
                    MessageBox.Show(Strings.SomethingError, Strings.Error);
                    return;
                }
            }


            bool result = false;

            if (transaction.ID > 0) result = await Task.Run(() => transactionRepository.EditTransaction(transaction));
            else result = await Task.Run(() => transactionRepository.AddTransaction(transaction));

            if (transaction.ID > 0 && result)
            {
                MessageBox.Show(Strings.EditTransactionOkay, Strings.Success);
                Dispose();
            }
            else if (result)
            {
                MessageBox.Show(Strings.AddTransactionOkay, Strings.Success);
                Dispose();
            }
            else MessageBox.Show(Strings.SomethingError, Strings.Error);

        }

        private async void EditRecurringTransaction()
        {
            if (tbx_name.Text.Equals(""))
            {
                MessageBox.Show(Strings.ErrorEmptyName);
                return;
            }

            RecurringTransactionRepository recurringTransactionRepository = RecurringTransactionRepository.Instance;

            recurringTransaction.Name = tbx_name.Text;
            recurringTransaction.TypeName = cbx_type.Text;
            recurringTransaction.Amount = nud_amount.Value;
            recurringTransaction.CreatedDate = dtp_date.Value;
            recurringTransaction.Note = rtbx_note.Text;
            recurringTransaction.Type = recurringTransaction.TypeName.Equals("Income") ? true : false;

            Contact contact = (Contact)cbx_contact.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(cbx_contact.Text)) recurringTransaction.ContactID = 0;
                else
                {
                    ContactRepository contactRepository = ContactRepository.Instance;
                    recurringTransaction.ContactID = await Task.Run(() => contactRepository.AddContact(new Contact { Name = cbx_contact.Text, UserID = Instances.User.ID }));
                }
            }
            else recurringTransaction.ContactID = contact.ID;

            if (chbx_infinite.Checked) recurringTransaction.EndDate = DateTime.MinValue;
            else recurringTransaction.EndDate = dtp_end_date.Value;

            recurringTransaction.Status = cbx_frequency.Text;

            bool result = false;

            result = await Task.Run(() => recurringTransactionRepository.EditTransaction(recurringTransaction));
            
            if (recurringTransaction.ID > 0 && result)
            {
                MessageBox.Show(Strings.EditRecurringTransactionOkay, Strings.Success);
                Dispose();
            }
            else MessageBox.Show(Strings.SomethingError, Strings.Error);

        }
        
        private async void AddUpdateTransactionLoad(object sender, EventArgs e)
        {

            ContactRepository contactRepository = ContactRepository.Instance;

            List<Contact> contactsList = await Task.Run(() => contactRepository.GetUserContacts(Instances.User.ID));

            cbx_contact.DataSource = contactsList;
            cbx_contact.DisplayMember = "Name";
            
            if (isRecurring) SelectRecurringTransactionContact(contactsList);
            else SelectTransactionContact(contactsList);
        }

        private void SelectTransactionContact(List<Contact> ContactList)
        {
            if (transaction.ID > 0)
            {
                if (transaction.ContactID == 0) cbx_contact.Text = "";
                else
                {
                    for (int i = 0; i < ContactList.Count; i++)
                    {
                        if (transaction.ContactID == ContactList[i].ID) cbx_contact.SelectedItem = cbx_contact.Items[i];
                    }
                }
            }
        }

        private void SelectRecurringTransactionContact(List<Contact> ContactList)
        {
            if (recurringTransaction.ID > 0)
            {
                if (recurringTransaction.ContactID == 0) cbx_contact.Text = "";
                else
                {
                    for (int i = 0; i < ContactList.Count; i++)
                    {
                        if (recurringTransaction.ContactID == ContactList[i].ID) cbx_contact.SelectedItem = cbx_contact.Items[i];
                    }
                }
            }
        }

        private void RecurringCheckboxCheckedChanged(object sender, EventArgs e)
        {
            if (chbx_recurring.Checked == true)
            {
                gbx_recurring.Visible = true;
                Height += 100;
            }
            else
            {
                gbx_recurring.Visible = false;
                Height -= 100;
            }
        }

        private void RecurringInfiniteCheckboxCheckedChanged(object sender, EventArgs e)
        {
            if (chbx_infinite.Checked == true) dtp_end_date.Enabled = false;
            else dtp_end_date.Enabled = true;
        }
    }
}
