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
    public partial class CodeBettingShopDeleteForm : Form
    {
        public CodeBettingShopDeleteForm()
        {
            InitializeComponent();
            CenterToParent();
        }



        private void PopulateCodeBettingShopComboBox()
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;


            CodeBettingShopComboBox.Items.Clear();
            SqlCeCommand cmd = Connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Code_betting_shop";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                CodeBettingShopComboBox.Items.Add(dr["Name"].ToString() + "-" + dr["Address"].ToString());
            }
            CodeBettingShopComboBox.SelectedIndex = 0;
        }

        private void CodeBettingShopForm_Load(object sender, EventArgs e)
        {
            PopulateCodeBettingShopComboBox();

        }

        private void CodeBettingShopComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form newform = new Code_betting_shop();
            this.Hide();
            newform.Show();
        }
    }
}
