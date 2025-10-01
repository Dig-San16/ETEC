using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Hospitalar
{
    class Paciente
    {
        // público para simplificar o acesso
        public string nome;
        public int idade;
        public string cpf; // CPF será público para poder pesquisar na fila
        public string telefone;
        public string endereco;
        public string nSus;

        // O método Cadastrar é como você fez, usando Console.ReadLine()
        public void Cadastrar()
        {
            Console.WriteLine("\n--- CADASTRO DE PACIENTE ---");

            Console.Write("Informe o nome: ");
            nome = Console.ReadLine();

            // Leitura da idade (sem TryParse, como se fosse um mundo ideal onde o usuário sempre digita certo)
            Console.Write("Qual a idade?: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o CPF: ");
            cpf = Console.ReadLine();

            Console.Write("Informe o telefone: ");
            telefone = Console.ReadLine();

            Console.Write("Informe o endereço: ");
            endereco = Console.ReadLine();

            Console.Write("Informe o número do Cartão SUS: ");
            nSus = Console.ReadLine();

            Console.WriteLine("\nPaciente cadastrado com sucesso!");
        }

        // Método para exibir dados
        public void Consultar()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("Telefone: " + telefone);
            Console.WriteLine("Endereço: " + endereco);
            Console.WriteLine("Cartão SUS: " + nSus);
            Console.WriteLine("----------------------------------");
        }

        // Método para Alterar Dados (só os básicos)
        public void AlterarDados()
        {
            Console.WriteLine($"\n--- ALTERAÇÃO DE DADOS PARA {nome} ---");

            Console.Write($"Telefone atual: {telefone}. Novo telefone (digite para alterar): ");
            string novoTelefone = Console.ReadLine();
            if (novoTelefone != "") // Checa se digitou algo
            {
                telefone = novoTelefone;
            }

            Console.Write($"Endereço atual: {endereco}. Novo endereço (digite para alterar): ");
            string novoEndereco = Console.ReadLine();
            if (novoEndereco != "")
            {
                endereco = novoEndereco;
            }

            Console.WriteLine("\nDados alterados com sucesso!");
        }
    }
}
