using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectPool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ObjectPool p = new ObjectPool();
            Veli t1 = p.GetTren();
            MessageBox.Show("Tolganın Velisini Cagır");
            Veli t2 = p.GetTren();
            MessageBox.Show("Ayşenin Velisini Cagır");
            Veli t3 = p.GetTren();
            MessageBox.Show("Fatmanın Velisini Cagır");
            Veli t4 = p.GetTren();
            MessageBox.Show("Gaffur Velisini Cagır");
        }
    }
}
