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
    public partial class AddEditEvent : Form
    {
        //constructer
        private Event auEventObj;
        private RecurringEvent auRecEventObj;
        private bool isRecurring = false;

        public AddEditEvent()
        {
            InitializeComponent();
            btn_add_editEvent.Text = "Add Event";
            auEventObj = new Event
            {
                UserID = Instances.User.ID
            };
            ResizePanel();
            lblHeadingEvent.Text = "Add Event";
            comboBoxEStatus.SelectedIndex = 0;
            comboBoxEvType.SelectedIndex = 0;
        }


        //update 
        public AddEditEvent(Event eventObj)
        {
            InitializeComponent();
            auEventObj = eventObj;
            lblHeadingEvent.Text = "Update Event";
            btn_add_editEvent.Text = "Update Event";
            txtEventName.Text = eventObj.Name;
            comboBoxEvType.Text = eventObj.TypeName;
            eventLocation.Text = eventObj.Location;
            eventDateTimePick.Value = eventObj.CreatedDate;
            richTextBoxEvNote.Text = eventObj.Note;


            groupBoxRecEv.Visible = false;
            checkBoxERecurring.Visible = false;
            ResizePanel();
        }

        // constructer recurring Event edit
        public AddEditEvent(RecurringEvent eventObj)
        {
            InitializeComponent();
            isRecurring = true;
            auRecEventObj = eventObj;
            lblHeadingEvent.Text = "Update Recurring Event";
            btn_add_editEvent.Text = "Update Recurring Event";
            txtEventName.Text = eventObj.Name;
            comboBoxEvType.Text = eventObj.TypeName;
            eventLocation.Text = eventObj.Location;
            eventDateTimePick.Value = eventObj.CreatedDate;
            richTextBoxEvNote.Text = eventObj.Note;
            comboBoxEStatus.Text = eventObj.Status;

            if (eventObj.EndDate == DateTime.MinValue)
            {
                dateTimeEvEndDate.Enabled = false;
                cbEUndefined.Checked = true;
            }
            else
            {
                dateTimeEvEndDate.Value = eventObj.EndDate;
            }

            groupBoxRecEv.Visible = true;
            checkBoxERecurring.Visible = false;
            ResizePanel();

        }
        //
        private void btn_add_editEvent_Click(object sender, EventArgs e)

        {
            if (isRecurring)
            {
                UpdateRecurringEvent();

            }
            else
            {
                AddUpadateNormalEvent();
            }
        }




        private async void AddUpadateNormalEvent()
        {
            if (txtEventName.Text.Equals(""))
            {
                MessageBox.Show("Event is Empty! Please add a Event name.");
                return;
            }
            EventRepository eventRepository = EventRepository.Instance;
            auEventObj.Name = txtEventName.Text;
            auEventObj.TypeName = comboBoxEvType.Text;
            auEventObj.Location = eventLocation.Text;
            auEventObj.CreatedDate = eventDateTimePick.Value;
            auEventObj.Note = richTextBoxEvNote.Text;

            RecurringEvent recurringEvent = new RecurringEvent();
            recurringEvent.Status = comboBoxEStatus.Text;
            recurringEvent.EndDate = dateTimeEvEndDate.Value;

            bool result = false;

            //Combo box type of Event
            if (auEventObj.TypeName.Equals("Task"))
            {
                //Task-  0
                auEventObj.Type = false;
            }
            else
            {
                //Appointment-  1
                auEventObj.Type = true;
            }

            Contact contact = (Contact)comboBoxContact.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxContact.Text))
                {
                    auEventObj.ContactID = 0;
                }
                else
                {
                    ContactRepository contactsRepository = ContactRepository.Instance;
                    auEventObj.ContactID = await Task.Run(() => contactsRepository.AddContact(new Contact
                    { Name = comboBoxContact.Text, UserID = Instances.User.ID }));
                }
            }
            else
            {
                auEventObj.ContactID = contact.ID;
            }

            // 0 -- ADDING
            // MORE THAN 0 EDITING
            if (checkBoxERecurring.Checked && auEventObj.ID == 0)
            {
                RecurringEvent recEvents = new RecurringEvent
                {
                    Name = auEventObj.Name,
                    Location = auEventObj.Location,
                    Type = auEventObj.Type,
                    Note = auEventObj.Note,
                    CreatedDate = auEventObj.CreatedDate,
                    UserID = auEventObj.UserID,
                    ContactID = auEventObj.ContactID

                };
                if (cbEUndefined.Checked)
                {
                    recEvents.EndDate = DateTime.MinValue;

                }
                else
                {
                    recEvents.EndDate = dateTimeEvEndDate.Value;
                }

                recEvents.Status = comboBoxEStatus.Text;

                RecurringEventRepository recEventsRepo = RecurringEventRepository.Instance;
                bool i = await Task.Run(() => recEventsRepo.AddRecurringEvent(recEvents));

                if (i == false)
                {
                    MessageBox.Show("Cannot Add Recurring Event!");
                    return;

                }
            }



            //add /edit Event
            if (auEventObj.ID > 0)
            {

                result = await Task.Run(() => eventRepository.EditEvent(auEventObj));
            }
            else
            {
                result = await Task.Run(() => eventRepository.AddEvent(auEventObj));
            }

            //messageBox for edit and add Event
            if (auEventObj.ID > 0 && result)
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

        private async void UpdateRecurringEvent()
        {

            if (txtEventName.Text.Equals(""))
            {
                MessageBox.Show("Event is Empty! Please add a Event name.");
                return;
            }
            RecurringEventRepository eventRepository = RecurringEventRepository.Instance;
            auRecEventObj.Name = txtEventName.Text;
            auRecEventObj.TypeName = comboBoxEvType.Text;
            auRecEventObj.Location = eventLocation.Text;
            auRecEventObj.CreatedDate = eventDateTimePick.Value;
            auRecEventObj.Note = richTextBoxEvNote.Text;
            RecurringEvent recurringEvent = new RecurringEvent();
            recurringEvent.Status = comboBoxEStatus.Text;
            recurringEvent.EndDate = dateTimeEvEndDate.Value;
            bool result = false;

            //Combo box type of  rec event
            if (auRecEventObj.TypeName.Equals("Task"))
            {
                //income-0
                auRecEventObj.Type = false;
            }
            else
            {
                //expense -1
                auRecEventObj.Type = true;
            }

            Contact contact = (Contact)comboBoxContact.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxContact.Text))
                {
                    auRecEventObj.ContactID = 0;
                }
                else
                {
                    ContactRepository contactsRepository = ContactRepository.Instance;
                    auRecEventObj.ContactID = await Task.Run(() => contactsRepository.AddContact(new Contact { Name = comboBoxContact.Text, UserID = Instances.User.ID }));
                }
            }
            else
            {
                auRecEventObj.ContactID = contact.ID;
            }

            if (cbEUndefined.Checked)
            {
                auRecEventObj.EndDate = DateTime.MinValue;

            }
            else
            {
                auRecEventObj.EndDate = dateTimeEvEndDate.Value;
            }

            auRecEventObj.Status = comboBoxEStatus.Text;
            // 0 -- ADDING
            // MORE THAN 0 EDITING

            //add /edit Event

            result = await Task.Run(() => eventRepository.EditRecurringEvent(auRecEventObj));


            //messageBox for edit and add Event
            if (auRecEventObj.ID > 0 && result)
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
        private async void AddUpdateEvent_Load(object sender, EventArgs e)
        {

            ContactRepository ContactRepo = ContactRepository.Instance;
            // Gets the contact list 
            List<Contact> ContactList = await Task.Run(() => ContactRepo.GetUserContacts(Instances.User.ID));
            comboBoxContact.DataSource = ContactList;
            comboBoxContact.DisplayMember = "Name";

            if (isRecurring)

            {
                SetRecurringEventsContact(ContactList);
            }
            else
            {
                SetEventContact(ContactList);
            }
        }

        private void SetEventContact(List<Contact> ContactList)
        {
            if (auEventObj.ID > 0)
            {
                if (auEventObj.ContactID == 0)
                {
                    comboBoxContact.Text = "";
                }
                else
                {
                    for (int i = 0; i < ContactList.Count; i++)
                    {
                        if (auEventObj.ContactID == ContactList[i].ID)
                        {
                            comboBoxContact.SelectedItem = comboBoxContact.Items[i];
                        }
                    }
                }
            }
        }


        private void SetRecurringEventsContact(List<Contact> ContactList)
        {
            if (auRecEventObj.ID > 0)
            {
                if (auRecEventObj.ContactID == 0)
                {
                    comboBoxContact.Text = "";
                }
                else
                {
                    for (int i = 0; i < ContactList.Count; i++)
                    {
                        if (auRecEventObj.ContactID == ContactList[i].ID)
                        {
                            comboBoxContact.SelectedItem = comboBoxContact.Items[i];
                        }
                    }
                }
            }
        }



        //Check box Recurring Event and visibility of the groupbox if checked
        private void checkBoxERecurring_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (checkBoxERecurring.Checked == true) groupBoxRecEv.Visible = true;
                else groupBoxRecEv.Visible = false;

            }
        }

        private void cbEUndefined_CheckedChanged(object sender, EventArgs e)
        {
            if (cbEUndefined.Checked == true) dateTimeEvEndDate.Enabled = false;
            else dateTimeEvEndDate.Enabled = true;


        }

        private void AddEditEventSizeChange(object sender, EventArgs e)
        {
            ResizePanel();
        }

        private void ResizePanel()
        {
            int x = ((Width - pl_main.Width) / 2);
            int y = ((Height - pl_main.Height) / 2);

            pl_main.Location = new Point(x, y);
        }
    }
}
