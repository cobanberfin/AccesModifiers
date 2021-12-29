using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnterfaceform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Küpkutu> klist = new List<Küpkutu>();
        private void btnküp_Click(object sender, EventArgs e)
        {
            Küpkutu kp = new Küpkutu();
            kp.id = 1;
            kp.yukseklik = 14;
            kp.UrunAd = "mukavva kutu";
            klist.Add(kp);

            Küpkutu kp2 = new Küpkutu();
            kp2.id = 2;
            kp2.yukseklik = 24;
            kp2.UrunAd = "karton kutu";
            klist.Add(kp2);

            Küpkutu kp3 = new Küpkutu();
            kp3.id = 3;
            kp3.yukseklik = 25;
            kp3.UrunAd = "tahta kutu";
            klist.Add(kp3);
            dataGridView1.DataSource = klist;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {//sanagelensecılen nesenın turukupkutumu bak
            if (dataGridView1.CurrentRow.DataBoundItem is Küpkutu)
            {
                Küpkutu k = (Küpkutu)dataGridView1.CurrentRow.DataBoundItem;
                int hacim = k.Hacim();
                MessageBox.Show(hacim.ToString());
            }
            else
            {
                Dikdörtgenkutu d = (Dikdörtgenkutu)dataGridView1.CurrentRow.DataBoundItem;

                int hacim = d.Hacim();
                MessageBox.Show(hacim.ToString());

            }
            List<Dikdörtgenkutu> dlist = new List<Dikdörtgenkutu>();
                Dikdörtgenkutu d = new Dikdörtgenkutu();
                d.id = 1;
                d.UrunAd = "Kutu";
                d.uzunkenar = 12;
                d.kısakenar = 5;
                d.yukseklik = 7;
                dlist.Add(d);

                Dikdörtgenkutu d2= new Dikdörtgenkutu();
                d2.id = 2;
                d2.UrunAd = " metal Kutu";
                d2.uzunkenar = 17;
                d2.kısakenar = 9;
                d2.yukseklik = 10;
                dlist.Add(d2);
                dataGridView1.DataSource = null; //herbastıgında once nulu alsın 
                dataGridView1.DataSource = dlist;
            
        }

      
    }

}
       
    
