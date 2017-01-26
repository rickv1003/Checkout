using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Models
{
    public class Orange : Produce
    {
        public Orange(OrangeVariety variety)
        {
            Variety = variety;
        }

        public OrangeVariety Variety { get; set; }

        public enum OrangeVariety
        {
            Mandarin,
            Clementine,
            Tangerine
        }
    }
}
