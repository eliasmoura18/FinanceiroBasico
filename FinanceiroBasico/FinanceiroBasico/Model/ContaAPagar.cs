using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroBasico.Model
{
    public class ContaAPagar //Single Responsability Principle
    {
        public string nome => _conta.nome;
        public decimal valorOriginal => _conta.valorOriginal;
        public DateTime dataVencimento => _conta.dataVencimento;
        public DateTime dataPagamento => _conta.dataPagamento;

        public Conta _conta;

        public ContaAPagar(Conta conta)
        {
            _conta = conta;
        }
    }
}
