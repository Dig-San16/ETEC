using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca
{
    internal class Cliente: Pessoa
    {
        public DateTime Data_Cadastro;
        public string Renda_Mensal;
        private string Limite_Credito;
        private string Observacao;
        
    }
}
