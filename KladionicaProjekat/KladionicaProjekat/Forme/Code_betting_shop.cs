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
using KladionicaProjekat.VIEW;

namespace KladionicaProjekat
{
    public partial class Code_betting_shop : Form
    {
        public Code_betting_shop()
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
                { MessageBox.Show("Unesite naziv grada!"); }
                else if (AddressTextBox.Text == "")
                { MessageBox.Show("Unesite adresu!"); }


                else
                {
                    SqlCeCommand command = new SqlCeCommand("INSERT INTO Code_betting_shop (Name, Address) VALUES" + " ('" + NameTextBox.Text + "', '" + AddressTextBox.Text + "'); ", Connection);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Unos je uspio!");
                    NameTextBox.Clear();
                    AddressTextBox.Clear();
                    NameTextBox.Focus();

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

        private void button1_Click(object sender, EventArgs e)
        {
            Form deleteform = new CodeBettingShopDeleteForm();
            deleteform.Show();
            this.Hide();
        }
    }
}
