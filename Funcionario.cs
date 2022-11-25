using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace trabalho2Pt1
{
    internal abstract class Funcionario
    {
        public string None { get; set; }
        public string Matricula { get; set; }
        public double SalarioBase { get; set; }
        public Funcionario(string none, string matricula, double salarioBase)
        {
            this.None = none;
            this.Matricula = matricula;
            this.SalarioBase = salarioBase;
        }

        public abstract double CalculaSalario();
    }
}
