using KladionicaProjekat;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicSchoolDiary
{
    public class Lists
    {
        

        public static void FillDropDownList1(string Query, string column, ComboBox DropDownName )
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            try
            {
                if (DropDownName.Items.Count > 0)
                {
                    DropDownName.Items.Clear();
                    SqlCeCommand cmd = new SqlCeCommand(Query, Connection);
                    SqlCeDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                        DropDownName.Items.Add(reader[column].ToString());
                        DropDownName.SelectedIndex = 0;
                        reader.Close();
                }
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message.ToString());
            }
        }
      
    }
}
