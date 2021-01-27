using FinanceiroBasico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroBasico.Repository
{
    interface IContaPagaRepository
    {
        ContaPaga FindById(int id);
        List<ContaPaga> FindAll();
    }
}
