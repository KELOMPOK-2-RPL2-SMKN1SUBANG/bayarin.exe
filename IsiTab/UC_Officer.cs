using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luthor.lib;
using System.Windows.Forms;

namespace Bayar.exe.IsiTab
{
    public partial class UC_Officer : UserControl
    {
        public UC_Officer()
        {
            InitializeComponent();
        }

        private string getId;

        private void UC_Officer_Load(object sender, EventArgs e)
        {
            readDataPetugas();
        }

        private void readDataPetugas()
        {          
            /*DataTable data = Db.Read("petugas", "id, username, nama_petugas, level");
            foreach (DataRow row in data.Rows)
            {
                gunaDataGridView1.Rows.Add(
                    row.Field<int>("id"),
                    row.Field<string>("username"),
                    row.Field<string>("nama_petugas"),
                    row.Field<string>("level")
                );
            }*/

            string query = "SELECT * FROM petugas";
            DataTable data = Db.Read(query);
            gunaDataGridView1.AutoGenerateColumns = false;
            gunaDataGridView1.DataSource = data;
        }

        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = gunaDataGridView1.CurrentCell.RowIndex;
            getId = gunaDataGridView1.Rows[row].Cells["ColumnId"].Value.ToString();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            hapusDataPetugas();
        }

        private void hapusDataPetugas()
        {
            if (getId.Length > 0)
            {
                var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    Db.Delete("petugas", $"id = {getId}");
                    readDataPetugas();
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
