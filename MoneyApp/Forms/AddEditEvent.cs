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
        private Event temporaryEvent;
        private RecurringEvent temporaryRecurringEvent;
        private bool isRecurring = false;

        public AddEditEvent()
        {
            InitializeComponent();

            btn_add_editEvent.Text = "Add Event";
            Text = "Add Event";
            lblHeadingEvent.Text = "Add Event";
            comboBoxEStatus.SelectedIndex = 0;
            comboBoxEvType.SelectedIndex = 0;

            temporaryEvent = new Event { UserID = Instances.User.ID };

            ResizePanel();
        }

        public AddEditEvent(Event eventObj)
        {
            InitializeComponent();

            Text = "Update Event";
            lblHeadingEvent.Text = "Update Event";
            btn_add_editEvent.Text = "Update Event";

            temporaryEvent = eventObj;
            txtEventName.Text = eventObj.Name;
            comboBoxEvType.Text = eventObj.TypeName;
            eventLocation.Text = eventObj.Location;
            eventDateTimePick.Value = eventObj.CreatedDate;
            richTextBoxEvNote.Text = eventObj.Note;
            groupBoxRecEv.Visible = false;
            checkBoxERecurring.Visible = false;

            ResizePanel();
        }

        public AddEditEvent(RecurringEvent eventObj)
        {
            InitializeComponent();
            isRecurring = true;
            temporaryRecurringEvent = eventObj;
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
            temporaryEvent.Name = txtEventName.Text;
            temporaryEvent.TypeName = comboBoxEvType.Text;
            temporaryEvent.Location = eventLocation.Text;
            temporaryEvent.CreatedDate = eventDateTimePick.Value;
            temporaryEvent.Note = richTextBoxEvNote.Text;

            RecurringEvent recurringEvent = new RecurringEvent();
            recurringEvent.Status = comboBoxEStatus.Text;
            recurringEvent.EndDate = dateTimeEvEndDate.Value;

            bool result = false;

            //Combo box type of Event
            if (temporaryEvent.TypeName.Equals("Task"))
            {
                //Task-  0
                temporaryEvent.Type = false;
            }
            else
            {
                //Appointment-  1
                temporaryEvent.Type = true;
            }

            Contact contact = (Contact)comboBoxContact.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxContact.Text))
                {
                    temporaryEvent.ContactID = 0;
                }
                else
                {
                    ContactRepository contactsRepository = ContactRepository.Instance;
                    temporaryEvent.ContactID = await Task.Run(() => contactsRepository.AddContact(new Contact
                    { Name = comboBoxContact.Text, UserID = Instances.User.ID }));
                }
            }
            else
            {
                temporaryEvent.ContactID = contact.ID;
            }

            // 0 -- ADDING
            // MORE THAN 0 EDITING
            if (checkBoxERecurring.Checked && temporaryEvent.ID == 0)
            {
                RecurringEvent recEvents = new RecurringEvent
                {
                    Name = temporaryEvent.Name,
                    Location = temporaryEvent.Location,
                    Type = temporaryEvent.Type,
                    Note = temporaryEvent.Note,
                    CreatedDate = temporaryEvent.CreatedDate,
                    UserID = temporaryEvent.UserID,
                    ContactID = temporaryEvent.ContactID

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
            if (temporaryEvent.ID > 0)
            {

                result = await Task.Run(() => eventRepository.EditEvent(temporaryEvent));
            }
            else
            {
                result = await Task.Run(() => eventRepository.AddEvent(temporaryEvent));
            }

            //messageBox for edit and add Event
            if (temporaryEvent.ID > 0 && result)
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
            temporaryRecurringEvent.Name = txtEventName.Text;
            temporaryRecurringEvent.TypeName = comboBoxEvType.Text;
            temporaryRecurringEvent.Location = eventLocation.Text;
            temporaryRecurringEvent.CreatedDate = eventDateTimePick.Value;
            temporaryRecurringEvent.Note = richTextBoxEvNote.Text;
            RecurringEvent recurringEvent = new RecurringEvent();
            recurringEvent.Status = comboBoxEStatus.Text;
            recurringEvent.EndDate = dateTimeEvEndDate.Value;
            bool result = false;

            //Combo box type of  rec event
            if (temporaryRecurringEvent.TypeName.Equals("Task"))
            {
                //income-0
                temporaryRecurringEvent.Type = false;
            }
            else
            {
                //expense -1
                temporaryRecurringEvent.Type = true;
            }

            Contact contact = (Contact)comboBoxContact.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(comboBoxContact.Text))
                {
                    temporaryRecurringEvent.ContactID = 0;
                }
                else
                {
                    ContactRepository contactsRepository = ContactRepository.Instance;
                    temporaryRecurringEvent.ContactID = await Task.Run(() => contactsRepository.AddContact(new Contact { Name = comboBoxContact.Text, UserID = Instances.User.ID }));
                }
            }
            else
            {
                temporaryRecurringEvent.ContactID = contact.ID;
            }

            if (cbEUndefined.Checked)
            {
                temporaryRecurringEvent.EndDate = DateTime.MinValue;

            }
            else
            {
                temporaryRecurringEvent.EndDate = dateTimeEvEndDate.Value;
            }

            temporaryRecurringEvent.Status = comboBoxEStatus.Text;
            // 0 -- ADDING
            // MORE THAN 0 EDITING

            //add /edit Event

            result = await Task.Run(() => eventRepository.EditRecurringEvent(temporaryRecurringEvent));


            //messageBox for edit and add Event
            if (temporaryRecurringEvent.ID > 0 && result)
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
            if (temporaryEvent.ID > 0)
            {
                if (temporaryEvent.ContactID == 0)
                {
                    comboBoxContact.Text = "";
                }
                else
                {
                    for (int i = 0; i < ContactList.Count; i++)
                    {
                        if (temporaryEvent.ContactID == ContactList[i].ID)
                        {
                            comboBoxContact.SelectedItem = comboBoxContact.Items[i];
                        }
                    }
                }
            }
        }


        private void SetRecurringEventsContact(List<Contact> ContactList)
        {
            if (temporaryRecurringEvent.ID > 0)
            {
                if (temporaryRecurringEvent.ContactID == 0)
                {
                    comboBoxContact.Text = "";
                }
                else
                {
                    for (int i = 0; i < ContactList.Count; i++)
                    {
                        if (temporaryRecurringEvent.ContactID == ContactList[i].ID)
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
