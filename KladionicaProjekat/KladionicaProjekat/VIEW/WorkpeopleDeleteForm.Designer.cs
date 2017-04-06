namespace KladionicaProjekat.VIEW
{
    partial class WorkpeopleDeleteForm
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
            this.ButtonOK = new System.Windows.Forms.Button();
            this.buttonCANCEL = new System.Windows.Forms.Button();
            this.WorkpeopleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(45, 190);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 14;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.Location = new System.Drawing.Point(168, 190);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
            this.buttonCANCEL.TabIndex = 15;
            this.buttonCANCEL.Text = "CANCEL";
            this.buttonCANCEL.UseVisualStyleBackColor = true;
            this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
            // 
            // WorkpeopleComboBox
            // 
            this.WorkpeopleComboBox.FormattingEnabled = true;
            this.WorkpeopleComboBox.Location = new System.Drawing.Point(73, 73);
            this.WorkpeopleComboBox.Name = "WorkpeopleComboBox";
            this.WorkpeopleComboBox.Size = new System.Drawing.Size(121, 21);
            this.WorkpeopleComboBox.TabIndex = 16;
            // 
            // WorkpeopleDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.WorkpeopleComboBox);
            this.Controls.Add(this.buttonCANCEL);
            this.Controls.Add(this.ButtonOK);
            this.Name = "WorkpeopleDeleteForm";
            this.Text = "WorkpeopleDeleteForm";
            this.Load += new System.EventHandler(this.WorkpeopleDeleteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button buttonCANCEL;
        private System.Windows.Forms.ComboBox WorkpeopleComboBox;
    }
}