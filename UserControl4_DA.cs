using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InformasiDesa
{
    public partial class UserControl4_DA : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        public UserControl4_DA()
        {
            InitializeComponent();
        }

        void TampilAcara2()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_ACARA", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_ACARA");
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "TBL_ACARA";
                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }

            finally
            {
                conn.Close();
            }
        }

        void TampilRonda2()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_RONDA", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_RONDA");
                dataGridView3.DataSource = ds;
                dataGridView3.DataMember = "TBL_RONDA";
                dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }

            finally
            {
                conn.Close();
            }
        }

        void NoOtomatis()
        {
            long hitung;
            string urutan;
            SqlDataReader rd;
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select No from TBL_ACARA where No in(select max(No) from TBL_ACARA) order by No desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["No"].ToString().Length - 3, 3)) + 1;
                string kodeurutan = "000" + hitung;
                urutan = "" + kodeurutan.Substring(kodeurutan.Length - 3, 3);
            }

            else
            {
                urutan = "001";
            }

            textBoxNo.Enabled = false;
            textBoxNo.Text = urutan;
            conn.Close();
            rd.Close();
        }

        void NoOtomatis2()
        {
            long hitung2;
            string urutan2;
            SqlDataReader rd;
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("select No from TBL_RONDA where No in(select max(No) from TBL_RONDA) order by No desc", conn);
            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                hitung2 = Convert.ToInt64(rd[0].ToString().Substring(rd["No"].ToString().Length - 3, 3)) + 1;
                string kodeurutan2 = "000" + hitung2;
                urutan2 = "" + kodeurutan2.Substring(kodeurutan2.Length - 3, 3);
            }

            else
            {
                urutan2 = "001";
            }

            textBoxNo2.Enabled = false;
            textBoxNo2.Text = urutan2;
            conn.Close();
            rd.Close();
        }

        private void UserControl4_DA_Load(object sender, EventArgs e)
        {
            TampilAcara2();
            TampilRonda2();
            NoOtomatis();
            NoOtomatis2();
        }

        void Bersihkan()
        {
            textBoxNo.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        void Bersihkan2()
        {
            textBoxNo2.Clear();
            hariSenin.Clear();
            hariSelasa.Clear();
            hariRabu.Clear();
            hariKamis.Clear();
            hariJumat.Clear();
            hariSabtu.Clear();
            hariMinggu.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNo.Text.Trim() == "" || textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Data belum terisi lengkap !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //else if ()
            //{
                //MessageBox.Show("Tidak dapat menambahkan data yang sudah ada !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            else
            {
                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("insert into TBL_ACARA values('" + textBoxNo.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil ditambahkan !");//, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information
                    TampilAcara2();
                    Bersihkan();
                    NoOtomatis();
                }

                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxNo.Text.Trim() == "" || textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Pilih dulu data yang ingin diubah !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("update TBL_ACARA set Acara='" + textBox1.Text + "',Tempat='" + textBox2.Text + "',Tanggal='" + textBox3.Text + "',Waktu='" + textBox4.Text + "' where No='" + textBoxNo.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update data berhasil !");
                    TampilAcara2();
                    Bersihkan();
                    NoOtomatis();
                }

                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxNo.Text.Trim() == "" || textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Pilih dulu data yang ingin dihapus !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show("Yakin akan menghapus data ke-" + textBoxNo.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();
                {
                    cmd = new SqlCommand("delete TBL_ACARA where No='" + textBoxNo.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hapus data berhasil !"); //,"Information", MessageBoxButtons.OK, MessageBoxIcon.Information
                    TampilAcara2();
                    Bersihkan();
                    NoOtomatis();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxNo2.Text.Trim() == "" || hariSenin.Text.Trim() == "" || hariSelasa.Text.Trim() == "" || hariRabu.Text.Trim() == "" || hariKamis.Text.Trim() == "" || hariJumat.Text.Trim() == "" || hariSabtu.Text.Trim() == "" || hariMinggu.Text.Trim() == "")
            {
                MessageBox.Show("Data belum terisi lengkap !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //else if ()
            //{
            //MessageBox.Show("Tidak dapat menambahkan data yang sudah ada !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            else
            {
                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("insert into TBL_RONDA values('" + textBoxNo2.Text + "','" + hariSenin.Text + "','" + hariSelasa.Text + "','" + hariRabu.Text + "','" + hariKamis.Text + "','" + hariJumat.Text + "','" + hariSabtu.Text + "','" + hariMinggu.Text +"')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil ditambahkan !");//, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information
                    TampilRonda2();
                    Bersihkan2();
                    NoOtomatis2();
                }

                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxNo2.Text.Trim() == "" || hariSenin.Text.Trim() == "" || hariSelasa.Text.Trim() == "" || hariRabu.Text.Trim() == "" || hariKamis.Text.Trim() == "" || hariJumat.Text.Trim() == "" || hariSabtu.Text.Trim() == "" || hariMinggu.Text.Trim() == "")
            {
                MessageBox.Show("Pilih dulu data yang ingin diubah !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {

                SqlConnection conn = Konn.GetConn();

                try
                {
                    cmd = new SqlCommand("update TBL_RONDA set Senin='" + hariSenin.Text + "',Selasa='" + hariSelasa.Text + "',Rabu='" + hariRabu.Text + "',Kamis='" + hariKamis.Text + "',Jumat='" + hariJumat.Text + "',Sabtu='" + hariSabtu.Text + "',Minggu='" + hariMinggu.Text + "' where No='" + textBoxNo2.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update data berhasil !");
                    TampilRonda2();
                    Bersihkan2();
                    NoOtomatis2();
                }

                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxNo2.Text.Trim() == "" || hariSenin.Text.Trim() == "" || hariSelasa.Text.Trim() == "" || hariRabu.Text.Trim() == "" || hariKamis.Text.Trim() == "" || hariJumat.Text.Trim() == "" || hariSabtu.Text.Trim() == "" || hariMinggu.Text.Trim() == "")
            {
                MessageBox.Show("Pilih dulu data yang ingin dihapus !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else if (MessageBox.Show("Yakin akan menghapus data ke-" + textBoxNo2.Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();
                {
                    cmd = new SqlCommand("delete TBL_RONDA where No='" + textBoxNo2.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hapus data berhasil !"); //,"Information", MessageBoxButtons.OK, MessageBoxIcon.Information
                    TampilRonda2();
                    Bersihkan2();
                    NoOtomatis2();
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                textBoxNo.Text = row.Cells["No"].Value.ToString();
                textBox1.Text = row.Cells["Acara"].Value.ToString();
                textBox2.Text = row.Cells["Tempat"].Value.ToString();
                textBox3.Text = row.Cells["Tanggal"].Value.ToString();
                textBox4.Text = row.Cells["Waktu"].Value.ToString();
            }

            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
                textBoxNo2.Text = row.Cells["No"].Value.ToString();
                hariSenin.Text = row.Cells["Senin"].Value.ToString();
                hariSelasa.Text = row.Cells["Selasa"].Value.ToString();
                hariRabu.Text = row.Cells["Rabu"].Value.ToString();
                hariKamis.Text = row.Cells["Kamis"].Value.ToString();
                hariJumat.Text = row.Cells["Jumat"].Value.ToString();
                hariSabtu.Text = row.Cells["Sabtu"].Value.ToString();
                hariMinggu.Text = row.Cells["Minggu"].Value.ToString();
            }

            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

    }

}
