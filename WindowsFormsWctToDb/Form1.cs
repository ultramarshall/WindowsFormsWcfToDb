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

            if (service.TambahBiodata(p) == 1)
            {
                MessageBox.Show("Biodata berhasil di simpan");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Biodata p = new Biodata()
            {
                Id = Convert.ToInt32(txtId.Text),
                Nama = txtNama.Text,
                Umur = Convert.ToInt32(txtUmur.Text)
            };
            

            Service1Client service = new Service1Client();

            if (service.EditBiodata(p) == 1)
            {
                MessageBox.Show("Biodata berhasil di edit");
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            Biodata p = new Biodata()
            {
                Id = Convert.ToInt32(txtId.Text),
            };
            
            Service1Client service = new Service1Client();

            if (service.HapusBiodata(p) == 1)
            {
                MessageBox.Show("Biodata berhasil di hapus");
            }
        }

        private void getBiodata_Click(object sender, EventArgs e)
        {
            List<Biodata> biodata = new List<Biodata>();
            Biodata p = new Biodata()
            {
                Id = Convert.ToInt32(txtId.Text)
            };
            Service1Client service = new Service1Client();
            biodata.Add(service.GetBiodata(p));
            dgvBiodata.DataSource = biodata;

        }

        private void AllBiodata_Click(object sender, EventArgs e)
        {
            List<Biodata> biodataList = new List<Biodata>();
            Service1Client service = new Service1Client();
            dgvBiodata.DataSource = service.GetAllBiodata();
        }
    }
}
