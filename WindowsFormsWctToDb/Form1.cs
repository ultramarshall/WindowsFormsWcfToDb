using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsWctToDb.ServiceReference1;

namespace WindowsFormsWctToDb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Biodata p = new Biodata();
            p.Id = Convert.ToInt32(txtId.Text);
            p.Nama = txtNama.Text;
            p.Umur = Convert.ToInt32(txtUmur.Text);

            Service1Client service = new Service1Client();

            if (service.InsertBiodata(p) == 1)
            {
                MessageBox.Show("Biodata berhasil di simpan");
            }
        }
    }
}
