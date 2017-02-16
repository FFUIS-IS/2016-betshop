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

namespace KladionicaProjekat
{
    public partial class Doubles : Form
    {
        public Doubles()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            SqlCeCommand command = new SqlCeCommand("INSERT INTO Doubles ([Name], [Sports_Id]) VALUES" + " ('" + NameTextBox.Text + "', '" + Sports_IdTextBox.Text + "'); ", Connection);

            try
            {

                if (NameTextBox.Text == "")
                { MessageBox.Show("Unesite ime para!"); }
                else if (Sports_IdTextBox.Text == "")
                { MessageBox.Show("Unesite ime sporta!"); }


                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Unos je uspio!");
                    NameTextBox.Clear();
                    Sports_IdTextBox.Clear();
                    NameTextBox.Focus();


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
