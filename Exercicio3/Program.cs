using System;
using Exercicio3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo à loja virtual:");
        Console.WriteLine("Selecione o método de pagamento:");
        Console.WriteLine("1 - Cartão de Crédito");
        Console.WriteLine("2 - Boleto Bancário");
        Console.WriteLine("3 - Pix");

        string opcao = Console.ReadLine();

        Console.WriteLine("Digite o valor do pagamento:");
        decimal valorPagamento = decimal.Parse(Console.ReadLine());

        LojaVirtual lojaVirtual = new LojaVirtual();

        switch (opcao)
        {
            case "1":
                Ipagamentos pagamentoCartao = new PagamentoCartaoCredito();
                lojaVirtual.RealizarPagamento(pagamentoCartao, valorPagamento);
                break;
            case "2":
                Ipagamentos pagamentoBoleto = new PagamentoBoleto();
                lojaVirtual.RealizarPagamento(pagamentoBoleto, valorPagamento);
                break;
            case "3":
                Ipagamentos pagamentoPix = new PagamentoPix();
                lojaVirtual.RealizarPagamento(pagamentoPix, valorPagamento);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}