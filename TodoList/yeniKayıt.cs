using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoList.BusinessServices;
using TodoList.entities;

namespace TodoList
{
    public partial class yeniKayıt : Form
    {
        public yeniKayıt()
        {
            InitializeComponent();
        }

        private void baslık_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void baslık_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Todoservice todoservice = new Todoservice();
            int sonuc = todoservice.YeniKayıt(new entities.todo()
            {
                id = Guid.NewGuid(),
                baslık = txtbaslık.Text,
                kisaaciklama = textBoxkısaacıklama.Text,
                aciklama = txtaciklama.Text,
                durumAciklama = comboBoxdurum.SelectedItem.ToString(),
                onemderece = int.Parse(txtonem.Text),
                Olusturmatarihi = DateTime.Now
            });

            if (sonuc > 0)
            {
                MessageBox.Show("kayıt ekleme işlemı basarılı", "bilgilendırme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("yenı kayıt ekleme işlemıne devam etme ister misiniz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                        if (item is TextBox)
                        {
                            ((TextBox)item).Text = string.Empty;
                        }
                    }
                }
                else
                {
                    Form kayitliste = Application.OpenForms["kayitliste"];
                    if (kayitliste == null)
                    {
                        kayitliste = new Kayıtliste();
                        kayitliste.MdiParent = Application.OpenForms["Form1"];
                        kayitliste.Show();
                        this.Close();
                    }
                    else
                    {//doluysa datagrıte ulaş 
                        GroupBox liste =(GroupBox) kayitliste.Controls["groupBoxliste"];
                        DataGridView grdliste = (DataGridView)liste.Controls["DataGridView1"];
                       
                        //listetı getır
                        List<todo> Guncelliste = todoservice.kayıtListe();
                        grdliste.DataSource = null;
                        grdliste.DataSource = Guncelliste;
                        //liste cıkınca yenı kayıt kapansın
                        this.Close();
                        grdliste.Columns["id"].Visible = false;
                       

                    }
                }
                

            }
            else
            {
                MessageBox.Show("kayıt ekleme işlemınde hata", "bilgilendırme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
