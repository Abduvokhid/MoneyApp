namespace MoneyApp.Forms
{
    partial class AddEditContact
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.btn_action = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbx_name
            // 
            this.tbx_name.Location = new System.Drawing.Point(53, 9);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(100, 20);
            this.tbx_name.TabIndex = 1;
            // 
            // btn_action
            // 
            this.btn_action.Location = new System.Drawing.Point(159, 7);
            this.btn_action.Name = "btn_action";
            this.btn_action.Size = new System.Drawing.Size(75, 23);
            this.btn_action.TabIndex = 2;
            this.btn_action.Text = "Action";
            this.btn_action.UseVisualStyleBackColor = true;
            this.btn_action.Click += new System.EventHandler(this.btn_action_Click);
            // 
            // AddEditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 39);
            this.Controls.Add(this.btn_action);
            this.Controls.Add(this.tbx_name);
            this.Controls.Add(this.label1);
            this.Name = "AddEditContact";
            this.Text = "AddEditContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.Button btn_action;
    }
}