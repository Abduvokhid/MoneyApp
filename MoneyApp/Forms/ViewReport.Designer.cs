namespace MoneyApp.Forms
{
    partial class ViewReport
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
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.cbx_show = new System.Windows.Forms.ComboBox();
            this.lbl_show = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.plList = new System.Windows.Forms.Panel();
            this.pl_item = new System.Windows.Forms.Panel();
            this.lblItemAmount = new System.Windows.Forms.Label();
            this.lblItemDateTime = new System.Windows.Forms.Label();
            this.lblItemContact = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.plList.SuspendLayout();
            this.pl_item.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_start
            // 
            this.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_start.Location = new System.Drawing.Point(13, 27);
            this.dt_start.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dt_start.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(200, 20);
            this.dt_start.TabIndex = 1;
            // 
            // dt_end
            // 
            this.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_end.Location = new System.Drawing.Point(338, 27);
            this.dt_end.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dt_end.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(200, 20);
            this.dt_end.TabIndex = 2;
            // 
            // cbx_show
            // 
            this.cbx_show.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_show.FormattingEnabled = true;
            this.cbx_show.Items.AddRange(new object[] {
            "Transactions",
            "Days",
            "Months",
            "Years"});
            this.cbx_show.Location = new System.Drawing.Point(92, 53);
            this.cbx_show.Name = "cbx_show";
            this.cbx_show.Size = new System.Drawing.Size(121, 21);
            this.cbx_show.TabIndex = 4;
            // 
            // lbl_show
            // 
            this.lbl_show.AutoSize = true;
            this.lbl_show.Location = new System.Drawing.Point(10, 56);
            this.lbl_show.Name = "lbl_show";
            this.lbl_show.Size = new System.Drawing.Size(51, 13);
            this.lbl_show.TabIndex = 6;
            this.lbl_show.Text = "Show by:";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(10, 9);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(32, 13);
            this.lbl_start.TabIndex = 7;
            this.lbl_start.Text = "Start:";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(338, 8);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(29, 13);
            this.lbl_end.TabIndex = 8;
            this.lbl_end.Text = "End:";
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(412, 53);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 9;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.BtnGenerateClick);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(38, 356);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(709, 254);
            this.cartesianChart1.TabIndex = 10;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // plList
            // 
            this.plList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plList.AutoScroll = true;
            this.plList.BackColor = System.Drawing.Color.White;
            this.plList.Controls.Add(this.pl_item);
            this.plList.Location = new System.Drawing.Point(13, 91);
            this.plList.Name = "plList";
            this.plList.Size = new System.Drawing.Size(677, 246);
            this.plList.TabIndex = 11;
            // 
            // pl_item
            // 
            this.pl_item.BackColor = System.Drawing.Color.White;
            this.pl_item.Controls.Add(this.lblItemAmount);
            this.pl_item.Controls.Add(this.lblItemDateTime);
            this.pl_item.Controls.Add(this.lblItemContact);
            this.pl_item.Controls.Add(this.lblItemName);
            this.pl_item.Location = new System.Drawing.Point(15, 22);
            this.pl_item.Name = "pl_item";
            this.pl_item.Size = new System.Drawing.Size(641, 60);
            this.pl_item.TabIndex = 0;
            // 
            // lblItemAmount
            // 
            this.lblItemAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblItemAmount.AutoSize = true;
            this.lblItemAmount.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblItemAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(75)))));
            this.lblItemAmount.Location = new System.Drawing.Point(526, 15);
            this.lblItemAmount.Name = "lblItemAmount";
            this.lblItemAmount.Size = new System.Drawing.Size(69, 19);
            this.lblItemAmount.TabIndex = 4;
            this.lblItemAmount.Text = "£125.00";
            // 
            // lblItemDateTime
            // 
            this.lblItemDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemDateTime.AutoSize = true;
            this.lblItemDateTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblItemDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(75)))));
            this.lblItemDateTime.Location = new System.Drawing.Point(273, 14);
            this.lblItemDateTime.Name = "lblItemDateTime";
            this.lblItemDateTime.Size = new System.Drawing.Size(138, 19);
            this.lblItemDateTime.TabIndex = 2;
            this.lblItemDateTime.Text = "12/12/2019 23:12";
            this.lblItemDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblItemContact
            // 
            this.lblItemContact.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemContact.AutoSize = true;
            this.lblItemContact.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(116)))), ((int)(((byte)(129)))));
            this.lblItemContact.Location = new System.Drawing.Point(17, 32);
            this.lblItemContact.Name = "lblItemContact";
            this.lblItemContact.Size = new System.Drawing.Size(24, 18);
            this.lblItemContact.TabIndex = 1;
            this.lblItemContact.Text = "TfL";
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblItemName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(56)))), ((int)(((byte)(75)))));
            this.lblItemName.Location = new System.Drawing.Point(14, 14);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(130, 19);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Travel to London";
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 639);
            this.Controls.Add(this.plList);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_show);
            this.Controls.Add(this.cbx_show);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.dt_start);
            this.Name = "ViewReport";
            this.Text = "ViewReport";
            this.plList.ResumeLayout(false);
            this.pl_item.ResumeLayout(false);
            this.pl_item.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.ComboBox cbx_show;
        private System.Windows.Forms.Label lbl_show;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Button btn_generate;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Panel plList;
        private System.Windows.Forms.Panel pl_item;
        private System.Windows.Forms.Label lblItemAmount;
        private System.Windows.Forms.Label lblItemDateTime;
        private System.Windows.Forms.Label lblItemContact;
        private System.Windows.Forms.Label lblItemName;
    }
}