using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    class Pessoa
    {
        public string nome;
        public string email;
        public string telefone;

        public void Cadastrar()
        {
            Console.WriteLine("Digite o nome do jogador: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o email do jogador: ");
            email = Console.ReadLine();
            Console.WriteLine("Digite o telefone do jogador: ");
            telefone = Console.ReadLine();
        }
        public void Exibir() {
            Console.WriteLine("o nome do jogador é {0}, seu email é {1} e seu telefone é {2}", nome, email, telefone);
        }

    }
}

