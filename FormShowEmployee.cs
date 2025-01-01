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

namespace mission5
{
    public partial class FormShowEmployee : Form
    {
        public FormShowEmployee()
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

        private void FormShowEmployee_Load(object sender, EventArgs e)
        {

            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=practice;Integrated Security=True";

            // Membuat koneksi
            using (SqlConnection connection = new SqlConnection(connectionString))

            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM emp_mission5", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvEmployee.DataSource = dt;
            }
        }
    }
}
