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
using KladionicaProjekat.VIEW;


namespace KladionicaProjekat
{
    public partial class EventForma : Form
    {
        public EventForma()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
             if (DoublesIDComboBox.Text == "")
                { MessageBox.Show("Unesite porove!"); }


                else
                {

                    int DoublesId = DoublesRepository.GetIdByName(DoublesIDComboBox.Text);

                    SqlCeCommand command = new SqlCeCommand("INSERT INTO Event (Date, Time, Doubles_Id1) VALUES" + " ('" + DateTime.Now.Date.ToString("yyyy-MM-dd") + "', '" + DateTime.Now.TimeOfDay + "', '" + DoublesId + "'); ", Connection);

                    command.ExecuteNonQuery();
                    MessageBox.Show("Unos je uspio!");


                }
            }

            catch (Exception ee)
            {


                MessageBox.Show("Unos nije uspio! \r Greska: " + ee.Message);
                return;

            }
        }
        


        private void PopulateDoublesComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            try
            {

                DoublesIDComboBox.Items.Clear();
                SqlCeCommand cmm = Connection.CreateCommand();
                cmm.CommandType = CommandType.Text;
                cmm.CommandText = "SELECT * FROM Doubles";

                cmm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmm);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    DoublesIDComboBox.Items.Add(dr["Name"].ToString());
                }



            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }


        private void EventForma_Load(object sender, EventArgs e)
        {
            PopulateDoublesComboBox();
        }

       

        private void Doubles_Id1BomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Time_ofDateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void DateDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
