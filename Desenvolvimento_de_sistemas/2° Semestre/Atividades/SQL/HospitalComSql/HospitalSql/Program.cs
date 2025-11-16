﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Hospital
{
    class Paciente
    {

        public string nome;
        public int idade;
        public int cpf;
        public string preferencial;
        static string conexaoString = "server=localhost; uid=root; pwd=Rnt915302@; database=hospital; port=3306";
        static List<Paciente> pacientes = new List<Paciente>();

        public void Lobby()
        {
            while (true)
            {
                Console.WriteLine("\nBem-vindo ao Hospital Branco");
                Console.WriteLine("[C] Cadastrar paciente");
                Console.WriteLine("[L] Listar pacientes");
                Console.WriteLine("[A] Atender pacientes");
                Console.WriteLine("[M] Mudar dados do pacientes");
                Console.WriteLine("[Q] Sair");
                Console.Write("Opção: ");

                string resposta = Console.ReadLine().Trim().ToUpper();
                
                Paciente pessoa = new Paciente();

                switch (resposta)
                {
                    case "C":
                        pessoa.Cadastro();
                        break;
                       
                    case "L":
                        pessoa.Listagem();
                        break;
                     
                    case "A":
                        pessoa.Atender();
                        break;

                    case "M":
                        pessoa.Mudar();
                        break;
                    case "Q":
                        Console.WriteLine("Bom trabalho, agora descanse");
                        return;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.\n");
                        break;
                }
            }
        }

        public void Cadastro()
        {
            while (true)
            {
                try
                {                
                    Console.Clear();
                    Console.Write("Digite seu nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Digite sua idade: ");
                    idade = int.Parse(Console.ReadLine());
                    Console.Write("Digite seu CPF: ");
                    cpf = int.Parse(Console.ReadLine());
                    Console.Write("Possui alguma deficiência? (S/N): ");
                    preferencial = Console.ReadLine().Trim().ToUpper();
     
                    if (preferencial != "S" && preferencial != "N")
                    {
                        Console.WriteLine("Ocorreu um erro durante o cadastro, tente novamente.\n");
                        continue;
                    }

                    using (MySqlConnection conexao = new MySqlConnection(conexaoString)) 
                    {
                        conexao.Open();
                        Console.WriteLine("\nCadastro realizado!\n");

                        string sqlInsert = @"insert into paciente (nome, idade, cpf, preferencial) values 
                                            (@nome, @idade, @cpf, @preferencial)";

                        using (MySqlCommand cmd = new MySqlCommand(sqlInsert, conexao))
                        {
                            cmd.Parameters.AddWithValue("@nome", nome);
                            cmd.Parameters.AddWithValue("@idade", idade);
                            cmd.Parameters.AddWithValue("@cpf", cpf);
                            cmd.Parameters.AddWithValue("@preferencial", preferencial);
                            cmd.ExecuteNonQuery();
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Ocorreu um erro durante o cadastro, tente novamente.\n");
                }
            }
        }

        public void Listagem()
        {
            Console.Clear();

            using (MySqlConnection conexao = new MySqlConnection(conexaoString)) 
            {
                conexao.Open();
                Console.WriteLine("\nConfira a lista de pacientes a seguir:\n");

                string sqlSelect = "select * from paciente";
                using (MySqlCommand cmd = new MySqlCommand(sqlSelect, conexao))
                    {
                        using MySqlDataReader ler = cmd.ExecuteReader();

                        while (ler.Read())
                        {
                            int id = Convert.ToInt32(ler["id"]);
                            string nome = ler.GetString("nome");
                            int idade = Convert.ToInt32(ler["idade"]);
                            int cpf = Convert.ToInt32(ler["cpf"]);
                            string preferencial = ler.GetString("preferencial");

                            Console.WriteLine("-------------------------------");
                            Console.WriteLine("Nome: {0}\nIdade: {1}\nCPF: {2}\nPreferencial: {3}", nome, idade, cpf, preferencial);
                            Console.WriteLine("-------------------------------\n");                            
                        } 
                    }
                }
            }

        public void Atender()
        {
            Console.Clear();

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();

                string sqlSelect = @"SELECT * FROM paciente 
                                    ORDER BY preferencial = 'N', 
                                    idade < 60, 
                                    id ASC";

                MySqlCommand cmdSelect = new MySqlCommand(sqlSelect, conexao);
                MySqlDataReader reader = cmdSelect.ExecuteReader();

                if (!reader.Read())
                {
                    Console.WriteLine("\nNenhum paciente na fila.\n");
                    return;
                }

                int id = Convert.ToInt32(reader["id"]);
                string nome = reader.GetString("nome");
                int idade = Convert.ToInt32(reader["idade"]);
                string preferencial = reader.GetString("preferencial");

                reader.Close();

                string sqlDelete = "DELETE FROM paciente WHERE id = @id";

                MySqlCommand cmdDelete = new MySqlCommand(sqlDelete, conexao);
                cmdDelete.Parameters.AddWithValue("@id", id);
                cmdDelete.ExecuteNonQuery();

                if (preferencial == "S")
                {
                    Console.WriteLine($"Paciente preferencial {nome} atendido com sucesso!\n");
                } 
                else if (idade >= 60)
                {
                    Console.WriteLine($"Paciente idoso {nome} atendido com sucesso!\n");
                } 
                else
                {
                    Console.WriteLine($"Paciente {nome} atendido com sucesso!\n");
                }
            }
        }
        public void Mudar()
        {
            Console.Clear();

            Console.Write("Digite o CPF do paciente que deseja alterar: ");
            string buscarCpf = Console.ReadLine();

            if (!int.TryParse(buscarCpf, out int cpfBusca))
            {
                Console.WriteLine("CPF inválido.");
                return;
            }

            Paciente paciente = null;

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();

                string sqlSelect = "SELECT * FROM paciente WHERE cpf = @cpf LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(sqlSelect, conexao))
                {
                    cmd.Parameters.AddWithValue("@cpf", cpfBusca);

                    using (MySqlDataReader ler = cmd.ExecuteReader())
                    {
                        if (ler.Read())
                        {
                            paciente = new Paciente();
                            paciente.nome = ler.GetString("nome");
                            paciente.idade = Convert.ToInt32(ler["idade"]);
                            paciente.cpf = Convert.ToInt32(ler["cpf"]);
                            paciente.preferencial = ler.GetString("preferencial");
                        }
                    }
                }
            }

            if (paciente == null)
            {
                Console.WriteLine("Paciente não encontrado.");
                return;
            }

            int escolha;
            do
            {
                Console.WriteLine($"\nALTERAÇÃO DE DADOS PARA {paciente.nome}");
                Console.WriteLine("1: Nome");
                Console.WriteLine("2: Idade");
                Console.WriteLine("3: CPF");
                Console.WriteLine("4: Preferencial");
                Console.WriteLine("0: Finalizar");
                Console.Write("Escolha: ");

                if (!int.TryParse(Console.ReadLine(), out escolha))
                {
                    Console.WriteLine("Opção inválida!");
                    continue;
                }

                switch (escolha)
                {
                    case 1:
                        Console.Write($"Nome atual: {paciente.nome}.\nNovo nome: ");
                        string novoNome = Console.ReadLine();
                        if (!string.IsNullOrEmpty(novoNome))
                            paciente.nome = novoNome;
                        break;

                    case 2:
                        Console.Write($"Idade atual: {paciente.idade}.\nNova idade: ");
                        if (int.TryParse(Console.ReadLine(), out int novaIdade))
                            paciente.idade = novaIdade;
                        break;

                    case 3:
                        Console.Write($"CPF atual: {paciente.cpf}.\nNovo CPF: ");
                        if (int.TryParse(Console.ReadLine(), out int novoCpfNum))
                            paciente.cpf = novoCpfNum;
                        break;

                    case 4:
                        Console.Write($"Preferencial atual: {paciente.preferencial}.\n(S/N): ");
                        string novoPref = Console.ReadLine().Trim().ToUpper();
                        if (novoPref == "S" || novoPref == "N")
                            paciente.preferencial = novoPref;
                        break;

                    case 0:
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            } while (escolha != 0);

            using (MySqlConnection conexao = new MySqlConnection(conexaoString))
            {
                conexao.Open();

                string sqlUpdate =
                @"UPDATE paciente SET 
                    nome=@nome, 
                    idade= @idade, 
                    cpf = @cpfNovo, 
                    preferencial = @preferencial 
                WHERE cpf = @cpfAntigo";

                using (MySqlCommand cmd = new MySqlCommand(sqlUpdate, conexao))
                {
                    cmd.Parameters.AddWithValue("@nome", paciente.nome);
                    cmd.Parameters.AddWithValue("@idade", paciente.idade);
                    cmd.Parameters.AddWithValue("@cpfNovo", paciente.cpf);
                    cmd.Parameters.AddWithValue("@preferencial", paciente.preferencial);
                    cmd.Parameters.AddWithValue("@cpfAntigo", cpfBusca);

                    cmd.ExecuteNonQuery();
                }
            }
            Console.WriteLine("\nDados atualizados com sucesso!");
        }
    }
}
