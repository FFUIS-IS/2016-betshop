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
    public partial class LeagueDeleteForm : Form
    {
        public LeagueDeleteForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void buttonVIEW_Click(object sender, EventArgs e)
        {
            Form deleteform = new League();
            deleteform.Show();
            this.Hide();
        }

        private void PopulateLeagueComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


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
            LeagueComboBox.SelectedIndex = 0;
        }

        private void LeagueDeleteForm_Load(object sender, EventArgs e)
        {
            PopulateLeagueComboBox();
        }
    }
}
