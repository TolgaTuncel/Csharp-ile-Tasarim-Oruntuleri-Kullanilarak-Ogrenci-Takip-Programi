using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GoGo derssinif = new GoGo();

            derssinif.Sinif = "304";

            GoGoCareTaker Taker = new GoGoCareTaker();

            Taker.Memento = derssinif.Kaydet();




            derssinif.OncekiniYukle(Taker.Memento);


            MessageBox.Show(derssinif.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GoGo derssinif = new GoGo();

            derssinif.Sinif = "305";

            GoGoCareTaker Taker = new GoGoCareTaker();

            Taker.Memento = derssinif.Kaydet();

            derssinif.OncekiniYukle(Taker.Memento);

            MessageBox.Show(derssinif.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GoGo derssinif = new GoGo();

            derssinif.Sinif = "306";

            GoGoCareTaker Taker = new GoGoCareTaker();

            Taker.Memento = derssinif.Kaydet();

            derssinif.OncekiniYukle(Taker.Memento);

            MessageBox.Show(derssinif.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GoGo derssinif = new GoGo();

            derssinif.Sinif = "307";

            GoGoCareTaker Taker = new GoGoCareTaker();

            Taker.Memento = derssinif.Kaydet();

            derssinif.OncekiniYukle(Taker.Memento);

            MessageBox.Show(derssinif.ToString());
        }
    }
}
