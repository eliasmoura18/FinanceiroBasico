using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinanceiroBasico.Data.VO
{
    public class ContaVO //Single Responsability Principle
    {
        [JsonIgnore]
        public int id { get; set; }
        public string nome { get; set; }
        public decimal valorOriginal { get; set; }
        public DateTime dataVencimento { get; set; }
        public DateTime dataPagamento { get; set; }
    }
}
