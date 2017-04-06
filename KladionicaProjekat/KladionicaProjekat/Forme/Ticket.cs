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
using KladionicaProjekat.Repository;

namespace KladionicaProjekat
{
    public partial class Ticket : Form
    {
        public Ticket()
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

                if (Date_of_paymentDateTime.Text == "")
                { MessageBox.Show("Unesite datum!"); }
                else if (Time_paymentDateTime.Text == "")
                { MessageBox.Show("Unesite vrijeme!"); }
                else if (Ticket_control_numberTextBox.Text == "")
                { MessageBox.Show("Unesite kontrolni broj tiketa!"); }
                else if (Payment_amountTextBox.Text == "")
                { MessageBox.Show("Unesite iznos uplate!"); }
                else if (Player_IdTextBox.Text == "")
                { MessageBox.Show("Unesite sifru igraca!"); }
                else if (Workpeople_IdTextBox.Text == "")
                { MessageBox.Show("Unesite ime zaposlenog!"); }
                else if (Code_betting_shop_IdTextBox.Text == "")
                { MessageBox.Show("Unesite sifru uplatnog mjesta!"); }
                else if (SystemTextBox.Text == "")
                { MessageBox.Show("Unesite da ili ne!"); }




                else
                {
                    /*SqlCeCommand command = new SqlCeCommand("INSERT INTO Ticket (Date_of_payment, Time_payment, Ticket_control_number, Payment_amount, Player_Id, System, Workpeople_Id, Code_betting_shop_Id) VALUES" + " ('" + Date_of_paymentDateTime.Value.Date.ToString("yyyy-MM-dd") + "', '" + Time_paymentDateTicke.Value.TimeOfDay.ToString("hh:mm:ss") + "','" + Ticket_control_numberTextBox.Text + "', '" + Payment_amountTextBox.Text + "', '" + Player_IdTextBox.Text + "', '" + SystemTextBox.Text + "', '" + Workpeople_IdTextBox.Text + "', '" + Code_betting_shop_IdTextBox.Text + "'); ", Connection);*/

                    SqlCeCommand command = new SqlCeCommand(@"INSERT INTO Ticket (Date_of_payment, Time_payment, Ticket_control_number, Payment_amount, Player_Id, Workpeople_Id, Code_betting_shop_Id, System)
                    VALUES (@date_of_payment, @time_payment, @ticket_control_number, @payment_amount, @player_Id, @workpeople_Id, @code_betting_shop_Id, @system)", Connection);
                    command.Parameters.AddWithValue("@date_of_pyament", Date_of_paymentDateTime.Value.Date.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@time_payment", Time_paymentDateTime);
                    command.Parameters.AddWithValue("@ticket_control_number", Ticket_control_numberTextBox);
                    command.Parameters.AddWithValue("@payment_amount", Payment_amountTextBox);
                    command.Parameters.AddWithValue("@player_id", Player_IdTextBox);
                    command.Parameters.AddWithValue("@workpeople_Id", Workpeople_IdTextBox);
                    command.Parameters.AddWithValue("@code_betting_shop_Id", Code_betting_shop_IdTextBox);
                    command.Parameters.AddWithValue("@system", SystemTextBox);


                    command.ExecuteNonQuery();
                    MessageBox.Show("Unos je uspio!");

                    Ticket_control_numberTextBox.Clear();
                    Payment_amountTextBox.Clear();
                    SystemTextBox.Clear();
                    Ticket_control_numberTextBox.Focus();



                }
            }

            catch (Exception ee)
            {


                MessageBox.Show("Unos nije uspio! \r Greska: " + ee.Message);
                return;

            }
        }

        

        private void PopulatePlayerComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;
            try
            {
                Player_IdTextBox.Items.Clear();
                SqlCeCommand cmd = Connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Player";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Player_IdTextBox.Items.Add(dr["First_name"].ToString());
                }




            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void PopulateWorkpeopleComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;
            try
            {
                Workpeople_IdTextBox.Items.Clear();
                SqlCeCommand cmd = Connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Workpeople";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Workpeople_IdTextBox.Items.Add(dr["First_name"].ToString());
                }




            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void PopulateCode_betting_shopComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;
            try
            {
                Code_betting_shop_IdTextBox.Items.Clear();
                SqlCeCommand cmd = Connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Code_betting_shop";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Code_betting_shop_IdTextBox.Items.Add(dr["Name"].ToString());
                }




            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Ticket_Load(object sender, EventArgs e)
        {
            Date_of_paymentDateTime.CustomFormat = ("yyyy-MM-dd");
            Time_paymentDateTime.CustomFormat = ("hh:mm:ss");
            PopulatePlayerComboBox();
            PopulateWorkpeopleComboBox();
            PopulateCode_betting_shopComboBox();
        }

        private void Date_of_paymentDateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Code_betting_shop_IdTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
