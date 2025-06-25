using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class PagamentoCartaoCredito : Ipagamentos
    {
        public void ProcessarPagamento(decimal valor)
        {
            Console.WriteLine($"Pagamento de R${valor} processado no cartão de crédito.");
        }
    }
}
