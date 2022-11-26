using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho2Pt1
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }
        public void limpaTela()
        {
            RdAnalista.Checked= true;
            txAdicional.Text = null;
            txMatricula.Text = null;
            txNome.Text = null;
            txSalario.Text = null;

        }

        private void RdProgramador_CheckedChanged(object sender, EventArgs e)
        {
            LblAdicional.Hide();
            txAdicional.Hide();
        }

        private void RdSuporte_CheckedChanged(object sender, EventArgs e)
        {
            LblAdicional.Hide();
            txAdicional.Hide();
        }

        private void RdAnalista_CheckedChanged(object sender, EventArgs e)
        {
            LblAdicional.Show();
            txAdicional.Show();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if(RdAnalista.Checked)
            {
                if(txAdicional.Text != null|| txMatricula.Text !=null || txNome.Text!=null || txSalario.Text !=null ) {
                    Analista analista = new Analista(txNome.Text, txMatricula.Text, double.Parse(txSalario.Text), double.Parse(txAdicional.Text));
                    bancoDados bd = bancoDados.getInstance();
                    bd.Analistas.Add(analista);
                    limpaTela();
                    MessageBox.Show($"O Analista {txNome.Text} foi cadastrado Corretamente");

                }
                else
                {
                    MessageBox.Show("Existem dados Faltantes");
                }
            }
            if (RdProgramador.Checked)
            {
                if (txMatricula.Text != null || txNome.Text != null || txSalario.Text != null)
                {
                    Programador programador = new Programador(txNome.Text, txMatricula.Text, double.Parse(txSalario.Text));
                    bancoDados bd = bancoDados.getInstance();
                    bd.Progradores.Add(programador);
                    limpaTela();
                    MessageBox.Show($"O programador {txNome.Text} foi cadastrado Corretamente");

                }
                else
                {
                    MessageBox.Show("Existem dados Faltantes");
                }
            }
            if (RdSuporte.Checked)
            {
                if (txMatricula.Text != null || txNome.Text != null || txSalario.Text != null)
                {
                    SuporteTecnico suporte = new SuporteTecnico(txNome.Text, txMatricula.Text, double.Parse(txSalario.Text));
                    bancoDados bd = bancoDados.getInstance();
                    bd.Suportes.Add(suporte);
                    limpaTela();
                    MessageBox.Show($"O suporte {txNome.Text} foi cadastrado Corretamente");
                }
                else
                {
                    MessageBox.Show("Existem dados Faltantes");
                }
            }
        }

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            FrmRelatorioFolha relatorio = new FrmRelatorioFolha();
            relatorio.Show();
        }
    }
}
