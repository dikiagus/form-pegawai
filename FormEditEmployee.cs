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
    public partial class FormEditEmployee : Form
    {
        public FormEditEmployee()
        {
            InitializeComponent();
            LoadEmployeeNames();
        }

        private void LoadEmployeeNames()
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=practice;Integrated Security=True";
            
            string query = "SELECT nama FROM emp_mission5";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string employeeName = reader["nama"].ToString();
                        comboBoxEmployeeNames.Items.Add(employeeName); // Tambahkan nama pegawai ke ComboBox
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        private void inputDataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInputEmployee formInput = new FormInputEmployee();

            // Menampilkan Form Input Pegawai
            formInput.Show();
            this.Hide();
        }

        private void tampilanDataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowEmployee formShow = new FormShowEmployee();
            formShow.Show();
            this.Close();
        }

        private void pencarianDataPegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearchEmployee formSearch = new FormSearchEmployee();
            formSearch.Show();
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

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (!decimal.TryParse(txtGaji.Text, out _))
            {
                MessageBox.Show("Kolom Gaji hanya boleh diisi dengan angka !", "Input Tidak Valid ! !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGaji.Focus(); // Mengembalikan fokus ke TextBox gaji
                txtGaji.Clear();
                return;
            }

            // Ambil nama pegawai yang dipilih dari ComboBox
            string selectedName = comboBoxEmployeeNames.SelectedItem.ToString();

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=practice;Integrated Security=True";

            // Membuat koneksi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Update data pegawai yang sesuai dengan nama yang dipilih
                string query = "UPDATE emp_mission5 SET nama = @nama, posisi = @posisi, gaji = @gaji WHERE nama = @selectedName";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@posisi", txtPosisi.Text);
                cmd.Parameters.AddWithValue("@gaji", Convert.ToDecimal(txtGaji.Text));
                cmd.Parameters.AddWithValue("@selectedName", selectedName); // Nama pegawai yang dipilih dari ComboBox

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Pegawai Telah Berhasil Diupdate !", "Berhasil ! !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                connection.Close();
                ClearInputFields();
                LoadEmployeeNames();
            }
        }

        private void ClearInputFields()
        {
            comboBoxEmployeeNames.SelectedItem = null; // Hapus pilihan yang ada
            comboBoxEmployeeNames.Items.Clear(); // Kosongkan item dalam ComboBox
            txtNama.Clear();
            txtPosisi.Clear();
            txtGaji.Clear();
        }

    }
}
