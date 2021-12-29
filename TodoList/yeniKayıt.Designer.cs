
namespace TodoList
{
    partial class yeniKayıt
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbaslık = new System.Windows.Forms.TextBox();
            this.textBoxkısaacıklama = new System.Windows.Forms.TextBox();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxdurum = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtonem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kısa Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlık";
            // 
            // txtbaslık
            // 
            this.txtbaslık.Location = new System.Drawing.Point(121, 31);
            this.txtbaslık.Name = "txtbaslık";
            this.txtbaslık.Size = new System.Drawing.Size(100, 20);
            this.txtbaslık.TabIndex = 2;
            this.txtbaslık.Enter += new System.EventHandler(this.baslık_Enter);
            this.txtbaslık.Leave += new System.EventHandler(this.baslık_Leave);
            // 
            // textBoxkısaacıklama
            // 
            this.textBoxkısaacıklama.Location = new System.Drawing.Point(121, 65);
            this.textBoxkısaacıklama.Name = "textBoxkısaacıklama";
            this.textBoxkısaacıklama.Size = new System.Drawing.Size(100, 20);
            this.textBoxkısaacıklama.TabIndex = 3;
            this.textBoxkısaacıklama.Enter += new System.EventHandler(this.baslık_Enter);
            this.textBoxkısaacıklama.Leave += new System.EventHandler(this.baslık_Leave);
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(121, 106);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(95, 20);
            this.txtaciklama.TabIndex = 5;
            this.txtaciklama.Enter += new System.EventHandler(this.baslık_Enter);
            this.txtaciklama.Leave += new System.EventHandler(this.baslık_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Önem Derecesi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Durum";
            // 
            // comboBoxdurum
            // 
            this.comboBoxdurum.FormattingEnabled = true;
            this.comboBoxdurum.Items.AddRange(new object[] {
            "Beklemede ",
            "Tamamlandı",
            "Tamamlanmadı",
            "Ertelendi",
            "İptal"});
            this.comboBoxdurum.Location = new System.Drawing.Point(121, 185);
            this.comboBoxdurum.Name = "comboBoxdurum";
            this.comboBoxdurum.Size = new System.Drawing.Size(121, 21);
            this.comboBoxdurum.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "yeni kayıt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtonem
            // 
            this.txtonem.Location = new System.Drawing.Point(121, 142);
            this.txtonem.Name = "txtonem";
            this.txtonem.Size = new System.Drawing.Size(95, 20);
            this.txtonem.TabIndex = 11;
            // 
            // yeniKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 299);
            this.Controls.Add(this.txtonem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxdurum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtaciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxkısaacıklama);
            this.Controls.Add(this.txtbaslık);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "yeniKayıt";
            this.Text = "Todo-Yeni Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbaslık;
        private System.Windows.Forms.TextBox textBoxkısaacıklama;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxdurum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtonem;
    }
}