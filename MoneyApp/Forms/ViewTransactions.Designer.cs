namespace MoneyApp.Forms
{
    partial class ViewTransactions
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
            this.lv_transactions = new System.Windows.Forms.ListView();
            this.cl_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_transactions
            // 
            this.lv_transactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_name,
            this.cl_contact,
            this.cl_type,
            this.cl_amount,
            this.cl_date,
            this.cl_note});
            this.lv_transactions.Location = new System.Drawing.Point(12, 12);
            this.lv_transactions.Name = "lv_transactions";
            this.lv_transactions.Size = new System.Drawing.Size(613, 228);
            this.lv_transactions.TabIndex = 0;
            this.lv_transactions.UseCompatibleStateImageBehavior = false;
            this.lv_transactions.View = System.Windows.Forms.View.Details;
            // 
            // cl_name
            // 
            this.cl_name.Text = "Name";
            this.cl_name.Width = 100;
            // 
            // cl_contact
            // 
            this.cl_contact.Text = "Contact";
            this.cl_contact.Width = 100;
            // 
            // cl_type
            // 
            this.cl_type.Text = "Type";
            // 
            // cl_amount
            // 
            this.cl_amount.Text = "Amount";
            this.cl_amount.Width = 80;
            // 
            // cl_date
            // 
            this.cl_date.Text = "Created date";
            this.cl_date.Width = 100;
            // 
            // cl_note
            // 
            this.cl_note.Text = "Note";
            this.cl_note.Width = 150;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(631, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.AddClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(631, 41);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.EditClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(631, 70);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.DeleteClick);
            // 
            // ViewTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 262);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lv_transactions);
            this.Name = "ViewTransactions";
            this.Text = "ViewTransactions";
            this.Activated += new System.EventHandler(this.ViewTransactionsActivated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewTransactionsFormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_transactions;
        private System.Windows.Forms.ColumnHeader cl_name;
        private System.Windows.Forms.ColumnHeader cl_contact;
        private System.Windows.Forms.ColumnHeader cl_type;
        private System.Windows.Forms.ColumnHeader cl_amount;
        private System.Windows.Forms.ColumnHeader cl_date;
        private System.Windows.Forms.ColumnHeader cl_note;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
    }
}