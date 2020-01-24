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

namespace MoneyApp.Forms
{
    public partial class AddEditTransaction : Form
    {
        private Transaction auTransactionObj;
        private RecurringTransaction auRecTransactionObj;
        private bool isRecurring = false;
        public AddEditTransaction()
        {
            AddTransaction();
        }

        private void AddTransaction()
        {
            InitializeComponent();
            btn_add_editTransaction.Text = "Add Transaction";
            auTransactionObj = new Transaction
            {
                UserID = Instances.User.ID
            };
            lblHeadingTransaction.Text = "Add Transaction";
            ResizePanel();
            comboBoxTStatus.SelectedIndex = 0;
            comboBoxType.SelectedIndex = 0;
        }

        //update 
        public AddEditTransaction(Transaction transactionObj)
        {
            InitializeComponent();
            auTransactionObj = transactionObj;
            lblHeadingTransaction.Text = "Update Transaction";
            btn_add_editTransaction.Text = "Update Transaction";
            txtTransactionName.Text = transactionObj.Name;
            comboBoxType.Text = transactionObj.TypeName;
            numericUpDownAmount.Value = transactionObj.Amount;
            transactionDateTimePick.Value = transactionObj.CreatedDate;
            richTextBoxTransactionNote.Text = transactionObj.Note;

            groupBoxRecTrans.Visible = false;
            checkBoxTRecurring.Visible = false;
            ResizePanel();
        }

        //update 
        public AddEditTransaction(RecurringTransaction transactionObj)
        {
            InitializeComponent();
            isRecurring = true;
            auRecTransactionObj = transactionObj;
            lblHeadingTransaction.Text = "Update Recurring Transaction";
            btn_add_editTransaction.Text = "Update Recurring Transaction";
            txtTransactionName.Text = transactionObj.Name;
            comboBoxType.Text = transactionObj.TypeName;
            numericUpDownAmount.Value = transactionObj.Amount;
            transactionDateTimePick.Value = transactionObj.CreatedDate;
            richTextBoxTransactionNote.Text = transactionObj.Note;
            comboBoxTStatus.Text = transactionObj.Status;
            if (transactionObj.EndDate == DateTime.MinValue)
            {
                dateTimePickerEndDate.Enabled = false;
                chbx_infinite.Checked = true;
            } else
            {
                dateTimePickerEndDate.Value = transactionObj.EndDate;
            }

            groupBoxRecTrans.Visible = true;
            checkBoxTRecurring.Visible = false;
            ResizePanel();
        }

        //
        private void btn_add_editTransaction_Click(object sender, EventArgs e)
        {
            
            if (isRecurring)
            {
                UpdateRecurringTransaction();
            } else
            {
                AddUpdateNormTransaction();
            }

        }

        private async void AddUpdateNormTransaction()
        {
            if (txtTransactionName.Text.Equals(""))
            {
                MessageBox.Show("Transaction is Empty! Please add a transaction name.");
                return;
            }
            TransactionRepository transactionsRepository = TransactionRepository.Instance;
            auTransactionObj.Name = txtTransactionName.Text;
            auTransactionObj.TypeName = comboBoxType.Text;
            auTransactionObj.Amount = numericUpDownAmount.Value;
            auTransactionObj.CreatedDate = transactionDateTimePick.Value;
            auTransactionObj.Note = richTextBoxTransactionNote.Text;
            bool result = false;

            //Combo box type of transaction
            if (auTransactionObj.TypeName.Equals("Income"))
            {
                //income-1
                auTransactionObj.Type = true;
            }
            else
            {
                //expense-   2
                auTransactionObj.Type = false;
            }

            Contact contact = (Contact)comboBoxContact.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxContact.Text))
                {
                    auTransactionObj.ContactID = 0;
                }
                else
                {
                    ContactRepository contactsRepository = ContactRepository.Instance;
                    auTransactionObj.ContactID = contactsRepository.AddContact(new Contact { Name = comboBoxContact.Text, UserID = Instances.User.ID });
                }
            }
            else
            {
                auTransactionObj.ContactID = contact.ID;
            }

            if (checkBoxTRecurring.Checked && auTransactionObj.ID == 0)
            {
                RecurringTransaction rt = new RecurringTransaction
                {
                    Name = auTransactionObj.Name,
                    Amount = auTransactionObj.Amount,
                    UserID = auTransactionObj.UserID,
                    Type = auTransactionObj.Type,
                    CreatedDate = auTransactionObj.CreatedDate,
                    Note = auTransactionObj.Note,
                    ContactID = auTransactionObj.ContactID
                };

                if (chbx_infinite.Checked)
                {
                    rt.EndDate = DateTime.MinValue;
                }
                else
                {
                    rt.EndDate = dateTimePickerEndDate.Value;
                }
                rt.Status = comboBoxTStatus.Text;

                RecurringTransactionRepository recurringTransactionRepository = RecurringTransactionRepository.Instance;
                bool i = await Task.Run(() => recurringTransactionRepository.AddTransaction(rt));
                if (i == false)
                {
                    MessageBox.Show("Error!");
                    return;
                }
            }



            //add /edit transaction
            if (auTransactionObj.ID > 0)
            {
                result = await Task.Run(() => transactionsRepository.EditTransaction(auTransactionObj));
            }
            else
            {
                result = await Task.Run(() => transactionsRepository.AddTransaction(auTransactionObj));
            }

            //messageBox for edit and add transaction
            if (auTransactionObj.ID > 0 && result)
            {
                MessageBox.Show("Edited Successfully");
                Dispose();
            }
            else if (result)
            {
                MessageBox.Show("Added Successfully");
                Dispose();
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }


        private async void UpdateRecurringTransaction()
        {
            if (txtTransactionName.Text.Equals(""))
            {
                MessageBox.Show("Transaction is Empty! Please add a transaction name.");
                return;
            }
            RecurringTransactionRepository recurringTransactionsRepository = RecurringTransactionRepository.Instance;
            auRecTransactionObj.Name = txtTransactionName.Text;
            auRecTransactionObj.TypeName = comboBoxType.Text;
            auRecTransactionObj.Amount = numericUpDownAmount.Value;
            auRecTransactionObj.CreatedDate = transactionDateTimePick.Value;
            auRecTransactionObj.Note = richTextBoxTransactionNote.Text;
            bool result = false;

            //Combo box type of transaction
            if (auRecTransactionObj.TypeName.Equals("Income"))
            {
                //income-1
                auRecTransactionObj.Type = true;
            }
            else
            {
                //expense-   0
                auRecTransactionObj.Type = false;
            }

            Contact contact = (Contact)comboBoxContact.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxContact.Text))
                {
                    auRecTransactionObj.ContactID = 0;
                }
                else
                {
                    ContactRepository contactsRepository = ContactRepository.Instance;
                    auRecTransactionObj.ContactID = await Task.Run(() => contactsRepository.AddContact(new Contact { Name = comboBoxContact.Text, UserID = Instances.User.ID }));
                }
            }
            else
            {
                auRecTransactionObj.ContactID = contact.ID;
            }

            if (chbx_infinite.Checked)
            {
                auRecTransactionObj.EndDate = DateTime.MinValue;
            }
            else
            {
                auRecTransactionObj.EndDate = dateTimePickerEndDate.Value;
            }
            auRecTransactionObj.Status = comboBoxTStatus.Text;

            result = await Task.Run(() => recurringTransactionsRepository.EditTransaction(auRecTransactionObj));
            

            //messageBox for edit and add transaction
            if (auRecTransactionObj.ID > 0 && result)
            {
                MessageBox.Show("Edited Successfully");
                Dispose();
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }
        //
        private async void AddUpdateTransaction_Load(object sender, EventArgs e)
        {

            ContactRepository ContactRepo = ContactRepository.Instance;
            // Gets the contact list 
            List<Contact> ContactList = await Task.Run(() => ContactRepo.GetUserContacts(Instances.User.ID));
            comboBoxContact.DataSource = ContactList;
            comboBoxContact.DisplayMember = "Name";
            
            if (isRecurring)
            {
                SetRecTransactionContact(ContactList);
            } else
            {
                SetTransactionContact(ContactList);
            }
        }

        private void SetTransactionContact(List<Contact> ContactList)
        {
            if (auTransactionObj.ID > 0)
            {
                if (auTransactionObj.ContactID == 0)
                {
                    comboBoxContact.Text = "";
                }
                else
                {
                    for (int i = 0; i < ContactList.Count; i++)
                    {
                        if (auTransactionObj.ContactID == ContactList[i].ID)
                        {
                            comboBoxContact.SelectedItem = comboBoxContact.Items[i];
                        }
                    }
                }
            }
        }

        private void SetRecTransactionContact(List<Contact> ContactList)
        {
            if (auRecTransactionObj.ID > 0)
            {
                if (auRecTransactionObj.ContactID == 0)
                {
                    comboBoxContact.Text = "";
                }
                else
                {
                    for (int i = 0; i < ContactList.Count; i++)
                    {
                        if (auRecTransactionObj.ContactID == ContactList[i].ID)
                        {
                            comboBoxContact.SelectedItem = comboBoxContact.Items[i];
                        }
                    }
                }
            }
        }

        //Check box Recurring Transaction and visibility of the groupbox if checked
        private void checkBoxTRecurring_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTRecurring.Checked == true) groupBoxRecTrans.Visible = true;
            else groupBoxRecTrans.Visible = false;

        }

        private void chbx_infinite_CheckedChanged(object sender, EventArgs e)
        {
            if (chbx_infinite.Checked == true) dateTimePickerEndDate.Enabled = false;
            else dateTimePickerEndDate.Enabled = true;
        }

        private void ResizePanel()
        {
            int x = ((Width - pl_main.Width) / 2);
            int y = ((Height - pl_main.Height) / 2);

            pl_main.Location = new Point(x, y);
        }

        private void AddEditTransactionSizeChanged(object sender, EventArgs e)
        {
            ResizePanel();
        }
    }
}
