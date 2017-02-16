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
    public partial class Event : Form
    {
        public Event()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            
            SqlCeCommand command = new SqlCeCommand("INSERT INTO Events ([Date], [Time_of], [Doubles_Id]) VALUES" + " ('" + DateTextBox.Text + "', '" + Time_ofTextBox.Text +"', '" + Doubles_IdTextBox.Text +"'); ", Connection);

            try
            {

                if (DateTextBox.Text == "")
                { MessageBox.Show("Unesite datum!"); }
                else if (Time_ofTextBox.Text == "")
                { MessageBox.Show("Unesite vrijeme!"); }
                else if (Doubles_IdTextBox.Text == "")
                { MessageBox.Show("Unesite porove!");  }



                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Unos je uspio!");
                    DateTextBox.Clear();
                    Time_ofTextBox.Clear();
                    Doubles_IdTextBox.Clear();
                    DateTextBox.Focus();


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
