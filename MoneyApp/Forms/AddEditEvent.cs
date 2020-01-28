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

            btn_action.Text = Strings.Add;
            Text = Strings.AddEvent;
            lbl_title.Text = Strings.AddEvent;
            cbx_frequency.SelectedIndex = 0;
            cbx_type.SelectedIndex = 0;
            Height -= 110;

            temporaryEvent = new Event { UserID = Instances.User.ID };

        }

        public AddEditEvent(Event parameterEvent)
        {
            InitializeComponent();

            Text = Strings.EditEvent;
            lbl_title.Text = Strings.EditEvent;
            btn_action.Text = Strings.Edit;
            gbx_recurring.Visible = false;
            chbx_recurring.Visible = false;
            Height -= 115;
            btn_action.Top -= 10;

            temporaryEvent = parameterEvent;
            tbx_name.Text = parameterEvent.Name;
            cbx_type.Text = parameterEvent.TypeName;
            tbx_location.Text = parameterEvent.Location;
            dtp_date.Value = parameterEvent.CreatedDate;
            rtbx_note.Text = parameterEvent.Note;

        }

        public AddEditEvent(RecurringEvent parameterRecurringEvent)
        {
            InitializeComponent();

            Text = Strings.EditRecurringEvent;
            lbl_title.Text = Strings.EditRecurringEvent;
            btn_action.Text = Strings.Edit;
            gbx_recurring.Visible = true;
            chbx_recurring.Visible = false;
            btn_action.Top -= 10;
            isRecurring = true;

            temporaryRecurringEvent = parameterRecurringEvent;
            tbx_name.Text = parameterRecurringEvent.Name;
            cbx_type.Text = parameterRecurringEvent.TypeName;
            tbx_location.Text = parameterRecurringEvent.Location;
            dtp_date.Value = parameterRecurringEvent.CreatedDate;
            rtbx_note.Text = parameterRecurringEvent.Note;
            cbx_frequency.Text = parameterRecurringEvent.Status;

            if (parameterRecurringEvent.EndDate == DateTime.MinValue)
            {
                dtp_enddate.Enabled = false;
                chbx_infinite.Checked = true;
            }
            else dtp_enddate.Value = parameterRecurringEvent.EndDate;
            
        }
        
        private void ActionClick(object sender, EventArgs e)
        {
            if (isRecurring) UpdateRecurringEvent();
            else AddUpdateEvent();
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
            if (chbx_recurring.Checked == true)
            {
                gbx_recurring.Visible = true;
                Height += 110;
            }
            else
            {
                gbx_recurring.Visible = false;
                Height -= 110;
            }
        }

        private void InfiniteCheckboxChanged(object sender, EventArgs e)
        {
            if (chbx_infinite.Checked == true) dtp_enddate.Enabled = false;
            else dtp_enddate.Enabled = true;
        }
        
        private async void AddUpdateEvent()
        {
            if (tbx_name.Text.Equals(""))
            {
                MessageBox.Show(Strings.ErrorEmptyName, Strings.Error);
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

            if (chbx_recurring.Checked && temporaryEvent.ID == 0)
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
                    MessageBox.Show(Strings.SomethingError);
                    return;
                }
            }

            if (temporaryEvent.ID > 0) result = await Task.Run(() => eventRepository.EditEvent(temporaryEvent));
            else result = await Task.Run(() => eventRepository.AddEvent(temporaryEvent));

            if (temporaryEvent.ID > 0 && result)
            {
                MessageBox.Show(Strings.EditEventOkay, Strings.Success);
                Dispose();
            }
            else if (result)
            {
                MessageBox.Show(Strings.AddEventOkay, Strings.Success);
                Dispose();
            }
            else MessageBox.Show(Strings.SomethingError, Strings.Error);
        }

        private async void UpdateRecurringEvent()
        {
            if (tbx_name.Text.Equals(""))
            {
                MessageBox.Show(Strings.ErrorEmptyName);
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

            bool result = false;

            result = await Task.Run(() => eventRepository.EditRecurringEvent(temporaryRecurringEvent));

            if (temporaryRecurringEvent.ID > 0 && result)
            {
                MessageBox.Show(Strings.EditRecurringEventOkay, Strings.Success);
                Dispose();
            }
            else MessageBox.Show(Strings.SomethingError, Strings.Error);
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
