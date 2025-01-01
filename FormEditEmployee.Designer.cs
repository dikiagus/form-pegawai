namespace mission5
{
    partial class FormEditEmployee
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inputDataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tampilanDataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencarianDataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtGaji = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosisi = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.comboBoxEmployeeNames = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataPegawaiToolStripMenuItem,
            this.tampilanDataPegawaiToolStripMenuItem,
            this.pencarianDataPegawaiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 28);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputDataPegawaiToolStripMenuItem
            // 
            this.inputDataPegawaiToolStripMenuItem.Name = "inputDataPegawaiToolStripMenuItem";
            this.inputDataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.inputDataPegawaiToolStripMenuItem.Text = "Input Data Pegawai";
            this.inputDataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.inputDataPegawaiToolStripMenuItem_Click);
            // 
            // tampilanDataPegawaiToolStripMenuItem
            // 
            this.tampilanDataPegawaiToolStripMenuItem.Name = "tampilanDataPegawaiToolStripMenuItem";
            this.tampilanDataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.tampilanDataPegawaiToolStripMenuItem.Text = "Tampilan Data Pegawai";
            this.tampilanDataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.tampilanDataPegawaiToolStripMenuItem_Click);
            // 
            // pencarianDataPegawaiToolStripMenuItem
            // 
            this.pencarianDataPegawaiToolStripMenuItem.Name = "pencarianDataPegawaiToolStripMenuItem";
            this.pencarianDataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.pencarianDataPegawaiToolStripMenuItem.Text = "Pencarian Data Pegawai";
            this.pencarianDataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.pencarianDataPegawaiToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(193, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Form Edit Data Pegawai";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(230, 429);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtGaji
            // 
            this.txtGaji.Location = new System.Drawing.Point(185, 372);
            this.txtGaji.Name = "txtGaji";
            this.txtGaji.Size = new System.Drawing.Size(338, 22);
            this.txtGaji.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Gaji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Posisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Nama";
            // 
            // txtPosisi
            // 
            this.txtPosisi.Location = new System.Drawing.Point(185, 316);
            this.txtPosisi.Name = "txtPosisi";
            this.txtPosisi.Size = new System.Drawing.Size(338, 22);
            this.txtPosisi.TabIndex = 35;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(185, 260);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(338, 22);
            this.txtNama.TabIndex = 34;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(382, 429);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 42;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // comboBoxEmployeeNames
            // 
            this.comboBoxEmployeeNames.FormattingEnabled = true;
            this.comboBoxEmployeeNames.Location = new System.Drawing.Point(283, 137);
            this.comboBoxEmployeeNames.Name = "comboBoxEmployeeNames";
            this.comboBoxEmployeeNames.Size = new System.Drawing.Size(240, 24);
            this.comboBoxEmployeeNames.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Nama Pegawai yang Akan Diedit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Data Baru Pegawai";
            // 
            // FormEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 520);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxEmployeeNames);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtGaji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosisi);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormEditEmployee";
            this.Text = "Form Edit Data Pegawai";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tampilanDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencarianDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtGaji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosisi;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.ComboBox comboBoxEmployeeNames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}