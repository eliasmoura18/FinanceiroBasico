using FinanceiroBasico.Model;
using FinanceiroBasico.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroBasico.Repository.Implementation
{
    public class ContaRepository : IContaRepository
    {
        public bool IsContaAtrasada(Conta contaEntity)
        {
            DateTime vencimento = Convert.ToDateTime(contaEntity.dataVencimento.ToString("dd/MM/yyyy"));
            DateTime pagamento = Convert.ToDateTime(contaEntity.dataPagamento.ToString("dd/MM/yyyy"));

            return pagamento > vencimento;
        }

        public int GetQtdeDiasAtraso(Conta contaEntity)
        {
            DateTime vencimento = Convert.ToDateTime(contaEntity.dataVencimento.ToString("dd/MM/yyyy"));
            DateTime pagamento = Convert.ToDateTime(contaEntity.dataPagamento.ToString("dd/MM/yyyy"));

            if (pagamento > vencimento)
            {
                return Convert.ToInt32(pagamento.Subtract(vencimento).TotalDays);
            }
            
            return 0;
        }
    }
}
