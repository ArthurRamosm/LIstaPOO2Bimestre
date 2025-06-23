using System;
using System.Collections.Generic;
using System.Linq;
using Exercicio1;

List<Aluno> lista = new List<Aluno>();

void MostrarMenu()
{
    Console.WriteLine("Digite qual funcionalidade você quer utilizar:");
    Console.WriteLine("1 - Cadastrar aluno");
    Console.WriteLine("2 - Listar todos os alunos cadastrados");
    Console.WriteLine("3 - Alterar dados de um aluno existente (localizado pelo RA)");
    Console.WriteLine("4 - Remover um aluno pelo RA");
    Console.WriteLine("5 - Encerrar programa");
}

int opcao;
do
{
    MostrarMenu();
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:

            Console.Write("Digite o RA: ");
            string RA = Console.ReadLine();
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (lista.Any(x => x.RA.Trim().ToLower() == RA.Trim().ToLower()))
            {
                Console.WriteLine("RA já cadastrado no sistema!");
            }
            else
            {
                Aluno aluno = new Aluno(RA, nome, idade);
                lista.Add(aluno);
                Console.WriteLine($"Aluno= RA: {aluno.RA}, Nome: {aluno.Nome}, Idade: {aluno.Idade} cadastrado com sucesso!");
            }
            break;

        case 2:
            Console.Clear();
            foreach (var item in lista) { Console.WriteLine($"RA: {item.RA} Nome {item.Nome} Idade {item.Idade}"); }
            Console.WriteLine();
            break;

        case 3:
            Console.Clear();
            Console.Write("Digite o RA que você deseja alterar:");
            string RAAlterado = Console.ReadLine();

            var alunoParaAlterar = lista.Find(x => x.RA.Trim().ToLower() == RAAlterado.Trim().ToLower());
            if (alunoParaAlterar != null)
            {
                Console.Write("Digite o novo nome: ");
                alunoParaAlterar.Nome = Console.ReadLine();

                Console.Write("Digite a nova idade: ");
                alunoParaAlterar.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Dados atualizados com sucesso.");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
            break;
        case 4:
            Console.Clear();
            Console.Write("Digite um RA que você deseja remover: ");
            string RARemover = Console.ReadLine();

            var alunoParaRemover = lista.Find(x => x.RA.Trim().ToLower() == RARemover.Trim().ToLower());
            if (alunoParaRemover != null)
            {
                lista.Remove(alunoParaRemover);
                Console.WriteLine("Aluno removido com sucesso.");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado.");
            }
            break;
        case 5:
            Console.Clear();
            Console.WriteLine("Encerrando o programa.");
            break;

        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

} while (opcao != 5);