using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KladionicaProjekat
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }
          string home = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString();

        public string GetHomeDirectory()
        {
            return home;
}
        private void Pocetna_Load(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;
        }

        private void workpeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workpeople wpeope = new Workpeople();
            wpeope.ShowDialog();
          
        }
    }
}
