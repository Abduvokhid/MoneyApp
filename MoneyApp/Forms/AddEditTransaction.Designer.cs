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
            this.lbl_Add_ContName = new System.Windows.Forms.Label();
            this.txtTransactionName = new System.Windows.Forms.TextBox();
            this.lblHeadingTransaction = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.transactionDateTimePick = new System.Windows.Forms.DateTimePicker();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.richTextBoxTransactionNote = new System.Windows.Forms.RichTextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxContact = new System.Windows.Forms.ComboBox();
            this.groupBoxRecTrans = new System.Windows.Forms.GroupBox();
            this.chbx_infinite = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTStatus = new System.Windows.Forms.ComboBox();
            this.cbx_recurring = new System.Windows.Forms.CheckBox();
            this.pl_main = new System.Windows.Forms.Panel();
            this.btn_add_editTransaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.groupBoxRecTrans.SuspendLayout();
            this.pl_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_ContName
            // 
            this.lbl_Add_ContName.AutoSize = true;
            this.lbl_Add_ContName.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lbl_Add_ContName.Location = new System.Drawing.Point(46, 62);
            this.lbl_Add_ContName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Add_ContName.Name = "lbl_Add_ContName";
            this.lbl_Add_ContName.Size = new System.Drawing.Size(45, 17);
            this.lbl_Add_ContName.TabIndex = 7;
            this.lbl_Add_ContName.Text = "Name:";
            // 
            // txtTransactionName
            // 
            this.txtTransactionName.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.txtTransactionName.Location = new System.Drawing.Point(95, 59);
            this.txtTransactionName.Margin = new System.Windows.Forms.Padding(2);
            this.txtTransactionName.Name = "txtTransactionName";
            this.txtTransactionName.Size = new System.Drawing.Size(200, 23);
            this.txtTransactionName.TabIndex = 6;
            // 
            // lblHeadingTransaction
            // 
            this.lblHeadingTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeadingTransaction.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblHeadingTransaction.Location = new System.Drawing.Point(0, 0);
            this.lblHeadingTransaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeadingTransaction.Name = "lblHeadingTransaction";
            this.lblHeadingTransaction.Size = new System.Drawing.Size(328, 57);
            this.lblHeadingTransaction.TabIndex = 4;
            this.lblHeadingTransaction.Text = "Add Transaction";
            this.lblHeadingTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeadingTransaction.UseMnemonic = false;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.comboBoxType.Location = new System.Drawing.Point(95, 86);
            this.comboBoxType.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(200, 25);
            this.comboBoxType.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label1.Location = new System.Drawing.Point(52, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblAmount.Location = new System.Drawing.Point(36, 146);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(55, 17);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount:";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.numericUpDownAmount.Location = new System.Drawing.Point(95, 144);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(200, 23);
            this.numericUpDownAmount.TabIndex = 12;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // transactionDateTimePick
            // 
            this.transactionDateTimePick.CustomFormat = "dd/MM/yyyy HH:mm";
            this.transactionDateTimePick.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.transactionDateTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.transactionDateTimePick.Location = new System.Drawing.Point(95, 170);
            this.transactionDateTimePick.Margin = new System.Windows.Forms.Padding(2);
            this.transactionDateTimePick.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.transactionDateTimePick.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.transactionDateTimePick.Name = "transactionDateTimePick";
            this.transactionDateTimePick.Size = new System.Drawing.Size(200, 23);
            this.transactionDateTimePick.TabIndex = 13;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblDateTime.Location = new System.Drawing.Point(53, 170);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(38, 17);
            this.lblDateTime.TabIndex = 14;
            this.lblDateTime.Text = "Date:";
            // 
            // richTextBoxTransactionNote
            // 
            this.richTextBoxTransactionNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxTransactionNote.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.richTextBoxTransactionNote.Location = new System.Drawing.Point(95, 197);
            this.richTextBoxTransactionNote.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxTransactionNote.Name = "richTextBoxTransactionNote";
            this.richTextBoxTransactionNote.Size = new System.Drawing.Size(200, 67);
            this.richTextBoxTransactionNote.TabIndex = 16;
            this.richTextBoxTransactionNote.Text = "";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.lblNote.Location = new System.Drawing.Point(53, 224);
            this.lblNote.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(38, 17);
            this.lblNote.TabIndex = 17;
            this.lblNote.Text = "Note:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label2.Location = new System.Drawing.Point(36, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contact:";
            // 
            // comboBoxContact
            // 
            this.comboBoxContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxContact.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.comboBoxContact.FormattingEnabled = true;
            this.comboBoxContact.Location = new System.Drawing.Point(95, 115);
            this.comboBoxContact.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxContact.Name = "comboBoxContact";
            this.comboBoxContact.Size = new System.Drawing.Size(200, 25);
            this.comboBoxContact.TabIndex = 19;
            // 
            // groupBoxRecTrans
            // 
            this.groupBoxRecTrans.Controls.Add(this.chbx_infinite);
            this.groupBoxRecTrans.Controls.Add(this.label4);
            this.groupBoxRecTrans.Controls.Add(this.dateTimePickerEndDate);
            this.groupBoxRecTrans.Controls.Add(this.label3);
            this.groupBoxRecTrans.Controls.Add(this.comboBoxTStatus);
            this.groupBoxRecTrans.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.groupBoxRecTrans.Location = new System.Drawing.Point(13, 286);
            this.groupBoxRecTrans.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxRecTrans.Name = "groupBoxRecTrans";
            this.groupBoxRecTrans.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxRecTrans.Size = new System.Drawing.Size(298, 98);
            this.groupBoxRecTrans.TabIndex = 21;
            this.groupBoxRecTrans.TabStop = false;
            this.groupBoxRecTrans.Visible = false;
            // 
            // chbx_infinite
            // 
            this.chbx_infinite.AutoSize = true;
            this.chbx_infinite.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.chbx_infinite.Location = new System.Drawing.Point(83, 71);
            this.chbx_infinite.Name = "chbx_infinite";
            this.chbx_infinite.Size = new System.Drawing.Size(91, 21);
            this.chbx_infinite.TabIndex = 23;
            this.chbx_infinite.Text = "Never ends";
            this.chbx_infinite.UseVisualStyleBackColor = true;
            this.chbx_infinite.CheckedChanged += new System.EventHandler(this.chbx_infinite_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label4.Location = new System.Drawing.Point(19, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "End date:";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(83, 45);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerEndDate.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Frequency:";
            // 
            // comboBoxTStatus
            // 
            this.comboBoxTStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTStatus.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.comboBoxTStatus.FormattingEnabled = true;
            this.comboBoxTStatus.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.comboBoxTStatus.Location = new System.Drawing.Point(83, 16);
            this.comboBoxTStatus.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTStatus.Name = "comboBoxTStatus";
            this.comboBoxTStatus.Size = new System.Drawing.Size(200, 25);
            this.comboBoxTStatus.TabIndex = 0;
            // 
            // cbx_recurring
            // 
            this.cbx_recurring.AutoSize = true;
            this.cbx_recurring.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.cbx_recurring.Location = new System.Drawing.Point(95, 268);
            this.cbx_recurring.Margin = new System.Windows.Forms.Padding(2);
            this.cbx_recurring.Name = "cbx_recurring";
            this.cbx_recurring.Size = new System.Drawing.Size(174, 21);
            this.cbx_recurring.TabIndex = 22;
            this.cbx_recurring.Text = "Is it recurring transaction?";
            this.cbx_recurring.UseVisualStyleBackColor = true;
            this.cbx_recurring.CheckedChanged += new System.EventHandler(this.checkBoxTRecurring_CheckedChanged);
            // 
            // pl_main
            // 
            this.pl_main.Controls.Add(this.btn_add_editTransaction);
            this.pl_main.Controls.Add(this.richTextBoxTransactionNote);
            this.pl_main.Controls.Add(this.cbx_recurring);
            this.pl_main.Controls.Add(this.lblHeadingTransaction);
            this.pl_main.Controls.Add(this.groupBoxRecTrans);
            this.pl_main.Controls.Add(this.txtTransactionName);
            this.pl_main.Controls.Add(this.comboBoxContact);
            this.pl_main.Controls.Add(this.lbl_Add_ContName);
            this.pl_main.Controls.Add(this.label2);
            this.pl_main.Controls.Add(this.comboBoxType);
            this.pl_main.Controls.Add(this.lblNote);
            this.pl_main.Controls.Add(this.label1);
            this.pl_main.Controls.Add(this.lblAmount);
            this.pl_main.Controls.Add(this.lblDateTime);
            this.pl_main.Controls.Add(this.numericUpDownAmount);
            this.pl_main.Controls.Add(this.transactionDateTimePick);
            this.pl_main.Location = new System.Drawing.Point(12, 12);
            this.pl_main.Name = "pl_main";
            this.pl_main.Size = new System.Drawing.Size(328, 437);
            this.pl_main.TabIndex = 23;
            // 
            // btn_add_editTransaction
            // 
            this.btn_add_editTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_add_editTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_add_editTransaction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_add_editTransaction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_add_editTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_editTransaction.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_editTransaction.ForeColor = System.Drawing.Color.White;
            this.btn_add_editTransaction.Location = new System.Drawing.Point(114, 389);
            this.btn_add_editTransaction.Name = "btn_add_editTransaction";
            this.btn_add_editTransaction.Size = new System.Drawing.Size(100, 34);
            this.btn_add_editTransaction.TabIndex = 44;
            this.btn_add_editTransaction.Text = "Action";
            this.btn_add_editTransaction.UseVisualStyleBackColor = false;
            // 
            // AddEditTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(353, 462);
            this.Controls.Add(this.pl_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEditTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUpdateTransaction";
            this.Load += new System.EventHandler(this.AddUpdateTransaction_Load);
            this.SizeChanged += new System.EventHandler(this.AddEditTransactionSizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.groupBoxRecTrans.ResumeLayout(false);
            this.groupBoxRecTrans.PerformLayout();
            this.pl_main.ResumeLayout(false);
            this.pl_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_ContName;
        private System.Windows.Forms.TextBox txtTransactionName;
        private System.Windows.Forms.Label lblHeadingTransaction;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.DateTimePicker transactionDateTimePick;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.RichTextBox richTextBoxTransactionNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxContact;
        private System.Windows.Forms.GroupBox groupBoxRecTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTStatus;
        private System.Windows.Forms.CheckBox cbx_recurring;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.CheckBox chbx_infinite;
        private System.Windows.Forms.Panel pl_main;
        private System.Windows.Forms.Button btn_add_editTransaction;
    }
}