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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReport));
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.cbx_show = new System.Windows.Forms.ComboBox();
            this.lbl_show = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.plList = new System.Windows.Forms.Panel();
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
            // plList
            // 
            this.plList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plList.AutoScroll = true;
            this.plList.BackColor = System.Drawing.Color.White;
            this.plList.Location = new System.Drawing.Point(13, 91);
            this.plList.Name = "plList";
            this.plList.Size = new System.Drawing.Size(783, 246);
            this.plList.TabIndex = 11;
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 354);
            this.Controls.Add(this.plList);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_show);
            this.Controls.Add(this.cbx_show);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.dt_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewReport";
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
        private System.Windows.Forms.Panel plList;
    }
}