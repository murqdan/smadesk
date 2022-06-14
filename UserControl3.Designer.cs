
namespace InformasiDesa
{
    partial class UserControl3
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textCari2 = new System.Windows.Forms.TextBox();
            this.Segarkeun2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(234, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "JADWAL RONDA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(245)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 118);
            this.panel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Location = new System.Drawing.Point(27, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(664, 278);
            this.dataGridView1.TabIndex = 3;
            // 
            // textCari2
            // 
            this.textCari2.ForeColor = System.Drawing.Color.DimGray;
            this.textCari2.Location = new System.Drawing.Point(165, 146);
            this.textCari2.Multiline = true;
            this.textCari2.Name = "textCari2";
            this.textCari2.Size = new System.Drawing.Size(388, 22);
            this.textCari2.TabIndex = 13;
            this.textCari2.Text = "cari seseorang...";
            this.textCari2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textCari2.Click += new System.EventHandler(this.textCari2_Click);
            this.textCari2.TextChanged += new System.EventHandler(this.textCari2_TextChanged);
            // 
            // Segarkeun2
            // 
            this.Segarkeun2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(154)))), ((int)(((byte)(48)))));
            this.Segarkeun2.FlatAppearance.BorderSize = 0;
            this.Segarkeun2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Segarkeun2.Font = new System.Drawing.Font("Arimo", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Segarkeun2.ForeColor = System.Drawing.Color.White;
            this.Segarkeun2.Location = new System.Drawing.Point(612, 164);
            this.Segarkeun2.Name = "Segarkeun2";
            this.Segarkeun2.Size = new System.Drawing.Size(79, 26);
            this.Segarkeun2.TabIndex = 14;
            this.Segarkeun2.Text = "Segarkan";
            this.Segarkeun2.UseVisualStyleBackColor = false;
            this.Segarkeun2.Click += new System.EventHandler(this.Segarkeun2_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Segarkeun2);
            this.Controls.Add(this.textCari2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(719, 545);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textCari2;
        private System.Windows.Forms.Button Segarkeun2;
    }
}
