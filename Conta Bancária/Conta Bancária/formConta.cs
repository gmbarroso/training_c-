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
            //Instanciando 
            Conta c = new Conta();
            c.Deposito(100.0);

            //inicializando os atributos
            c.numero = 1;
            c.titular = "Guilherme";
            c.saldo = 100;

            //c.saldo -= 50.0;
            //c.saldo -= 100.0;

            //Acessando o método na classe principal Conta
            // Se a conta tiver saldo suficiente, deuCerto conterá o valor true
            // senão, ela conterá false  
            bool deuCerto = c.Saca(100.0);

            Conta guilherme = new Conta();
            guilherme.saldo = 1000;

            Conta guilherme = new Conta();



            if (deuCerto)
            {
                MessageBox.Show("Saque realizado com sucesso");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }


            MessageBox.Show("valor: " + c.saldo);
        }
    }
}
