using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa objogador;
            Pessoa camisa7;
            objogador = new Pessoa();
            camisa7 = new Pessoa();
            objogador.Cadastrar();
            camisa7.Cadastrar();
            objogador.Exibir();
            camisa7.Exibir();
        }
    }
}
