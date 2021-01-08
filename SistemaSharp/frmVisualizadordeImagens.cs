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
    public partial class frmVisualizadordeImagens : Form
    {
        public frmVisualizadordeImagens()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                pbImagem.Load(openFileDialog1.FileName);
            }
            btnApagar.Enabled = true;
            btnAbrir.Enabled = false;
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            btnAbrir.Enabled = true;
            btnApagar.Enabled = false;
            pbImagem.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rbEsticar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbEsticar.Checked==true)
            {
                pbImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void rbCentralizar_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCentralizar.Checked==true)
            {
                pbImagem.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }

        private void rbZoom_CheckedChanged(object sender, EventArgs e)
        {
            if(rbZoom.Checked==true)
            {
                pbImagem.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
