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
    public partial class ViewEvents : Form
    {
        private EventRepository EventRepo;
        private RecurringEventRepository recEventRepository;
        private bool isRecurring = false;


        public ViewEvents()
        {
            InitializeComponent();
            Instances.MoneyApp.Hide();
            EventRepo = EventRepository.Instance();
        }

        //Recurring Event
        public ViewEvents(bool recurring)
        {
            InitializeComponent();
            isRecurring = recurring;
            if (isRecurring == true)
            {

                listViewEvents.Columns.Add("Status Type");
                listViewEvents.Columns.Add("End Date");
                recEventRepository = RecurringEventRepository.Instance();

            }

            Instances.MoneyApp.Hide();
            EventRepo = EventRepository.Instance();

        }


        //
        private async void viewEventFormActivated(object sender, EventArgs e)
        {
            if (isRecurring)
            {
                List<RecurringEvent> EventList = await Task.Run(() => recEventRepository.GetRecEvents(Instances.User.ID));

                //clear the list
                listViewEvents.Items.Clear();

                //for loop for every events in EventList
                foreach (RecurringEvent events in EventList)
                {
                    string EndDateText = (events.EndDate == DateTime.MinValue) ?
                        "Not Applicable" : events.EndDate.ToString();

                    //Creating row
                    ListViewItem eventListViewItem = new ListViewItem(new string[] {events.Name,
                    events.TypeName,
                    events.Location,
                    events.ContactName,
                    events.CreatedDate.ToString(),
                    events.Note,events.Status, EndDateText
                    });

                    eventListViewItem.Tag = events;

                    listViewEvents.Items.Add(eventListViewItem);

                }
            }
            else
            {
                List<Event> EventList = await Task.Run(() => EventRepo.GetUserEvents(Instances.User.ID));

                //clear the list
                listViewEvents.Items.Clear();

                //for loop for every transaction in transactionList
                foreach (Event events in EventList)
                {
                    //Creating row
                    ListViewItem eventListViewItem = new ListViewItem(new string[] { events.Name, events.TypeName,
                    events.Location, events.ContactName, events.CreatedDate.ToString(), events.Note });
                    //selection
                    eventListViewItem.Tag = events;
                    //Display it in the list of Contacts
                    listViewEvents.Items.Add(eventListViewItem);

                }

            }


        }

        //Adding/ creating form, activating and showing it
        private void btn_addEvent_Click(object sender, EventArgs e)
        {
            AddEditEvent addUpdateEvent = new AddEditEvent();
            addUpdateEvent.Activate();
            addUpdateEvent.ShowDialog();
        }

        //Editing event
        private void btn_editEvent_Click(object sender, EventArgs e)
        {
            {
                if (isRecurring)
                {

                    RecurringEvent selectedEvent = (RecurringEvent)
                        listViewEvents.SelectedItems[0].Tag;
                    AddEditEvent addUpdateEvent = new AddEditEvent(selectedEvent);
                    addUpdateEvent.Activate();
                    addUpdateEvent.ShowDialog();
                }
                else
                {
                    Event selectedEvent = (Event)listViewEvents.SelectedItems[0].Tag;
                    AddEditEvent addUpdateEvent = new AddEditEvent(selectedEvent);
                    addUpdateEvent.Activate();
                    addUpdateEvent.ShowDialog();
                }
            }
        }


        //Delete event
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (listViewEvents.SelectedItems.Count > 0)
            {
                if (isRecurring)
                {
                    RecurringEvent selectedEvent = (RecurringEvent)listViewEvents.SelectedItems[0].Tag;

                    bool eventResult = await Task.Run(() => recEventRepository.DeleterecEvent(selectedEvent));
                    if (eventResult)
                    {
                        MessageBox.Show("Successfull!");

                    }
                    else
                        MessageBox.Show("Error!");


                }
                else
                {
                    Event selectedEvent = (Event)listViewEvents.SelectedItems[0].Tag;

                    bool eventResult = await Task.Run(() => EventRepo.DeleteEvent(selectedEvent));
                    if (eventResult)
                    {
                        MessageBox.Show("Successfull!");

                    }
                    else
                        MessageBox.Show("Error!");
                }


            }
        }


        //Form Closed
        private void ViewEventForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            Instances.MoneyApp.Activate();
            Instances.MoneyApp.Show();
        }
    }
}
