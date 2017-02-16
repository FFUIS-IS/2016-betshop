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
    public partial class Ticket : Form
    {
        public Ticket()
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


            SqlCeCommand command = new SqlCeCommand("INSERT INTO Event ([Date_of_payment], [Time_payment], [Code_betting_shop_code], [Ticket_control_number], [Payment_amount], [Player_Id], [System], [Workpeople_Id]) VALUES" + " ('" + Date_of_paymentTextBox.Text + "', '" + Time_paymentTextBox.Text + "', '" + Code_betting_shop_codeTextBox.Text + "', '" + Ticket_control_numberTextBox.Text + "', '" + Payment_amountTextBox.Text + "', '" + Player_IdTextBox.Text + "', '" + SystemTextBox.Text + "', '" + Workpeople_IdTextBox.Text + "'); ", Connection);

            try
            {

                if (Date_of_paymentTextBox.Text == "")
                { MessageBox.Show("Unesite datum!"); }
                else if (Time_paymentTextBox.Text == "")
                { MessageBox.Show("Unesite vrijeme!"); }
                else if (Code_betting_shop_codeTextBox.Text == "")
                { MessageBox.Show("Unesite sifru uplatnog mjesta!"); }
                else if (Ticket_control_numberTextBox.Text == "")
                { MessageBox.Show("Unesite kontrolni broj tiketa!"); }
                else if (Payment_amountTextBox.Text == "")
                { MessageBox.Show("Unesite iznos uplate!"); }
                else if (Player_IdTextBox.Text == "")
                { MessageBox.Show("Unesite sifru igraca!"); }
                else if (SystemTextBox.Text == "")
                { MessageBox.Show("Potvrdite sistem!"); }
                else if (Workpeople_IdTextBox.Text == "")
                { MessageBox.Show("Unesite ime zaposlenog!"); }




                else
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Unos je uspio!");
                    Date_of_paymentTextBox.Clear();
                    Time_paymentTextBox.Clear();
                    Code_betting_shop_codeTextBox.Clear();
                    Ticket_control_numberTextBox.Clear();
                    Payment_amountTextBox.Clear();
                    Player_IdTextBox.Clear();
                    SystemTextBox.Clear();
                    Workpeople_IdTextBox.Clear();
                    Date_of_paymentTextBox.Focus();


                    ;


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
