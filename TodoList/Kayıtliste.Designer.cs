
namespace TodoList
{
    partial class Kayıtliste
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
            this.groupBoxliste = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonTümlist = new System.Windows.Forms.Button();
            this.buttontamamlandı = new System.Windows.Forms.Button();
            this.buttontamolmadı = new System.Windows.Forms.Button();
            this.buttoniptal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxliste.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxliste
            // 
            this.groupBoxliste.Controls.Add(this.dataGridView1);
            this.groupBoxliste.Location = new System.Drawing.Point(309, 12);
            this.groupBoxliste.Name = "groupBoxliste";
            this.groupBoxliste.Size = new System.Drawing.Size(351, 409);
            this.groupBoxliste.TabIndex = 0;
            this.groupBoxliste.TabStop = false;
            this.groupBoxliste.Text = "Liste";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonTümlist
            // 
            this.buttonTümlist.Location = new System.Drawing.Point(55, 19);
            this.buttonTümlist.Name = "buttonTümlist";
            this.buttonTümlist.Size = new System.Drawing.Size(75, 23);
            this.buttonTümlist.TabIndex = 1;
            this.buttonTümlist.Text = "Tüm Liste";
            this.buttonTümlist.UseVisualStyleBackColor = true;
            // 
            // buttontamamlandı
            // 
            this.buttontamamlandı.Location = new System.Drawing.Point(55, 74);
            this.buttontamamlandı.Name = "buttontamamlandı";
            this.buttontamamlandı.Size = new System.Drawing.Size(75, 23);
            this.buttontamamlandı.TabIndex = 2;
            this.buttontamamlandı.Text = "Tamamlandı";
            this.buttontamamlandı.UseVisualStyleBackColor = true;
            this.buttontamamlandı.Click += new System.EventHandler(this.buttontamamlandı_Click);
            // 
            // buttontamolmadı
            // 
            this.buttontamolmadı.Location = new System.Drawing.Point(55, 116);
            this.buttontamolmadı.Name = "buttontamolmadı";
            this.buttontamolmadı.Size = new System.Drawing.Size(75, 23);
            this.buttontamolmadı.TabIndex = 3;
            this.buttontamolmadı.Text = "Tamamlanamadı";
            this.buttontamolmadı.UseVisualStyleBackColor = true;
            this.buttontamolmadı.Click += new System.EventHandler(this.buttontamolmadı_Click);
            // 
            // buttoniptal
            // 
            this.buttoniptal.Location = new System.Drawing.Point(55, 175);
            this.buttoniptal.Name = "buttoniptal";
            this.buttoniptal.Size = new System.Drawing.Size(75, 23);
            this.buttoniptal.TabIndex = 4;
            this.buttoniptal.Text = "İptal edildi";
            this.buttoniptal.UseVisualStyleBackColor = true;
            this.buttoniptal.Click += new System.EventHandler(this.buttoniptal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttontamolmadı);
            this.groupBox1.Controls.Add(this.buttoniptal);
            this.groupBox1.Controls.Add(this.buttonTümlist);
            this.groupBox1.Controls.Add(this.buttontamamlandı);
            this.groupBox1.Location = new System.Drawing.Point(33, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 378);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlem Listesi";
            // 
            // Kayıtliste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxliste);
            this.Name = "Kayıtliste";
            this.Text = "Kayıtliste";
            this.Load += new System.EventHandler(this.Kayıtliste_Load);
            this.groupBoxliste.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxliste;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonTümlist;
        private System.Windows.Forms.Button buttontamamlandı;
        private System.Windows.Forms.Button buttontamolmadı;
        private System.Windows.Forms.Button buttoniptal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}