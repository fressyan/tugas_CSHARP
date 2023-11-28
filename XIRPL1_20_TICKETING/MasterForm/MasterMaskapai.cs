using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XIRPL1_20_TICKETING.MasterForm
{
    public partial class MasterMaskapai : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public MasterMaskapai()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)

        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_tiket.tbl_maskapai (id,nama,perusahaan,jumlahkru,deskripsi) VALUES " +
                        "('" + id.Text + "'," +
                        "'" + txtNama.Text + "'," +
                        "'" + txtPerusahaan.Text + "'," +
                        "'" + nudJumlahKru.Value + "'," +
                        "'" + txtDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Maskapai");
                view_data();
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_tiket.tbl_maskapai", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvmaskapai.DataSource = dt;
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_tiket.tbl_maskapai where id in(select max(id) FROM db_tiket.tbl_maskapai) order by id desc";
            NpgsqlCommand
            cmd = new NpgsqlCommand(sql, koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                nomor = Convert.ToInt32(dr[0]);
                hitung = nomor + 1;
            }
            else
            {
                hitung = 1;
            }
            dr.Close();
            id.Text = Convert.ToString(hitung);
            koneksi.conn.Close();

        }
        private void MasterMaskapai_Load(object sender, EventArgs e)
        {
            
        }

        private void MasterMaskapai_Load_1(object sender, EventArgs e)
        {

        }
    }
}
