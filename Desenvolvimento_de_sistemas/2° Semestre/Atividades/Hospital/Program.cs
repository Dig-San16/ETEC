﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Paciente
    {
        //Atributos (características)
        public string nome;
        public int idade;
        public string cpf;
        public string preferencial;
        public static List<Paciente> pacientes = new List<Paciente>();

        //Método de cadastrar
        public void Cadastro()
        {
            //este código vai repetir até tudo ser preenchido
            while (true)
            {
                // Try é usado quando se espera um erro acontecer no código
                try
                {
                    // condição caso o número de pacientes chegar a 15
                    if (pacientes.Count >= 15)
                    {
                        Console.WriteLine("Não é possível cadastrar mais pacientes. Limite de 15 atingido.\n");
                        return;
                    }
                    // seção de perguntas e respostas
                    Console.Clear();
                    Console.Write("Digite seu nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Digite sua idade: ");
                    idade = int.Parse(Console.ReadLine());
                    Console.Write("Digite seu CPF: ");
                    cpf = Console.ReadLine();
                    Console.Write("Possui alguma deficiência? (S/N): ");
                    preferencial = Console.ReadLine().Trim().ToUpper();

                    // condição caso o usuário digitar qualquer coisa em uma pergunta que vale apenas 2 respostas
                    if (preferencial != "S" && preferencial != "N")
                    {
                        Console.WriteLine("Ocorreu um erro durante o cadastro, tente novamente.\n");
                        continue;
                    }

                    // adiciona todos os dados digitados na lista "pacientes" e encerra a seção de cadastro
                    pacientes.Add(this);
                    Console.WriteLine("Cadastro realizado!\n");
                    break;
                }

                // catch lida com o erro que ocorrer no programa (aqui no caso, exception lida com qualquer tipo de erro)
                catch (Exception)
                {
                    Console.WriteLine("Ocorreu um erro durante o cadastro, tente novamente.\n");
                }
            }
        }

        //Método de Listagem
        public void Listagem()
        {
            Console.Clear();

            // aqui a condição mostra os pacientes cadastrados
            if (pacientes.Count > 0)
            {
                // for identifica os dados dos paciente
                for (int i = 0; i < pacientes.Count; i++)
                {
                    // cria-se então um objeto que referencia esses dados para enfim mostra-los
                    Paciente dados = pacientes[i];
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Nome: {0}\nIdade: {1}\nCPF: {2}\nPreferencial: {3}", dados.nome, dados.idade, dados.cpf, dados.preferencial);
                    Console.WriteLine("-------------------------------\n");
                }
            }
            // condição caso não houver nenhum paciente na lista "pacientes"
            else
            {
                Console.WriteLine("Nenhum paciente cadastrado ainda.\n");
            }
        }
        //Método de atendimento
        public void Atender()
        {
            Console.Clear();

            //condição caso a lista "pacientes" não ter nenhum paciente cadastrado
            if (pacientes.Count == 0)
            {
                Console.WriteLine("Não há pacientes para atender.\n");
            }
            else
            {
                // cria -se um objeto que fará referência aos pacientes com propriedade preferencial
                // (pacientes preferenciais foram aqueles que responderam "S" de sim na ultima pergunta do cadastro)
                Paciente atender = pacientes.Find(p => p.preferencial == "S");

                // condição caso não houver paciente com atendimento preferencial
                if (atender == null)
                {
                    atender = pacientes[0];
                }

                //aqui remove cada paciente que for atendido
                pacientes.Remove(atender);

                // condição que identifica alguns pacientes 
                // (se um deles possuir alguma deficiência ou forem mais velhos, eles serão atendidos primeiro)
                if (atender.preferencial == "S")
                {
                    Console.WriteLine($"Paciente deficiente {atender.nome} atendido com prioridade!\n");
                }
                else if (atender.idade >= 60)
                {
                    Console.WriteLine($"Paciente idoso {atender.nome} atendido com prioridade!\n");
                }
                else
                {
                    Console.WriteLine($"Paciente {atender.nome} atendido!\n");
                }
            }
        }

        // Método de mudar dados de um paciente
        public void Mudar()
        {
            Console.Clear();

            //aqui diz para digitar o cpf do paciente que pretende fazer as alterações de dados
            Console.Write("Digite o CPF do paciente que deseja alterar: ");
            string buscarCpf = Console.ReadLine();

            //esse objeto faz referencia ao cpf digitado pelo usuário
            Paciente paciente = pacientes.Find(p => p.cpf == buscarCpf);

            // essa condição identifica se o cpf
            if (paciente != null)
            {

                int escolha;

                // aqui, a condição irá repetir até que o usuário escreva 0 para sair
                do
                {
                    // título, opçôes, e a escolha
                    Console.WriteLine("\nALTERAÇÃO DE DADOS PARA {0}", paciente.nome);
                    Console.WriteLine("Digite o que pretende alterar:");
                    Console.WriteLine("1: Nome");
                    Console.WriteLine("2: Idade");
                    Console.WriteLine("3: CPF");
                    Console.WriteLine("4: Preferencial");
                    Console.WriteLine("0: Finalizar");
                    Console.Write("Escolha: ");

                    // condição caso o opção não seja um número
                    if (!int.TryParse(Console.ReadLine(), out escolha))
                    {
                        Console.WriteLine("Opção inválida! Digite um número.");
                        continue;
                    }

                    // condição que identifica a opção e executa o código 
                    switch (escolha)
                    {
                        // caso for alterar o nome 
                        case 1:
                            Console.Write($"Nome atual: {paciente.nome}. Novo nome: ");
                            string novoNome = Console.ReadLine();
                            if (!string.IsNullOrEmpty(novoNome))
                            {
                                paciente.nome = novoNome;
                                Console.WriteLine("Nome alterado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Nome não alterado.");
                            }
                            break;
                            
                        // caso for alterar a idade    
                        case 2:
                            Console.Write($"Idade atual: {paciente.idade}. Nova idade: ");
                            string idadeStr = Console.ReadLine();
                            if (int.TryParse(idadeStr, out int novaIdade))
                            {
                                paciente.idade = novaIdade;
                                Console.WriteLine("Idade alterada com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Idade inválida! Não alterada.");
                            }
                            break;
                            
                        // caso for alterar o cpf
                        case 3:
                            Console.Write($"CPF atual: {paciente.cpf}. Novo CPF: ");
                            string novoCpf = Console.ReadLine();
                            if (!string.IsNullOrEmpty(novoCpf))
                            {
                                paciente.cpf = novoCpf;
                                Console.WriteLine("CPF alterado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("CPF não alterado.");
                            }
                            break;

                        // caso for alterar a preferencial
                        case 4:
                            Console.Write($"Preferencial atual: {paciente.preferencial}. É preferencial? (S/N): ");
                            string novoPreferencial = Console.ReadLine().Trim().ToUpper();
                            if (novoPreferencial == "S" || novoPreferencial == "N")
                            {
                                paciente.preferencial = novoPreferencial;
                            }
                            else
                            {
                                Console.WriteLine("Opção inválida! Use S ou N");
                            }
                            break;

                        // caso for sair
                        case 0:
                            Console.Clear();
                            break;

                        // se não digitar os números de 0 a 4. 
                        default:
                            Console.WriteLine("Opção inválida! Escolha entre 0-4");
                            break;
                    }

                } while (escolha != 0);
            }

            // condição caso não for digitado nada ou o cpf digitado não existe
            else
            {
                Console.WriteLine("Paciente não encontrado.\n");
            }
        }


        // Método do menu
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

                // aqui digita-se as opções com base em sua letra especifica
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

    }
}
