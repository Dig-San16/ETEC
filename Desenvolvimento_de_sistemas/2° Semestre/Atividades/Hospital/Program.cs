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
            if (pacientes.Count >= 15)
            {
                Console.WriteLine("Não é possível cadastrar pacientes agora, espere até o atendimento ser concluído\n");
            }
            else if (pacientes.Count == 0)
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
                    Console.WriteLine($"Paciente preferencial {atender.nome} atendido!\n");
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
                Console.WriteLine("\n--- ALTERAÇÃO DE DADOS PARA {0} ---", paciente.nome);
                Console.Write($"CPF atual: {paciente.cpf}. Novo CPF (digite para alterar): ");
                string novocpf = Console.ReadLine();
                if (!string.IsNullOrEmpty(novocpf))
                {
                    paciente.cpf = novocpf;
                    Console.WriteLine("CPF atualizado com sucesso!\n");
                }
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
                        Console.WriteLine("Bom trabalho, agora");
                        return;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente.\n");
                        break;
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Paciente menu = new Paciente();
                menu.Lobby();
            }
        }

    }
}