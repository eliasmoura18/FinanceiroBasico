using FinanceiroBasico.Data.Converter.Contract;
using FinanceiroBasico.Data.VO;
using FinanceiroBasico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroBasico.Data.Converter.Implementation
{
    public class ContaConverter : IParser<ContaVO, Conta>, IParser<Conta, ContaVO>
    {
        public Conta Parse(ContaVO origin)
        {
            if (origin == null) return null;
            return new Conta
            {
                id = origin.id,
                nome = origin.nome,
                valorOriginal = origin.valorOriginal,
                dataVencimento = origin.dataVencimento,
                dataPagamento = origin.dataPagamento
            };
        }

        public ContaVO Parse(Conta origin)
        {
            if (origin == null) return null;
            return new ContaVO
            {
                id = origin.id,
                nome = origin.nome,
                valorOriginal = origin.valorOriginal,
                dataVencimento = origin.dataVencimento,
                dataPagamento = origin.dataPagamento
            };
        }

        public List<Conta> Parse(List<ContaVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<ContaVO> Parse(List<Conta> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
