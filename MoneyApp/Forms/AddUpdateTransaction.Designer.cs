namespace MoneyApp.Forms
{
    partial class AddUpdateTransaction
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
            this.lbl_Add_ContName = new System.Windows.Forms.Label();
            this.txtTransactionName = new System.Windows.Forms.TextBox();
            this.btn_add_editTransaction = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxRecTrans = new System.Windows.Forms.GroupBox();
            this.checkBoxTRecurring = new System.Windows.Forms.CheckBox();
            this.comboBoxTStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.groupBoxRecTrans.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Add_ContName
            // 
            this.lbl_Add_ContName.AutoSize = true;
            this.lbl_Add_ContName.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_ContName.Location = new System.Drawing.Point(155, 256);
            this.lbl_Add_ContName.Name = "lbl_Add_ContName";
            this.lbl_Add_ContName.Size = new System.Drawing.Size(73, 29);
            this.lbl_Add_ContName.TabIndex = 7;
            this.lbl_Add_ContName.Text = "Name";
            // 
            // txtTransactionName
            // 
            this.txtTransactionName.Location = new System.Drawing.Point(306, 250);
            this.txtTransactionName.Name = "txtTransactionName";
            this.txtTransactionName.Size = new System.Drawing.Size(401, 31);
            this.txtTransactionName.TabIndex = 6;
            // 
            // btn_add_editTransaction
            // 
            this.btn_add_editTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.btn_add_editTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_editTransaction.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_editTransaction.ForeColor = System.Drawing.Color.White;
            this.btn_add_editTransaction.Location = new System.Drawing.Point(306, 933);
            this.btn_add_editTransaction.Name = "btn_add_editTransaction";
            this.btn_add_editTransaction.Size = new System.Drawing.Size(171, 51);
            this.btn_add_editTransaction.TabIndex = 5;
            this.btn_add_editTransaction.Text = "Submit";
            this.btn_add_editTransaction.UseVisualStyleBackColor = false;
            this.btn_add_editTransaction.Click += new System.EventHandler(this.btn_add_editTransaction_Click);
            // 
            // lblHeadingTransaction
            // 
            this.lblHeadingTransaction.AutoSize = true;
            this.lblHeadingTransaction.Font = new System.Drawing.Font("Candara", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingTransaction.Location = new System.Drawing.Point(198, 69);
            this.lblHeadingTransaction.Name = "lblHeadingTransaction";
            this.lblHeadingTransaction.Size = new System.Drawing.Size(394, 64);
            this.lblHeadingTransaction.TabIndex = 4;
            this.lblHeadingTransaction.Text = "Add Transaction";
            this.lblHeadingTransaction.UseMnemonic = false;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.comboBoxType.Location = new System.Drawing.Point(306, 312);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(401, 33);
            this.comboBoxType.TabIndex = 8;
            this.comboBoxType.Text = "Income";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(152, 424);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(95, 29);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(306, 424);
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
            this.numericUpDownAmount.Size = new System.Drawing.Size(401, 31);
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
            this.transactionDateTimePick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.transactionDateTimePick.Location = new System.Drawing.Point(306, 202);
            this.transactionDateTimePick.Name = "transactionDateTimePick";
            this.transactionDateTimePick.Size = new System.Drawing.Size(401, 31);
            this.transactionDateTimePick.TabIndex = 13;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(152, 207);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(122, 29);
            this.lblDateTime.TabIndex = 14;
            this.lblDateTime.Text = "Date -Time";
            // 
            // richTextBoxTransactionNote
            // 
            this.richTextBoxTransactionNote.Location = new System.Drawing.Point(309, 484);
            this.richTextBoxTransactionNote.Name = "richTextBoxTransactionNote";
            this.richTextBoxTransactionNote.Size = new System.Drawing.Size(401, 126);
            this.richTextBoxTransactionNote.TabIndex = 16;
            this.richTextBoxTransactionNote.Text = "";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(155, 484);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(62, 29);
            this.lblNote.TabIndex = 17;
            this.lblNote.Text = "Note";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Contact";
            // 
            // comboBoxContact
            // 
            this.comboBoxContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxContact.FormattingEnabled = true;
            this.comboBoxContact.Location = new System.Drawing.Point(306, 365);
            this.comboBoxContact.Name = "comboBoxContact";
            this.comboBoxContact.Size = new System.Drawing.Size(401, 33);
            this.comboBoxContact.TabIndex = 19;
            this.comboBoxContact.SelectedIndexChanged += new System.EventHandler(this.comboBoxContact_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(78)))), ((int)(((byte)(130)))));
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 25);
            this.panel1.TabIndex = 20;
            // 
            // groupBoxRecTrans
            // 
            this.groupBoxRecTrans.Controls.Add(this.label4);
            this.groupBoxRecTrans.Controls.Add(this.dateTimePickerEndDate);
            this.groupBoxRecTrans.Controls.Add(this.label3);
            this.groupBoxRecTrans.Controls.Add(this.comboBoxTStatus);
            this.groupBoxRecTrans.Location = new System.Drawing.Point(151, 703);
            this.groupBoxRecTrans.Name = "groupBoxRecTrans";
            this.groupBoxRecTrans.Size = new System.Drawing.Size(556, 170);
            this.groupBoxRecTrans.TabIndex = 21;
            this.groupBoxRecTrans.TabStop = false;
            this.groupBoxRecTrans.Visible = false;
            // 
            // checkBoxTRecurring
            // 
            this.checkBoxTRecurring.AutoSize = true;
            this.checkBoxTRecurring.Location = new System.Drawing.Point(160, 651);
            this.checkBoxTRecurring.Name = "checkBoxTRecurring";
            this.checkBoxTRecurring.Size = new System.Drawing.Size(256, 29);
            this.checkBoxTRecurring.TabIndex = 22;
            this.checkBoxTRecurring.Text = "Recurring Transaction";
            this.checkBoxTRecurring.UseVisualStyleBackColor = true;
            this.checkBoxTRecurring.CheckedChanged += new System.EventHandler(this.checkBoxTRecurring_CheckedChanged);
            // 
            // comboBoxTStatus
            // 
            this.comboBoxTStatus.FormattingEnabled = true;
            this.comboBoxTStatus.Items.AddRange(new object[] {
            "Weekly",
            "Monthly",
            "Yearly"});
            this.comboBoxTStatus.Location = new System.Drawing.Point(254, 29);
            this.comboBoxTStatus.Name = "comboBoxTStatus";
            this.comboBoxTStatus.Size = new System.Drawing.Size(233, 33);
            this.comboBoxTStatus.TabIndex = 0;
            this.comboBoxTStatus.Text = "Weekly";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Transaction Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-5, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "End Date -Time";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(235, 80);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(252, 31);
            this.dateTimePickerEndDate.TabIndex = 15;
            // 
            // AddUpdateTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(909, 1020);
            this.Controls.Add(this.checkBoxTRecurring);
            this.Controls.Add(this.groupBoxRecTrans);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBoxContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.richTextBoxTransactionNote);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.transactionDateTimePick);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.lbl_Add_ContName);
            this.Controls.Add(this.txtTransactionName);
            this.Controls.Add(this.btn_add_editTransaction);
            this.Controls.Add(this.lblHeadingTransaction);
            this.Name = "AddUpdateTransaction";
            this.Text = "AddUpdateTransaction";
            this.Load += new System.EventHandler(this.AddUpdateTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.groupBoxRecTrans.ResumeLayout(false);
            this.groupBoxRecTrans.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Add_ContName;
        private System.Windows.Forms.TextBox txtTransactionName;
        private System.Windows.Forms.Button btn_add_editTransaction;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxRecTrans;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTStatus;
        private System.Windows.Forms.CheckBox checkBoxTRecurring;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
    }
}