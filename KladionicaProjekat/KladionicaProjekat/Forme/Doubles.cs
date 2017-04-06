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
using KladionicaProjekat.VIEW;


namespace KladionicaProjekat
{
    public partial class Doubles : Form
    {
        public Doubles()
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            try
            {

                if (NameTextBox.Text == "")
                { MessageBox.Show("Unesite ime para!"); }
                else if (SportComboBox.Text == "")
                { MessageBox.Show("Uzaberite vrstu sporta!"); }



                else
                {
                    int sportsId = SportsRepository.GetIdByName(SportComboBox.Text);

                    SqlCeCommand command = new SqlCeCommand("INSERT INTO Doubles (Name, Sports_Id) VALUES" + " ('" + NameTextBox.Text + "', '" + sportsId + "'); ", Connection);

                    command.ExecuteNonQuery();

                    MessageBox.Show("Unos je uspio!");
                    NameTextBox.Clear();
                    NameTextBox.Focus();


                }
            }

            catch (Exception ee)
            {


                MessageBox.Show("Unos nije uspio! \r Greska: " + ee.Message);
                return;

            }
        }

        private void Doubles_Load_1(object sender, EventArgs e)
        {
            PopulateSportsComboBox();
        }

        private void PopulateSportsComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;
          
            try
            {
                

                SportComboBox.Items.Clear();
                SqlCeCommand cmm = Connection.CreateCommand();
                cmm.CommandType = CommandType.Text;
                cmm.CommandText = "SELECT * FROM Sports";

                cmm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmm);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    SportComboBox.Items.Add(dr["Description_sports"].ToString());
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void SportComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonVIEW_Click(object sender, EventArgs e)
        {
            Form deleteform = new DoublesDeleteForm();
            deleteform.Show();
            this.Hide();
        }
    }
}
