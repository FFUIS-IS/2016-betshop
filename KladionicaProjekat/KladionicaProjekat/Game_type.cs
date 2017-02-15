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
    public partial class Game_type : Form
    {
        public Game_type()
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


            SqlCeCommand command = new SqlCeCommand("INSERT INTO Game_type ([Kind_of_game]) VALUES" + " ('" + Kind_of_gameTextBox.Text + "'); ", Connection);

            try
            {
                command.ExecuteNonQuery();
            }

            catch (Exception ee)
            {


                MessageBox.Show("Unos nije uspio! \r Greska: " + ee.Message);
                return;

            }


            if (Kind_of_gameTextBox.Text == "")
            { MessageBox.Show("Unesite vrstu igre!"); }


            else
            {
                MessageBox.Show("Unos je uspio!");
                Kind_of_gameTextBox.Clear();
                Kind_of_gameTextBox.Focus();
            }


        }
    }
}
