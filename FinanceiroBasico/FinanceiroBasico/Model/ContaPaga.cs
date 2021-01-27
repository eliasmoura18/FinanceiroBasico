using FinanceiroBasico.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroBasico.Model
{
    public class ContaPaga //Single Responsability Principle
    {
        public string nome => _conta.nome;
        public decimal valorOriginal => _conta.valorOriginal;
        public decimal valorCorrigido => _conta.valorCorrigido;
        public int qtdeDiasAtraso => _conta.qtdeDiasAtraso;
        public DateTime dataPagamento => _conta.dataPagamento;

        public Conta _conta;


        public ContaPaga(Conta conta)
        {
            _conta = conta;
        }
    }
}
