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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxContact = new System.Windows.Forms.ComboBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.richTextBoxEvNote = new System.Windows.Forms.RichTextBox();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.eventDateTimePick = new System.Windows.Forms.DateTimePicker();
            this.lblType = new System.Windows.Forms.Label();
            this.comboBoxEvType = new System.Windows.Forms.ComboBox();
            this.lbl_Add_ContName = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.btn_add_editEvent = new System.Windows.Forms.Button();
            this.lblHeadingTransaction = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHeadingEvent = new System.Windows.Forms.Label();
            this.lbllocation = new System.Windows.Forms.Label();
            this.eventLocation = new System.Windows.Forms.TextBox();
            this.checkBoxERecurring = new System.Windows.Forms.CheckBox();
            this.groupBoxRecEv = new System.Windows.Forms.GroupBox();
            this.cbEUndefined = new System.Windows.Forms.CheckBox();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimeEvEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEventStatus = new System.Windows.Forms.Label();
            this.comboBoxEStatus = new System.Windows.Forms.ComboBox();
            this.groupBoxRecEv.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.panel1.Location = new System.Drawing.Point(-36, -150);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 25);
            this.panel1.TabIndex = 35;
            // 
            // comboBoxContact
            // 
            this.comboBoxContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxContact.FormattingEnabled = true;
            this.comboBoxContact.Location = new System.Drawing.Point(327, 239);
            this.comboBoxContact.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxContact.Name = "comboBoxContact";
            this.comboBoxContact.Size = new System.Drawing.Size(394, 33);
            this.comboBoxContact.TabIndex = 34;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.lblContact.Location = new System.Drawing.Point(175, 239);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(93, 25);
            this.lblContact.TabIndex = 33;
            this.lblContact.Text = "Contact";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.lblNote.Location = new System.Drawing.Point(171, 418);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(61, 25);
            this.lblNote.TabIndex = 32;
            this.lblNote.Text = "Note";
            // 
            // richTextBoxEvNote
            // 
            this.richTextBoxEvNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxEvNote.Location = new System.Drawing.Point(327, 418);
            this.richTextBoxEvNote.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxEvNote.Name = "richTextBoxEvNote";
            this.richTextBoxEvNote.Size = new System.Drawing.Size(394, 71);
            this.richTextBoxEvNote.TabIndex = 31;
            this.richTextBoxEvNote.Text = "";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.lblDateTime.Location = new System.Drawing.Point(171, 362);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(127, 25);
            this.lblDateTime.TabIndex = 30;
            this.lblDateTime.Text = "Date -Time";
            // 
            // eventDateTimePick
            // 
            this.eventDateTimePick.CustomFormat = "dd/MM/yyyy HH:mm";
            this.eventDateTimePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventDateTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventDateTimePick.Location = new System.Drawing.Point(327, 356);
            this.eventDateTimePick.Margin = new System.Windows.Forms.Padding(4);
            this.eventDateTimePick.Name = "eventDateTimePick";
            this.eventDateTimePick.Size = new System.Drawing.Size(394, 31);
            this.eventDateTimePick.TabIndex = 29;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(175, 187);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(64, 25);
            this.lblType.TabIndex = 26;
            this.lblType.Text = "Type";
            // 
            // comboBoxEvType
            // 
            this.comboBoxEvType.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEvType.FormattingEnabled = true;
            this.comboBoxEvType.Items.AddRange(new object[] {
            "Task",
            "Appointment"});
            this.comboBoxEvType.Location = new System.Drawing.Point(327, 187);
            this.comboBoxEvType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEvType.Name = "comboBoxEvType";
            this.comboBoxEvType.Size = new System.Drawing.Size(394, 33);
            this.comboBoxEvType.TabIndex = 25;
            this.comboBoxEvType.Text = "Task";
            // 
            // lbl_Add_ContName
            // 
            this.lbl_Add_ContName.AutoSize = true;
            this.lbl_Add_ContName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.lbl_Add_ContName.Location = new System.Drawing.Point(175, 131);
            this.lbl_Add_ContName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Add_ContName.Name = "lbl_Add_ContName";
            this.lbl_Add_ContName.Size = new System.Drawing.Size(72, 25);
            this.lbl_Add_ContName.TabIndex = 24;
            this.lbl_Add_ContName.Text = "Name";
            // 
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEventName.Location = new System.Drawing.Point(327, 126);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(394, 31);
            this.txtEventName.TabIndex = 23;
            // 
            // btn_add_editEvent
            // 
            this.btn_add_editEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.btn_add_editEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_editEvent.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_editEvent.ForeColor = System.Drawing.Color.White;
            this.btn_add_editEvent.Location = new System.Drawing.Point(327, 780);
            this.btn_add_editEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add_editEvent.Name = "btn_add_editEvent";
            this.btn_add_editEvent.Size = new System.Drawing.Size(172, 52);
            this.btn_add_editEvent.TabIndex = 22;
            this.btn_add_editEvent.Text = "Submit";
            this.btn_add_editEvent.UseVisualStyleBackColor = false;
            this.btn_add_editEvent.Click += new System.EventHandler(this.btn_add_editEvent_Click);
            // 
            // lblHeadingTransaction
            // 
            this.lblHeadingTransaction.AutoSize = true;
            this.lblHeadingTransaction.Font = new System.Drawing.Font("Candara", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTransaction.Location = new System.Drawing.Point(158, -83);
            this.lblHeadingTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadingTransaction.Name = "lblHeadingTransaction";
            this.lblHeadingTransaction.Size = new System.Drawing.Size(394, 64);
            this.lblHeadingTransaction.TabIndex = 21;
            this.lblHeadingTransaction.Text = "Add Transaction";
            this.lblHeadingTransaction.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(910, 25);
            this.panel2.TabIndex = 37;
            // 
            // lblHeadingEvent
            // 
            this.lblHeadingEvent.AutoSize = true;
            this.lblHeadingEvent.Font = new System.Drawing.Font("Times New Roman", 22.125F, System.Drawing.FontStyle.Bold);
            this.lblHeadingEvent.Location = new System.Drawing.Point(313, 41);
            this.lblHeadingEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeadingEvent.Name = "lblHeadingEvent";
            this.lblHeadingEvent.Size = new System.Drawing.Size(298, 67);
            this.lblHeadingEvent.TabIndex = 36;
            this.lblHeadingEvent.Text = "Add Event";
            this.lblHeadingEvent.UseMnemonic = false;
            // 
            // lbllocation
            // 
            this.lbllocation.AutoSize = true;
            this.lbllocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.lbllocation.Location = new System.Drawing.Point(175, 299);
            this.lbllocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbllocation.Name = "lbllocation";
            this.lbllocation.Size = new System.Drawing.Size(102, 25);
            this.lbllocation.TabIndex = 39;
            this.lbllocation.Text = "Location";
            // 
            // eventLocation
            // 
            this.eventLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLocation.Location = new System.Drawing.Point(327, 293);
            this.eventLocation.Margin = new System.Windows.Forms.Padding(4);
            this.eventLocation.Name = "eventLocation";
            this.eventLocation.Size = new System.Drawing.Size(394, 31);
            this.eventLocation.TabIndex = 38;
            // 
            // checkBoxERecurring
            // 
            this.checkBoxERecurring.AutoSize = true;
            this.checkBoxERecurring.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.checkBoxERecurring.Location = new System.Drawing.Point(177, 522);
            this.checkBoxERecurring.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxERecurring.Name = "checkBoxERecurring";
            this.checkBoxERecurring.Size = new System.Drawing.Size(213, 29);
            this.checkBoxERecurring.TabIndex = 41;
            this.checkBoxERecurring.Text = "Recurring Event";
            this.checkBoxERecurring.UseVisualStyleBackColor = true;
            this.checkBoxERecurring.CheckedChanged += new System.EventHandler(this.checkBoxERecurring_CheckedChanged);
            // 
            // groupBoxRecEv
            // 
            this.groupBoxRecEv.Controls.Add(this.cbEUndefined);
            this.groupBoxRecEv.Controls.Add(this.lblEndDate);
            this.groupBoxRecEv.Controls.Add(this.dateTimeEvEndDate);
            this.groupBoxRecEv.Controls.Add(this.lblEventStatus);
            this.groupBoxRecEv.Controls.Add(this.comboBoxEStatus);
            this.groupBoxRecEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.groupBoxRecEv.Location = new System.Drawing.Point(177, 554);
            this.groupBoxRecEv.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRecEv.Name = "groupBoxRecEv";
            this.groupBoxRecEv.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRecEv.Size = new System.Drawing.Size(556, 191);
            this.groupBoxRecEv.TabIndex = 40;
            this.groupBoxRecEv.TabStop = false;
            this.groupBoxRecEv.Visible = false;
            // 
            // cbEUndefined
            // 
            this.cbEUndefined.AutoSize = true;
            this.cbEUndefined.Location = new System.Drawing.Point(3, 70);
            this.cbEUndefined.Name = "cbEUndefined";
            this.cbEUndefined.Size = new System.Drawing.Size(250, 29);
            this.cbEUndefined.TabIndex = 18;
            this.cbEUndefined.Text = "Undefined end date";
            this.cbEUndefined.UseVisualStyleBackColor = true;
            this.cbEUndefined.CheckedChanged += new System.EventHandler(this.cbEUndefined_CheckedChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(-2, 114);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(165, 29);
            this.lblEndDate.TabIndex = 16;
            this.lblEndDate.Text = "End Date -Time";
            // 
            // dateTimeEvEndDate
            // 
            this.dateTimeEvEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeEvEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeEvEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEvEndDate.Location = new System.Drawing.Point(238, 114);
            this.dateTimeEvEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeEvEndDate.Name = "dateTimeEvEndDate";
            this.dateTimeEvEndDate.Size = new System.Drawing.Size(252, 31);
            this.dateTimeEvEndDate.TabIndex = 15;
            // 
            // lblEventStatus
            // 
            this.lblEventStatus.AutoSize = true;
            this.lblEventStatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventStatus.Location = new System.Drawing.Point(6, 29);
            this.lblEventStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventStatus.Name = "lblEventStatus";
            this.lblEventStatus.Size = new System.Drawing.Size(135, 29);
            this.lblEventStatus.TabIndex = 1;
            this.lblEventStatus.Text = "Event Status";
            // 
            // comboBoxEStatus
            // 
            this.comboBoxEStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEStatus.FormattingEnabled = true;
            this.comboBoxEStatus.Items.AddRange(new object[] {
            "Weekly",
            "Monthly",
            "Yearly"});
            this.comboBoxEStatus.Location = new System.Drawing.Point(254, 29);
            this.comboBoxEStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEStatus.Name = "comboBoxEStatus";
            this.comboBoxEStatus.Size = new System.Drawing.Size(232, 33);
            this.comboBoxEStatus.TabIndex = 0;
            this.comboBoxEStatus.Text = "Weekly";
            // 
            // AddUpdateEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(924, 967);
            this.Controls.Add(this.checkBoxERecurring);
            this.Controls.Add(this.groupBoxRecEv);
            this.Controls.Add(this.lbllocation);
            this.Controls.Add(this.eventLocation);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblHeadingEvent);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.richTextBoxEvNote);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.eventDateTimePick);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.comboBoxEvType);
            this.Controls.Add(this.lbl_Add_ContName);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.btn_add_editEvent);
            this.Controls.Add(this.lblHeadingTransaction);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddUpdateEvent";
            this.Text = "AddUpdateEvent";
            this.Load += new System.EventHandler(this.AddUpdateEvent_Load);
            this.groupBoxRecEv.ResumeLayout(false);
            this.groupBoxRecEv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.RichTextBox richTextBoxEvNote;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker eventDateTimePick;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox comboBoxEvType;
        private System.Windows.Forms.Label lbl_Add_ContName;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Button btn_add_editEvent;
        private System.Windows.Forms.Label lblHeadingTransaction;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblHeadingEvent;
        private System.Windows.Forms.Label lbllocation;
        private System.Windows.Forms.TextBox eventLocation;
        private System.Windows.Forms.CheckBox checkBoxERecurring;
        private System.Windows.Forms.GroupBox groupBoxRecEv;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimeEvEndDate;
        private System.Windows.Forms.Label lblEventStatus;
        private System.Windows.Forms.ComboBox comboBoxEStatus;
        private System.Windows.Forms.CheckBox cbEUndefined;
    }
}