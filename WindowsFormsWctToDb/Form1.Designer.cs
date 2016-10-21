namespace WindowsFormsWctToDb
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUmur = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.dgvBiodata = new System.Windows.Forms.DataGridView();
            this.getBiodata = new System.Windows.Forms.Button();
            this.AllBiodata = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiodata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(307, 19);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Simpan";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(54, 21);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(237, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(54, 50);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(237, 20);
            this.txtNama.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "umur";
            // 
            // txtUmur
            // 
            this.txtUmur.Location = new System.Drawing.Point(54, 79);
            this.txtUmur.Name = "txtUmur";
            this.txtUmur.Size = new System.Drawing.Size(237, 20);
            this.txtUmur.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(307, 48);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(307, 77);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 8;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dgvBiodata
            // 
            this.dgvBiodata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBiodata.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBiodata.Location = new System.Drawing.Point(0, 142);
            this.dgvBiodata.Name = "dgvBiodata";
            this.dgvBiodata.Size = new System.Drawing.Size(395, 165);
            this.dgvBiodata.TabIndex = 9;
            // 
            // getBiodata
            // 
            this.getBiodata.Location = new System.Drawing.Point(12, 113);
            this.getBiodata.Name = "getBiodata";
            this.getBiodata.Size = new System.Drawing.Size(75, 23);
            this.getBiodata.TabIndex = 10;
            this.getBiodata.Text = "Cari";
            this.getBiodata.UseVisualStyleBackColor = true;
            this.getBiodata.Click += new System.EventHandler(this.getBiodata_Click);
            // 
            // AllBiodata
            // 
            this.AllBiodata.Location = new System.Drawing.Point(93, 113);
            this.AllBiodata.Name = "AllBiodata";
            this.AllBiodata.Size = new System.Drawing.Size(127, 23);
            this.AllBiodata.TabIndex = 11;
            this.AllBiodata.Text = "Cari Semua Biodata";
            this.AllBiodata.UseVisualStyleBackColor = true;
            this.AllBiodata.Click += new System.EventHandler(this.AllBiodata_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 307);
            this.Controls.Add(this.AllBiodata);
            this.Controls.Add(this.getBiodata);
            this.Controls.Add(this.dgvBiodata);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUmur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnInsert);
            this.Name = "Form1";
            this.Text = "Biodata";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBiodata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUmur;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dgvBiodata;
        private System.Windows.Forms.Button getBiodata;
        private System.Windows.Forms.Button AllBiodata;
    }
}

