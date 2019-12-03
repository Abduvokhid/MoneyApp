namespace MoneyApp.Forms
{
    partial class ViewContacts
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
            this.lv_contacts = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_contacts
            // 
            this.lv_contacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name});
            this.lv_contacts.FullRowSelect = true;
            this.lv_contacts.Location = new System.Drawing.Point(12, 12);
            this.lv_contacts.MultiSelect = false;
            this.lv_contacts.Name = "lv_contacts";
            this.lv_contacts.Size = new System.Drawing.Size(124, 245);
            this.lv_contacts.TabIndex = 0;
            this.lv_contacts.UseCompatibleStateImageBehavior = false;
            this.lv_contacts.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 100;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(142, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.AddClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(142, 41);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.EditClick);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(142, 70);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.DeleteClick);
            // 
            // ViewContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 269);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lv_contacts);
            this.Name = "ViewContacts";
            this.Text = "ContactsView";
            this.Activated += new System.EventHandler(this.ViewContactsActivated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewContactsFormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_contacts;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
    }
}