using FinanceiroBasico.Data.Converter.Contract;
using FinanceiroBasico.Data.VO;
using FinanceiroBasico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroBasico.Data.Converter.Implementation
{
    public class ContaPagaConverter : IParser<ContaPagaVO, Conta>, IParser<Conta, ContaPagaVO>
    {
        public Conta Parse(ContaPagaVO origin)
        {
            if (origin == null) return null;
            return new Conta
            {
                id = origin.id,
                nome = origin.nome,
                valorOriginal = origin.valorOriginal,
                valorCorrigido = origin.valorCorrigido,
                qtdeDiasAtraso = origin.qtdeDiasAtraso,
                dataPagamento = origin.dataPagamento
            };
        }

        public ContaPagaVO Parse(Conta origin)
        {
            if (origin == null) return null;
            return new ContaPagaVO
            {
                id = origin.id,
                nome = origin.nome,
                valorOriginal = origin.valorOriginal,
                valorCorrigido = origin.valorCorrigido,
                qtdeDiasAtraso = origin.qtdeDiasAtraso,
                dataPagamento = origin.dataPagamento
            };
        }

        public List<Conta> Parse(List<ContaPagaVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<ContaPagaVO> Parse(List<Conta> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
