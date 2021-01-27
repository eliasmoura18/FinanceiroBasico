using FinanceiroBasico.Model;
using FinanceiroBasico.Model.Context;
using FinanceiroBasico.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace FinanceiroBasico.Business.Implementation
{
    public class ContaBusiness : IContaBusiness
    {
        private IContaRepository _repository;

        public ContaBusiness(IContaRepository repository)
        {
            _repository = repository;
        }

        public List<Conta> FindAll()
        {
            return _repository.FindAll();
        }

        public Conta FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Conta Create(Conta conta)
        {
            return _repository.Create(conta);
        }

        public Conta Update(Conta conta)
        {
            return _repository.Update(conta);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);

        }
    }
}
