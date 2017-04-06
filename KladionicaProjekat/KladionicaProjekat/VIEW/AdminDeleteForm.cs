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
    public partial class AdminDeleteForm : Form
    {
        public AdminDeleteForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            Form newform = new Admin();
            this.Hide();
            newform.Show();
        }

        private void PopulateAdminComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            AdminComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Administrator";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                AdminComboBox.Items.Add(dr["Name"].ToString() + "-" + dr["SurName"].ToString());
            }
            AdminComboBox.SelectedIndex = 0;
        }

        private void AdminDeleteForm_Load(object sender, EventArgs e)
        {
            PopulateAdminComboBox();
        }
    }
}
