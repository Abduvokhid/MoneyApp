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
            this.lblContact = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.rtbx_note = new System.Windows.Forms.RichTextBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lblType = new System.Windows.Forms.Label();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.lbl_Add_ContName = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.lblHeadingTransaction = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeadingEvent = new System.Windows.Forms.Label();
            this.lbllocation = new System.Windows.Forms.Label();
            this.tbx_location = new System.Windows.Forms.TextBox();
            this.cbx_recurring = new System.Windows.Forms.CheckBox();
            this.gb_recurring = new System.Windows.Forms.GroupBox();
            this.chbx_infinite = new System.Windows.Forms.CheckBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtp_enddate = new System.Windows.Forms.DateTimePicker();
            this.lblEventStatus = new System.Windows.Forms.Label();
            this.cbx_frequency = new System.Windows.Forms.ComboBox();
            this.pl_main = new System.Windows.Forms.Panel();
            this.btn_action = new System.Windows.Forms.Button();
            this.gb_recurring.SuspendLayout();
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
            this.cbx_contact.Location = new System.Drawing.Point(114, 109);
            this.cbx_contact.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_contact.Name = "cbx_contact";
            this.cbx_contact.Size = new System.Drawing.Size(200, 25);
            this.cbx_contact.TabIndex = 34;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblContact.Location = new System.Drawing.Point(51, 112);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(55, 17);
            this.lblContact.TabIndex = 33;
            this.lblContact.Text = "Contact:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblNote.Location = new System.Drawing.Point(72, 231);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(38, 17);
            this.lblNote.TabIndex = 32;
            this.lblNote.Text = "Note:";
            // 
            // rtbx_note
            // 
            this.rtbx_note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbx_note.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rtbx_note.Location = new System.Drawing.Point(114, 204);
            this.rtbx_note.Margin = new System.Windows.Forms.Padding(4);
            this.rtbx_note.Name = "rtbx_note";
            this.rtbx_note.Size = new System.Drawing.Size(200, 71);
            this.rtbx_note.TabIndex = 31;
            this.rtbx_note.Text = "";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblDateTime.Location = new System.Drawing.Point(68, 178);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(38, 17);
            this.lblDateTime.TabIndex = 30;
            this.lblDateTime.Text = "Date:";
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_date.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(114, 173);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 23);
            this.dtp_date.TabIndex = 29;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblType.Location = new System.Drawing.Point(71, 79);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 17);
            this.lblType.TabIndex = 26;
            this.lblType.Text = "Type:";
            // 
            // cbx_type
            // 
            this.cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_type.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Items.AddRange(new object[] {
            "Task",
            "Appointment"});
            this.cbx_type.Location = new System.Drawing.Point(114, 76);
            this.cbx_type.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(200, 25);
            this.cbx_type.TabIndex = 25;
            // 
            // lbl_Add_ContName
            // 
            this.lbl_Add_ContName.AutoSize = true;
            this.lbl_Add_ContName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Add_ContName.Location = new System.Drawing.Point(65, 48);
            this.lbl_Add_ContName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Add_ContName.Name = "lbl_Add_ContName";
            this.lbl_Add_ContName.Size = new System.Drawing.Size(44, 15);
            this.lbl_Add_ContName.TabIndex = 24;
            this.lbl_Add_ContName.Text = "Name:";
            // 
            // tbx_name
            // 
            this.tbx_name.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbx_name.Location = new System.Drawing.Point(114, 45);
            this.tbx_name.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(200, 23);
            this.tbx_name.TabIndex = 23;
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
            // lblHeadingEvent
            // 
            this.lblHeadingEvent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeadingEvent.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHeadingEvent.Location = new System.Drawing.Point(0, 0);
            this.lblHeadingEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadingEvent.Name = "lblHeadingEvent";
            this.lblHeadingEvent.Size = new System.Drawing.Size(370, 41);
            this.lblHeadingEvent.TabIndex = 36;
            this.lblHeadingEvent.Text = "Add event";
            this.lblHeadingEvent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeadingEvent.UseMnemonic = false;
            // 
            // lbllocation
            // 
            this.lbllocation.AutoSize = true;
            this.lbllocation.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbllocation.Location = new System.Drawing.Point(50, 145);
            this.lbllocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllocation.Name = "lbllocation";
            this.lbllocation.Size = new System.Drawing.Size(60, 17);
            this.lbllocation.TabIndex = 39;
            this.lbllocation.Text = "Location:";
            // 
            // tbx_location
            // 
            this.tbx_location.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.tbx_location.Location = new System.Drawing.Point(114, 142);
            this.tbx_location.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_location.Name = "tbx_location";
            this.tbx_location.Size = new System.Drawing.Size(200, 23);
            this.tbx_location.TabIndex = 38;
            // 
            // cbx_recurring
            // 
            this.cbx_recurring.AutoSize = true;
            this.cbx_recurring.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.cbx_recurring.Location = new System.Drawing.Point(114, 283);
            this.cbx_recurring.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_recurring.Name = "cbx_recurring";
            this.cbx_recurring.Size = new System.Drawing.Size(141, 21);
            this.cbx_recurring.TabIndex = 41;
            this.cbx_recurring.Text = "Is it recurring event?";
            this.cbx_recurring.UseVisualStyleBackColor = true;
            this.cbx_recurring.CheckedChanged += new System.EventHandler(this.RecurringCheckboxChanged);
            // 
            // gb_recurring
            // 
            this.gb_recurring.Controls.Add(this.chbx_infinite);
            this.gb_recurring.Controls.Add(this.lblEndDate);
            this.gb_recurring.Controls.Add(this.dtp_enddate);
            this.gb_recurring.Controls.Add(this.lblEventStatus);
            this.gb_recurring.Controls.Add(this.cbx_frequency);
            this.gb_recurring.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.gb_recurring.Location = new System.Drawing.Point(27, 305);
            this.gb_recurring.Margin = new System.Windows.Forms.Padding(4);
            this.gb_recurring.Name = "gb_recurring";
            this.gb_recurring.Padding = new System.Windows.Forms.Padding(4);
            this.gb_recurring.Size = new System.Drawing.Size(309, 106);
            this.gb_recurring.TabIndex = 40;
            this.gb_recurring.TabStop = false;
            this.gb_recurring.Visible = false;
            // 
            // chbx_infinite
            // 
            this.chbx_infinite.AutoSize = true;
            this.chbx_infinite.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.chbx_infinite.Location = new System.Drawing.Point(89, 75);
            this.chbx_infinite.Name = "chbx_infinite";
            this.chbx_infinite.Size = new System.Drawing.Size(91, 21);
            this.chbx_infinite.TabIndex = 18;
            this.chbx_infinite.Text = "Never ends";
            this.chbx_infinite.UseVisualStyleBackColor = true;
            this.chbx_infinite.CheckedChanged += new System.EventHandler(this.InfiniteCheckboxChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblEndDate.Location = new System.Drawing.Point(21, 53);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(60, 17);
            this.lblEndDate.TabIndex = 16;
            this.lblEndDate.Text = "End date:";
            // 
            // dtp_enddate
            // 
            this.dtp_enddate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_enddate.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.dtp_enddate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_enddate.Location = new System.Drawing.Point(89, 48);
            this.dtp_enddate.Margin = new System.Windows.Forms.Padding(4);
            this.dtp_enddate.Name = "dtp_enddate";
            this.dtp_enddate.Size = new System.Drawing.Size(200, 23);
            this.dtp_enddate.TabIndex = 15;
            // 
            // lblEventStatus
            // 
            this.lblEventStatus.AutoSize = true;
            this.lblEventStatus.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblEventStatus.Location = new System.Drawing.Point(11, 18);
            this.lblEventStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventStatus.Name = "lblEventStatus";
            this.lblEventStatus.Size = new System.Drawing.Size(70, 17);
            this.lblEventStatus.TabIndex = 1;
            this.lblEventStatus.Text = "Frequency:";
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
            this.cbx_frequency.Location = new System.Drawing.Point(89, 15);
            this.cbx_frequency.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_frequency.Name = "cbx_frequency";
            this.cbx_frequency.Size = new System.Drawing.Size(200, 25);
            this.cbx_frequency.TabIndex = 0;
            // 
            // pl_main
            // 
            this.pl_main.Controls.Add(this.btn_action);
            this.pl_main.Controls.Add(this.rtbx_note);
            this.pl_main.Controls.Add(this.cbx_recurring);
            this.pl_main.Controls.Add(this.gb_recurring);
            this.pl_main.Controls.Add(this.tbx_name);
            this.pl_main.Controls.Add(this.lbllocation);
            this.pl_main.Controls.Add(this.lbl_Add_ContName);
            this.pl_main.Controls.Add(this.tbx_location);
            this.pl_main.Controls.Add(this.cbx_type);
            this.pl_main.Controls.Add(this.lblType);
            this.pl_main.Controls.Add(this.lblHeadingEvent);
            this.pl_main.Controls.Add(this.dtp_date);
            this.pl_main.Controls.Add(this.lblDateTime);
            this.pl_main.Controls.Add(this.cbx_contact);
            this.pl_main.Controls.Add(this.lblNote);
            this.pl_main.Controls.Add(this.lblContact);
            this.pl_main.Location = new System.Drawing.Point(6, 11);
            this.pl_main.Name = "pl_main";
            this.pl_main.Size = new System.Drawing.Size(370, 468);
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
            this.btn_action.Location = new System.Drawing.Point(129, 418);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(100, 34);
            this.btn_action.TabIndex = 43;
            this.btn_action.Text = "Action";
            this.btn_action.UseVisualStyleBackColor = false;
            this.btn_action.Click += new System.EventHandler(this.ActionClick);
            // 
            // AddEditEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(384, 491);
            this.Controls.Add(this.pl_main);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHeadingTransaction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(400, 530);
            this.Name = "AddEditEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateEvent";
            this.Load += new System.EventHandler(this.AddUpdateEventLoad);
            this.SizeChanged += new System.EventHandler(this.AddEditEventSizeChange);
            this.gb_recurring.ResumeLayout(false);
            this.gb_recurring.PerformLayout();
            this.pl_main.ResumeLayout(false);
            this.pl_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_contact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.RichTextBox rtbx_note;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.Label lbl_Add_ContName;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label lblHeadingTransaction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeadingEvent;
        private System.Windows.Forms.Label lbllocation;
        private System.Windows.Forms.TextBox tbx_location;
        private System.Windows.Forms.CheckBox cbx_recurring;
        private System.Windows.Forms.GroupBox gb_recurring;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtp_enddate;
        private System.Windows.Forms.Label lblEventStatus;
        private System.Windows.Forms.ComboBox cbx_frequency;
        private System.Windows.Forms.CheckBox chbx_infinite;
        private System.Windows.Forms.Panel pl_main;
        private System.Windows.Forms.Button btn_action;
    }
}