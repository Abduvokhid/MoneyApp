namespace MoneyApp.Forms
{
    partial class ViewPrediction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPrediction));
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_date_title = new System.Windows.Forms.Label();
            this.btn_predict = new System.Windows.Forms.Button();
            this.lbl_result_title = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Roboto", 9.75F);
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(12, 33);
            this.dtp_date.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtp_date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(159, 23);
            this.dtp_date.TabIndex = 0;
            // 
            // lbl_date_title
            // 
            this.lbl_date_title.AutoSize = true;
            this.lbl_date_title.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_date_title.Location = new System.Drawing.Point(9, 13);
            this.lbl_date_title.Name = "lbl_date_title";
            this.lbl_date_title.Size = new System.Drawing.Size(37, 15);
            this.lbl_date_title.TabIndex = 3;
            this.lbl_date_title.Text = "Date:";
            // 
            // btn_predict
            // 
            this.btn_predict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btn_predict.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_predict.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(229)))));
            this.btn_predict.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(181)))), ((int)(((byte)(246)))));
            this.btn_predict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_predict.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_predict.ForeColor = System.Drawing.Color.White;
            this.btn_predict.Location = new System.Drawing.Point(12, 65);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Size = new System.Drawing.Size(159, 34);
            this.btn_predict.TabIndex = 4;
            this.btn_predict.Text = "Predict";
            this.btn_predict.UseVisualStyleBackColor = false;
            this.btn_predict.Click += new System.EventHandler(this.PredictClick);
            // 
            // lbl_result_title
            // 
            this.lbl_result_title.AutoSize = true;
            this.lbl_result_title.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_result_title.Location = new System.Drawing.Point(12, 108);
            this.lbl_result_title.Name = "lbl_result_title";
            this.lbl_result_title.Size = new System.Drawing.Size(46, 15);
            this.lbl_result_title.TabIndex = 5;
            this.lbl_result_title.Text = "Result:";
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_result.Location = new System.Drawing.Point(12, 125);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(87, 24);
            this.lbl_result.TabIndex = 6;
            this.lbl_result.Text = "Unknown";
            // 
            // ViewPrediction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(184, 161);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_result_title);
            this.Controls.Add(this.btn_predict);
            this.Controls.Add(this.lbl_date_title);
            this.Controls.Add(this.dtp_date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewPrediction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prediction";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosedEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label lbl_date_title;
        private System.Windows.Forms.Button btn_predict;
        private System.Windows.Forms.Label lbl_result_title;
        private System.Windows.Forms.Label lbl_result;
    }
}