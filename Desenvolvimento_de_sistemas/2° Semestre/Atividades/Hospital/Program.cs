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
        public string nome;
        public int idade;
        public string cpf;
        public string preferencial;
        public static List<Paciente> pacientes = new List<Paciente>();

        public void Cadastro()
        {
            while (true)
            {
                try
                {
                    if (pacientes.Count >= 15)
                    {
                        Console.WriteLine("Não é possível cadastrar mais pacientes. Limite de 15 atingido.\n");
                        return;
                    }
                    Console.Clear();
                    Console.Write("Digite seu nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Digite sua idade: ");
                    idade = int.Parse(Console.ReadLine());
                    Console.Write("Digite seu CPF: ");
                    cpf = Console.ReadLine();
                    Console.Write("Possui alguma deficiência? (S/N): ");
                    preferencial = Console.ReadLine().Trim().ToUpper();
                    if (preferencial != "S" && preferencial != "N")
                    {
                        Console.WriteLine("Ocorreu um erro durante o cadastro, tente novamente.\n");
                        continue;
                    }

                    pacientes.Add(this);
                    Console.WriteLine("Cadastro realizado!\n");
                    break;
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
            if (pacientes.Count > 0)
            {
                for (int i = 0; i < pacientes.Count; i++)
                {
                    Paciente dados = pacientes[i];
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Nome: {0}\nIdade: {1}\nCPF: {2}\nPreferencial: {3}", dados.nome, dados.idade, dados.cpf, dados.preferencial);
                    Console.WriteLine("-------------------------------\n");
                }
            }
            else
            {
                Console.WriteLine("Nenhum paciente cadastrado ainda.\n");
            }
        }
        public void Atender()
        {

            Console.Clear();
            if (pacientes.Count == 0)
            {
                Console.WriteLine("Não há pacientes para atender.\n");
            }
            else
            {
                Paciente atender = pacientes.Find(p => p.preferencial == "S");

                if (atender == null)
                {
                    atender = pacientes[0];
                }

                pacientes.Remove(atender);

                if (atender.preferencial == "S")
                {
                    Console.WriteLine($"Paciente preferencial {atender.nome} atendido com prioridade!\n");
                }
                else if (atender.idade >= 60)
                {
                    Console.WriteLine($"Paciente idodo {atender.nome} atendido com prioridade!\n");
                }
                else
                {
                    Console.WriteLine($"Paciente {atender.nome} atendido!\n");
                }
            }
        }
        public void Mudar()
        {
            Console.Clear();
            Console.Write("Digite o CPF do paciente que deseja alterar: ");

            string buscarCpf = Console.ReadLine();
            Paciente paciente = pacientes.Find(p => p.cpf == buscarCpf);

            if (paciente != null)
            {
                int escolha;

                do
                {
                    Console.WriteLine("\nALTERAÇÃO DE DADOS PARA {0}", paciente.nome);
                    Console.WriteLine("Digite o que pretende alterar:");
                    Console.WriteLine("1: Nome");
                    Console.WriteLine("2: Idade");
                    Console.WriteLine("3: CPF");
                    Console.WriteLine("4: Preferencial");
                    Console.WriteLine("0: Finalizar");
                    Console.Write("Escolha: ");

                    if (!int.TryParse(Console.ReadLine(), out escolha))
                    {
                        Console.WriteLine("Opção inválida! Digite um número.");
                        continue;
                    }

                    switch (escolha)
                    {
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

                        case 0:
                            Console.Clear();
                            break;

                        default:
                            Console.WriteLine("Opção inválida! Escolha entre 0-4");
                            break;
                    }

                } while (escolha != 0);
            }
            else
            {
                Console.WriteLine("Paciente não encontrado.\n");
            }
        }

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

    }
}