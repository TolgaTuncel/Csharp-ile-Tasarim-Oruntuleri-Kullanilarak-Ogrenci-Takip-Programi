using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Component
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calisan Tolga = new Calisan { Adı = "Tolga", Gorevi = "(Müdür)" };

            Calisan Sevinc = new Calisan { Adı = "Sevinç", Gorevi = "(Müdür Yardımcısı)" };
            Calisan Gokturk = new Calisan { Adı = "Göktürk", Gorevi = "(Öğretmen)" };

            Tolga.AddSubordinate(Sevinc);
            Tolga.AddSubordinate(Gokturk);

            Calisan Tugrul = new Calisan { Adı = "Tugrul", Gorevi = "(Hizmetli)" };


            Tolga.AddSubordinate(Tugrul);


            MessageBox.Show("Adı=" + Tolga.Adı + "  " + Tolga.Gorevi);

            foreach (Calisan manager in Tolga)
            {
                MessageBox.Show("  " + "Adı=" + manager.Adı + " " + manager.Gorevi);

                foreach (var employee in manager)
                {
                    MessageBox.Show("  " + "Adı=" + employee.Adı + "  " + employee.Gorevi);
                }
            }
        }
    }
}
