using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BildirimManagerFactory manager = new BildirimManagerFactory(new LoggerFactory2());
            manager.Save();
            MessageBox.Show("Öğrenciye bilgilendirme SMS Gönderildi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BildirimManagerFactory manager = new BildirimManagerFactory(new LoggerFactory1());
            manager.Save();
            MessageBox.Show("Öğrenciye bilgilendirme Mail Gönderildi");
        }
    }
}
