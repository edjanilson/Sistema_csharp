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
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void adiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabuadaAdicao adicao = new frmTabuadaAdicao();
            adicao.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente fechar o programa?","====Fechar====",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void subtraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTabuadaSub sub = new frmTabuadaSub();
            sub.ShowDialog();
        }

        private void médiaEscolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMediaEscolar media = new frmMediaEscolar();
            media.ShowDialog();
        }

        private void visualizadorDeImagensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisualizadordeImagens visu = new frmVisualizadordeImagens();
            visu.ShowDialog();
        }

        private void multiplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMultiplicacao mult = new frmMultiplicacao();
            mult.ShowDialog();
        }

        private void divisãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDivisao divisao = new frmDivisao();
            divisao.ShowDialog();
        }
    }
}
