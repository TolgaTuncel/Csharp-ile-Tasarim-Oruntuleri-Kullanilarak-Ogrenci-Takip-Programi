using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mediator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mediatorr mediator = new Mediatorr();
            Hoca tolga = new Hoca(mediator);

            tolga.Name = "Tolga";

            mediator.Hoca = tolga;
            Ogrenci refik = new Ogrenci();
            refik.Name = "Refik";


            Ogrenci salih = new Ogrenci();
            salih.Name = "Salih";
            mediator.Ogrenciler = new List<Ogrenci> { refik, salih };

            tolga.SendNewImageUrl("slide1.jpg");
            MessageBox.Show(tolga.Name + "Hoca resmi değiştirdi");
            MessageBox.Show("Resim" + salih.Name + "adlı öğrenciye iletildi");
            MessageBox.Show("Resim" + refik.Name + "adlı öğrenciye iletildi");
            //birşeyler yazdı.
        }
    }
}
