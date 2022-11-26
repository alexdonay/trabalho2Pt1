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
    }
}
