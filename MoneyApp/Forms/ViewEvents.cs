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
    public partial class ViewEvents : Form
    {
        private EventRepository eventRepository;
        private RecurringEventRepository recurringEventRepository;
        private bool isRecurring = false;


        public ViewEvents()
        {
            InitializeComponent();
            Text = Strings.Events;
            eventRepository = EventRepository.Instance;
            ResizeColumns();
        }

        public ViewEvents(bool recurring)
        {
            InitializeComponent();
            isRecurring = recurring;
            Text = Strings.RecurringEvents;
            if (isRecurring == true)
            {
                lv_events.Columns.Add("Status Type");
                lv_events.Columns.Add("End Date");
                recurringEventRepository = RecurringEventRepository.Instance;
            }
            ResizeColumns();
            eventRepository = EventRepository.Instance;

        }

        private async void ViewEventsActivated(object sender, EventArgs e)
        {
            if (isRecurring)
            {
                List<RecurringEvent> EventList = await Task.Run(() => recurringEventRepository.GetRecurringEvents(Instances.User.ID));

                lv_events.Items.Clear();

                foreach (RecurringEvent events in EventList)
                {
                    string EndDateText = (events.EndDate == DateTime.MinValue) ?
                        "Never ends" : events.EndDate.ToString();

                    ListViewItem eventListViewItem = new ListViewItem(new string[] {
                        events.Name,
                        events.ContactName,
                        events.TypeName,
                        events.Location,
                        events.Note,
                        events.CreatedDate.ToString(),
                        events.Status,
                        EndDateText
                    });

                    eventListViewItem.Tag = events;

                    lv_events.Items.Add(eventListViewItem);

                }
            }
            else
            {
                List<Event> eventsList = await Task.Run(() => eventRepository.GetUserEvents(Instances.User.ID));

                lv_events.Items.Clear();

                foreach (Event events in eventsList)
                {
                    ListViewItem eventListViewItem = new ListViewItem(new string[] { events.Name, events.TypeName,
                    events.Location, events.ContactName, events.CreatedDate.ToString(), events.Note });
                    eventListViewItem.Tag = events;
                    lv_events.Items.Add(eventListViewItem);
                }
            }
        }

        private void AddClick(object sender, EventArgs e)
        {
            AddEditEvent addEditEvent = new AddEditEvent();
            addEditEvent.Activate();
            addEditEvent.ShowDialog();
        }

        private void EditClick(object sender, EventArgs e)
        {
            if (lv_events.SelectedItems.Count > 0)
            {
                if (isRecurring)
                {
                    RecurringEvent selectedEvent = (RecurringEvent)lv_events.SelectedItems[0].Tag;
                    AddEditEvent addEditEvent = new AddEditEvent(selectedEvent);
                    addEditEvent.Activate();
                    addEditEvent.ShowDialog();
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

        private async void DeleteClick(object sender, EventArgs e)
        {
            if (lv_events.SelectedItems.Count > 0)
            {
                if (isRecurring)
                {
                    RecurringEvent selectedEvent = (RecurringEvent)lv_events.SelectedItems[0].Tag;

                    bool eventResult = await Task.Run(() => recurringEventRepository.DeleteRecurringEvent(selectedEvent));

                    if (eventResult) MessageBox.Show(Strings.DeleteSuccess, Strings.Success);
                    else MessageBox.Show(Strings.SomethingError, Strings.Error);
                }
                else
                {
                    Event selectedEvent = (Event)lv_events.SelectedItems[0].Tag;

                    bool eventResult = await Task.Run(() => eventRepository.DeleteEvent(selectedEvent));

                    if (eventResult) MessageBox.Show(Strings.DeleteSuccess, Strings.Success);
                    else MessageBox.Show(Strings.SomethingError, Strings.Error);
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
