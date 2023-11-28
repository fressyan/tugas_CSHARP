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
    public partial class MasterBandara : Form
    {
        ComboBoxFunction cb = new ComboBoxFunction();
        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public MasterBandara()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)

        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM db_tiket.tbl_Bandara", koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvbandara.DataSource = dt;
        }
        public void nomor_urut()
        {
            int hitung, nomor;
            koneksi.conn.Open();
            string sql = "SELECT id FROM db_tiket.tbl_bandara where id in(select max(id) FROM db_tiket.tbl_bandara) order by id desc";
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

        private void txtJumlah_Terminal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MasterBandara_Load(object sender, EventArgs e)
        {
            view_data();
            nomor_urut();

            //Menampilkan Data Negara Dari database dan dimasukkan ke combobox
            string query = "SELECT * FROM tbl_negara";
            //ComboBoxFunction.Set_ComboBox(query, "nama", txtNegara);
            // txtNegara.DataSource = cb.getData(query);
            //txtNegara.DisplayMember = "nama";
            //txtNegara.ValueMember = "id";
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            try
            {
                koneksi.conn.Open();
                String sql = "INSERT INTO db_tiket.tbl_bandara (id,nama,kodeiata,kota,negaraid,jumlahterminal,alamat) VALUES " +
                        "('" + id.Text + "'," +
                        "'" + txtNama.Text + "'," +
                        "'" + txtKodeIATA.Text + "'," +
                        "'" + txtKota.Text + "'," +
                        "'" + cb_negara_id.SelectedValue + "'," +
                        "'" + txtJumlahterminal.Text + "'," +
                        "'" + txtAlamat.Text + "')";
                cmd = new NpgsqlCommand(sql, koneksi.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil Simpan Data Bandara");
                view_data();
                koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
