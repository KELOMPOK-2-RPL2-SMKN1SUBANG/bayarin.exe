using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using Luthor.lib;
using System.Windows.Forms;

namespace Bayarin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text.Length > 0 && txtpassword.Text.Length > 0)
            {
                if (Auth.Login(txtusername.Text, txtpassword.Text, "petugas"))
                {
                    Form Dashboard = new FormDashboard();
                    this.Hide();
                    Dashboard.Show();
                }
                else if (Auth.Login($"SELECT * from siswa where nis='{txtusername.Text}' and birthday='{txtpassword.Text}' "))
                {
                    Form Dashboard = new FormDashboard();
                    this.Hide();
                    Dashboard.Show(); 
                }
                else
                {
                    MessageBox.Show("Username atau password salah", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtpassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void txtusername_Enter(object sender, EventArgs e)
        {
            if (txtusername.Text == "Default is NIS") txtusername.ResetText();
            txtusername.ForeColor = Color.Black;
        }

        private void txtusername_Leave(object sender, EventArgs e)
        {
            if (txtusername.Text.Length <= 0) 
            {
                txtusername.Text = "Default is NIS";
                txtusername.ForeColor = Color.DarkGray;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            gunaLabel1.Hide();
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text.Length <= 0)
            {
                gunaLabel1.Show();
            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {
            txtpassword.Focus();
        }
    }
}
