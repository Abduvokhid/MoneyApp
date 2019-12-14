using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyApp.Forms
{
    public partial class Notification : Form
    {
        public Notification(string text)
        {
            InitializeComponent();

            lbl_close.ForeColor = Color.FromArgb(199, 199, 199);
            lbl_info.Text = text;

            StartPosition = FormStartPosition.Manual;
            Rectangle size = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(size.Width - Width - 10, size.Height - Height - 10);

            GenerateBorders();

            SystemSounds.Exclamation.Play();
            bw_wait.RunWorkerAsync();
        }

        private void GenerateBorders()
        {
            Color color = Color.FromArgb(241, 241, 241);

            Panel left = new Panel
            {
                Height = Height,
                Width = 1,
                BackColor = color,
                Location = new Point(0, 0)
            };
            Controls.Add(left);

            Panel right = new Panel
            {
                Height = Height,
                Width = 1,
                BackColor = color,
                Location = new Point(Width - 1, 0)
            };
            Controls.Add(right);

            Panel top = new Panel
            {
                Height = 1,
                Width = Width,
                BackColor = color,
                Location = new Point(0, 0)
            };
            Controls.Add(top);

            Panel bottom = new Panel
            {
                Height = 1,
                Width = Width,
                BackColor = color,
                Location = new Point(0, Height - 1)
            };
            Controls.Add(bottom);
        }

        private void CloseClick(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CloseMouseEnter(object sender, EventArgs e)
        {
            lbl_close.ForeColor = Color.FromArgb(163, 163, 163);
        }

        private void CloseMouseLeave(object sender, EventArgs e)
        {
            lbl_close.ForeColor = Color.FromArgb(199, 199, 199);
        }

        private void WaitDoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(5000);
        }

        private void WaitCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Dispose();
        }
    }
}
