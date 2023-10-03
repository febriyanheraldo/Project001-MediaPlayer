using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayerEr
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lagu = {"Balonku ada 5",  "Pelangi Pelangi", "Topi Saya bundar", "Bintang Kecil"};
            foreach (string item in lagu)
            {
                Console.WriteLine(item);
            }
        }
    }
}
