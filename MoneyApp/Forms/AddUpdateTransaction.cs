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
    public partial class AddUpdateTransaction : Form
    {
        private Transaction auTransactionObj;
        public AddUpdateTransaction()
        {
            InitializeComponent();
            btn_add_editTransaction.Text = "Add Transaction";
            auTransactionObj = new Transaction
            {
                UserID = Instances.User.ID
            };
            lblHeadingTransaction.Text = "Add Transaction";
        }

        //update 
        public AddUpdateTransaction(Transaction transactionObj)
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

        }

        //
        private void btn_add_editTransaction_Click(object sender, EventArgs e)
        {
            if (txtTransactionName.Text.Equals(""))
            {
                MessageBox.Show("Transaction is Empty! Please add a transaction name.");
                return;
            }
            TransactionRepository transactionsRepository = TransactionRepository.Instance();
            auTransactionObj.Name = txtTransactionName.Text;
            auTransactionObj.TypeName = comboBoxType.Text;
            auTransactionObj.Amount = numericUpDownAmount.DecimalPlaces;
            auTransactionObj.CreatedDate = transactionDateTimePick.Value;
            auTransactionObj.Note = richTextBoxTransactionNote.Text;
            bool result = false;

            //Combo box type of transaction
            if (auTransactionObj.TypeName.Equals("Income"))
            {
                //income-0
                auTransactionObj.Type = false;
            }
            else
            {
                //expense-   1
                auTransactionObj.Type = true;
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
                    ContactRepository contactsRepository = ContactRepository.Instance();
                    auTransactionObj.ContactID = contactsRepository.AddContact(new Contact { Name = comboBoxContact.Text, UserID = Instances.User.ID });
                }
            }
            else
            {
                auTransactionObj.ContactID = contact.ID;
            }




            //add /edit transaction
            if (auTransactionObj.ID > 0)
            {
                Console.WriteLine(auTransactionObj.ID);
                result = transactionsRepository.EditTransaction(auTransactionObj);
            }
            else
            {
                result = transactionsRepository.AddTransaction(auTransactionObj);
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


        //
        private void AddUpdateTransaction_Load(object sender, EventArgs e)
        {

            ContactRepository ContactRepo = ContactRepository.Instance();
            // Gets the contact list 
            List<Contact> ContactList = ContactRepo.GetUserContacts(Instances.User.ID);
            comboBoxContact.DataSource = ContactList;
            comboBoxContact.DisplayMember = "Name";

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

        //
        private void comboBoxContact_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //Check box Recurring Transaction and visibility of the groupbox if checked
        private void checkBoxTRecurring_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTRecurring.Checked == true) groupBoxRecTrans.Visible = true;
            else groupBoxRecTrans.Visible = false;

        }
    }
}
