using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta_Bancária
{
    public partial class formConta : Form
    {
        
        public formConta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta conta = new ContaPoupanca();
            if (conta.Saca(100.0))
            {
                MessageBox.Show("Saque Efetuado");
            }
        }


    }

   

}

