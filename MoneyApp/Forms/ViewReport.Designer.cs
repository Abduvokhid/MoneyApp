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
            this.lv_report = new System.Windows.Forms.ListView();
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
            this.plList.Location = new System.Drawing.Point(475, 92);
            this.plList.Name = "plList";
            this.plList.Size = new System.Drawing.Size(674, 246);
            this.plList.TabIndex = 11;
            // 
            // lv_report
            // 
            this.lv_report.FullRowSelect = true;
            this.lv_report.Location = new System.Drawing.Point(12, 92);
            this.lv_report.MultiSelect = false;
            this.lv_report.Name = "lv_report";
            this.lv_report.Size = new System.Drawing.Size(457, 246);
            this.lv_report.TabIndex = 0;
            this.lv_report.UseCompatibleStateImageBehavior = false;
            this.lv_report.View = System.Windows.Forms.View.Details;
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 639);
            this.Controls.Add(this.plList);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_show);
            this.Controls.Add(this.cbx_show);
            this.Controls.Add(this.dt_end);
            this.Controls.Add(this.dt_start);
            this.Controls.Add(this.lv_report);
            this.Name = "ViewReport";
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
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.Panel plList;
        private System.Windows.Forms.ListView lv_report;
    }
}