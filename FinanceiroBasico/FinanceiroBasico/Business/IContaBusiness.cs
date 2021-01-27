using FinanceiroBasico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroBasico.Business
{
    public interface IContaBusiness
    {
        Conta Create(Conta conta);
        Conta FindById(int id);
        List<Conta> FindAll();
        Conta Update(Conta conta);
        void Delete(int id);
    }
}
