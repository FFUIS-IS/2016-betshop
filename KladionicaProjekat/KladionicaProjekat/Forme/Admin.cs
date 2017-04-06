using KladionicaProjekat.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KladionicaProjekat.VIEW;

namespace KladionicaProjekat
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Form newform = new Pocetna();
            this.Hide();
            newform.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            try
            {
                if (NameTextBox.Text == "")
                { MessageBox.Show("Unesite ime!"); }
                else if (SurNameTextBox.Text == "")
                { MessageBox.Show("Unesite prezime!"); }


                else
                {
                    bool isUnique = UserRepository.CheckUnique(NameTextBox.Text);

                    if (isUnique != true)
                    {
                        UserRepository.InsertUser(NameTextBox.Text, NameTextBox.Text + SurNameTextBox.Text);
                        int AdminId = UserRepository.GetIdByName(NameTextBox.Text);

                        SqlCeCommand command = new SqlCeCommand("INSERT INTO Administrator (Name, SurName, User_Id) VALUES" + " ('" + NameTextBox.Text + "', '" + SurNameTextBox.Text + "', '" + AdminId + "'); ", Connection);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Unos je uspio!");
                        NameTextBox.Clear();
                        SurNameTextBox.Clear();
                        NameTextBox.Focus();
                    }



                }
            }

            catch (Exception ee)
            {


                MessageBox.Show("Unos nije uspio! \r Greska: " + ee.Message);
                return;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void buttonVIEW_Click(object sender, EventArgs e)
        {
            Form newform = new AdminDeleteForm();
            this.Hide();
            newform.Show();
        }
    }
}
