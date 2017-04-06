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
    public partial class DoublesDeleteForm : Form
    {
        public DoublesDeleteForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            Form newform = new Doubles();
            this.Hide();
            newform.Show();
        }

        
        private void PopulateDoublesComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            DoublesComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Doubles";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                DoublesComboBox.Items.Add(dr["Name"].ToString());
            }
            DoublesComboBox.SelectedIndex = 0;
        }

        private void DoublesDeleteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DoublesDeleteForm_Load(object sender, EventArgs e)
        {
            PopulateDoublesComboBox();
        }
    }
}
