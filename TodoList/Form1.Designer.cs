
namespace TodoList
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxislemliste = new System.Windows.Forms.GroupBox();
            this.btnkapat = new System.Windows.Forms.Button();
            this.btnKayıtliste = new System.Windows.Forms.Button();
            this.btnyenıkyt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelzamn = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBoxislemliste.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxislemliste);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 497);
            this.panel1.TabIndex = 1;
            // 
            // groupBoxislemliste
            // 
            this.groupBoxislemliste.Controls.Add(this.btnkapat);
            this.groupBoxislemliste.Controls.Add(this.btnKayıtliste);
            this.groupBoxislemliste.Controls.Add(this.btnyenıkyt);
            this.groupBoxislemliste.Location = new System.Drawing.Point(12, 158);
            this.groupBoxislemliste.Name = "groupBoxislemliste";
            this.groupBoxislemliste.Size = new System.Drawing.Size(165, 316);
            this.groupBoxislemliste.TabIndex = 1;
            this.groupBoxislemliste.TabStop = false;
            this.groupBoxislemliste.Text = "işlem listesi";
            this.groupBoxislemliste.Enter += new System.EventHandler(this.groupBoxislemliste_Enter);
            // 
            // btnkapat
            // 
            this.btnkapat.Location = new System.Drawing.Point(6, 121);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(153, 23);
            this.btnkapat.TabIndex = 2;
            this.btnkapat.Text = "Uygulama kapat";
            this.btnkapat.UseVisualStyleBackColor = true;
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // btnKayıtliste
            // 
            this.btnKayıtliste.Location = new System.Drawing.Point(6, 76);
            this.btnKayıtliste.Name = "btnKayıtliste";
            this.btnKayıtliste.Size = new System.Drawing.Size(153, 23);
            this.btnKayıtliste.TabIndex = 1;
            this.btnKayıtliste.Text = "Kayıt Lİste";
            this.btnKayıtliste.UseVisualStyleBackColor = true;
            this.btnKayıtliste.Click += new System.EventHandler(this.btnKayıtliste_Click);
            // 
            // btnyenıkyt
            // 
            this.btnyenıkyt.Location = new System.Drawing.Point(6, 30);
            this.btnyenıkyt.Name = "btnyenıkyt";
            this.btnyenıkyt.Size = new System.Drawing.Size(153, 23);
            this.btnyenıkyt.TabIndex = 0;
            this.btnyenıkyt.Text = "Yenikayıt";
            this.btnyenıkyt.UseVisualStyleBackColor = true;
            this.btnyenıkyt.Click += new System.EventHandler(this.btnyenıkyt_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelzamn);
            this.panel2.Location = new System.Drawing.Point(749, 440);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 57);
            this.panel2.TabIndex = 2;
            // 
            // labelzamn
            // 
            this.labelzamn.AutoSize = true;
            this.labelzamn.Location = new System.Drawing.Point(16, 36);
            this.labelzamn.Name = "labelzamn";
            this.labelzamn.Size = new System.Drawing.Size(97, 13);
            this.labelzamn.TabIndex = 0;
            this.labelzamn.Text = "28/12/2021/11.40";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TodoList.Properties.Resources.User_Interface_Checklist_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Todo-Uygulaması";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxislemliste.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxislemliste;
        private System.Windows.Forms.Button btnkapat;
        private System.Windows.Forms.Button btnKayıtliste;
        private System.Windows.Forms.Button btnyenıkyt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelzamn;
        private System.Windows.Forms.Timer timer1;
    }
}

