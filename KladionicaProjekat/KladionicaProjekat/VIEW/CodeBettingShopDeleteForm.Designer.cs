namespace KladionicaProjekat.VIEW
{
    partial class CodeBettingShopDeleteForm
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
            this.CodeBettingShopComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodeBettingShopComboBox
            // 
            this.CodeBettingShopComboBox.FormattingEnabled = true;
            this.CodeBettingShopComboBox.Location = new System.Drawing.Point(70, 47);
            this.CodeBettingShopComboBox.Name = "CodeBettingShopComboBox";
            this.CodeBettingShopComboBox.Size = new System.Drawing.Size(121, 21);
            this.CodeBettingShopComboBox.TabIndex = 0;
            this.CodeBettingShopComboBox.SelectedIndexChanged += new System.EventHandler(this.CodeBettingShopComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(168, 191);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // CodeBettingShopDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CodeBettingShopComboBox);
            this.Name = "CodeBettingShopDeleteForm";
            this.Text = "CodeBettingShopForm";
            this.Load += new System.EventHandler(this.CodeBettingShopForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CodeBettingShopComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
    }
}