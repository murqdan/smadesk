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
    public partial class UserControl3 : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        public UserControl3()
        {
            InitializeComponent();
        }

        void TampilRonda()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_RONDA", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_RONDA");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_RONDA";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        void CariRonda()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_RONDA where No like '%" + textCari2.Text + "%' or Senin like '%" + textCari2.Text + "%' or Selasa like '%" + textCari2.Text + "%' or Rabu like '%" + textCari2.Text + "%' or Kamis like '%" + textCari2.Text + "%' or Jumat like '%" + textCari2.Text + "%' or Sabtu like '%" + textCari2.Text + "%' or Minggu like '%" + textCari2.Text + "%' ", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_RONDA");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_RONDA";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

        private void UserControl3_Load(object sender, EventArgs e)
        {
            textCari2.TextAlign = HorizontalAlignment.Center;
            TampilRonda();
        }

        private void textCari2_TextChanged(object sender, EventArgs e)
        {
            CariRonda();
        }

        private void textCari2_Click(object sender, EventArgs e)
        {
            textCari2.Clear();
        }

        private void Segarkeun2_Click(object sender, EventArgs e)
        {
            TampilRonda();
            MessageBox.Show("Data berhasil disegarkan !");
        }
    }
}
