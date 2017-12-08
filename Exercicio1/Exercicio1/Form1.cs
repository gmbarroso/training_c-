using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*int idadePai = 64;
            int idadeGui = 32;
            int idadeMae = 60;

            double mediaIdade;

            mediaIdade = (idadePai + idadeGui + idadeMae) / 3;*/

            /*int pi;
            pi = 3.14;
            Object valor de pi não cabe em pi*/


            //double pi = 3.14;
            //int piQuebrado = (int)pi;

            /*int a = 30;
            int b = 60;
            int c = 80;

            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);*/
            

            MessageBox.Show("valores: " + delta + " e " + a2);
        }
    }
}
