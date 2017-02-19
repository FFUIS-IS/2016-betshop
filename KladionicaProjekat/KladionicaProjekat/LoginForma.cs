using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KladionicaProjekat.Models;
using System.Data.SqlServerCe;
using System.IO;

namespace KladionicaProjekat
{
    public partial class LoginForma : Form
    {
        public LoginForma()
        {
            InitializeComponent();
        }
        string home = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString();

        public string GetHomeDirectory()
        {
            return home;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text.Length == 0 )
            {
                MessageBox.Show("Unesite korisnicko ime!");
            }
            else if (PasswordTextBox.Text.Length == 0)
            {
                MessageBox.Show("Unesite lozinku!");
            }
            else
            {
                CheckLogin r = new CheckLogin();
                r.Check(UserNameTextBox, PasswordTextBox);
                if (r.isNewFormOpened() == true)
                {
                    UserNameTextBox.Text = "";
                    PasswordTextBox.Text = "";
                    this.Hide();
                }
            }
        }
        
        
    }
}
