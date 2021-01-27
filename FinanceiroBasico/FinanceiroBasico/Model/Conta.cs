using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinanceiroBasico.Model
{
    [Table("CONTA")]
    public class Conta
    {
        [JsonIgnore]
        [Column("id")]
        public int id { get; set; }

        [Column("nome")]
        public string nome { get; set; }

        [Column("valorOriginal")]
        public decimal valorOriginal { get; set; }

        [Column("valorCorrigido")]
        public decimal valorCorrigido { get; set; }

        [Column("dataVencimento")]
        public DateTime dataVencimento { get; set; }

        [Column("dataPagamento")]
        public DateTime dataPagamento { get; set; }

        [Column("qtdeDiasAtraso")]
        public int qtdeDiasAtraso { get; set; }
    }
}
