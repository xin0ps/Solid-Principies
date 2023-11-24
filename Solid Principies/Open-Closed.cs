using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principies
{
    public abstract class Discount
    {
        public abstract decimal ApplyDiscount(decimal price);
    }

    public class ChristmasDiscount : Discount
    {
        public override decimal ApplyDiscount(decimal price)
        {
            return price * 0.8m; // %20 
        }
    }

    public class BlackFridayDiscount : Discount
    {
        public override decimal ApplyDiscount(decimal price)
        {
            return price * 0.7m; // %30 
        }
    }

//Yeni bir endirim elave etmek ucun sadece Discountdan torenen yeni bir class elave edirik kodu deyismirik
}
