using Exercicio4;

class Program
{
    public int MostrarMenu()
    {
        Console.WriteLine("1. Cadastrar uma nova competição.");
        Console.WriteLine("2. Adicionar competidores a competição.");
        Console.WriteLine("3. Listar os competidores.");
        Console.WriteLine("4. Alterar competidor.");
        Console.WriteLine("5. Remover competidor.");
        Console.WriteLine("6. Sair");
        Console.WriteLine("Digite a opção que desejada:");

        int opcao;
        while (!int.TryParse(Console.ReadLine(), out opcao))
        {
            Console.WriteLine("Opção inválida.");
        }
        return opcao;
    }

    static void Main(string[] args)
    {
        Program program = new Program();
        int opcao = program.MostrarMenu();

        Competicao competicao = null;

        do
        {
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o nome da competição:");
                    string nomeCompeticao = Console.ReadLine();
                    competicao = new Competicao { Nome = nomeCompeticao, ListaDeCompetidores = new List<Competidor>() };
                    Console.WriteLine($"Competição '{competicao.Nome}' cadastrada.");
                    Console.WriteLine("Pressione enter para continuar.");
                    Console.ReadKey();
                    break;
                case 2:
                    if (competicao == null)
                    {
                        Console.WriteLine("Nenhuma competição foi inicializada. Cadastre uma competição primeiro.");
                        Console.WriteLine("Pressione enter para continuar.");
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine("Digite o nome do competidor:");
                    string nomeCompetidor = Console.ReadLine();
                    Console.WriteLine("Digite a idade do competidor:");
                    int idadeCompetidor = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a modalidade do competidor:");
                    string modalidadeCompetidor = Console.ReadLine();
                    Competidor competidor = new Competidor { Nome = nomeCompetidor, Idade = idadeCompetidor, Modalidade = modalidadeCompetidor };
                    competicao.AdicionarCompetidor(competidor);
                    Console.WriteLine("Competidor adicionado.");
                    Console.WriteLine("Pressione enter para continuar.");
                    Console.ReadKey();
                    break;
                case 3:
                    if (competicao == null || competicao.ListaDeCompetidores == null || competicao.ListaDeCompetidores.Count == 0)
                    {
                        Console.WriteLine("Nenhum competidor foi cadastrado.");
                    }
                    else
                    {
                        foreach (var comp in competicao.ListaDeCompetidores)
                        {
                            Console.WriteLine($"Nome: {comp.Nome} Idade: {comp.Idade} Modalidade: {comp.Modalidade}");
                        }
                    }
                    Console.WriteLine("Pressione enter para continuar.");
                    Console.ReadKey();
                    break;
                case 4:
                    if (competicao == null || competicao.ListaDeCompetidores == null)
                    {
                        Console.WriteLine("Nenhuma competição foi iniciada ou nao existe competidores cadastrados.");
                        Console.WriteLine("Pressione enter para continuar.");
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine("Digite o nome do competidor a ser alterado:");
                    string nomeAlterar = Console.ReadLine().ToLower();

                    var competidorAlterar = competicao.ListaDeCompetidores
                        .FirstOrDefault(c => c.Nome.ToLower() == nomeAlterar);

                    if (competidorAlterar != null)
                    {
                        Console.WriteLine("Digite o novo nome do competidor:");
                        competidorAlterar.Nome = Console.ReadLine();
                        Console.WriteLine("Digite a nova idade do competidor:");
                        competidorAlterar.Idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a nova modalidade do competidor:");
                        competidorAlterar.Modalidade = Console.ReadLine();
                        Console.WriteLine("Competidor alterado com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine("Competido r não encontrado.");
                    }
                    Console.WriteLine("Pressione enter para continuar.");
                    Console.ReadKey();
                    break;
                case 5:
                    if (competicao == null || competicao.ListaDeCompetidores == null)
                    {
                        Console.WriteLine("Nenhuma competição foi iniciada ou existe competidores cadastrados.");
                        Console.WriteLine("Pressione enter para continuar.");
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine("Digite o nome do competidor para o remover:");
                    string nomeRemover = Console.ReadLine().ToLower();

                    Competidor competidorRemover = competicao.ListaDeCompetidores
                        .FirstOrDefault(c => c.Nome.ToLower() == nomeRemover);
                    if (competidorRemover != null)
                    {
                        competicao.ListaDeCompetidores.Remove(competidorRemover);
                        Console.WriteLine("Competidor removido.");
                    }
                    else
                    {
                        Console.WriteLine("Competidor não encontrado.");
                    }
                    Console.WriteLine("Pressione enter para continuar.");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("FIM DO PROGRAMA...");
                    break;
                default:
                    Console.WriteLine("Selecione uma opção válida:");
                    Console.WriteLine("Pressione enter para continuar.");
                    Console.ReadKey();
                    break;
            }
            if (opcao != 6)
            {
                Console.Clear();
                opcao = program.MostrarMenu();
            }
        } while (opcao != 6);
        Console.Clear();
        Console.WriteLine("FIM DO PROGRAMA...");
        Console.ReadKey();
    }
}