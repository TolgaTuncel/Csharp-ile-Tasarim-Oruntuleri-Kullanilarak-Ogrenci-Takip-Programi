using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Etkinlik k1 = new Etkinlik() { Adi = "YakarTop", DersAdi = "BedenEğitimi" };
            k1.Adres = new Adres() { adres = "Derince" };

            MessageBox.Show("Etkinlik Adı: " + k1.Adi + " " + "Ders Adi: " + k1.DersAdi + " " + "Adres: " + k1.Adres.adres);


            Etkinlik k2 = k1.Clone();

            MessageBox.Show("Etkinlik Adı: " + k2.Adi + " " + "Ders Adi: " + k2.DersAdi + " " + "Adres: " + k2.Adres.adres);

            k2.Adi = "Peygamberin Doğumu";

            k2.DersAdi = "Din Külütürü";

            k2.Adres.adres = "İzmit";

            MessageBox.Show("Etkinlik Adı: " + k1.Adi + " " + "DersAdi: " + k1.DersAdi + " " + "Adres: " + k1.Adres.adres + "\n" + "Etkinlik Adı: " + k2.Adi + " " + "Ders Adi: " + k2.DersAdi + " " + "Adres: " + k2.Adres.adres);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Etkinlik k3 = new Etkinlik() { Adi = "YakarTop", DersAdi = "BedenEğitimi" };
            k3.Adres = new Adres() { adres = "Derince" };

            MessageBox.Show("Ad: " + k3.Adi + " " + "Soyadı: " + k3.DersAdi + " " + "Adres: " + k3.Adres.adres);


            Etkinlik k4 = k3.DeepCopy();

            MessageBox.Show("Ad: " + k4.Adi + " " + "Soyadı: " + k4.DersAdi + " " + "Adres: " + k4.Adres.adres);


            k3.Adi = "Seda";

            k3.DersAdi = "Çetin";

            k3.Adres.adres = "İzmir";

            MessageBox.Show("Ad: " + k3.Adi + " " + "Soyadı: " + k3.DersAdi + " " + "Adres: " + k3.Adres.adres + "\n" + "Ad: " + k4.Adi + " " + "Soyadı: " + k4.DersAdi + " " + "Adres: " + k4.Adres.adres);
        }
    }
}
