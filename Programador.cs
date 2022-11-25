using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho2Pt1
{
    internal class Programador : Funcionario
    {
        public Programador(string none, string matricula, double salarioBase) : base(none, matricula, salarioBase)
        {
           
        }

        public override double CalculaSalario()
        {
            return this.SalarioBase * 2;
        }
    }
}
