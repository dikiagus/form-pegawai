namespace mission5
{
    partial class FormSearchEmployee
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
            this.editDataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tampilanDataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvSearchResults = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataPegawaiToolStripMenuItem,
            this.editDataPegawaiToolStripMenuItem,
            this.tampilanDataPegawaiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputDataPegawaiToolStripMenuItem
            // 
            this.inputDataPegawaiToolStripMenuItem.Name = "inputDataPegawaiToolStripMenuItem";
            this.inputDataPegawaiToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.inputDataPegawaiToolStripMenuItem.Text = "Input Data Pegawai";
            this.inputDataPegawaiToolStripMenuItem.Click += new System.EventHandler(this.inputDataPegawaiToolStripMenuItem_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(237, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Form Pencarian Data Pegawai";
            // 
            // dgvSearchResults
            // 
            this.dgvSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchResults.Location = new System.Drawing.Point(32, 188);
            this.dgvSearchResults.Name = "dgvSearchResults";
            this.dgvSearchResults.RowHeadersWidth = 51;
            this.dgvSearchResults.RowTemplate.Height = 24;
            this.dgvSearchResults.Size = new System.Drawing.Size(616, 250);
            this.dgvSearchResults.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Masukkan Nama atau Posisi Pegawai";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(287, 138);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(361, 22);
            this.txtCari.TabIndex = 37;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(686, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(686, 415);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 39;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // FormSearchEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSearchResults);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormSearchEmployee";
            this.Text = "Form Pencarian Data Pegawai";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tampilanDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvSearchResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnKeluar;
    }
}