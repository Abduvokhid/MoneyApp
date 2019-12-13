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
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_predict = new System.Windows.Forms.Button();
            this.lbl_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(51, 23);
            this.dtp_date.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dtp_date.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(119, 20);
            this.dtp_date.TabIndex = 0;
            // 
            // btn_predict
            // 
            this.btn_predict.Location = new System.Drawing.Point(51, 50);
            this.btn_predict.Name = "btn_predict";
            this.btn_predict.Size = new System.Drawing.Size(75, 23);
            this.btn_predict.TabIndex = 1;
            this.btn_predict.Text = "Predict";
            this.btn_predict.UseVisualStyleBackColor = true;
            this.btn_predict.Click += new System.EventHandler(this.btn_predict_Click);
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Location = new System.Drawing.Point(51, 80);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(40, 13);
            this.lbl_result.TabIndex = 2;
            this.lbl_result.Text = "Result:";
            // 
            // ViewPrediction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.btn_predict);
            this.Controls.Add(this.dtp_date);
            this.Name = "ViewPrediction";
            this.Text = "ViewPrediction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button btn_predict;
        private System.Windows.Forms.Label lbl_result;
    }
}