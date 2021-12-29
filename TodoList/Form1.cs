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

namespace TodoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 15000; //15 snyede bır calısck
            timer1.Tick += Tm_zamanla_Tick;
            timer1.Start();
            ButonAcKapa(false);
            SistemGiriş kullanicikontrol = new SistemGiriş();
            kullanicikontrol.MdiParent = this; //aynı pencere acmak için
            kullanicikontrol.StartPosition =FormStartPosition.CenterScreen;//ortaya yaz
            kullanicikontrol.Show();

        }

        private void ButonAcKapa(bool kontrol) //sana gönderılen degerıkontrol et
        {//butonlar gruopbaksın ıcınde onları göstercez
            foreach (Control item in groupBoxislemliste.Controls)
            {
                if(item is Button)
                {
                  ((Button)item).Enabled = kontrol;

                }

            }
            
        }

        private void Tm_zamanla_Tick(object sender, EventArgs e)
        {
            labelzamn.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
        }

        private void groupBoxislemliste_Enter(object sender, EventArgs e)
        {

        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();//uygulamadan cıktı
        }

        Form T;//bıkac yerde kullanacagım ıcın
        private void btnyenıkyt_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["yeniKayıt"] != null)
            {
                T = Application.OpenForms["yeniKayıt"];
                T.Focus(); //bu form acıksa gıt focus odaklan et
            }
            else
            {

                T = new yeniKayıt();
                T.MdiParent = this; //senın sahıbın bu 
                T.Show();
            }


        }

        private void btnKayıtliste_Click(object sender, EventArgs e)
        {
            Todoservice todoservice = new Todoservice();
            //kayıt yoksa lıste acılmasın 
            if (todoservice.kayıtKontrol() > 0)
            {
                Kayıtliste kayıtlistesi = new Kayıtliste();
                kayıtlistesi.MdiParent = this;
                kayıtlistesi.Show();
            }
            else
            {
                MessageBox.Show("listelenecek kayıt bulunamadı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
