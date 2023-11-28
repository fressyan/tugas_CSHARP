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
    public partial class MasterKodePromo : Form
    {
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public MasterKodePromo()
        {
            InitializeComponent();
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_tiket.tbl_KodePromo (id,kode,persentase_diskon,maksimum_diskon,berlaku_sampai,deskripsi) VALUES " +
                        "('" + id.Text + "'," +
                        "'" + txtKodePromo.Text + "'," +
                        "'" + dtBerlakuSampai.Text + "'," +
                        "'" + nudPersentaseDiskon.Text + "'," +
                        "'" + nudMaksimumDiskon.Text + "'," +
                        "'" + txtDeskripsi.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data KodePromo");
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
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_tiket.tbl_KodePromo", koneksi.conn);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            dgvKodePromo.DataSource = ds;
        }

        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_tiket.tbl_KodePromo where id in(select max(id) FROM db_tiket.tbl_KodePromo) order by id desc";
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
        private void MasterKodePromo_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();
        }
    }
}
