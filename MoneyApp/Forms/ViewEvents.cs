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
            EventRepo = EventRepository.Instance;
            ResizeColumns();
        }

        //Recurring Event
        public ViewEvents(bool recurring)
        {
            InitializeComponent();
            isRecurring = recurring;
            if (isRecurring == true)
            {

                lv_events.Columns.Add("Status Type");
                lv_events.Columns.Add("End Date");
                recEventRepository = RecurringEventRepository.Instance;

            }
            ResizeColumns();
            EventRepo = EventRepository.Instance;

        }


        //
        private async void viewEventFormActivated(object sender, EventArgs e)
        {
            if (isRecurring)
            {
                List<RecurringEvent> EventList = await Task.Run(() => recEventRepository.GetRecurringEvents(Instances.User.ID));

                //clear the list
                lv_events.Items.Clear();

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

                    lv_events.Items.Add(eventListViewItem);

                }
            }
            else
            {
                List<Event> EventList = await Task.Run(() => EventRepo.GetUserEvents(Instances.User.ID));

                //clear the list
                lv_events.Items.Clear();

                //for loop for every transaction in transactionList
                foreach (Event events in EventList)
                {
                    //Creating row
                    ListViewItem eventListViewItem = new ListViewItem(new string[] { events.Name, events.TypeName,
                    events.Location, events.ContactName, events.CreatedDate.ToString(), events.Note });
                    //selection
                    eventListViewItem.Tag = events;
                    //Display it in the list of Contacts
                    lv_events.Items.Add(eventListViewItem);

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
            if (lv_events.SelectedItems.Count > 0)
            {
                if (isRecurring)
                {

                    RecurringEvent selectedEvent = (RecurringEvent)
                        lv_events.SelectedItems[0].Tag;
                    AddEditEvent addUpdateEvent = new AddEditEvent(selectedEvent);
                    addUpdateEvent.Activate();
                    addUpdateEvent.ShowDialog();
                }
                else
                {
                    Event selectedEvent = (Event)lv_events.SelectedItems[0].Tag;
                    AddEditEvent addUpdateEvent = new AddEditEvent(selectedEvent);
                    addUpdateEvent.Activate();
                    addUpdateEvent.ShowDialog();
                }
            }
        }


        //Delete event
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (lv_events.SelectedItems.Count > 0)
            {
                if (isRecurring)
                {
                    RecurringEvent selectedEvent = (RecurringEvent)lv_events.SelectedItems[0].Tag;

                    bool eventResult = await Task.Run(() => recEventRepository.DeleteRecurringEvent(selectedEvent));
                    if (eventResult)
                    {
                        MessageBox.Show("Successfull!");

                    }
                    else
                        MessageBox.Show("Error!");


                }
                else
                {
                    Event selectedEvent = (Event)lv_events.SelectedItems[0].Tag;

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

        private void ResizeColumns()
        {
            int count = lv_events.Columns.Count;
            int per = (lv_events.Width - 20) / count;

            for (int i = 0; i < count; i++)
            {
                int width = 0;
                if (i == count - 1)
                {
                    width = lv_events.Width - ((count - 1) * per) - 20;
                }
                else
                {
                    width = per;
                }
                lv_events.Columns[i].Width = width;
            }
        }

        private void EventsSizeChanged(object sender, EventArgs e)
        {
            ResizeColumns();
        }
    }
}
