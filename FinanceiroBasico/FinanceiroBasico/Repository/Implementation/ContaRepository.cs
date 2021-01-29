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

        public decimal GetJurosEMultaPorDiasAtraso(Conta contaEntity)
        {
            /*
             * Pela quantidade de cálculos de multa/juros ser simples, optei por
             * definir os valores (multa/juros) no próprio código. Poderia também
             * criar uma tabela no banco (interessante para muitos registros/qtde
             * de itens que interferem na regra)
             */
            float multa = 0;
            float juros = 0;
            int diasAtraso = contaEntity.qtdeDiasAtraso;

            if (diasAtraso <= 0)
                return 0;

            if (diasAtraso <= 3)
            {
                multa = 2;
                juros = 0.1f;
            }
            else if (diasAtraso <= 5)
            {
                multa = 3;
                juros = 0.2f;
            }
            else
            {
                multa = 5;
                juros = 0.3f;
            }

            decimal valorMulta = contaEntity.valorOriginal * ((decimal)multa / 100);
            decimal valorJuros = contaEntity.valorOriginal * ((decimal)juros / 100) * diasAtraso;

            return valorMulta + valorJuros;
        }
    }
}
