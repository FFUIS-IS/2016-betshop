namespace KladionicaProjekat.Forme
{
    partial class PlayerDeleteForm
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
            this.PlayerComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCANCEL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerComboBox
            // 
            this.PlayerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerComboBox.FormattingEnabled = true;
            this.PlayerComboBox.Location = new System.Drawing.Point(80, 38);
            this.PlayerComboBox.Name = "PlayerComboBox";
            this.PlayerComboBox.Size = new System.Drawing.Size(121, 21);
            this.PlayerComboBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.Location = new System.Drawing.Point(177, 152);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
            this.buttonCANCEL.TabIndex = 2;
            this.buttonCANCEL.Text = "CANCEL";
            this.buttonCANCEL.UseVisualStyleBackColor = true;
            this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
            // 
            // PlayerDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCANCEL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PlayerComboBox);
            this.Name = "PlayerDeleteForm";
            this.Text = "DeletePlayerForm";
            this.Load += new System.EventHandler(this.DeletePlayerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PlayerComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCANCEL;
    }
}