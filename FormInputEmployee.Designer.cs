namespace mission5
{
    partial class FormInputEmployee
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
            this.editDataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tampilanDataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pencarianDataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGaji = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPosisi = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDataPegawaiToolStripMenuItem,
            this.tampilanDataPegawaiToolStripMenuItem,
            this.pencarianDataPegawaiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(606, 28);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editDataPegawaiToolStripMenuItem
            // 
            this.editDataPegawaiToolStripMenuItem.Name = "editDataPegawaiToolStripMenuItem";
            this.editDataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.editDataPegawaiToolStripMenuItem.Text = "Edit Data Pegawai";
            this.editDataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.editDataPegawaiToolStripMenuItem_Click);
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
            this.label4.Location = new System.Drawing.Point(203, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 25);
            this.label4.TabIndex = 30;
            this.label4.Text = "Form Input Data Pegawai";
            // 
            // txtGaji
            // 
            this.txtGaji.Location = new System.Drawing.Point(191, 258);
            this.txtGaji.Name = "txtGaji";
            this.txtGaji.Size = new System.Drawing.Size(338, 22);
            this.txtGaji.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Gaji";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Posisi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nama";
            // 
            // txtPosisi
            // 
            this.txtPosisi.Location = new System.Drawing.Point(191, 202);
            this.txtPosisi.Name = "txtPosisi";
            this.txtPosisi.Size = new System.Drawing.Size(338, 22);
            this.txtPosisi.TabIndex = 23;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(191, 146);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(338, 22);
            this.txtNama.TabIndex = 22;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(395, 351);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 44;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(243, 351);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 43;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // FormInputEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 428);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGaji);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPosisi);
            this.Controls.Add(this.txtNama);
            this.Name = "FormInputEmployee";
            this.Text = "Form Input Data Pegawai";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tampilanDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencarianDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGaji;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPosisi;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Button btnInput;
    }
}

