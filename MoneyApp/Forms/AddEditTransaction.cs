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
    public partial class AddEditTransaction : Form
    {
        List<Panel> panels = new List<Panel>();
        int lastYLoc = 0;
        int lastID = 0;
        private Transaction transaction;
        public AddEditTransaction()
        {
            InitializeComponent();
            checkBox1_CheckedChanged();
            /*btn_action.Text = "Add";
            Text = "Add transaction";
            transaction = new Transaction { UserID = Instances.User.ID };
            cbx_type.SelectedItem = cbx_type.Items[0];*/
        }

        public AddEditTransaction(Transaction t)
        {
            InitializeComponent();
            /*transaction = t;
            btn_action.Text = "Edit";
            Text = "Edit transaction";
            tbx_name.Text = t.Name;
            cbx_type.Text = t.TypeName;
            nud_amount.Value = t.Amount;
            dtp_date.Value = t.CreatedDate;
            tbx_note.Text = t.Note;*/
        }

        private void ActionClick(object sender, EventArgs e)
        {

        }

        private void SetDefaultValues()
        {
        }

        private void SetEmptyValues()
        {

        }

        private void AddEditTransactionFormLoad(object sender, EventArgs e)
        {
            /*ContactRepository contactRepository = ContactRepository.Instance();
            List<Contact> contacts = contactRepository.GetUserContacts(Instances.User.ID);
            cbx_contact.DataSource = contacts;
            cbx_contact.DisplayMember = "Name";
            int index = (transaction.ID > 0) ? contacts.FindIndex(c => c.ID == transaction.ContactID) : 0;
            cbx_contact.SelectedItem = cbx_contact.Items[index];*/
        }

        private void checkBox1_CheckedChanged()
        {
            lastID++;
            Label lbl_name;
            Label tbl_contact;
            Label lbl_type;
            Label lbl_amount;
            Label lbl_note;
            Label lbl_date;
            TextBox tbx_name;
            ComboBox cbx_contact;
            ComboBox cbx_type;
            TextBox tbx_note;
            DateTimePicker dtp_date;
            NumericUpDown nud_amount;
            Button btn_action;
            Button btn_help;
            CheckBox chbx_recurring;
            DateTimePicker dateTimePicker1;
            GroupBox gbx_recurring;
            ComboBox comboBox1;
            Button btn_size;
            Panel panel1;
            lbl_name = new System.Windows.Forms.Label();
            tbl_contact = new System.Windows.Forms.Label();
            lbl_type = new System.Windows.Forms.Label();
            lbl_amount = new System.Windows.Forms.Label();
            lbl_note = new System.Windows.Forms.Label();
            lbl_date = new System.Windows.Forms.Label();
            tbx_name = new System.Windows.Forms.TextBox();
            cbx_contact = new System.Windows.Forms.ComboBox();
            cbx_type = new System.Windows.Forms.ComboBox();
            tbx_note = new System.Windows.Forms.TextBox();
            dtp_date = new System.Windows.Forms.DateTimePicker();
            nud_amount = new System.Windows.Forms.NumericUpDown();
            btn_action = new System.Windows.Forms.Button();
            btn_help = new System.Windows.Forms.Button();
            chbx_recurring = new System.Windows.Forms.CheckBox();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            gbx_recurring = new System.Windows.Forms.GroupBox();
            comboBox1 = new System.Windows.Forms.ComboBox();
            btn_size = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            gbx_recurring.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new System.Drawing.Point(90, 37);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new System.Drawing.Size(38, 13);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Name:";
            // 
            // tbl_contact
            // 
            tbl_contact.AutoSize = true;
            tbl_contact.Location = new System.Drawing.Point(81, 63);
            tbl_contact.Name = "tbl_contact";
            tbl_contact.Size = new System.Drawing.Size(47, 13);
            tbl_contact.TabIndex = 1;
            tbl_contact.Text = "Contact:";
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.Location = new System.Drawing.Point(94, 90);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new System.Drawing.Size(34, 13);
            lbl_type.TabIndex = 2;
            lbl_type.Text = "Type:";
            // 
            // lbl_amount
            // 
            lbl_amount.AutoSize = true;
            lbl_amount.Location = new System.Drawing.Point(82, 117);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.Size = new System.Drawing.Size(46, 13);
            lbl_amount.TabIndex = 3;
            lbl_amount.Text = "Amount:";
            // 
            // lbl_note
            // 
            lbl_note.AutoSize = true;
            lbl_note.Location = new System.Drawing.Point(95, 169);
            lbl_note.Name = "lbl_note";
            lbl_note.Size = new System.Drawing.Size(33, 13);
            lbl_note.TabIndex = 4;
            lbl_note.Text = "Note:";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new System.Drawing.Point(95, 146);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new System.Drawing.Size(33, 13);
            lbl_date.TabIndex = 5;
            lbl_date.Text = "Date:";
            // 
            // tbx_name
            // 
            tbx_name.Location = new System.Drawing.Point(134, 34);
            tbx_name.Name = "tbx_name";
            tbx_name.Size = new System.Drawing.Size(100, 20);
            tbx_name.TabIndex = 6;
            // 
            // cbx_contact
            // 
            cbx_contact.FormattingEnabled = true;
            cbx_contact.Location = new System.Drawing.Point(134, 60);
            cbx_contact.Name = "cbx_contact";
            cbx_contact.Size = new System.Drawing.Size(121, 21);
            cbx_contact.TabIndex = 7;
            // 
            // cbx_type
            // 
            cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbx_type.FormattingEnabled = true;
            cbx_type.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            cbx_type.Location = new System.Drawing.Point(134, 87);
            cbx_type.Name = "cbx_type";
            cbx_type.Size = new System.Drawing.Size(121, 21);
            cbx_type.TabIndex = 8;
            // 
            // tbx_note
            // 
            tbx_note.Location = new System.Drawing.Point(134, 166);
            tbx_note.Multiline = true;
            tbx_note.Name = "tbx_note";
            tbx_note.Size = new System.Drawing.Size(234, 76);
            tbx_note.TabIndex = 11;
            // 
            // dtp_date
            // 
            dtp_date.CustomFormat = "HH:mm dd/MM/yyyy";
            dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtp_date.Location = new System.Drawing.Point(134, 140);
            dtp_date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new System.Drawing.Size(144, 20);
            dtp_date.TabIndex = 10;
            dtp_date.Value = new System.DateTime(2019, 12, 6, 16, 37, 48, 298);
            // 
            // nud_amount
            // 
            nud_amount.DecimalPlaces = 2;
            nud_amount.Location = new System.Drawing.Point(134, 115);
            nud_amount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            nud_amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            nud_amount.Name = "nud_amount";
            nud_amount.Size = new System.Drawing.Size(120, 20);
            nud_amount.TabIndex = 9;
            nud_amount.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // btn_action
            // 
            btn_action.Location = new System.Drawing.Point(203, 377);
            btn_action.Name = "btn_action";
            btn_action.Size = new System.Drawing.Size(75, 23);
            btn_action.TabIndex = 12;
            btn_action.UseVisualStyleBackColor = true;
            btn_action.Click += new System.EventHandler(ActionClick);
            // 
            // btn_help
            // 
            btn_help.Location = new System.Drawing.Point(261, 60);
            btn_help.Name = "btn_help";
            btn_help.Size = new System.Drawing.Size(27, 23);
            btn_help.TabIndex = 13;
            btn_help.Text = "?";
            btn_help.UseVisualStyleBackColor = true;
            // 
            // chbx_recurring
            // 
            chbx_recurring.AutoSize = true;
            chbx_recurring.Location = new System.Drawing.Point(134, 248);
            chbx_recurring.Name = "chbx_recurring";
            chbx_recurring.Size = new System.Drawing.Size(72, 17);
            chbx_recurring.TabIndex = 14;
            chbx_recurring.Text = "Recurring";
            chbx_recurring.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(26, 32);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            dateTimePicker1.TabIndex = 15;
            // 
            // gbx_recurring
            // 
            gbx_recurring.Controls.Add(comboBox1);
            gbx_recurring.Controls.Add(dateTimePicker1);
            gbx_recurring.Location = new System.Drawing.Point(108, 271);
            gbx_recurring.Name = "gbx_recurring";
            gbx_recurring.Size = new System.Drawing.Size(260, 100);
            gbx_recurring.TabIndex = 16;
            gbx_recurring.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(25, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(121, 21);
            comboBox1.TabIndex = 16;
            // 
            // btn_size
            // 
            btn_size.Location = new System.Drawing.Point(0, 0);
            btn_size.Name = "btn_size" + lastID;
            btn_size.Size = new System.Drawing.Size(460, 23);
            btn_size.TabIndex = 17;
            btn_size.Text = "Transaction " + lastID;
            btn_size.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            panel1.Controls.Add(btn_size);
            panel1.Controls.Add(lbl_name);
            panel1.Controls.Add(gbx_recurring);
            panel1.Controls.Add(tbl_contact);
            panel1.Controls.Add(chbx_recurring);
            panel1.Controls.Add(lbl_type);
            panel1.Controls.Add(btn_help);
            panel1.Controls.Add(lbl_amount);
            panel1.Controls.Add(btn_action);
            panel1.Controls.Add(lbl_note);
            panel1.Controls.Add(nud_amount);
            panel1.Controls.Add(lbl_date);
            panel1.Controls.Add(dtp_date);
            panel1.Controls.Add(tbx_name);
            panel1.Controls.Add(tbx_note);
            panel1.Controls.Add(cbx_contact);
            panel1.Controls.Add(cbx_type);
            lastYLoc += 12;
            panel1.Location = new System.Drawing.Point(12, lastYLoc);
            panel1.Name = "panel_" + lastID;
            panel1.Size = new System.Drawing.Size(460, 424);
            lastYLoc += 424;
            panel1.TabIndex = 18;

            btn_size.Click += new EventHandler(button_size);
            panels.Add(panel1);
            main_panel.Controls.Add(panel1);
        }

        private void button_size(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Panel panel = (Panel)button.Parent;
            if (panel.Height == 23)
            {
                panel.Height = 424;
            } else
            {
                panel.Height = 23;
            }
            resize_all();
        }

        private void resize_all()
        {
            lastYLoc = 0;
            foreach (Panel p in panels)
            {
                lastYLoc += 12;
                p.Location = new Point(12, lastYLoc);
                if (p.Visible)
                {
                    lastYLoc += p.Size.Height;
                }
            }
        }

        private void  button1_Click(object sender, EventArgs e)
        {
            foreach (Panel p in panels)
            {
                p.Dispose();
            }
            lastYLoc = 0;
            lastID = 0;
            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                 checkBox1_CheckedChanged();
            }
        }
    }
}
