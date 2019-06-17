using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ilkObserver = new IlkAsamaObserver();
            var ikinciObserver = new IkinciAsamaObserver();
            Observerr biletManager = new Observerr();
            biletManager.Attach(ilkObserver);
            biletManager.Attach(ikinciObserver);
            MessageBox.Show("Program Bilgileri Kontrol Edildi ve Güncellendi");
        }
    }
}
