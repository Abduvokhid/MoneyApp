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
            this.lbl_name = new System.Windows.Forms.Label();
            this.tbl_contact = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_amount = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.cbx_contact = new System.Windows.Forms.ComboBox();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.tbx_note = new System.Windows.Forms.TextBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.nud_amount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(47, 27);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // tbl_contact
            // 
            this.tbl_contact.AutoSize = true;
            this.tbl_contact.Location = new System.Drawing.Point(38, 53);
            this.tbl_contact.Name = "tbl_contact";
            this.tbl_contact.Size = new System.Drawing.Size(47, 13);
            this.tbl_contact.TabIndex = 1;
            this.tbl_contact.Text = "Contact:";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(51, 80);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(34, 13);
            this.lbl_type.TabIndex = 2;
            this.lbl_type.Text = "Type:";
            // 
            // lbl_amount
            // 
            this.lbl_amount.AutoSize = true;
            this.lbl_amount.Location = new System.Drawing.Point(39, 107);
            this.lbl_amount.Name = "lbl_amount";
            this.lbl_amount.Size = new System.Drawing.Size(46, 13);
            this.lbl_amount.TabIndex = 3;
            this.lbl_amount.Text = "Amount:";
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(52, 159);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(33, 13);
            this.lbl_note.TabIndex = 4;
            this.lbl_note.Text = "Note:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(52, 136);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(33, 13);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "Date:";
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(91, 24);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_name.TabIndex = 6;
            // 
            // cbx_contact
            // 
            this.cbx_contact.FormattingEnabled = true;
            this.cbx_contact.Location = new System.Drawing.Point(91, 50);
            this.cbx_contact.Name = "cbx_contact";
            this.cbx_contact.Size = new System.Drawing.Size(121, 21);
            this.cbx_contact.TabIndex = 7;
            // 
            // cbx_type
            // 
            this.cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Items.AddRange(new object[] {
            "Income",
            "Expense"});
            this.cbx_type.Location = new System.Drawing.Point(91, 77);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(121, 21);
            this.cbx_type.TabIndex = 8;
            // 
            // tbx_note
            // 
            this.tbx_note.Location = new System.Drawing.Point(91, 156);
            this.tbx_note.Multiline = true;
            this.tbx_note.Name = "tbx_note";
            this.tbx_note.Size = new System.Drawing.Size(234, 76);
            this.tbx_note.TabIndex = 11;
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "HH:mm dd/MM/yyyy";
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(91, 130);
            this.dtp_date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(144, 20);
            this.dtp_date.TabIndex = 10;
            // 
            // nud_amount
            // 
            this.nud_amount.DecimalPlaces = 2;
            this.nud_amount.Location = new System.Drawing.Point(91, 105);
            this.nud_amount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nud_amount.Name = "nud_amount";
            this.nud_amount.Size = new System.Drawing.Size(120, 20);
            this.nud_amount.TabIndex = 9;
            // 
            // AddEditTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nud_amount);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.tbx_note);
            this.Controls.Add(this.cbx_type);
            this.Controls.Add(this.cbx_contact);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.lbl_amount);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.tbl_contact);
            this.Controls.Add(this.lbl_name);
            this.Name = "AddEditTransaction";
            this.Text = "AddEditTransaction";
            ((System.ComponentModel.ISupportInitialize)(this.nud_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label tbl_contact;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_amount;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.ComboBox cbx_contact;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.TextBox tbx_note;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.NumericUpDown nud_amount;
    }
}