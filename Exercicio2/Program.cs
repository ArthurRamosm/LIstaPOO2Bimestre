using Exercício02;

ContaBancaria _contaBancaria = new ContaBancaria();

Console.WriteLine("Digite o número da sua conta:");
_contaBancaria.NumeroConta = Console.ReadLine();

Console.WriteLine("Digite o nome completo do titular da conta:");
_contaBancaria.Titular = Console.ReadLine();

Console.Clear();
Console.WriteLine(_contaBancaria);
Console.WriteLine();
Console.WriteLine("O que você deseja fazer hoje?");
Console.WriteLine("Depositar");
Console.WriteLine("Sacar");
Console.WriteLine("Exibir saldo");
Console.WriteLine("Sair");
Console.WriteLine();
Console.WriteLine("Digite a opção desejada, abaixo:");
string opcao = Console.ReadLine().ToUpper();

do
{
    if (opcao == "DEPOSITAR")
    {
        Console.Clear();
        Console.WriteLine(_contaBancaria);
        Console.WriteLine();
        Console.WriteLine("Digite o valor a ser depositado:");
        double valorDeposito = double.Parse(Console.ReadLine());
        _contaBancaria.Depositar(valorDeposito);
        Console.WriteLine();
        Console.WriteLine("O que você deseja fazer hoje?");
        opcao = Console.ReadLine().ToUpper();
    }
    else if (opcao == "SACAR")
    {
        Console.Clear();
        Console.WriteLine(_contaBancaria);
        Console.WriteLine();
        Console.WriteLine("Digite o valor a ser sacado:");
        double valorSaque = double.Parse(Console.ReadLine());
        _contaBancaria.Sacar(valorSaque);
        Console.WriteLine();
        Console.WriteLine("O que você deseja fazer hoje?");
        opcao = Console.ReadLine().ToUpper();
    }
    else if (opcao == "EXIBIR SALDO")
    {
        Console.Clear();
        Console.WriteLine(_contaBancaria);
        Console.WriteLine();
        _contaBancaria.ExibirSaldo();
        Console.WriteLine();
        Console.WriteLine("O que você deseja fazer hoje?");
        Console.WriteLine();
        opcao = Console.ReadLine().ToUpper();
    }
    else
    {
        Console.WriteLine("Opção inválida, digite uma opção válida!");
        Console.WriteLine();
        Console.WriteLine("O que você deseja fazer hoje?");
        opcao = Console.ReadLine().ToUpper();
    }
}
while (opcao != "SAIR");
