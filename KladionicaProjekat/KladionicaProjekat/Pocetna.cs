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
            CenterToScreen();
        }
     
        private void Pocetna_Load(object sender, EventArgs e)
        {
            SqlCeConnection Connection = DataBaseConnection.Instance.Connection;
        }

        private void workpeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Workpeople workpeope = new Workpeople();
            workpeope.ShowDialog();
          
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player.ShowDialog();
        }

        private void gametypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game_type gameType = new Game_type();
            gameType.ShowDialog();
        }

        private void leagueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            League leagues = new League();
            leagues.ShowDialog();
        }

        private void sportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sports sportss = new Sports();
            sportss.ShowDialog();
        }

        private void doublesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doubles doubless = new Doubles();
            doubless.ShowDialog(); 
        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventForma events = new EventForma();
            events.ShowDialog();
        }

        private void codebettingshopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Code_betting_shop CodeBettigShop = new Code_betting_shop();
            CodeBettigShop.ShowDialog();
        }

        private void tiketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ticket Tickets = new Ticket();
            Tickets.ShowDialog();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Form newform = new LoginForm();
            this.Hide();
            newform.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin Admins = new Admin();
            Admins.ShowDialog();
        }
    }
}
