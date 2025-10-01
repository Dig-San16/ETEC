using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Hospitalar
{

    using System;

    class Program
    {
        // Variáveis de controle precisam ser static para serem acessadas pelo Main e pelos métodos.
        static Paciente[] filaPacientes = new Paciente[15]; // Array com 15 posições
        static int numPacientes = 0; // Contador de pacientes na fila
        static int TAMANHO_MAXIMO = 15; // Variável simples

        // O programa principal (ponto de entrada) DEVE ser static.
        public static void Main(string[] args)
        {
            // ... (o código dentro do Main permanece o mesmo)
            string opcao = "";

            do
            {
                ExibirMenu();
                opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "c":
                        CadastrarPaciente();
                        break;
                    case "l":
                        ListarPacientes();
                        break;
                    case "a":
                        AtenderPaciente();
                        break;
                    case "d":
                        AlterarDadosPaciente();
                        break;
                    case "q":
                        Console.WriteLine("\nSaindo do software. Tchau.");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida.");
                        break;
                }

                if (opcao != "q")
                {
                    Console.WriteLine("\n--- Pressione ENTER para continuar ---");
                    Console.ReadLine();
                }

            } while (opcao != "q");
        }

        // Os métodos (funções) chamados pelo Main também precisam ser static
        // para que a chamada funcione sem complicação.

        public static void ExibirMenu()
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("SISTEMA DE GESTÃO DE FILA DE HOSPITAL");
            Console.WriteLine("=====================================");
            Console.WriteLine("Pacientes na fila: " + numPacientes + "/" + TAMANHO_MAXIMO);
            Console.WriteLine("[C] - Cadastrar paciente");
            Console.WriteLine("[L] - Listar pacientes");
            Console.WriteLine("[A] - Atender paciente");
            Console.WriteLine("[D] - Alterar dados");
            Console.WriteLine("[Q] - Sair");
            Console.Write("Opção: ");
        }

        // O mesmo deve ser feito para CadastrarPaciente, ListarPacientes, AtenderPaciente e AlterarDadosPaciente.
        public static void CadastrarPaciente()
        {
            // ... (Mantenha o código de cadastro e prioridade da resposta anterior aqui)
            if (numPacientes >= TAMANHO_MAXIMO)
            {
                Console.WriteLine("\nERRO: A fila está lotada.");
                return;
            }

            Paciente novoPaciente = new Paciente();
            novoPaciente.Cadastrar();

            // Lógica de Prioridade
            if (novoPaciente.idade >= 60)
            {
                int indiceInsercao = 0;
                for (int i = 0; i < numPacientes; i++)
                {
                    if (filaPacientes[i].idade >= 60)
                    {
                        indiceInsercao = i + 1;
                    }
                    else
                    {
                        break;
                    }
                }

                // Deslocamento
                for (int i = numPacientes; i > indiceInsercao; i--)
                {
                    filaPacientes[i] = filaPacientes[i - 1];
                }

                filaPacientes[indiceInsercao] = novoPaciente;
                Console.WriteLine("\nPaciente PREFERENCIAL adicionado à fila.");
            }
            else
            {
                filaPacientes[numPacientes] = novoPaciente;
                Console.WriteLine("\nPaciente adicionado ao final da fila.");
            }

            numPacientes++;
        }

        public static void ListarPacientes()
        {
            // ... (Mantenha o código de listagem da resposta anterior aqui)
            if (numPacientes == 0)
            {
                Console.WriteLine("\nA fila está vazia.");
                return;
            }

            Console.WriteLine("\n--- LISTA DE PACIENTES NA FILA ---");

            for (int i = 0; i < numPacientes; i++)
            {
                string prioridade = "";
                if (filaPacientes[i].idade >= 60)
                {
                    prioridade = " (PREFERENCIAL)";
                }
                Console.WriteLine("[" + (i + 1) + "] - Nome: " + filaPacientes[i].nome + ", Idade: " + filaPacientes[i].idade + prioridade);
            }
        }

        public static void AtenderPaciente()
        {
            // ... (Mantenha o código de atendimento da resposta anterior aqui)
            if (numPacientes == 0)
            {
                Console.WriteLine("\nA fila está vazia. Nada para atender.");
                return;
            }

            Paciente atendido = filaPacientes[0];

            Console.WriteLine("\n--- PACIENTE ATENDIDO ---");
            atendido.Consultar();

            // Deslocamento
            for (int i = 0; i < numPacientes - 1; i++)
            {
                filaPacientes[i] = filaPacientes[i + 1];
            }

            filaPacientes[numPacientes - 1] = null;
            numPacientes--;

            Console.WriteLine("\nPaciente atendido e removido da fila.");
        }

        public static void AlterarDadosPaciente()
        {
            // ... (Mantenha o código de alteração de dados da resposta anterior aqui)
            if (numPacientes == 0)
            {
                Console.WriteLine("\nA fila está vazia. Não há dados para alterar.");
                return;
            }

            Console.Write("\nInforme o CPF do paciente para alterar: ");
            string cpfBusca = Console.ReadLine();

            Paciente pacienteParaAlterar = null;
            for (int i = 0; i < numPacientes; i++)
            {
                // O CPF está acessível pois na classe Paciente ele é público
                if (filaPacientes[i].cpf == cpfBusca)
                {
                    pacienteParaAlterar = filaPacientes[i];
                    break;
                }
            }

            if (pacienteParaAlterar != null)
            {
                pacienteParaAlterar.AlterarDados();
            }
            else
            {
                Console.WriteLine($"\nPaciente com CPF {cpfBusca} não encontrado na fila.");
            }
        }
    }
}


