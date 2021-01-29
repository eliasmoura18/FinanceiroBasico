using FinanceiroBasico.Data.VO;
using FinanceiroBasico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroBasico.Business
{
    public interface IContaBusiness
    {
        ContaPagaVO FindById(int id);
        List<ContaPagaVO> FindAll();
        ContaPagaVO Create(ContaVO conta);
        ContaVO Update(ContaVO conta);
        void Delete(int id);
    }
}
