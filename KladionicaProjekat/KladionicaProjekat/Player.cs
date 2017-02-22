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
    public partial class Player : Form
    {

        private static SqlCeConnection connection = DataBaseConnection.Instance.Connection;

        public Player()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
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
                else if (Date_of_birthTextBox.Text == "")
                { MessageBox.Show("Unesite godinu rodjenja!"); }
                else
                {
                    bool isUnique = UserRepository.CheckUnique(First_nameTextBox.Text);
                    if (isUnique != true)
                    {
                        UserRepository.InsertUser(First_nameTextBox.Text, First_nameTextBox.Text + Last_nameTextBox.Text);
                        int PlayerId = UserRepository.GetIdByName(First_nameTextBox.Text);

                        SqlCeCommand command = new SqlCeCommand("INSERT INTO Player (First_name, Last_name, Date_of_birth, User_Id) VALUES" + " ('" + First_nameTextBox.Text + "', '" + Last_nameTextBox.Text + "', '" + Date_of_birthTextBox.Value.Date.ToString("yyyy-MM-dd") + "', '" + PlayerId + "'); ", Connection);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Unos je uspio!");
                        First_nameTextBox.Clear();
                        Last_nameTextBox.Clear();
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

        private void Player_Load(object sender, EventArgs e)
        {
            Date_of_birthTextBox.CustomFormat = "yyyy-MM-dd";
        }

        private void Date_of_birthTextBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
