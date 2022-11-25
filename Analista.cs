using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho2Pt1
{
    internal class Analista : Funcionario
    {
        private double extra { get; set; }
        public Analista(string none, string matricula, double salarioBase, double extra) : base(none, matricula, salarioBase)
        {
            this.extra = extra;
        }

        public override double CalculaSalario()
        {
            return extra + this.SalarioBase;
        }
    }
}
