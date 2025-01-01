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
    public partial class FormInputEmployee : Form
    {
        public FormInputEmployee()
        {
            InitializeComponent();
        }

        private void editDataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditEmployee formEdit = new FormEditEmployee();
            formEdit.Show();
            this.Hide();
        }

        private void tampilanDataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowEmployee formShow = new FormShowEmployee();
            formShow.Show();
            this.Hide(); // Menutup form Input Pegawai
            }

        private void pencarianDataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchEmployee formSearch = new FormSearchEmployee();
            formSearch.Show();
            this.Hide();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit(); // Keluar dari aplikasi
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(txtGaji.Text, out _))
            {
                MessageBox.Show("Kolom Gaji hanya boleh diisi dengan angka !", "Input Tidak Valid ! !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGaji.Focus(); // Mengembalikan fokus ke TextBox gaji
                txtGaji.Clear();
                return;
            }

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=practice;Integrated Security=True";

            // Membuat koneksi
            using (SqlConnection connection = new SqlConnection(connectionString))
            
                {
                    connection.Open();
                string query = "INSERT INTO emp_mission5 (nama, posisi, gaji) VALUES (@nama, @posisi, @gaji)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@posisi", txtPosisi.Text);
                cmd.Parameters.AddWithValue("@gaji", Convert.ToDecimal(txtGaji.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Pegawai Telah Berhasil Ditambahkan !", "Berhasil ! !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                ClearInputFields();
            }
        }

        private void ClearInputFields()
        {
            txtNama.Clear();
            txtPosisi.Clear();
            txtGaji.Clear();
        }

    }
}
