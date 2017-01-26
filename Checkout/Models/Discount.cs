using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Models
{
    public abstract class Discount
    {
        internal List<Pricing> _pricing { get; set; }

        internal void CheckForPricing(Type T)
        {
            if (_pricing.Where(x => x.Item == T).Count() == 0)
            {
                throw new Exception("No pricing for selected discount item");
            }
            else if (_pricing.Where(x => x.Item == T).Count() > 1)
            {
                throw new Exception("Multiple pricing for selected discount item");
            }
       }
    }
}
