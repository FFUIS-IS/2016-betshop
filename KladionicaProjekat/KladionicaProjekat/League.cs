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
    public partial class League : Form
    {
        public League()
        {
            InitializeComponent();
            CenterToScreen();
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

                if (Type_leaguesTextBox.Text == "")
                { MessageBox.Show("Unesite vrstu lige!"); }

                else
                {
                    SqlCeCommand command = new SqlCeCommand("INSERT INTO League (Type_leagues) VALUES" + " ('" + Type_leaguesTextBox.Text + "'); ", Connection);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Unos je uspio!");
                    Type_leaguesTextBox.Clear();
                    Type_leaguesTextBox.Focus();
                }
                
            }

            catch (Exception ee)
            {


                MessageBox.Show("Unos nije uspio! \r Greska: " + ee.Message);
                return;

            }


            
        }

        private void Type_leaguesTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
