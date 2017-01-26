using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Checkout.Models;

namespace Checkout.Interfaces
{
    public interface IDiscount
    {
        double CalculateDiscount(List<Produce> produce);
    }
}
