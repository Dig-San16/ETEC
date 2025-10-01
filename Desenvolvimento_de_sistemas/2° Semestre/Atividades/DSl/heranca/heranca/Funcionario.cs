using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Funcionario: Pessoa
    {
        public string Cargo;
        public DateTime Data_Admissao;
        public double Salario;
        private string Banco;
        private string Agencia;
        private string ContaCorrente;
    }
}
