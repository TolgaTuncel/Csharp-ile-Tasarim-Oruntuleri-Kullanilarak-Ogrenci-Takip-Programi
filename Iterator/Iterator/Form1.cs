using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iterator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelAggregate aggregate = new PersonelAggregate();
            aggregate.Add(new Iterator { Id = 1, DersAdi = "Dil ve Anlatım", DersSaati = "2" });
            aggregate.Add(new Iterator { Id = 2, DersAdi = "Türk Edebiyatı", DersSaati = "2" });
            aggregate.Add(new Iterator { Id = 3, DersAdi = "Yabancı Dil", DersSaati = "4" });
            aggregate.Add(new Iterator { Id = 4, DersAdi = "Matematik", DersSaati = "6" });
            aggregate.Add(new Iterator { Id = 5, DersAdi = "Fizik", DersSaati = "5" });
            aggregate.Add(new Iterator { Id = 6, DersAdi = "Kimya", DersSaati = "4" });
            aggregate.Add(new Iterator { Id = 7, DersAdi = "Biyoloji", DersSaati = "4" });
            aggregate.Add(new Iterator { Id = 8, DersAdi = "Meslek Gelişim", DersSaati = "8" });

            Iteratorr iterasyon = aggregate.CreateIterator();
            while (iterasyon.HasItem())
            {
                MessageBox.Show($"ID : {iterasyon.CurrentItem().Id}\nDers Adı : {iterasyon.CurrentItem().DersAdi}\nDers Saati : {iterasyon.CurrentItem().DersSaati}\n*****");
                iterasyon.NextItem();
            }
        }
    }
}
