﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class LojaVirtual
    {
        public void RealizarPagamento(Ipagamentos metodo, decimal valor)
        {
            metodo.ProcessarPagamento(valor);
        }
    }
}
