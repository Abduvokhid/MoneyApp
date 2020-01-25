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
    public partial class AddEditEvent : Form
    {
        private Event temporaryEvent;
        private RecurringEvent temporaryRecurringEvent;
        private bool isRecurring = false;

        public AddEditEvent()
        {
            InitializeComponent();

            btn_action.Text = "Add Event";
            Text = "Add Event";
            lblHeadingEvent.Text = "Add Event";
            cbx_frequency.SelectedIndex = 0;
            cbx_type.SelectedIndex = 0;

            temporaryEvent = new Event { UserID = Instances.User.ID };

            ResizePanel();
        }

        public AddEditEvent(Event temporaryEvent)
        {
            InitializeComponent();

            Text = Strings.EditEvent;
            lblHeadingEvent.Text = Strings.EditEvent;
            btn_action.Text = Strings.Edit;
            gb_recurring.Visible = false;
            cbx_recurring.Visible = false;

            this.temporaryEvent = temporaryEvent;
            tbx_name.Text = temporaryEvent.Name;
            cbx_type.Text = temporaryEvent.TypeName;
            tbx_location.Text = temporaryEvent.Location;
            dtp_date.Value = temporaryEvent.CreatedDate;
            rtbx_note.Text = temporaryEvent.Note;

            ResizePanel();
        }

        public AddEditEvent(RecurringEvent temporaryRecurringEvent)
        {
            InitializeComponent();

            Text = Strings.EditRecurringEvent;
            lblHeadingEvent.Text = Strings.EditRecurringEvent;
            btn_action.Text = Strings.Edit;
            gb_recurring.Visible = true;
            cbx_recurring.Visible = false;
            isRecurring = true;

            this.temporaryRecurringEvent = temporaryRecurringEvent;
            tbx_name.Text = temporaryRecurringEvent.Name;
            cbx_type.Text = temporaryRecurringEvent.TypeName;
            tbx_location.Text = temporaryRecurringEvent.Location;
            dtp_date.Value = temporaryRecurringEvent.CreatedDate;
            rtbx_note.Text = temporaryRecurringEvent.Note;
            cbx_frequency.Text = temporaryRecurringEvent.Status;

            if (temporaryRecurringEvent.EndDate == DateTime.MinValue)
            {
                dtp_enddate.Enabled = false;
                chbx_infinite.Checked = true;
            }
            else dtp_enddate.Value = temporaryRecurringEvent.EndDate;
            
            ResizePanel();
        }
        
        private void ActionClick(object sender, EventArgs e)
        {
            if (isRecurring) UpdateRecurringEvent();
            else AddUpadateNormalEvent();
        }
        
        private async void AddUpdateEventLoad(object sender, EventArgs e)
        {
            ContactRepository contactRepository = ContactRepository.Instance;
            List<Contact> contactsList = await Task.Run(() => contactRepository.GetUserContacts(Instances.User.ID));
            cbx_contact.DataSource = contactsList;
            cbx_contact.DisplayMember = "Name";

            if (isRecurring) SetRecurringEventsContact(contactsList);
            else SetEventContact(contactsList);
        }

        private void RecurringCheckboxChanged(object sender, EventArgs e)
        {
            if (cbx_recurring.Checked == true) gb_recurring.Visible = true;
            else gb_recurring.Visible = false;
        }

        private void InfiniteCheckboxChanged(object sender, EventArgs e)
        {
            if (chbx_infinite.Checked == true) dtp_enddate.Enabled = false;
            else dtp_enddate.Enabled = true;
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

        private async void AddUpadateNormalEvent()
        {
            if (tbx_name.Text.Equals(""))
            {
                MessageBox.Show("Event is Empty! Please add a Event name.");
                return;
            }
            EventRepository eventRepository = EventRepository.Instance;
            temporaryEvent.Name = tbx_name.Text;
            temporaryEvent.TypeName = cbx_type.Text;
            temporaryEvent.Location = tbx_location.Text;
            temporaryEvent.CreatedDate = dtp_date.Value;
            temporaryEvent.Note = rtbx_note.Text;

            RecurringEvent recurringEvent = new RecurringEvent();
            recurringEvent.Status = cbx_frequency.Text;
            recurringEvent.EndDate = dtp_enddate.Value;

            bool result = false;

            if (temporaryEvent.TypeName.Equals("Task")) temporaryEvent.Type = false;
            else temporaryEvent.Type = true;

            Contact contact = (Contact)cbx_contact.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(cbx_contact.Text)) temporaryEvent.ContactID = 0;
                else
                {
                    ContactRepository contactsRepository = ContactRepository.Instance;
                    temporaryEvent.ContactID = await Task.Run(() => contactsRepository.AddContact(new Contact
                    { Name = cbx_contact.Text, UserID = Instances.User.ID }));
                }
            }
            else temporaryEvent.ContactID = contact.ID;

            if (cbx_recurring.Checked && temporaryEvent.ID == 0)
            {
                RecurringEvent temporaryRecurringEvent = new RecurringEvent
                {
                    Name = temporaryEvent.Name,
                    Location = temporaryEvent.Location,
                    Type = temporaryEvent.Type,
                    Note = temporaryEvent.Note,
                    CreatedDate = temporaryEvent.CreatedDate,
                    UserID = temporaryEvent.UserID,
                    ContactID = temporaryEvent.ContactID
                };

                if (chbx_infinite.Checked) temporaryRecurringEvent.EndDate = DateTime.MinValue;
                else temporaryRecurringEvent.EndDate = dtp_enddate.Value;

                temporaryRecurringEvent.Status = cbx_frequency.Text;

                RecurringEventRepository recurringEventRepository = RecurringEventRepository.Instance;
                bool i = await Task.Run(() => recurringEventRepository.AddRecurringEvent(temporaryRecurringEvent));

                if (i == false)
                {
                    MessageBox.Show("Cannot Add Recurring Event!");
                    return;
                }
            }

            if (temporaryEvent.ID > 0) result = await Task.Run(() => eventRepository.EditEvent(temporaryEvent));
            else result = await Task.Run(() => eventRepository.AddEvent(temporaryEvent));

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
            if (tbx_name.Text.Equals(""))
            {
                MessageBox.Show("Event is Empty! Please add a Event name.");
                return;
            }

            RecurringEventRepository eventRepository = RecurringEventRepository.Instance;
            temporaryRecurringEvent.Name = tbx_name.Text;
            temporaryRecurringEvent.TypeName = cbx_type.Text;
            temporaryRecurringEvent.Location = tbx_location.Text;
            temporaryRecurringEvent.CreatedDate = dtp_date.Value;
            temporaryRecurringEvent.Note = rtbx_note.Text;
            RecurringEvent recurringEvent = new RecurringEvent();
            recurringEvent.Status = cbx_frequency.Text;
            recurringEvent.EndDate = dtp_enddate.Value;
            bool result = false;

            if (temporaryRecurringEvent.TypeName.Equals("Task")) temporaryRecurringEvent.Type = false;
            else temporaryRecurringEvent.Type = true;

            Contact contact = (Contact)cbx_contact.SelectedItem;
            if (contact == null)
            {
                if (string.IsNullOrWhiteSpace(cbx_contact.Text)) temporaryRecurringEvent.ContactID = 0;
                else
                {
                    ContactRepository contactRepository = ContactRepository.Instance;
                    temporaryRecurringEvent.ContactID = await Task.Run(() => contactRepository.AddContact(new Contact { Name = cbx_contact.Text, UserID = Instances.User.ID }));
                }
            }
            else temporaryRecurringEvent.ContactID = contact.ID;

            if (chbx_infinite.Checked) temporaryRecurringEvent.EndDate = DateTime.MinValue;
            else temporaryRecurringEvent.EndDate = dtp_enddate.Value;

            temporaryRecurringEvent.Status = cbx_frequency.Text;

            result = await Task.Run(() => eventRepository.EditRecurringEvent(temporaryRecurringEvent));

            if (temporaryRecurringEvent.ID > 0 && result)
            {
                MessageBox.Show("Edited Successfully");
                Dispose();
            }
            else MessageBox.Show("Error!");
        }

        private void SetEventContact(List<Contact> ContactList)
        {
            if (temporaryEvent.ID > 0)
            {
                if (temporaryEvent.ContactID == 0) cbx_contact.Text = "";
                else
                {
                    for (int i = 0; i < ContactList.Count; i++)
                    {
                        if (temporaryEvent.ContactID == ContactList[i].ID) cbx_contact.SelectedItem = cbx_contact.Items[i];
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
                    cbx_contact.Text = "";
                }
                else
                {
                    for (int i = 0; i < ContactList.Count; i++)
                    {
                        if (temporaryRecurringEvent.ContactID == ContactList[i].ID)
                        {
                            cbx_contact.SelectedItem = cbx_contact.Items[i];
                        }
                    }
                }
            }
        }
    }
}
