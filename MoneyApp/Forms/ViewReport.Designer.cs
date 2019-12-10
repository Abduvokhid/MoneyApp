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
            this.lv_report = new System.Windows.Forms.ListView();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.dt_end = new System.Windows.Forms.DateTimePicker();
            this.cbx_show = new System.Windows.Forms.ComboBox();
            this.lbl_show = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.btn_generate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_report
            // 
            this.lv_report.FullRowSelect = true;
            this.lv_report.Location = new System.Drawing.Point(12, 116);
            this.lv_report.MultiSelect = false;
            this.lv_report.Name = "lv_report";
            this.lv_report.Size = new System.Drawing.Size(736, 222);
            this.lv_report.TabIndex = 0;
            this.lv_report.UseCompatibleStateImageBehavior = false;
            this.lv_report.View = System.Windows.Forms.View.Details;
            // 
            // dt_start
            // 
            this.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_start.Location = new System.Drawing.Point(66, 27);
            this.dt_start.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dt_start.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(200, 20);
            this.dt_start.TabIndex = 1;
            // 
            // dt_end
            // 
            this.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_end.Location = new System.Drawing.Point(391, 27);
            this.dt_end.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dt_end.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dt_end.Name = "dt_end";
            this.dt_end.Size = new System.Drawing.Size(200, 20);
            this.dt_end.TabIndex = 2;
            // 
            // cbx_show
            // 
            this.cbx_show.FormattingEnabled = true;
            this.cbx_show.Location = new System.Drawing.Point(145, 53);
            this.cbx_show.Name = "cbx_show";
            this.cbx_show.Size = new System.Drawing.Size(121, 21);
            this.cbx_show.TabIndex = 4;
            // 
            // lbl_show
            // 
            this.lbl_show.AutoSize = true;
            this.lbl_show.Location = new System.Drawing.Point(63, 56);
            this.lbl_show.Name = "lbl_show";
            this.lbl_show.Size = new System.Drawing.Size(51, 13);
            this.lbl_show.TabIndex = 6;
            this.lbl_show.Text = "Show by:";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(63, 9);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(32, 13);
            this.lbl_start.TabIndex = 7;
            this.lbl_start.Text = "Start:";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(391, 8);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(29, 13);
            this.lbl_end.TabIndex = 8;
            this.lbl_end.Text = "End:";
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(465, 53);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 9;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.BtnGenerateClick);
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

        private System.Windows.Forms.ListView lv_report;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.DateTimePicker dt_end;
        private System.Windows.Forms.ComboBox cbx_show;
        private System.Windows.Forms.Label lbl_show;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Button btn_generate;
    }
}