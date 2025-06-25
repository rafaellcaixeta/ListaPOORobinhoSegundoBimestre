using Exercicio3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class PagamentoCartaoCredito : IPagamento
    {
        public void ProcessarPagamento(decimal valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentNullException("O valor do pagamento deve ser maior que zero.");
            }

            Console.WriteLine($"Pagamento de {valor.ToString("C2")} processado no cartão de crédito.");
        }
    }
}
