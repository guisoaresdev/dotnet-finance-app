using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using dotnet_finance_app.Models;

namespace dotnet_finance_app.Models
{
    public class Stock
    {
        public int id {get; set; } 
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal LastDiv { get; set; }
        public string Industry { get; set; }
        public long MarketCap { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

    }
}