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
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lv_events = new MaterialSkin.Controls.MaterialListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(304, 12);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(140, 34);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete event";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.DeleteClick);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btn_edit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(124)))), ((int)(((byte)(0)))));
            this.btn_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(77)))));
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(158, 12);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(140, 34);
            this.btn_edit.TabIndex = 16;
            this.btn_edit.Text = "Edit event";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.EditClick);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(199)))), ((int)(((byte)(132)))));
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(12, 12);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(140, 34);
            this.btn_add.TabIndex = 15;
            this.btn_add.Text = "Add event";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.AddClick);
            // 
            // lv_events
            // 
            this.lv_events.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_events.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_events.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_contact,
            this.ch_type,
            this.ch_location,
            this.ch_note,
            this.ch_date});
            this.lv_events.Depth = 0;
            this.lv_events.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.lv_events.FullRowSelect = true;
            this.lv_events.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_events.Location = new System.Drawing.Point(12, 52);
            this.lv_events.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_events.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_events.MultiSelect = false;
            this.lv_events.Name = "lv_events";
            this.lv_events.OwnerDraw = true;
            this.lv_events.Size = new System.Drawing.Size(760, 397);
            this.lv_events.TabIndex = 18;
            this.lv_events.UseCompatibleStateImageBehavior = false;
            this.lv_events.View = System.Windows.Forms.View.Details;
            // 
            // ch_name
            // 
            this.ch_name.Text = "Name";
            // 
            // ch_contact
            // 
            this.ch_contact.Text = "Contact";
            // 
            // ch_type
            // 
            this.ch_type.Text = "Type";
            // 
            // ch_location
            // 
            this.ch_location.Text = "Location";
            // 
            // ch_note
            // 
            this.ch_note.Text = "Note";
            // 
            // ch_date
            // 
            this.ch_date.Text = "Date & Time";
            // 
            // ViewEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lv_events);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "ViewEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Events";
            this.Activated += new System.EventHandler(this.ViewEventsActivated);
            this.SizeChanged += new System.EventHandler(this.EventsSizeChanged);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private MaterialSkin.Controls.MaterialListView lv_events;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_contact;
        private System.Windows.Forms.ColumnHeader ch_type;
        private System.Windows.Forms.ColumnHeader ch_location;
        private System.Windows.Forms.ColumnHeader ch_note;
        private System.Windows.Forms.ColumnHeader ch_date;
    }
}