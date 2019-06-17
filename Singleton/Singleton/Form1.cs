using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SİNGLETON PATTERN KULLANIMI
            var ogrenciManager = OgrenciManagerSingleton.CreateSingleton();
            ogrenciManager.Save();

            MessageBox.Show("Öğrenci Bilgileri Kaydedildi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
