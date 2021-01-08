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
    public partial class frmMediaEscolar : Form
    {
        public frmMediaEscolar()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtNum1.Text == "" || txtNum2.Text == "" || txtQuan.Text == "")
            {
                MessageBox.Show("Dados ausentes. Insira todos os dados necessários e tente novamente.");
            }
            else
            {

                try
                {


                    string nome;
                    nome = txtNome.Text;
                    int faltas = 0;
                    faltas = int.Parse(txtQuan.Text);
                    double nota1, nota2, media = 0;
                    nota1 = double.Parse(txtNum1.Text);
                    nota2 = double.Parse(txtNum2.Text);
                    media = (nota1 + nota2) / 2;

                    if (media <= 5 && faltas > 30)
                    {
                        txtNome.Clear();
                        txtNum1.Clear();
                        txtNum2.Clear();
                        txtQuan.Clear();

                        MessageBox.Show("Aluno(a): -> " + nome + "\r\n" + "Primeira nota: -> " + nota1 + "\r\n" + "Segunda nota: -> " + nota2 + "\r\n" + "Média: -> " + media + "\r\n" + "Faltas: -> " + faltas + "\r\n" + "Situação: ->  Reprovado(a)");

                    }
                    else
                        if (media < 7 && faltas < 20)
                    {
                        txtNome.Clear();
                        txtNum1.Clear();
                        txtNum2.Clear();
                        txtQuan.Clear();

                        MessageBox.Show("Aluno(a): -> " + nome + "\r\n" + "Primeira nota: -> " + nota1 + "\r\n" + "Segunda nota: -> " + nota2 + "\r\n" + "Média: -> " + media + "\r\n" + "Situação: ->  Recuperação.");
                    }
                    else
                        if (media >= 7 && faltas < 10)
                    {
                        txtNome.Clear();
                        txtNum1.Clear();
                        txtNum2.Clear();
                        txtQuan.Clear();

                        MessageBox.Show("Aluno(a): -> " + nome + "\r\n" + "Primeira nota: -> " + nota1 + "\r\n" + "Segunda nota: -> " + nota2 + "\r\n" + "Média: -> " + media + "\r\n" + "Situação: ->  Aprovado(a).");
                    }
                    else
                    {
                        txtNome.Clear();
                        txtNum1.Clear();
                        txtNum2.Clear();
                        txtQuan.Clear();

                        MessageBox.Show("Aluno(a): -> " + nome + "\r\n" + "Primeira nota: -> " + nota1 + "\r\n" + "Segunda nota: -> " + nota2 + "\r\n" + "Média: -> " + media + "\r\n" + "Situação: ->  Condição não atingida.");
                    }
                }catch(FormatException )
                {
                    MessageBox.Show("Dado em formato incorreto.");
                    txtNome.Clear();
                    txtNum1.Clear();
                    txtNum2.Clear();
                    txtQuan.Clear();
                }


            }

            }


            private void btnFechar_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
                if (checkBox1.Checked == true)
                {
                    txtCondicao.Visible = true;
                }
                else
                    if (checkBox1.Checked == false)
                {
                    txtCondicao.Visible = false;
                }
            }
        }
    }
