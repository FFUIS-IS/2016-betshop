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
using ElectronicSchoolDiary;
using KladionicaProjekat.Repository;

namespace KladionicaProjekat
{
    public partial class Sports : Form
    {


        public Sports()
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

                if (Description_sportsTextBox.Text == "")
                { MessageBox.Show("Unesite opis sporta!"); }
                else if (LeagueComboBox.Text == "")
                { MessageBox.Show("Izaberite vrstu lige"); }


                else
                {
                    SqlCeCommand command = new SqlCeCommand("INSERT INTO Sports ([Description_sports], [League_Id]) VALUES" + " ('" + Description_sportsTextBox.Text + "', '" + LeagueComboBox.Text + "'); ", Connection);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Unos je uspio!");
                    Description_sportsTextBox.Clear();
                    Description_sportsTextBox.Focus();

                }
            }

            catch (Exception ee)
            {


                MessageBox.Show("Unos nije uspio! \r Greska: " + ee.Message);
                return;

            }



        }

        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sports_Load(object sender, EventArgs e)
        {
           
            PopulateLeagueComboBox();
            
           
        }
        private void PopulateLeagueComboBox()
        {
            try
            {
                string Query = LeagueRepository.GetQuery();
                Lists.FillDropDownList1(Query, "Type_leagues", LeagueComboBox);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
