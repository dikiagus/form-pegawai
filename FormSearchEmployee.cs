using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace mission5
{
    public partial class FormSearchEmployee : Form
    {
        public FormSearchEmployee()
        {
            InitializeComponent();
        }

        private void inputDataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInputEmployee formInput = new FormInputEmployee();

            // Menampilkan Form Input Pegawai
            formInput.Show();
            this.Hide();
        }

        private void editDataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditEmployee formEdit = new FormEditEmployee();
            formEdit.Show();
            this.Close();
        }

        private void tampilanDataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowEmployee formShow = new FormShowEmployee();
            formShow.Show();
            this.Close();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit(); // Keluar dari aplikasi
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=practice;Integrated Security=True";

            // Membuat koneksi
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                string query = "SELECT * FROM emp_mission5 WHERE nama LIKE @nama OR posisi LIKE @posisi";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.SelectCommand.Parameters.AddWithValue("@nama", "%" + txtCari.Text + "%");
                da.SelectCommand.Parameters.AddWithValue("@posisi", "%" + txtCari.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dgvSearchResults.DataSource = dt;
                    MessageBox.Show("Data Pegawai Berhasil Ditemukan !", "Ditemukan ! !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCari.Clear();
                }
                else
                {
                    MessageBox.Show("Data Pegawai Tidak Ditemukan !", "Tidak Ditemukan ! !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
