using Exercicio3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class LojaVirtual
    {
        public void RealizarPagamento(IPagamento metodo, decimal valor)
        {
            metodo.ProcessarPagamento(valor);
        }
    }
}
