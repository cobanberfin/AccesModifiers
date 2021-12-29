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
    public partial class Kayıtliste : Form
    {
        Todoservice todoservice;
        public Kayıtliste()
        {
            InitializeComponent();
            todoservice = new Todoservice();
        }

        private void Kayıtliste_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe();
            dataGridView1.Columns["id"].Visible = false; //bu alanı gösterme
        }

        private List<todo> TumListe()
        {
            return todoservice.kayıtListe();

        }

        private void buttonTümlist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe();
            dataGridView1.Columns["id"].Visible = false; //bu alanı gösterme
        }

        private void buttontamamlandı_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe().Where(x => x.durumAciklama == "Tamamlandı").ToList();
            dataGridView1.Columns["id"].Visible = false;
        }

        private void buttontamolmadı_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe().Where(x => x.durumAciklama == "Tamamlanmadı").ToList();
            dataGridView1.Columns["id"].Visible = false;
        }

        private void buttoniptal_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = TumListe().Where(x => x.durumAciklama == "İptal").ToList();
            dataGridView1.Columns["id"].Visible = false;
        }
    }
}
