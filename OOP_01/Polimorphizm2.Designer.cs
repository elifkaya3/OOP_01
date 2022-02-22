
namespace OOP_01
{
    partial class Polimorphizm2
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
            this.btnEkmek = new System.Windows.Forms.Button();
            this.btnCep = new System.Windows.Forms.Button();
            this.btnTekstil = new System.Windows.Forms.Button();
            this.dgvSepet = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkmek
            // 
            this.btnEkmek.Location = new System.Drawing.Point(138, 167);
            this.btnEkmek.Name = "btnEkmek";
            this.btnEkmek.Size = new System.Drawing.Size(75, 23);
            this.btnEkmek.TabIndex = 5;
            this.btnEkmek.Text = "Ekmek";
            this.btnEkmek.UseVisualStyleBackColor = true;
            this.btnEkmek.Click += new System.EventHandler(this.btnEkmek_Click);
            // 
            // btnCep
            // 
            this.btnCep.Location = new System.Drawing.Point(79, 107);
            this.btnCep.Name = "btnCep";
            this.btnCep.Size = new System.Drawing.Size(134, 23);
            this.btnCep.TabIndex = 4;
            this.btnCep.Text = "Cep Telefonu";
            this.btnCep.UseVisualStyleBackColor = true;
            this.btnCep.Click += new System.EventHandler(this.btnCep_Click);
            // 
            // btnTekstil
            // 
            this.btnTekstil.Location = new System.Drawing.Point(138, 47);
            this.btnTekstil.Name = "btnTekstil";
            this.btnTekstil.Size = new System.Drawing.Size(75, 23);
            this.btnTekstil.TabIndex = 3;
            this.btnTekstil.Text = "Tekstil";
            this.btnTekstil.UseVisualStyleBackColor = true;
            this.btnTekstil.Click += new System.EventHandler(this.btnTekstil_Click);
            // 
            // dgvSepet
            // 
            this.dgvSepet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSepet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvSepet.Location = new System.Drawing.Point(248, 47);
            this.dgvSepet.Name = "dgvSepet";
            this.dgvSepet.Size = new System.Drawing.Size(411, 164);
            this.dgvSepet.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ürün Adı";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Fiyat";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "KDV Dahil Fiyat";
            this.Column3.Name = "Column3";
            // 
            // Polimorphizm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSepet);
            this.Controls.Add(this.btnEkmek);
            this.Controls.Add(this.btnCep);
            this.Controls.Add(this.btnTekstil);
            this.Name = "Polimorphizm2";
            this.Text = "Polimorphizm2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSepet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkmek;
        private System.Windows.Forms.Button btnCep;
        private System.Windows.Forms.Button btnTekstil;
        private System.Windows.Forms.DataGridView dgvSepet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}