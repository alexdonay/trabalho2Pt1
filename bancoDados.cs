using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalho2Pt1
{
    sealed class bancoDados
    {
        public List<Programador> Progradores = new List<Programador>();
        public List<Analista> Analistas = new List<Analista>();
        public List<SuporteTecnico> Suportes = new List<SuporteTecnico>();

        private bancoDados() { }
        private static bancoDados _instance;
        public static bancoDados getInstance()
        {
            if (_instance == null)
            {
                _instance = new bancoDados();
            }
            return _instance;
        }
    }
}
