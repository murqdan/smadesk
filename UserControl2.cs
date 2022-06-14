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
    public partial class UserControl2 : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Koneksi Konn = new Koneksi();

        public UserControl2()
        {
            InitializeComponent();
        }

        void TampilAcara()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_ACARA", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_ACARA");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_ACARA";
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

        void CariAcara()
        {
            SqlConnection conn = Konn.GetConn();

            try
            {
                conn.Open();
                cmd = new SqlCommand("Select * from TBL_ACARA where No like '%" + textCari1.Text + "%' or Acara like '%" + textCari1.Text + "%' or Tempat like '%" + textCari1.Text + "%' or Tanggal like '%" + textCari1.Text + "%' or Waktu like '%" + textCari1.Text + "%' ", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "TBL_ACARA");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "TBL_ACARA";
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

        public void UserControl2_Load(object sender, EventArgs e)
        {
            textCari1.TextAlign = HorizontalAlignment.Center;
            TampilAcara();
        }

        private void textCari1_TextChanged(object sender, EventArgs e)
        {
            CariAcara();
        }

        private void textCari1_Click(object sender, EventArgs e)
        {
            textCari1.Clear();
        }

        private void Segarkeun_Click(object sender, EventArgs e)
        {
            TampilAcara();
            MessageBox.Show("Data berhasil disegarkan !");
        }
    }

}
