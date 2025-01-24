using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_finance_app.Models;

namespace dotnet_finance_app.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedOn {get; set;} = DateTime.Now;
        public int? StockId { get; set; }
        // Navigation Prop
        public Stock? Stock { get; set; }
    }
}