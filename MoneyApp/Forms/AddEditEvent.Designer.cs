namespace MoneyApp.Forms
{
    partial class AddEditEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditEvent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_contact = new System.Windows.Forms.ComboBox();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.rtbx_note = new System.Windows.Forms.RichTextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_type = new System.Windows.Forms.Label();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.lblHeadingTransaction = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_location = new System.Windows.Forms.Label();
            this.tbx_location = new System.Windows.Forms.TextBox();
            this.chbx_recurring = new System.Windows.Forms.CheckBox();
            this.gbx_recurring = new System.Windows.Forms.GroupBox();
            this.chbx_infinite = new System.Windows.Forms.CheckBox();
            this.lbl_end_date = new System.Windows.Forms.Label();
            this.dtp_enddate = new System.Windows.Forms.DateTimePicker();
            this.lbl_frequency = new System.Windows.Forms.Label();
            this.cbx_frequency = new System.Windows.Forms.ComboBox();
            this.pl_main = new System.Windows.Forms.Panel();
            this.btn_action = new System.Windows.Forms.Button();
            this.gbx_recurring.SuspendLayout();
            this.pl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.panel1.Location = new System.Drawing.Point(-121, -186);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 25);
            this.panel1.TabIndex = 35;
            // 
            // cbx_contact
            // 
            this.cbx_contact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_contact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_contact.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.cbx_contact.FormattingEnabled = true;
            this.cbx_contact.Location = new System.Drawing.Point(96, 101);
            this.cbx_contact.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_contact.Name = "cbx_contact";
            this.cbx_contact.Size = new System.Drawing.Size(200, 25);
            this.cbx_contact.TabIndex = 3;
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_contact.Location = new System.Drawing.Point(33, 104);
            this.lbl_contact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(55, 17);
            this.lbl_contact.TabIndex = 33;
            this.lbl_contact.Text = "Contact:";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_note.Location = new System.Drawing.Point(54, 223);
            this.lbl_note.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(38, 17);
            this.lbl_note.TabIndex = 32;
            this.lbl_note.Text = "Note:";
            // 
            // rtbx_note
            // 
            this.rtbx_note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbx_note.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rtbx_note.Location = new System.Drawing.Point(96, 196);
            this.rtbx_note.Margin = new System.Windows.Forms.Padding(4);
            this.rtbx_note.Name = "rtbx_note";
            this.rtbx_note.Size = new System.Drawing.Size(200, 71);
            this.rtbx_note.TabIndex = 6;
            this.rtbx_note.Text = "";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_date.Location = new System.Drawing.Point(50, 170);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(38, 17);
            this.lbl_date.TabIndex = 30;
            this.lbl_date.Text = "Date:";
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_date.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(96, 165);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 23);
            this.dtp_date.TabIndex = 5;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_type.Location = new System.Drawing.Point(53, 71);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(39, 17);
            this.lbl_type.TabIndex = 26;
            this.lbl_type.Text = "Type:";
            // 
            // cbx_type
            // 
            this.cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_type.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Items.AddRange(new object[] {
            "Task",
            "Appointment"});
            this.cbx_type.Location = new System.Drawing.Point(96, 68);
            this.cbx_type.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(200, 25);
            this.cbx_type.TabIndex = 2;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.Location = new System.Drawing.Point(47, 40);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(44, 15);
            this.lbl_name.TabIndex = 24;
            this.lbl_name.Text = "Name:";
            // 
            // tbx_name
            // 
            this.tbx_name.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_name.Location = new System.Drawing.Point(96, 37);
            this.tbx_name.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(200, 23);
            this.tbx_name.TabIndex = 1;
            // 
            // lblHeadingTransaction
            // 
            this.lblHeadingTransaction.AutoSize = true;
            this.lblHeadingTransaction.Font = new System.Drawing.Font("Candara", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTransaction.Location = new System.Drawing.Point(73, -119);
            this.lblHeadingTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadingTransaction.Name = "lblHeadingTransaction";
            this.lblHeadingTransaction.Size = new System.Drawing.Size(202, 33);
            this.lblHeadingTransaction.TabIndex = 21;
            this.lblHeadingTransaction.Text = "Add Transaction";
            this.lblHeadingTransaction.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.panel2.Location = new System.Drawing.Point(-84, -36);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 25);
            this.panel2.TabIndex = 37;
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(331, 28);
            this.lbl_title.TabIndex = 36;
            this.lbl_title.Text = "Add event";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_title.UseMnemonic = false;
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_location.Location = new System.Drawing.Point(32, 137);
            this.lbl_location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(60, 17);
            this.lbl_location.TabIndex = 39;
            this.lbl_location.Text = "Location:";
            // 
            // tbx_location
            // 
            this.tbx_location.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.tbx_location.Location = new System.Drawing.Point(96, 134);
            this.tbx_location.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_location.Name = "tbx_location";
            this.tbx_location.Size = new System.Drawing.Size(200, 23);
            this.tbx_location.TabIndex = 4;
            // 
            // chbx_recurring
            // 
            this.chbx_recurring.AutoSize = true;
            this.chbx_recurring.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.chbx_recurring.Location = new System.Drawing.Point(96, 275);
            this.chbx_recurring.Margin = new System.Windows.Forms.Padding(4);
            this.chbx_recurring.Name = "chbx_recurring";
            this.chbx_recurring.Size = new System.Drawing.Size(141, 21);
            this.chbx_recurring.TabIndex = 7;
            this.chbx_recurring.Text = "Is it recurring event?";
            this.chbx_recurring.UseVisualStyleBackColor = true;
            this.chbx_recurring.CheckedChanged += new System.EventHandler(this.RecurringCheckboxChanged);
            // 
            // gbx_recurring
            // 
            this.gbx_recurring.Controls.Add(this.chbx_infinite);
            this.gbx_recurring.Controls.Add(this.lbl_end_date);
            this.gbx_recurring.Controls.Add(this.dtp_enddate);
            this.gbx_recurring.Controls.Add(this.lbl_frequency);
            this.gbx_recurring.Controls.Add(this.cbx_frequency);
            this.gbx_recurring.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.gbx_recurring.Location = new System.Drawing.Point(9, 339);
            this.gbx_recurring.Margin = new System.Windows.Forms.Padding(4);
            this.gbx_recurring.Name = "gbx_recurring";
            this.gbx_recurring.Padding = new System.Windows.Forms.Padding(4);
            this.gbx_recurring.Size = new System.Drawing.Size(309, 106);
            this.gbx_recurring.TabIndex = 40;
            this.gbx_recurring.TabStop = false;
            this.gbx_recurring.Visible = false;
            // 
            // chbx_infinite
            // 
            this.chbx_infinite.AutoSize = true;
            this.chbx_infinite.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.chbx_infinite.Location = new System.Drawing.Point(89, 77);
            this.chbx_infinite.Name = "chbx_infinite";
            this.chbx_infinite.Size = new System.Drawing.Size(91, 21);
            this.chbx_infinite.TabIndex = 10;
            this.chbx_infinite.Text = "Never ends";
            this.chbx_infinite.UseVisualStyleBackColor = true;
            this.chbx_infinite.CheckedChanged += new System.EventHandler(this.InfiniteCheckboxChanged);
            // 
            // lbl_end_date
            // 
            this.lbl_end_date.AutoSize = true;
            this.lbl_end_date.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_end_date.Location = new System.Drawing.Point(21, 55);
            this.lbl_end_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_end_date.Name = "lbl_end_date";
            this.lbl_end_date.Size = new System.Drawing.Size(60, 17);
            this.lbl_end_date.TabIndex = 16;
            this.lbl_end_date.Text = "End date:";
            // 
            // dtp_enddate
            // 
            this.dtp_enddate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_enddate.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.dtp_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_enddate.Location = new System.Drawing.Point(89, 50);
            this.dtp_enddate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_enddate.Name = "dtp_enddate";
            this.dtp_enddate.Size = new System.Drawing.Size(200, 23);
            this.dtp_enddate.TabIndex = 9;
            // 
            // lbl_frequency
            // 
            this.lbl_frequency.AutoSize = true;
            this.lbl_frequency.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_frequency.Location = new System.Drawing.Point(11, 20);
            this.lbl_frequency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_frequency.Name = "lbl_frequency";
            this.lbl_frequency.Size = new System.Drawing.Size(70, 17);
            this.lbl_frequency.TabIndex = 1;
            this.lbl_frequency.Text = "Frequency:";
            // 
            // cbx_frequency
            // 
            this.cbx_frequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_frequency.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.cbx_frequency.FormattingEnabled = true;
            this.cbx_frequency.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.cbx_frequency.Location = new System.Drawing.Point(89, 17);
            this.cbx_frequency.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_frequency.Name = "cbx_frequency";
            this.cbx_frequency.Size = new System.Drawing.Size(200, 25);
            this.cbx_frequency.TabIndex = 8;
            // 
            // pl_main
            // 
            this.pl_main.Controls.Add(this.btn_action);
            this.pl_main.Controls.Add(this.rtbx_note);
            this.pl_main.Controls.Add(this.chbx_recurring);
            this.pl_main.Controls.Add(this.gbx_recurring);
            this.pl_main.Controls.Add(this.tbx_name);
            this.pl_main.Controls.Add(this.lbl_location);
            this.pl_main.Controls.Add(this.lbl_name);
            this.pl_main.Controls.Add(this.tbx_location);
            this.pl_main.Controls.Add(this.cbx_type);
            this.pl_main.Controls.Add(this.lbl_type);
            this.pl_main.Controls.Add(this.lbl_title);
            this.pl_main.Controls.Add(this.dtp_date);
            this.pl_main.Controls.Add(this.lbl_date);
            this.pl_main.Controls.Add(this.cbx_contact);
            this.pl_main.Controls.Add(this.lbl_note);
            this.pl_main.Controls.Add(this.lbl_contact);
            this.pl_main.Location = new System.Drawing.Point(4, 10);
            this.pl_main.Name = "pl_main";
            this.pl_main.Size = new System.Drawing.Size(331, 453);
            this.pl_main.TabIndex = 42;
            this.pl_main.Click += new System.EventHandler(this.ActionClick);
            // 
            // btn_action
            // 
            this.btn_action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_action.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_action.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_action.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_action.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_action.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_action.ForeColor = System.Drawing.Color.White;
            this.btn_action.Location = new System.Drawing.Point(113, 301);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(100, 34);
            this.btn_action.TabIndex = 11;
            this.btn_action.Text = "Action";
            this.btn_action.UseVisualStyleBackColor = false;
            this.btn_action.Click += new System.EventHandler(this.ActionClick);
            // 
            // AddEditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(334, 465);
            this.Controls.Add(this.pl_main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeadingTransaction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateEvent";
            this.Load += new System.EventHandler(this.AddUpdateEventLoad);
            this.gbx_recurring.ResumeLayout(false);
            this.gbx_recurring.PerformLayout();
            this.pl_main.ResumeLayout(false);
            this.pl_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_contact;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.RichTextBox rtbx_note;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label lblHeadingTransaction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.TextBox tbx_location;
        private System.Windows.Forms.CheckBox chbx_recurring;
        private System.Windows.Forms.GroupBox gbx_recurring;
        private System.Windows.Forms.Label lbl_end_date;
        private System.Windows.Forms.DateTimePicker dtp_enddate;
        private System.Windows.Forms.Label lbl_frequency;
        private System.Windows.Forms.ComboBox cbx_frequency;
        private System.Windows.Forms.CheckBox chbx_infinite;
        private System.Windows.Forms.Panel pl_main;
        private System.Windows.Forms.Button btn_action;
    }
}