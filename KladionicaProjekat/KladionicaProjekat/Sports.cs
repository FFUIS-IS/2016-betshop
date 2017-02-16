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
    public partial class Sports : Form
    {


        public Sports()
        {
            InitializeComponent();
        }



        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            SqlCeCommand command = new SqlCeCommand("INSERT INTO Sports ([Description_sports], [League_Id]) VALUES" + " ('" + Description_sportsTextBox.Text + "', '" + League_IdTextBox.Text + "'); ", Connection);

            try
            {

                if (Description_sportsTextBox.Text == "")
                { MessageBox.Show("Unesite opis sporta!"); }
                else if (League_IdTextBox.Text == "")
                { MessageBox.Show("Unesite ligu!"); }


                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Unos je uspio!");
                    Description_sportsTextBox.Clear();
                    League_IdTextBox.Clear();
                    Description_sportsTextBox.Focus();

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
