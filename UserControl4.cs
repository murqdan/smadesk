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
    public partial class UserControl4 : UserControl
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Koneksi Konn = new Koneksi();

        public UserControl4()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Konn.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from TBL_LOGIN where NamaUser='" + txtUsername.Text + "' and PasswordUser='" + txtPassword.Text + "'", conn);

            rd = cmd.ExecuteReader();
            rd.Read();

            if (rd.HasRows)
            {
                FormAdmin formAdmin = new FormAdmin();
                formAdmin.Show();
                txtUsername.Clear();
                txtPassword.Clear();

                // Ini untuk menampilkan UserControl baru, ketika mengklik tombol pada UserControl sebelumnya
                /*UserControl4_DA UCDA = new UserControl4_DA();
                this.Controls.Add(UCDA);
                UserControl4 uc4 = new UserControl4();
                this.Hide();
                this.Parent.Controls.Add(UCDA);
                txtUsername.Clear();
                txtPassword.Clear();*/
            }
            else
            {
                MessageBox.Show("Anda Salah Menginputkan Username/Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
