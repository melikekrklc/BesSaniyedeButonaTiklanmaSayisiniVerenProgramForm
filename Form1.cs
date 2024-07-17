using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BesSaniyedeButonaTıklanmaSayısınıVerenProgramForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        int enBuyuk = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (sayac>enBuyuk)
            {
                enBuyuk = sayac;
            }
            this.Text = "Şu ana kadar en çok" + enBuyuk;

            button2.Enabled = true;
            sayac = 0;
            timer1.Stop();
            timer1.Start();

            textBox1.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            textBox1.Text = sayac.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}
