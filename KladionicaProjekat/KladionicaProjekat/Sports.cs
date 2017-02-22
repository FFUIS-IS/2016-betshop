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

        private void label2_Click(object sender, EventArgs e)
        {

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
                    SqlCeCommand command = new SqlCeCommand("INSERT INTO Sports (Description_sports, League_Id) VALUES" + " ('" + Description_sportsTextBox.Text + "', '" + LeagueComboBox.Text + "'); ", Connection);

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
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;
            try
            {
                LeagueComboBox.Items.Clear();
                SqlCeCommand cmd = Connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM League";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    LeagueComboBox.Items.Add(dr["Type_leagues"].ToString());
                }




            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        
    }
    }
