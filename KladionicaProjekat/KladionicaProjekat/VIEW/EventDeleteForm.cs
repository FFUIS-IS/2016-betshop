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
    public partial class EventDeleteForm : Form
    {
        public EventDeleteForm()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            Form newform = new EventForma();
            this.Hide();
            newform.Show();
        }

        private void PopulateEventComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            EventComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Event";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                EventComboBox.Items.Add(dr["Date"].ToString() + "-" + dr["Time_of"].ToString());
            }
            /*EventDeleteComboBox.SelectedIndex = 0;*/
        }

        private void EventDeleteForm_Load(object sender, EventArgs e)
        {
            PopulateEventComboBox();
        }
    }
}
