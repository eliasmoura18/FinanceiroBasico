using FinanceiroBasico.Data.Converter.Implementation;
using FinanceiroBasico.Data.VO;
using FinanceiroBasico.Model;
using FinanceiroBasico.Model.Context;
using FinanceiroBasico.Repository;
using FinanceiroBasico.Repository.Generic;
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
        private readonly IGenericRepository<Conta> _repository;
        private readonly IContaRepository _contaRepository;
        private readonly ContaConverter _converterConta;
        private readonly ContaPagaConverter _converterContaPaga;

        public ContaBusiness(IGenericRepository<Conta> repository, IContaRepository contaRepository)
        {
            _repository = repository;
            _contaRepository = contaRepository;
            _converterConta = new ContaConverter();
            _converterContaPaga = new ContaPagaConverter();
        }

        public List<ContaPagaVO> FindAll()
        {
            return _converterContaPaga.Parse(_repository.FindAll());
        }

        public ContaPagaVO FindById(int id)
        {
            return _converterContaPaga.Parse(_repository.FindById(id));
        }

        public ContaPagaVO Create(ContaVO conta)
        {
            Conta contaEntity = _converterConta.Parse(conta);

            if (_contaRepository.IsContaAtrasada(contaEntity))
            {
                contaEntity.qtdeDiasAtraso = _contaRepository.GetQtdeDiasAtraso(contaEntity);
                contaEntity.valorCorrigido = contaEntity.valorOriginal + _contaRepository.GetJurosEMultaPorDiasAtraso(contaEntity);
            }
            else
            {
                contaEntity.qtdeDiasAtraso = 0;
                contaEntity.valorCorrigido = contaEntity.valorOriginal;
            }

            contaEntity = _repository.Create(contaEntity);
            return _converterContaPaga.Parse(contaEntity);
        }

        public ContaVO Update(ContaVO conta)
        {
            var contaEntity = _converterConta.Parse(conta);
            contaEntity = _repository.Update(contaEntity);
            return _converterConta.Parse(contaEntity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
