using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinanceiroBasico.Model.Base
{
    public class BaseEntity
    {
        [JsonIgnore]
        [Column("id")]
        public int id { get; set; }

    }
}
