using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KladionicaProjekat;
using System.Data.SqlServerCe;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;
namespace KladionicaProjekat.Repository
{
    class EventRepository
    {

        public static bool AddEvent(DateTime Date, DateTime Time_of, string Doubles_Id1)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Event (Date, Time_of, Doubles_Id1) VALUES (@date, @time_of, @doubles_Id1)", Connection);
                command1.Parameters.AddWithValue("@date", Date);
                command1.Parameters.AddWithValue("@time_of", Time_of);
                command1.Parameters.AddWithValue("@doubles_Id1", Doubles_Id1);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali dogadjaj!!!");
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return flag;
        }
    }
}
