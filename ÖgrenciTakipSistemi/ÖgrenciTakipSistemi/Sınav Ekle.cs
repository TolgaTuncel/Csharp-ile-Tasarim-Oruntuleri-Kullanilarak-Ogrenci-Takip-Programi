using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ÖgrenciTakipSistemi
{
    public partial class Sınav_Ekle : Form
    {
        public Sınav_Ekle()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Veritabanım.mdb");
        OleDbDataAdapter adtr = new OleDbDataAdapter();
        private void button1_Click(object sender, EventArgs e)
        {

           

            //AbstractFactory Kullanımı
            OgrenciAbstracFactory systemManager = new OgrenciAbstracFactory(new Fabricate1());
            systemManager.GetAll();
            MessageBox.Show("Local Cache ve NLogger");
        }

        private void Sınav_Ekle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dil Ve Anlatım");
            comboBox1.Items.Add("Türk Edebiyatı");
            comboBox1.Items.Add("Yabancı Dil");
            comboBox1.Items.Add("Tarih");
            comboBox1.Items.Add("Matematik");
            comboBox1.Items.Add("Geometri");
            comboBox1.Items.Add("Biyoloji");
            comboBox1.Items.Add("Kimya");
            comboBox1.Items.Add("Fizik");
            comboBox1.Items.Add("Din Kültürü");
            comboBox1.Items.Add("Meslek Gelişim");
        }
    }
}
