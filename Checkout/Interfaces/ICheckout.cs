using Checkout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Interfaces
{
    public interface ICheckout
    {
        Models.Receipt Total(List<Produce> produce);
    }
}
