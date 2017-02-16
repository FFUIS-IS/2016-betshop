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


            SqlCeCommand command = new SqlCeCommand("INSERT INTO Player" + " ([First_name], [Last_name], [Date_of_birth]) VALUES" +  " ('" + First_nameTextBox.Text + "', '" + Last_nameTextBox.Text +"', '" + Date_of_birthTextBox.Text +"'); ", Connection);

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
                    command.ExecuteNonQuery();
                    MessageBox.Show("Unos je uspio!");
                    First_nameTextBox.Clear();
                    Last_nameTextBox.Clear();
                    Date_of_birthTextBox.Clear();
                    First_nameTextBox.Focus();

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
