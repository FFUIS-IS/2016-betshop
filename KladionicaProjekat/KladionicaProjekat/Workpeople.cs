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

namespace KladionicaProjekat
{
    public partial class Workpeople : Form
    {
        

        public Workpeople()
        {
            InitializeComponent();
            CenterToScreen();
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

            try
            {
                if (First_nameTextBox.Text == "")
                { MessageBox.Show("Unesite ime!"); }
                else if (Last_nameTextBox.Text == "")
                { MessageBox.Show("Unesite prezime!"); }
                else if (Access_levelTextBox.Text == "")
                { MessageBox.Show("Unesite nivo pristupa!"); }


                else
                {
                    bool isUnique = UserRepository.CheckUnique(First_nameTextBox.Text);

                    if (isUnique != true)
                    {
                        UserRepository.InsertUser(First_nameTextBox.Text, First_nameTextBox.Text + Last_nameTextBox.Text);
                        int WorkpeopleId = UserRepository.GetIdByName(First_nameTextBox.Text);

                        SqlCeCommand command = new SqlCeCommand("INSERT INTO Workpeople (First_name, Last_name, Phone_number, Address, Access_level, User_Id) VALUES" + " ('" + First_nameTextBox.Text + "', '" + Last_nameTextBox.Text + "', '" + Phone_numberTextBox.Text + "', '" + AddressTextBox.Text + "', '" + Access_levelTextBox.Text + "', '" + WorkpeopleId +"'); ", Connection);

                        command.ExecuteNonQuery();

                        MessageBox.Show("Unos je uspio!");
                        First_nameTextBox.Clear();
                        Last_nameTextBox.Clear();
                        Phone_numberTextBox.Clear();
                        AddressTextBox.Clear();
                        Access_levelTextBox.Clear();
                        First_nameTextBox.Focus();
                    }

                        

                }
            }

            catch (Exception ee)
            {


                MessageBox.Show("Unos nije uspio! \r Greska: " + ee.Message);
                return;

            }

        }

        

        
    }
}
