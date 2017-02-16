using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;

namespace KladionicaProjekat
{
    public partial class Workpeople : Form
    {
        

        public Workpeople()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = new SqlCeCommand("INSERT INTO Workpeople ([First_name], [Last_name], [Phone_number], [Address], [Password], [Access_level]) VALUES" + " ('" + First_nameTextBox.Text + "', '" + Last_nameTextBox.Text +"', '" + Phone_numberTextBox.Text +"', '" + AddressTextBox.Text +"', '" + PasswordTextBox.Text +"', '" + Access_levelTextBox.Text +"'); ", Connection);

            try
            {
                if (First_nameTextBox.Text == "")
                { MessageBox.Show("Unesite ime!"); }
                else if (Last_nameTextBox.Text == "")
                { MessageBox.Show("Unesite prezime!"); }
                else if (PasswordTextBox.Text == "")
                { MessageBox.Show("Unesite sifru!"); }
                else if (Access_levelTextBox.Text == "")
                { MessageBox.Show("Unesite nivo pristupa!"); }


                else
                {

                    command.ExecuteNonQuery();
                    MessageBox.Show("Unos je uspio!");
                    First_nameTextBox.Clear();
                    Last_nameTextBox.Clear();
                    Phone_numberTextBox.Clear();
                    AddressTextBox.Clear();
                    PasswordTextBox.Clear();
                    Access_levelTextBox.Clear();
                    First_nameTextBox.Focus();

                }
            }

            catch (Exception ee)
            {


                MessageBox.Show("Unos nije uspio! \r Greska: " + ee.Message);
                return;

            }

        }

        private void First_nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
