namespace KladionicaProjekat.VIEW
{
    partial class LeagueDeleteForm
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCANCEL = new System.Windows.Forms.Button();
            this.LeagueComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(38, 156);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.Location = new System.Drawing.Point(183, 156);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
            this.buttonCANCEL.TabIndex = 7;
            this.buttonCANCEL.Text = "CANCEL";
            this.buttonCANCEL.UseVisualStyleBackColor = true;
            this.buttonCANCEL.Click += new System.EventHandler(this.buttonVIEW_Click);
            // 
            // LeagueComboBox
            // 
            this.LeagueComboBox.FormattingEnabled = true;
            this.LeagueComboBox.Location = new System.Drawing.Point(86, 55);
            this.LeagueComboBox.Name = "LeagueComboBox";
            this.LeagueComboBox.Size = new System.Drawing.Size(121, 21);
            this.LeagueComboBox.TabIndex = 8;
            // 
            // LeagueDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LeagueComboBox);
            this.Controls.Add(this.buttonCANCEL);
            this.Controls.Add(this.buttonOK);
            this.Name = "LeagueDeleteForm";
            this.Text = "LeagueDeleteForm";
            this.Load += new System.EventHandler(this.LeagueDeleteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCANCEL;
        private System.Windows.Forms.ComboBox LeagueComboBox;
    }
}