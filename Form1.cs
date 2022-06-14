using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformasiDesa
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams parms = base.CreateParams;
                parms.ClassStyle |= 0x200;
                return parms;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hide other user controls
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();

            //Show current user control
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Hide other user controls
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl51.Hide();

            //Show current user control
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Hide other user controls
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            userControl51.Hide();

            //Show current user control
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Hide other user controls
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl51.Hide();

            //Show current user control
            userControl41.Show();
            userControl41.BringToFront();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //Hide other user controls
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();

            //Show current user control
            userControl51.Show();
            userControl51.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Yakin anda ingin keluar ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();

                Pengguna pengguna = new Pengguna();
                pengguna.Show();
            }
        }

    }

}
