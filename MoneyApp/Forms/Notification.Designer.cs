namespace MoneyApp.Forms
{
    partial class Notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notification));
            this.lbl_close = new System.Windows.Forms.Label();
            this.bw_wait = new System.ComponentModel.BackgroundWorker();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.BackColor = System.Drawing.Color.Transparent;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_close.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_close.Location = new System.Drawing.Point(271, 6);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Padding = new System.Windows.Forms.Padding(3);
            this.lbl_close.Size = new System.Drawing.Size(21, 19);
            this.lbl_close.TabIndex = 0;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.CloseClick);
            this.lbl_close.MouseEnter += new System.EventHandler(this.CloseMouseEnter);
            this.lbl_close.MouseLeave += new System.EventHandler(this.CloseMouseLeave);
            // 
            // bw_wait
            // 
            this.bw_wait.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WaitDoWork);
            this.bw_wait.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WaitCompleted);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_title.Location = new System.Drawing.Point(9, 8);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(94, 14);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "New notification";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info.Location = new System.Drawing.Point(9, 26);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(71, 15);
            this.lbl_info.TabIndex = 2;
            this.lbl_info.Text = "Information";
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 80);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Notification";
            this.Text = "Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_close;
        private System.ComponentModel.BackgroundWorker bw_wait;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_info;
    }
}