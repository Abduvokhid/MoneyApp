namespace MoneyApp.Forms
{
    partial class AddEditTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditTransaction));
            this.lbl_name = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.nud_amount = new System.Windows.Forms.NumericUpDown();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.rtbx_note = new System.Windows.Forms.RichTextBox();
            this.lbl_note = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.cbx_contact = new System.Windows.Forms.ComboBox();
            this.gbx_recurring = new System.Windows.Forms.GroupBox();
            this.chbx_infinite = new System.Windows.Forms.CheckBox();
            this.lbl_end_date = new System.Windows.Forms.Label();
            this.dtp_end_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_frequency = new System.Windows.Forms.Label();
            this.cbx_frequency = new System.Windows.Forms.ComboBox();
            this.chbx_recurring = new System.Windows.Forms.CheckBox();
            this.pl_main = new System.Windows.Forms.Panel();
            this.btn_action = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).BeginInit();
            this.gbx_recurring.SuspendLayout();
            this.pl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_name.Location = new System.Drawing.Point(46, 48);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(45, 17);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name:";
            // 
            // tbx_name
            // 
            this.tbx_name.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.tbx_name.Location = new System.Drawing.Point(95, 45);
            this.tbx_name.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(200, 23);
            this.tbx_name.TabIndex = 1;
            // 
            // lbl_title
            // 
            this.lbl_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_title.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(0, 0);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(328, 31);
            this.lbl_title.TabIndex = 4;
            this.lbl_title.Text = "Add Transaction";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_title.UseMnemonic = false;
            // 
            // cbx_type
            // 
            this.cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_type.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cbx_type.Location = new System.Drawing.Point(95, 72);
            this.cbx_type.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(200, 25);
            this.cbx_type.TabIndex = 2;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_type.Location = new System.Drawing.Point(52, 75);
            this.lbl_type.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(39, 17);
            this.lbl_type.TabIndex = 9;
            this.lbl_type.Text = "Type:";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_amount.Location = new System.Drawing.Point(36, 132);
            this.lbl_amount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(55, 17);
            this.lbl_amount.TabIndex = 10;
            this.lbl_amount.Text = "Amount:";
            // 
            // nud_amount
            // 
            this.nud_amount.DecimalPlaces = 2;
            this.nud_amount.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.nud_amount.Location = new System.Drawing.Point(95, 130);
            this.nud_amount.Margin = new System.Windows.Forms.Padding(2);
            this.nud_amount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_amount.Name = "nud_amount";
            this.nud_amount.Size = new System.Drawing.Size(200, 23);
            this.nud_amount.TabIndex = 4;
            this.nud_amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_date.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(95, 156);
            this.dtp_date.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_date.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtp_date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 23);
            this.dtp_date.TabIndex = 5;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_date.Location = new System.Drawing.Point(53, 156);
            this.lbl_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(38, 17);
            this.lbl_date.TabIndex = 14;
            this.lbl_date.Text = "Date:";
            // 
            // rtbx_note
            // 
            this.rtbx_note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbx_note.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.rtbx_note.Location = new System.Drawing.Point(95, 183);
            this.rtbx_note.Margin = new System.Windows.Forms.Padding(2);
            this.rtbx_note.Name = "rtbx_note";
            this.rtbx_note.Size = new System.Drawing.Size(200, 67);
            this.rtbx_note.TabIndex = 6;
            this.rtbx_note.Text = "";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_note.Location = new System.Drawing.Point(53, 210);
            this.lbl_note.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(38, 17);
            this.lbl_note.TabIndex = 17;
            this.lbl_note.Text = "Note:";
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_contact.Location = new System.Drawing.Point(36, 104);
            this.lbl_contact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(55, 17);
            this.lbl_contact.TabIndex = 18;
            this.lbl_contact.Text = "Contact:";
            // 
            // cbx_contact
            // 
            this.cbx_contact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_contact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_contact.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.cbx_contact.FormattingEnabled = true;
            this.cbx_contact.Location = new System.Drawing.Point(95, 101);
            this.cbx_contact.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_contact.Name = "cbx_contact";
            this.cbx_contact.Size = new System.Drawing.Size(200, 25);
            this.cbx_contact.TabIndex = 3;
            // 
            // gbx_recurring
            // 
            this.gbx_recurring.Controls.Add(this.chbx_infinite);
            this.gbx_recurring.Controls.Add(this.lbl_end_date);
            this.gbx_recurring.Controls.Add(this.dtp_end_date);
            this.gbx_recurring.Controls.Add(this.lbl_frequency);
            this.gbx_recurring.Controls.Add(this.cbx_frequency);
            this.gbx_recurring.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.gbx_recurring.Location = new System.Drawing.Point(13, 317);
            this.gbx_recurring.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_recurring.Name = "gbx_recurring";
            this.gbx_recurring.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_recurring.Size = new System.Drawing.Size(298, 98);
            this.gbx_recurring.TabIndex = 21;
            this.gbx_recurring.TabStop = false;
            this.gbx_recurring.Visible = false;
            // 
            // chbx_infinite
            // 
            this.chbx_infinite.AutoSize = true;
            this.chbx_infinite.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.chbx_infinite.Location = new System.Drawing.Point(83, 71);
            this.chbx_infinite.Name = "chbx_infinite";
            this.chbx_infinite.Size = new System.Drawing.Size(91, 21);
            this.chbx_infinite.TabIndex = 10;
            this.chbx_infinite.Text = "Never ends";
            this.chbx_infinite.UseVisualStyleBackColor = true;
            this.chbx_infinite.CheckedChanged += new System.EventHandler(this.RecurringInfiniteCheckboxCheckedChanged);
            // 
            // lbl_end_date
            // 
            this.lbl_end_date.AutoSize = true;
            this.lbl_end_date.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_end_date.Location = new System.Drawing.Point(19, 50);
            this.lbl_end_date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_end_date.Name = "lbl_end_date";
            this.lbl_end_date.Size = new System.Drawing.Size(60, 17);
            this.lbl_end_date.TabIndex = 16;
            this.lbl_end_date.Text = "End date:";
            // 
            // dtp_end_date
            // 
            this.dtp_end_date.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtp_end_date.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.dtp_end_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_end_date.Location = new System.Drawing.Point(83, 45);
            this.dtp_end_date.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_end_date.Name = "dtp_end_date";
            this.dtp_end_date.Size = new System.Drawing.Size(200, 23);
            this.dtp_end_date.TabIndex = 9;
            // 
            // lbl_frequency
            // 
            this.lbl_frequency.AutoSize = true;
            this.lbl_frequency.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_frequency.Location = new System.Drawing.Point(9, 19);
            this.lbl_frequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
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
            this.cbx_frequency.Location = new System.Drawing.Point(83, 16);
            this.cbx_frequency.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_frequency.Name = "cbx_frequency";
            this.cbx_frequency.Size = new System.Drawing.Size(200, 25);
            this.cbx_frequency.TabIndex = 8;
            // 
            // chbx_recurring
            // 
            this.chbx_recurring.AutoSize = true;
            this.chbx_recurring.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.chbx_recurring.Location = new System.Drawing.Point(95, 254);
            this.chbx_recurring.Margin = new System.Windows.Forms.Padding(2);
            this.chbx_recurring.Name = "chbx_recurring";
            this.chbx_recurring.Size = new System.Drawing.Size(174, 21);
            this.chbx_recurring.TabIndex = 7;
            this.chbx_recurring.Text = "Is it recurring transaction?";
            this.chbx_recurring.UseVisualStyleBackColor = true;
            this.chbx_recurring.CheckedChanged += new System.EventHandler(this.RecurringCheckboxCheckedChanged);
            // 
            // pl_main
            // 
            this.pl_main.Controls.Add(this.btn_action);
            this.pl_main.Controls.Add(this.rtbx_note);
            this.pl_main.Controls.Add(this.chbx_recurring);
            this.pl_main.Controls.Add(this.lbl_title);
            this.pl_main.Controls.Add(this.gbx_recurring);
            this.pl_main.Controls.Add(this.tbx_name);
            this.pl_main.Controls.Add(this.cbx_contact);
            this.pl_main.Controls.Add(this.lbl_name);
            this.pl_main.Controls.Add(this.lbl_contact);
            this.pl_main.Controls.Add(this.cbx_type);
            this.pl_main.Controls.Add(this.lbl_note);
            this.pl_main.Controls.Add(this.lbl_type);
            this.pl_main.Controls.Add(this.lbl_amount);
            this.pl_main.Controls.Add(this.lbl_date);
            this.pl_main.Controls.Add(this.nud_amount);
            this.pl_main.Controls.Add(this.dtp_date);
            this.pl_main.Location = new System.Drawing.Point(-1, 12);
            this.pl_main.Name = "pl_main";
            this.pl_main.Size = new System.Drawing.Size(328, 424);
            this.pl_main.TabIndex = 23;
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
            this.btn_action.Location = new System.Drawing.Point(117, 280);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(100, 34);
            this.btn_action.TabIndex = 11;
            this.btn_action.Text = "Action";
            this.btn_action.UseVisualStyleBackColor = false;
            this.btn_action.Click += new System.EventHandler(this.ActionClick);
            // 
            // AddEditTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(325, 440);
            this.Controls.Add(this.pl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddEditTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateTransaction";
            this.Load += new System.EventHandler(this.AddUpdateTransactionLoad);
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).EndInit();
            this.gbx_recurring.ResumeLayout(false);
            this.gbx_recurring.PerformLayout();
            this.pl_main.ResumeLayout(false);
            this.pl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.NumericUpDown nud_amount;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.RichTextBox rtbx_note;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.ComboBox cbx_contact;
        private System.Windows.Forms.GroupBox gbx_recurring;
        private System.Windows.Forms.Label lbl_frequency;
        private System.Windows.Forms.ComboBox cbx_frequency;
        private System.Windows.Forms.CheckBox chbx_recurring;
        private System.Windows.Forms.Label lbl_end_date;
        private System.Windows.Forms.DateTimePicker dtp_end_date;
        private System.Windows.Forms.CheckBox chbx_infinite;
        private System.Windows.Forms.Panel pl_main;
        private System.Windows.Forms.Button btn_action;
    }
}