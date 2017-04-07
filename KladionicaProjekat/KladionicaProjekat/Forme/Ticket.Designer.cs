namespace KladionicaProjekat
{
    partial class Ticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Ticket_control_numberTextBox = new System.Windows.Forms.TextBox();
            this.Payment_amountTextBox = new System.Windows.Forms.TextBox();
            this.SystemTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.PlayerIDTextBox = new System.Windows.Forms.ComboBox();
            this.WorkpeopleIDTextBox = new System.Windows.Forms.ComboBox();
            this.CodeBettingShopIDTextBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Uplatno mjesto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kontrolni broj tiketa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(334, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Iznos uplate:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Igrac:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Zaposleni:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(334, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sistem:";
            // 
            // Ticket_control_numberTextBox
            // 
            this.Ticket_control_numberTextBox.Location = new System.Drawing.Point(148, 85);
            this.Ticket_control_numberTextBox.Name = "Ticket_control_numberTextBox";
            this.Ticket_control_numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.Ticket_control_numberTextBox.TabIndex = 11;
            // 
            // Payment_amountTextBox
            // 
            this.Payment_amountTextBox.Location = new System.Drawing.Point(438, 41);
            this.Payment_amountTextBox.Name = "Payment_amountTextBox";
            this.Payment_amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.Payment_amountTextBox.TabIndex = 12;
            // 
            // SystemTextBox
            // 
            this.SystemTextBox.Location = new System.Drawing.Point(438, 165);
            this.SystemTextBox.Name = "SystemTextBox";
            this.SystemTextBox.Size = new System.Drawing.Size(100, 20);
            this.SystemTextBox.TabIndex = 15;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(148, 248);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "SAVE";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(410, 248);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 17;
            this.CancelButton.Text = "CANCEL";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PlayerIDTextBox
            // 
            this.PlayerIDTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlayerIDTextBox.FormattingEnabled = true;
            this.PlayerIDTextBox.Location = new System.Drawing.Point(438, 80);
            this.PlayerIDTextBox.Name = "PlayerIDTextBox";
            this.PlayerIDTextBox.Size = new System.Drawing.Size(121, 21);
            this.PlayerIDTextBox.TabIndex = 20;
            // 
            // WorkpeopleIDTextBox
            // 
            this.WorkpeopleIDTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkpeopleIDTextBox.FormattingEnabled = true;
            this.WorkpeopleIDTextBox.Location = new System.Drawing.Point(438, 123);
            this.WorkpeopleIDTextBox.Name = "WorkpeopleIDTextBox";
            this.WorkpeopleIDTextBox.Size = new System.Drawing.Size(121, 21);
            this.WorkpeopleIDTextBox.TabIndex = 21;
            // 
            // CodeBettingShopIDTextBox
            // 
            this.CodeBettingShopIDTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CodeBettingShopIDTextBox.FormattingEnabled = true;
            this.CodeBettingShopIDTextBox.Location = new System.Drawing.Point(148, 45);
            this.CodeBettingShopIDTextBox.Name = "CodeBettingShopIDTextBox";
            this.CodeBettingShopIDTextBox.Size = new System.Drawing.Size(121, 21);
            this.CodeBettingShopIDTextBox.TabIndex = 22;
            this.CodeBettingShopIDTextBox.SelectedIndexChanged += new System.EventHandler(this.Code_betting_shop_IdTextBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 284);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 291);
            this.Controls.Add(this.CodeBettingShopIDTextBox);
            this.Controls.Add(this.WorkpeopleIDTextBox);
            this.Controls.Add(this.PlayerIDTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SystemTextBox);
            this.Controls.Add(this.Payment_amountTextBox);
            this.Controls.Add(this.Ticket_control_numberTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Ticket_control_numberTextBox;
        private System.Windows.Forms.TextBox Payment_amountTextBox;
        private System.Windows.Forms.TextBox SystemTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox PlayerIDTextBox;
        private System.Windows.Forms.ComboBox WorkpeopleIDTextBox;
        private System.Windows.Forms.ComboBox CodeBettingShopIDTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}