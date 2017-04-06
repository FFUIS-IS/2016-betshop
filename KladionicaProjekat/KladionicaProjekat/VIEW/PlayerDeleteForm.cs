using ElectronicSchoolDiary;
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


namespace KladionicaProjekat.Forme
{
    public partial class PlayerDeleteForm : Form
    {
        public PlayerDeleteForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            Form newform = new Player();
            this.Hide();
            newform.Show();
        }

        private void PopulatePlayerComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            PlayerComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Player";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                PlayerComboBox.Items.Add(dr["First_name"].ToString() + "-" + dr["Last_name"].ToString());
            }
            PlayerComboBox.SelectedIndex = 0;
        }


        private void DeletePlayer(String name, String surname)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            try
            {
                SqlCeCommand cmd = Connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM PLAYER WHERE First_name =" + name + "AND Last_name =" + surname;
                cmd.ExecuteNonQuery();

                SqlCeCommand command1 = new SqlCeCommand(@"DELETE FROM Player WHERE First_Name = @uname AND Last_name = @surname ", Connection);
                command1.Parameters.AddWithValue("@name", name);
                command1.Parameters.AddWithValue("@surname", surname);
                command1.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }


        private void DeletePlayerForm_Load(object sender, EventArgs e)
        {
            PopulatePlayerComboBox();

        }


       
    }
}
