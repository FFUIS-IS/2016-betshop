namespace KladionicaProjekat.VIEW
{
    partial class DoublesDeleteForm
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
            this.DoublesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(53, 187);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCANCEL
            // 
            this.buttonCANCEL.Location = new System.Drawing.Point(166, 187);
            this.buttonCANCEL.Name = "buttonCANCEL";
            this.buttonCANCEL.Size = new System.Drawing.Size(75, 23);
            this.buttonCANCEL.TabIndex = 1;
            this.buttonCANCEL.Text = "CANCEL";
            this.buttonCANCEL.UseVisualStyleBackColor = true;
            this.buttonCANCEL.Click += new System.EventHandler(this.buttonCANCEL_Click);
            // 
            // DoublesComboBox
            // 
            this.DoublesComboBox.FormattingEnabled = true;
            this.DoublesComboBox.Location = new System.Drawing.Point(91, 48);
            this.DoublesComboBox.Name = "DoublesComboBox";
            this.DoublesComboBox.Size = new System.Drawing.Size(121, 21);
            this.DoublesComboBox.TabIndex = 2;
            this.DoublesComboBox.SelectedIndexChanged += new System.EventHandler(this.DoublesDeleteComboBox_SelectedIndexChanged);
            // 
            // DoublesDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.DoublesComboBox);
            this.Controls.Add(this.buttonCANCEL);
            this.Controls.Add(this.buttonOK);
            this.Name = "DoublesDeleteForm";
            this.Text = "DoublesDeleteForm";
            this.Load += new System.EventHandler(this.DoublesDeleteForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCANCEL;
        private System.Windows.Forms.ComboBox DoublesComboBox;
    }
}