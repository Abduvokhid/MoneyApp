namespace MoneyApp.Forms
{
    partial class ViewEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewEvents));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEventsList = new System.Windows.Forms.Label();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.col_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eventLocation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateTime_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.btn_addEvent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.lblEventsList);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 138);
            this.panel1.TabIndex = 8;
            this.panel1.UseWaitCursor = true;
            // 
            // lblEventsList
            // 
            this.lblEventsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEventsList.AutoSize = true;
            this.lblEventsList.Font = new System.Drawing.Font("Times New Roman", 22.125F, System.Drawing.FontStyle.Bold);
            this.lblEventsList.ForeColor = System.Drawing.Color.White;
            this.lblEventsList.Location = new System.Drawing.Point(518, 39);
            this.lblEventsList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEventsList.Name = "lblEventsList";
            this.lblEventsList.Size = new System.Drawing.Size(312, 67);
            this.lblEventsList.TabIndex = 6;
            this.lblEventsList.Text = "Events List";
            this.lblEventsList.UseWaitCursor = true;
            // 
            // listViewEvents
            // 
            this.listViewEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Name,
            this.Type,
            this.eventLocation,
            this.Contact,
            this.DateTime_col,
            this.Note});
            this.listViewEvents.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.listViewEvents.FullRowSelect = true;
            this.listViewEvents.HideSelection = false;
            this.listViewEvents.Location = new System.Drawing.Point(119, 226);
            this.listViewEvents.Margin = new System.Windows.Forms.Padding(4);
            this.listViewEvents.MultiSelect = false;
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(1063, 442);
            this.listViewEvents.TabIndex = 11;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.View = System.Windows.Forms.View.Details;
            // 
            // col_Name
            // 
            this.col_Name.Text = "Name";
            this.col_Name.Width = 200;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 100;
            // 
            // eventLocation
            // 
            this.eventLocation.Text = "Location";
            this.eventLocation.Width = 200;
            // 
            // Contact
            // 
            this.Contact.Text = "Contact";
            this.Contact.Width = 200;
            // 
            // DateTime_col
            // 
            this.DateTime_col.Text = "Date-Time";
            this.DateTime_col.Width = 250;
            // 
            // Note
            // 
            this.Note.Text = "Note";
            this.Note.Width = 100;
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeleteEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.btnDeleteEvent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnDeleteEvent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEvent.Location = new System.Drawing.Point(916, 745);
            this.btnDeleteEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(232, 60);
            this.btnDeleteEvent.TabIndex = 14;
            this.btnDeleteEvent.Text = "Delete";
            this.btnDeleteEvent.UseVisualStyleBackColor = false;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.btnEditEvent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnEditEvent.ForeColor = System.Drawing.Color.White;
            this.btnEditEvent.Location = new System.Drawing.Point(518, 745);
            this.btnEditEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(232, 60);
            this.btnEditEvent.TabIndex = 13;
            this.btnEditEvent.Text = "Edit";
            this.btnEditEvent.UseVisualStyleBackColor = false;
            this.btnEditEvent.Click += new System.EventHandler(this.btn_editEvent_Click);
            // 
            // btn_addEvent
            // 
            this.btn_addEvent.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_addEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.btn_addEvent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btn_addEvent.ForeColor = System.Drawing.Color.White;
            this.btn_addEvent.Location = new System.Drawing.Point(119, 745);
            this.btn_addEvent.Margin = new System.Windows.Forms.Padding(4);
            this.btn_addEvent.Name = "btn_addEvent";
            this.btn_addEvent.Size = new System.Drawing.Size(232, 60);
            this.btn_addEvent.TabIndex = 12;
            this.btn_addEvent.Text = "Add ";
            this.btn_addEvent.UseVisualStyleBackColor = false;
            this.btn_addEvent.Click += new System.EventHandler(this.btn_addEvent_Click);
            // 
            // ViewEventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1371, 935);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnEditEvent);
            this.Controls.Add(this.btn_addEvent);
            this.Controls.Add(this.listViewEvents);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewEventsForm";
            this.Text = "ViewEventsForm";
            this.Activated += new System.EventHandler(this.viewEventFormActivated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewEventForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEventsList;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.ColumnHeader col_Name;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader DateTime_col;
        private System.Windows.Forms.ColumnHeader Note;
        private System.Windows.Forms.ColumnHeader Contact;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.Button btn_addEvent;
        private System.Windows.Forms.ColumnHeader eventLocation;
    }
}