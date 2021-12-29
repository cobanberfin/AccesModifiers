using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesModifiers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //public: uygulamamızın içinde veya dısıarısında ulaşılabılır
            //private: sadece tanımlandıgı class ıcersınde erısıleıblır 
            //protected : normal kullanımda priivat gıbı calısır kalıtım alınırsa publıc olarak işlem göçrür
            //internal: bu namespacenın ıcınde ulaşılabılır classların varsayılan erısım belirlysdr.

            Kisi k = new Kisi();
            Ogrenci o = new Ogrenci();
            
        }
    }
}
