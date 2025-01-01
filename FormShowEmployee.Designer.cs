namespace mission5
{
    partial class FormShowEmployee
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
            this.pencarianDataPegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputDataPegawaiToolStripMenuItem,
            this.editDataPegawaiToolStripMenuItem,
            this.pencarianDataPegawaiToolStripMenuItem});
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
            this.label4.Location = new System.Drawing.Point(215, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(371, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Form Tampilan Data Pegawai (Show)";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(28, 115);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersWidth = 51;
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(652, 314);
            this.dgvEmployee.TabIndex = 36;
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(701, 257);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 40;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // FormShowEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormShowEmployee";
            this.Text = "Form Tampilan Data Pegawai (Show)";
            this.Load += new System.EventHandler(this.FormShowEmployee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pencarianDataPegawaiToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Button btnKeluar;
    }
}