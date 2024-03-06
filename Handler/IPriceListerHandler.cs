using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuppliesPriceLister.Models.Views;

namespace SuppliesPriceLister.Handler
{
    public interface IPriceListerHandler
    {
        List<SuppliesViewModel> combinepricedata();
    }
}
