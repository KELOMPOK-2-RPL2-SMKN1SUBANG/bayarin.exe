using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luthor.lib;
using System.Windows.Forms;

namespace Bayarin
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            /*Jika login sebagai petugas*/
            if (Session.getUserLogged().Columns.Contains("level") && Session.getUserLogged().Rows[0].Field<string>("level") == "officer")
            {
                gunaLabel3.Text = "Petugas";
            }

            /*Jika login sebagai siswa*/
            if (!Session.getUserLogged().Columns.Contains("level"))
            {
                gunaLabel3.Text = "Siswa";

                label2.Visible = false;
                gunaButton2.Visible = false;

                label3.Visible = false;
                gunaButton3.Visible = false;

                /*label4.Location = new System.Drawing.Point(12, 185);*/
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Sign Out", "Yakin ingin keluar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Auth.Logout();
                this.Hide();
                Form login = new Login();
                login.Show();
            }
        }
    }
}
