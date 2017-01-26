using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Models
{
    public class Apple : Produce
    {
        public Apple(AppleColor color)
        {
            Color = color;
        }

        public AppleColor Color { get; set; }

        public enum AppleColor
        {
            Red,
            Green
        }
    }
}
