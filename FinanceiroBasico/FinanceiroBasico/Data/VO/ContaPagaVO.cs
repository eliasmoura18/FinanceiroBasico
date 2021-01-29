using FinanceiroBasico.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinanceiroBasico.Data.VO
{
    public class ContaPagaVO //Single Responsability Principle
    {
        [JsonIgnore]
        public int id { get; set; }
        public string nome { get; set; }
        public decimal valorOriginal { get; set; }
        public decimal valorCorrigido { get; set; }
        public int qtdeDiasAtraso { get; set; }
        public DateTime dataPagamento { get; set; }

    }
}
