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
    public partial class WorkpeopleDeleteForm : Form
    {
        public WorkpeopleDeleteForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            Form newform = new Workpeople();
            this.Hide();
            newform.Show();
        }

        private void PopulateWorkpeopleComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            WorkpeopleComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Workpeople";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                WorkpeopleComboBox.Items.Add(dr["First_name"].ToString() + "-" + dr["Last_name"].ToString());
            }
            WorkpeopleComboBox.SelectedIndex = 0;
        }

        private void WorkpeopleDeleteForm_Load(object sender, EventArgs e)
        {
            PopulateWorkpeopleComboBox();
        }
    }
}
