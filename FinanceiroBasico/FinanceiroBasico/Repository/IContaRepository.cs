using FinanceiroBasico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroBasico.Repository
{
    public interface IContaRepository
    {
        bool IsContaAtrasada(Conta contaEntity);

        int GetQtdeDiasAtraso(Conta contaEntity);
    }
}
