//Aqui os usings são usados para importar bibliotecas.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

class Site
{
    //atributos 
    public string nome;
    public int idade;
    public string curso;

    //Aqui jaz uma string de conexão com o banco de dados
    static string conexaoString = "server=localhost; uid=root; pwd=; database=curso; port=3306";
    //server: endereço ou IP ondê o MySQL êsta rodando (localhost ou 127.0.0.1 sê for no mêsmo computador). Você podê informar a porta caso nao sêja a padrao (port=3306).
    //uid (Usêr ID): nome do usuario (ex: root).
    //pwd (Password): senha do usuario.
    //database: nomê do banco quê você quêr acêssar (por êxêmplo, curso)

    //Método cadastrar
    public void cadastrar()
    {
        // este código vai entrar em loop
        while (true)
        {
            // ele também pode dar erro, ent usamos try-catch
            try
            {
                //seção de perguntas
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.Write("Digite sua idade: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Digite o curso que está cursando: ");
                curso = Console.ReadLine();

                // Aqui, o "using" é usado para fechar o objeto automaticamente (sem precisar usar um "conexao.Close()" no final).
                // MySqlConnection é a classe da biblioteca MySql.Data.MySqlClient Ela cria uma conexão entre o C# e o MySQL
                // O objeto "conexao" é inicializado com a string de conexão "conexaoString", 
                // que contém as informações necessárias para acessar o banco (servidor, usuário, senha, banco e porta)
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    //Open() inicia o objeto de conexão
                    conexao.Open();

                    //Caso a conexão for bem sucedida, será mostrado esse trecho
                    Console.WriteLine("Seu registro foi inserido no Banco de dados, parabéns");

                    //Com isso, criamos uma variável que guardará o comando SQL para a execução
                    string sqlInserir = "INSERT INTO alunos (Nome, Idade, Curso) VALUES (@nome, @idade, @curso)";

                    //Aqui o using continua tendo a mesma função
                    //MySqlCommand é a classe que lê os comandos do MySQL, aqui ele interpreta a
                    //sintaxe da variável "sqlInserir"
                    using (MySqlCommand cmd = new MySqlCommand(sqlInserir, conexao))
                    {
                        //cmd envia os comandos sql para o banco
                        //Parameters refere-se aos parâmetros @nome, @idade e @curso
                        //AddWithValue adiciona no banco os valores escritos pelo usuário na seção de perguntas
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@idade", idade);
                        cmd.Parameters.AddWithValue("@curso", curso);

                        //ExecuteNonQuery() é um método que executa comandos que manipulam dados (ex: INSERT, DELETE e UPDATE)
                        cmd.ExecuteNonQuery();
                        break;
                    }
                }
            }
            //lidando com o erro
            catch (Exception)
            {
                Console.WriteLine("\nErro durante o registro tente novamente, tente novamente.");
                continue;
            }
        }
    }
    public void listar()
    {
        //mesmo esquema 
        using (MySqlConnection conexao = new MySqlConnection(conexaoString))
        {
            conexao.Open();
            Console.WriteLine("Segue a lista de alunos a seguir:");

            //agora o comando é outro
            string sqlListar = "SELECT * FROM alunos";

            using (MySqlCommand cmd = new MySqlCommand(sqlListar, conexao))
            {
                //MySqlDataReader é a classe destinada a leitura dos resultados dos comandos de consulta do MySQL 
                //ExecuteReader() executa comandos de consulta (ex: SELECT)
                using MySqlDataReader reader = cmd.ExecuteReader();

                //com o WHILE, é possivel o objeto ler os dados linha por linha
                while (reader.Read())
                {
                    // converte os valores inteiros do banco (INT) para int no C#
                    int id = Convert.ToInt32(reader["Id"]);
                    int idade = Convert.ToInt32(reader["Idade"]);

                    // lê os valores de texto do banco (VARCHAR) e converte para string no C#
                    string nome = reader.GetString("Nome");
                    string curso = reader.GetString("Curso");

                    Console.WriteLine($"\nID: {id}  \nNome: {nome}  \nIdade: {idade}  \ncurso: {curso}\n");
                }
            }
        }
    }
    public void buscarAluno()
    {
        //Solicitando nome para busca
        Console.Write("Digite o nome do aluno: ");
        string busca = Console.ReadLine();

        //mesmo esquema
        using (MySqlConnection conexao = new MySqlConnection(conexaoString))
        {
            conexao.Open();
            Console.WriteLine("Resultado da busca:");

            //agora o comando é outro
            string sqlListar = "SELECT * FROM alunos WHERE nome LIKE @nome";

            using (MySqlCommand cmd = new MySqlCommand(sqlListar, conexao))
            {
                //o nome escrito pelo usuário será usado para buscar o aluno
                cmd.Parameters.AddWithValue("@nome", busca);

                //então mostramos os dados desse aluno executando o comando de consulta
                using MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // convertedo os valores inteiros do banco (INT) para int no C#
                    int id = Convert.ToInt32(reader["Id"]);
                    int idade = Convert.ToInt32(reader["Idade"]);

                    // lendo os valores de texto do banco (VARCHAR) e convertendo para string no C#
                    string nome = reader.GetString("Nome");
                    string curso = reader.GetString("Curso");

                    Console.WriteLine($"\nID: {id}  \nNome: {nome}  \nIdade: {idade}  \ncurso: {curso}\n");
                }
            }
        }
    }
    public void atualizar()
    {
        //repetição
        while (true)
        {
            //lidando com erros
            try
            {
                //seção de perguntas
                Console.WriteLine("Digite seu nome: ");
                string novoNome = Console.ReadLine();
                Console.WriteLine("Digite sua idade: ");
                int novaIdade = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o curso que está cursando: ");
                string novoCurso = Console.ReadLine();
                Console.WriteLine("Digite o número de identificação do aluno: ");
                int idParaAtualizar = int.Parse(Console.ReadLine());

                //mesmo esquema
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();
                    Console.WriteLine("Os registros foram atualizados, parabéns");

                    //o comando agora é outro
                    string sqlUpdate = "UPDATE alunos SET Nome=@nome, Idade=@idade, Curso=@curso";

                    using (MySqlCommand cmd = new MySqlCommand(sqlUpdate, conexao))
                    {
                        //enviando e adicionando os valores para banco 
                        cmd.Parameters.AddWithValue("@nome", novoNome);
                        cmd.Parameters.AddWithValue("@idade", novaIdade);
                        cmd.Parameters.AddWithValue("@curso", novoCurso);
                        cmd.Parameters.AddWithValue("@id", idParaAtualizar);

                        //executa o comando manipulador de dados
                        cmd.ExecuteNonQuery();
                        break;
                    }

                }
            }
            //lidando com o erro
            catch (Exception)
            {
                Console.WriteLine($"Nenhum aluno foi encontrado, tente novamente.");
                continue;
            }
        }
    }
    public void excluir()
    {
        //repetição
        while (true)
        {
            //lidando com erros
            try
            {
                //pergunta e reposta
                Console.Write("Digite a identificação do aluno (digite 0 para sair): ");
                int idParaExcluir = int.Parse(Console.ReadLine());

                //o usuário volta ao início se digitar 0
                if (idParaExcluir == 0)
                {
                    lobby();
                }

                //mesmo esquema
                using (MySqlConnection conexao = new MySqlConnection(conexaoString))
                {
                    conexao.Open();
                    Console.WriteLine("O registro foi excluído com sucesso, parabéns");

                    //o comando agora é outro
                    string sqlDelete = "DELETE FROM alunos WHERE Id=@id";
                    using (MySqlCommand cmd = new MySqlCommand(sqlDelete, conexao))
                    {
                        //enviando e adicionando o valor ao banco 
                        cmd.Parameters.AddWithValue("@id", idParaExcluir);

                        //executa o comando manipulador de dados
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Erro na exclusão, tente novamente");
                continue;
            }
        }
    }
    public void exibirTotal()
    {
        //mesmo esquema
        using (MySqlConnection conexao = new MySqlConnection(conexaoString))
        {
            conexao.Open();
            Console.WriteLine("Segue o total de alunos cadastrados a seguir:");

            //agora o comando é outro
            string sqlExibir = "SELECT COUNT(*) FROM alunos";

            using (MySqlCommand cmd = new MySqlCommand(sqlExibir, conexao))
            {
                //long é um tipo de dado interiro utilizado para armazenar números grandes
                long Total = (long)cmd.ExecuteScalar();
                Console.WriteLine($"Total de alunos: {Total}");

                //int tem a capacidade de armazenar 32 bits de dados (usado para contar coisas como idade, quantidade de itens)
                //long armazena 64 bits de dados (usado para contar coisas como número de registros em um banco gigante,
                //bytes em um arquivo, etc.)
            }
        }
    }

    public void lobby()
    {
        Console.Clear();
        int op = 0;
        do
        {
            try
            {
                //interface
                Console.WriteLine("--- Gerenciamento de Alunos ---");
                Console.WriteLine("1: Cadastrar");
                Console.WriteLine("2: Listar todos os alunos");
                Console.WriteLine("3: Buscar aluno por nome");
                Console.WriteLine("4: Atualizar aluno");
                Console.WriteLine("5: Excluir aluno");
                Console.WriteLine("6: Exibir total de alunos");
                Console.WriteLine("7: Sair");
                Console.Write("\nOpção: ");

                op = int.Parse(Console.ReadLine());

                Console.Clear();

                //caso uma opção for escolhida
                switch (op)
                {
                    case 1:
                        cadastrar();
                        break;
                    case 2:
                        listar();
                        break;
                    case 3:
                        buscarAluno();
                        break;
                    case 4:
                        atualizar();
                        break;
                    case 5:
                        excluir();
                        break;
                    case 6:
                        exibirTotal();
                        break;
                    case 7:
                        Console.WriteLine("Até mais!");
                        return;
                    default:
                        Console.WriteLine("Opção incorreta, digite novamente.");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para voltar ao menu...");
                Console.ReadLine();
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Por favor, digite apenas números.");
            }

        } while (op != 7);
    }
}


