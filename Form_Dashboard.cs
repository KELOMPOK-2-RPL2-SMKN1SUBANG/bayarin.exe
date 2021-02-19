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

namespace Bayar.exe
{
    public partial class Form_Dashboard : Form
    {
        public Form_Dashboard()
        {
            InitializeComponent();
        }

        private void Form_Dashboard_Load(object sender, EventArgs e)
        {
            /*Jika login sebagai petugas*/
            if (Session.getUserLogged().Columns.Contains("level") && Session.getUserLogged().Rows[0].Field<string>("level") == "officer")
            {
                gunaLabel3.Text = "Petugas";

                btnpayments.Visible = false;

                labelofficer.Visible = false;
                btnofficer.Visible = false;
            }

            /*Jika login sebagai siswa*/
            if (!Session.getUserLogged().Columns.Contains("level"))
            {
                gunaLabel3.Text = "Siswa";

                labelstudents.Visible = false;
                btnstudents.Visible = false;
                btnclass.Visible = false;

                btnpay.Text = "Riwayat Pembayaran";
                btnpayments.Visible = false;

                labelofficer.Visible = false;
                btnofficer.Visible = false;
            }
        }

        private void btnofficer_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl petugas = new IsiTab.UC_Officer();
            petugas.Dock = DockStyle.Fill;
            panel1.Controls.Add(petugas);
        }
    }
}
