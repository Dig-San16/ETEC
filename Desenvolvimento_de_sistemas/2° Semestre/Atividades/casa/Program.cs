using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu inicio = new Menu();
            Pessoa[] array = new Pessoa[15];
            int contador = 0;
            bool continuar = true;

            while (continuar)
            {
                switch (inicio.Hud())
                {
                    case "1":
                        const int limite = 3;
                        string res = "S";

                        while (res == "S" && contador < limite)
                        {
                            Pessoa paciente = new Pessoa();
                            paciente.Cadastrar();

                            array[contador] = paciente;

                            Console.Clear();
                            Console.WriteLine("Paciente Cadastrado!!");
                            Console.Clear();

                            contador++;

                            if (contador == limite)
                            {
                                Console.Clear();
                                Console.WriteLine("Paciente Cadastrado!! \n\nLimite de Pacientes Excedido\n\n");
                                Console.WriteLine("Pressione ENTER para voltar ao Menu...");
                                Console.ReadLine();
                                Console.Clear();

                            }
                            else
                            {
                                Console.WriteLine("Deseja Cadastrar Outro Paciente? (S/N)");
                                res = Console.ReadLine();
                                res = res.ToUpper();
                                Console.Clear();
                                Console.WriteLine("Pressione ENTER para continuar...");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            if (res != "S" && res != "N")
                            {
                                Console.Clear();
                                Console.WriteLine("Opção inválida. Voltando ao Menu.");
                                res = "N";
                                Console.Clear();
                            }
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine($"PACIENTES NA FILA ({contador + "/" + limite}):");
                        if (contador == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Não existem pacientes Cadastrados!\nPressione Enter para voltar ao Menu...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            for (int x = 0; x < contador; x++)
                            {
                                for (int j = 0; j < contador - 1; j++)
                                {
                                    if (array[j].idade < array[j + 1].idade)
                                    {
                                        Pessoa aux = array[j];
                                        array[j] = array[j + 1];
                                        array[j + 1] = aux;
                                    }
                                }
                            }
                            for (int y = 0; y < contador; y++)
                            {
                                Console.WriteLine($"Paciente {y + 1}: {array[y].nome}");
                            }
                            Console.WriteLine("\n\n\nPressione Enter para voltar ao Menu...");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    case "3":
                        Console.Clear();
                        if (contador == 0)
                        {
                            Console.WriteLine("A fila de atendimento está vazia!\n\n\nPressione ENTER para retornar ao Menu.");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        else
                        {
                            Pessoa pacienteAtendido = array[0];
                            Console.WriteLine("|********** PACIENTE ATENDIDO **********|\n");
                            Console.WriteLine($"O Paciente {pacienteAtendido.nome} de {pacienteAtendido.idade} anos, finalizou o atendimento!!\n\n");

                            for (int x = 0; x < contador - 1; x++)
                            {
                                array[x] = array[x + 1];
                            }
                            array[contador - 1] = null;

                            contador--;

                            Console.WriteLine($"|*LISTA DE PACIENTES NA FILA ATUALIZADA ({contador}/{limite})*|");
                            Console.WriteLine("\n\nPressione ENTER para retornar ao Menu");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        break;

                    case "4":
                        Console.Clear();
                        if (contador == 0)
                        {
                            Console.WriteLine("Não existe nenhum paciente cadastrado no sistema. Voltando ao Menu. \n\n\n");
                        }
                        else
                        {
                            Console.WriteLine("Digite o CPF do paciente que deseja alterar dados cadastrais:");
                            string cpfBusca = Console.ReadLine();
                            for (int y = 0; y < contador; y++)
                            {
                                array[y].Consultar(cpfBusca);
                            }
                        }
                        break;

                    case "Q":
                        Console.Clear();
                        Console.WriteLine("Saindo do programa. Aperte ESC para fechar.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Invalida! Tente Novamente:");
                        Console.WriteLine("Pressione ENTER para voltar ao Menu...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}