using FinanceiroBasico.Model;
using FinanceiroBasico.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FinanceiroBasico.Repository.Implementation
{
    public class ContaRepository : IContaRepository
    {
        private SQLServerContext _context;

        public ContaRepository(SQLServerContext context)
        {
            _context = context;
        }

        public List<Conta> FindAll()
        {
            return _context.Conta.ToList();
        }

        public Conta FindById(int id)
        {
            return _context.Conta.SingleOrDefault(c => c.id.Equals(id));
        }

        public Conta Create(Conta conta)
        {
            try
            {
                _context.Add(conta);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return conta;
        }

        public Conta Update(Conta conta)
        {
            if (!IsExiste(conta.id))
                return new Conta();

            var contaExiste = _context.Conta.SingleOrDefault(c => c.id.Equals(conta.id));

            if (contaExiste != null)
            {
                try
                {
                    _context.Entry(contaExiste).CurrentValues.SetValues(conta);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return conta;
        }

        public void Delete(int id)
        {
            var conta = _context.Conta.SingleOrDefault(c => c.id.Equals(id));

            if (conta != null)
            {
                try
                {
                    _context.Conta.Remove(conta);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        private bool IsExiste(int id)
        {
            return _context.Conta.Any(c => c.id.Equals(id));
        }

    }
}
