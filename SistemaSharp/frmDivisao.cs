using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSharp
{
    public partial class frmDivisao : Form
    {
        public frmDivisao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                MessageBox.Show("Valor ausente. Insira um número e tente novamente.");
            }
            else
            {
                try
                {
                    int num1, contador = 1, total;
                    num1 = int.Parse(txtNum.Text);

                    while (contador <= 10)
                    {

                        total = num1 * contador;
                        txtNum.Text = "";
                        txtTabuada.Text = txtTabuada.Text + num1 + "÷" + contador + "=" + total + "\r\n";
                        contador++;
                    }

                    btnApagar.Enabled = true;
                    btnCalcular.Enabled = false;
                    txtNum.Focus();

                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato inválido. Insira um número e tente novamente.");
                    txtNum.Clear();

                }

            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            txtTabuada.Clear();
            btnCalcular.Enabled = true;
            btnApagar.Enabled = false;
            txtNum.Focus();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
