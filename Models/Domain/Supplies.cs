using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuppliesPriceLister.Models.Domain
{
    public class Supplies
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Uom { get; set; }
        public float PriceInCents { get; set; }
        public string ProviderId { get; set; }
        public string MaterialType { get; set; }
    }
}
