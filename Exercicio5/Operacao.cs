using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Operacao
    {
        public int Valor1 { get; set; }
        public int Valor2 { get; set; }

        public string Resposta { get; set; }

        public void Divisao()
        {
            try
            {
                Console.WriteLine("DIVISÃO DE 2 NUMEROS.");
                Console.WriteLine("--------------------------");
                Console.WriteLine("Digite o Primeiro numero:");
                Valor1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o Segundo numero:");
                Valor2 = int.Parse(Console.ReadLine());
                if (Valor2 == 0)
                {
                    throw new DivideByZeroException("Não é possível dividir por zero.");
                }
                else
                {
                    double resultado = (double)Valor1 / Valor2;
                    Console.WriteLine($"O resultado da divisão é: {resultado}");

                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Erro: Formato inválido. Por favor, insira números inteiros.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Operação Finalizada.");
            }
            Console.Write("\nDeseja realizar outra divisão? (s/n): ");
             string resposta = Console.ReadLine().ToLower();
            Console.WriteLine();

            if(resposta == "s")
            {
                Divisao();
            }
            
            else
            {
                Console.WriteLine("OEncerrando o programa.");

            } 





        }
    }
}
