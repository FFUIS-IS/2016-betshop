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
    class Code_betting_shopRepository
    {
        public static string GetNameCode_betting_shopQuery()
        {
            string query;
            query = @"SELECT Name FROM Code_betting_shop";
            return query;
        }

        public static string GetAddressCode_betting_shopQuery()
        {
            string query;
            query = @"SELECT Address FROM Code_betting_shop";
            return query;
        }

        public static bool AddCode_betting_shop(string Name, string Address)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;

            bool flag = false;

            try
            {

                SqlCeCommand command1 = new SqlCeCommand(@"INSERT INTO Code_betting_shop (Name, Address) VALUES (@name, @address)", Connection);
                command1.Parameters.AddWithValue("@name", Name);
                command1.Parameters.AddWithValue("@address", Address);

                int result = command1.ExecuteNonQuery();

                if (result > 0)
                {
                    flag = true;
                    MessageBox.Show("Uspjesno ste dodali sifru uplatnog mjesta!!!");
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
