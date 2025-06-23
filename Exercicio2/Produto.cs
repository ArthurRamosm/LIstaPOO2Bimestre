using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício02
{
    class ContaBancaria
    {
        public string NumeroConta;
        public string Titular;
        public double Saldo;

        public override string ToString()
        {
            return $"Conta {NumeroConta}                             Olá, {Titular}!";
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public void ExibirSaldo()
        {
            if (Saldo < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"R$ {Saldo.ToString("F2")}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"R$ {Saldo.ToString("F2")}");
                Console.ResetColor();
            }
        }
    }
}