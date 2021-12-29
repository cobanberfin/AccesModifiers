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
    public partial class SistemGiriş : Form
    {
        public SistemGiriş()
        {
            InitializeComponent();
        }

        private void txtkullanıcıad_Enter(object sender, EventArgs e)
        {//sener ıle gelen txtboxını baackcolrınısarı yap
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;


        }

        private void txtkullanıcıad_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {//giriş yap butonları ac
            if (!string.IsNullOrEmpty(txtkullanıcıad.Text) || !string.IsNullOrEmpty(txtşifre.Text))
            {
                KullanıcıService kullanıcıService = new KullanıcıService();
                Kullanıcı kontrolkullanici = kullanıcıService.kullanıcıkontrol(txtkullanıcıad.Text, txtşifre.Text);
                if(kontrolkullanici != null)
                {
                    Form anaform = Application.OpenForms["Form1"];//formu aldım
                    Panel solpanel = (Panel)anaform.Controls["panel1"];//panele indim
                    GroupBox grbislemliste = (GroupBox)solpanel.Controls["groupBoxislemliste"];

                    foreach ( Control item in grbislemliste.Controls)
                    {
                       
                        if(item is Button)
                        {
                            item.Enabled = true;
                        }

                    }
                    MessageBox.Show("Merhaba" + kontrolkullanici.KullanıcıAdı, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();


                }


                else
                {
                    MessageBox.Show("hatalı kullanıc adı veya şifre", "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                
                MessageBox.Show("lütfen giriş bilgilerinizi eksıksız giriniz", "bilgilendırme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
