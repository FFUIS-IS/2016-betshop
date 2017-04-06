namespace KladionicaProjekat.VIEW
{
    partial class AdminDeleteForm
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
            this.AdminComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtonOK
            // 
            this.ButtonOK.Location = new System.Drawing.Point(36, 194);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 5;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.Location = new System.Drawing.Point(183, 194);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
            this.buttonCANCEL.TabIndex = 6;
            this.buttonCANCEL.Text = "CANCEL";
            this.buttonCANCEL.UseVisualStyleBackColor = true;
            this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
            // 
            // AdminComboBox
            // 
            this.AdminComboBox.FormattingEnabled = true;
            this.AdminComboBox.Location = new System.Drawing.Point(85, 50);
            this.AdminComboBox.Name = "AdminComboBox";
            this.AdminComboBox.Size = new System.Drawing.Size(121, 21);
            this.AdminComboBox.TabIndex = 7;
            // 
            // AdminDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AdminComboBox);
            this.Controls.Add(this.buttonCANCEL);
            this.Controls.Add(this.ButtonOK);
            this.Name = "AdminDeleteForm";
            this.Text = "AdminDeleteForm";
            this.Load += new System.EventHandler(this.AdminDeleteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button buttonCANCEL;
        private System.Windows.Forms.ComboBox AdminComboBox;
    }
}