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
    public partial class FrmRelatorioFolha : Form
    {
        public FrmRelatorioFolha()
        {
            InitializeComponent();
        }

        private void FrmRelatorioFolha_Load(object sender, EventArgs e)
        {
            bancoDados dados = bancoDados.getInstance();
            foreach (Analista analista in dados.Analistas)
            {
                gridFolha.Rows.Add(analista.None,analista.Matricula, analista.SalarioBase, analista.extra, analista.CalculaSalario(), "Analista");
            }
            foreach (SuporteTecnico suporte in dados.Suportes)
            {
                gridFolha.Rows.Add(suporte.None, suporte.Matricula, suporte.SalarioBase, 0, suporte.CalculaSalario(), "Suporte");
            }
            foreach(Programador programador in dados.Progradores)
            {
                gridFolha.Rows.Add(programador.None, programador.Matricula, programador.SalarioBase, 0, programador.CalculaSalario(), "Programador");
            }
            txTotal.Text = (dados.Analistas.Sum(x => x.CalculaSalario()) + dados.Progradores.Sum(x => x.CalculaSalario()) + dados.Suportes.Sum(x => x.CalculaSalario())).ToString() ;

        }
    }
}
