using FinanceiroBasico.Model;
using FinanceiroBasico.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroBasico.Repository.Implementation
{
    public class ContaPagaRepository : IContaPagaRepository
    {
        private SQLServerContext _context;

        public ContaPagaRepository(SQLServerContext context)
        {
            _context = context;
        }

        public List<ContaPaga> FindAll()
        {
            throw new NotImplementedException();
        }

        public ContaPaga FindById(int id)
        {
            return new ContaPaga(_context.Conta.SingleOrDefault(c => c.id.Equals(id)));
        }
    }
}
