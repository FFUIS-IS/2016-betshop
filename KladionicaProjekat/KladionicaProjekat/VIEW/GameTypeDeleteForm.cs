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

namespace KladionicaProjekat.VIEW
{
    public partial class GameTypeForm : Form
    {
        public GameTypeForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            Form newform = new Game_type();
            this.Hide();
            newform.Show();
        }

        private void PopulateGameTypeComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            GameTypeComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Game_type";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                GameTypeComboBox.Items.Add(dr["Kind_of_game"].ToString());
            }
           GameTypeComboBox.SelectedIndex = 0;
        }

        private void GameTypeDeleteForm_Load(object sender, EventArgs e)
        {
            PopulateGameTypeComboBox();
        }

    

       /*proba za brisanje treba popraviti
        *
        * private void GameTypeDelete(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = Connection.CreateCommand();

            command.CommandText = "SELECT * FROM Game_type";


            SqlCeDataReader rdr = command.ExecuteReader();


            while (rdr.Read())
            {


                SqlCeDataReader reserveReader;
                string info;

                int from = rdr.GetInt32(1);

                command.CommandText = "SELECT Game_type FROM Kind_of_game WHERE id = " + from + ";";

                reserveReader = command.ExecuteReader();
                reserveReader.Read();

                info = reserveReader.GetString(0);
              
                info += " - " + reserveReader.GetString(0);
                GameTypeComboBox.Items.Add(rdr.GetInt32(0) + " " + info);


            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            SqlCeCommand command = Connection.CreateCommand();

            DialogResult dr = MessageBox.Show("Da li želite da izbrišete ?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {


                string name = GameTypeComboBox.SelectedItem.ToString().Substring(0, GameTypeComboBox.SelectedItem.ToString().IndexOf(' '));


                command.CommandText = "DELETE FROM Game_type WHERE id = " + int.Parse(name) + ";";
                try
                {
                    command.ExecuteReader();

                    GameTypeComboBox.Items.Remove(GameTypeComboBox.SelectedItem);
                }
                catch (SqlCeException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

            else if (dr == DialogResult.No) { }
        }*/

    }
}
