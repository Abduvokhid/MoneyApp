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
            this.pl_main = new System.Windows.Forms.Panel();
            this.btn_add_editEvent = new System.Windows.Forms.Button();
            this.groupBoxRecEv.SuspendLayout();
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
            // comboBoxContact
            // 
            this.comboBoxContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxContact.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.comboBoxContact.FormattingEnabled = true;
            this.comboBoxContact.Location = new System.Drawing.Point(114, 109);
            this.comboBoxContact.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxContact.Name = "comboBoxContact";
            this.comboBoxContact.Size = new System.Drawing.Size(200, 25);
            this.comboBoxContact.TabIndex = 34;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblContact.Location = new System.Drawing.Point(51, 112);
            this.lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(54, 15);
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
            this.lblNote.Size = new System.Drawing.Size(37, 15);
            this.lblNote.TabIndex = 32;
            this.lblNote.Text = "Note:";
            // 
            // richTextBoxEvNote
            // 
            this.richTextBoxEvNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxEvNote.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.richTextBoxEvNote.Location = new System.Drawing.Point(114, 204);
            this.richTextBoxEvNote.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxEvNote.Name = "richTextBoxEvNote";
            this.richTextBoxEvNote.Size = new System.Drawing.Size(200, 71);
            this.richTextBoxEvNote.TabIndex = 31;
            this.richTextBoxEvNote.Text = "";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblDateTime.Location = new System.Drawing.Point(68, 178);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(37, 15);
            this.lblDateTime.TabIndex = 30;
            this.lblDateTime.Text = "Date:";
            // 
            // eventDateTimePick
            // 
            this.eventDateTimePick.CustomFormat = "dd/MM/yyyy HH:mm";
            this.eventDateTimePick.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.eventDateTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.eventDateTimePick.Location = new System.Drawing.Point(114, 173);
            this.eventDateTimePick.Margin = new System.Windows.Forms.Padding(4);
            this.eventDateTimePick.Name = "eventDateTimePick";
            this.eventDateTimePick.Size = new System.Drawing.Size(200, 23);
            this.eventDateTimePick.TabIndex = 29;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblType.Location = new System.Drawing.Point(71, 79);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(38, 15);
            this.lblType.TabIndex = 26;
            this.lblType.Text = "Type:";
            // 
            // comboBoxEvType
            // 
            this.comboBoxEvType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEvType.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEvType.FormattingEnabled = true;
            this.comboBoxEvType.Items.AddRange(new object[] {
            "Task",
            "Appointment"});
            this.comboBoxEvType.Location = new System.Drawing.Point(114, 76);
            this.comboBoxEvType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEvType.Name = "comboBoxEvType";
            this.comboBoxEvType.Size = new System.Drawing.Size(200, 25);
            this.comboBoxEvType.TabIndex = 25;
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
            // txtEventName
            // 
            this.txtEventName.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEventName.Location = new System.Drawing.Point(114, 45);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(200, 23);
            this.txtEventName.TabIndex = 23;
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
            this.lbllocation.Size = new System.Drawing.Size(59, 15);
            this.lbllocation.TabIndex = 39;
            this.lbllocation.Text = "Location:";
            // 
            // eventLocation
            // 
            this.eventLocation.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.eventLocation.Location = new System.Drawing.Point(114, 142);
            this.eventLocation.Margin = new System.Windows.Forms.Padding(4);
            this.eventLocation.Name = "eventLocation";
            this.eventLocation.Size = new System.Drawing.Size(200, 23);
            this.eventLocation.TabIndex = 38;
            // 
            // checkBoxERecurring
            // 
            this.checkBoxERecurring.AutoSize = true;
            this.checkBoxERecurring.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.checkBoxERecurring.Location = new System.Drawing.Point(114, 283);
            this.checkBoxERecurring.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxERecurring.Name = "checkBoxERecurring";
            this.checkBoxERecurring.Size = new System.Drawing.Size(140, 19);
            this.checkBoxERecurring.TabIndex = 41;
            this.checkBoxERecurring.Text = "Is it recurring event?";
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
            this.groupBoxRecEv.Location = new System.Drawing.Point(27, 305);
            this.groupBoxRecEv.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxRecEv.Name = "groupBoxRecEv";
            this.groupBoxRecEv.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxRecEv.Size = new System.Drawing.Size(309, 106);
            this.groupBoxRecEv.TabIndex = 40;
            this.groupBoxRecEv.TabStop = false;
            this.groupBoxRecEv.Visible = false;
            // 
            // cbEUndefined
            // 
            this.cbEUndefined.AutoSize = true;
            this.cbEUndefined.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.cbEUndefined.Location = new System.Drawing.Point(89, 75);
            this.cbEUndefined.Name = "cbEUndefined";
            this.cbEUndefined.Size = new System.Drawing.Size(90, 19);
            this.cbEUndefined.TabIndex = 18;
            this.cbEUndefined.Text = "Never ends";
            this.cbEUndefined.UseVisualStyleBackColor = true;
            this.cbEUndefined.CheckedChanged += new System.EventHandler(this.cbEUndefined_CheckedChanged);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblEndDate.Location = new System.Drawing.Point(21, 53);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(59, 15);
            this.lblEndDate.TabIndex = 16;
            this.lblEndDate.Text = "End date:";
            // 
            // dateTimeEvEndDate
            // 
            this.dateTimeEvEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimeEvEndDate.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.dateTimeEvEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeEvEndDate.Location = new System.Drawing.Point(89, 48);
            this.dateTimeEvEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeEvEndDate.Name = "dateTimeEvEndDate";
            this.dateTimeEvEndDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimeEvEndDate.TabIndex = 15;
            // 
            // lblEventStatus
            // 
            this.lblEventStatus.AutoSize = true;
            this.lblEventStatus.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblEventStatus.Location = new System.Drawing.Point(11, 18);
            this.lblEventStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventStatus.Name = "lblEventStatus";
            this.lblEventStatus.Size = new System.Drawing.Size(69, 15);
            this.lblEventStatus.TabIndex = 1;
            this.lblEventStatus.Text = "Frequency:";
            // 
            // comboBoxEStatus
            // 
            this.comboBoxEStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEStatus.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.comboBoxEStatus.FormattingEnabled = true;
            this.comboBoxEStatus.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.comboBoxEStatus.Location = new System.Drawing.Point(89, 15);
            this.comboBoxEStatus.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEStatus.Name = "comboBoxEStatus";
            this.comboBoxEStatus.Size = new System.Drawing.Size(200, 25);
            this.comboBoxEStatus.TabIndex = 0;
            // 
            // pl_main
            // 
            this.pl_main.Controls.Add(this.btn_add_editEvent);
            this.pl_main.Controls.Add(this.richTextBoxEvNote);
            this.pl_main.Controls.Add(this.checkBoxERecurring);
            this.pl_main.Controls.Add(this.groupBoxRecEv);
            this.pl_main.Controls.Add(this.txtEventName);
            this.pl_main.Controls.Add(this.lbllocation);
            this.pl_main.Controls.Add(this.lbl_Add_ContName);
            this.pl_main.Controls.Add(this.eventLocation);
            this.pl_main.Controls.Add(this.comboBoxEvType);
            this.pl_main.Controls.Add(this.lblType);
            this.pl_main.Controls.Add(this.lblHeadingEvent);
            this.pl_main.Controls.Add(this.eventDateTimePick);
            this.pl_main.Controls.Add(this.lblDateTime);
            this.pl_main.Controls.Add(this.comboBoxContact);
            this.pl_main.Controls.Add(this.lblNote);
            this.pl_main.Controls.Add(this.lblContact);
            this.pl_main.Location = new System.Drawing.Point(6, 11);
            this.pl_main.Name = "pl_main";
            this.pl_main.Size = new System.Drawing.Size(370, 468);
            this.pl_main.TabIndex = 42;
            // 
            // btn_add_editEvent
            // 
            this.btn_add_editEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_add_editEvent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_add_editEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_add_editEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_add_editEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_editEvent.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_editEvent.ForeColor = System.Drawing.Color.White;
            this.btn_add_editEvent.Location = new System.Drawing.Point(129, 418);
            this.btn_add_editEvent.Name = "btn_add_editEvent";
            this.btn_add_editEvent.Size = new System.Drawing.Size(100, 34);
            this.btn_add_editEvent.TabIndex = 43;
            this.btn_add_editEvent.Text = "Action";
            this.btn_add_editEvent.UseVisualStyleBackColor = false;
            this.btn_add_editEvent.Click += new System.EventHandler(this.btn_add_editEvent_Click);
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
            this.Text = "AddUpdateEvent";
            this.Load += new System.EventHandler(this.AddUpdateEvent_Load);
            this.SizeChanged += new System.EventHandler(this.AddEditEventSizeChange);
            this.groupBoxRecEv.ResumeLayout(false);
            this.groupBoxRecEv.PerformLayout();
            this.pl_main.ResumeLayout(false);
            this.pl_main.PerformLayout();
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
        private System.Windows.Forms.Panel pl_main;
        private System.Windows.Forms.Button btn_add_editEvent;
    }
}