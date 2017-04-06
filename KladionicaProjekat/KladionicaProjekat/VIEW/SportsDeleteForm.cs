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
    public partial class SportsDeleteForm : Form
    {
        public SportsDeleteForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            Form newform = new Sports();
            this.Hide();
            newform.Show();
        }

        private void PopulateSportsComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            SportComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Sports";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                SportComboBox.Items.Add(dr["Description_sports"].ToString());
            }
            SportComboBox.SelectedIndex = 0;
        }

        private void SportsDeleteForm_Load(object sender, EventArgs e)
        {
            PopulateSportsComboBox();
        }
    }
}
