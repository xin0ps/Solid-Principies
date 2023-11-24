using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_Principies
{
    public class Invoice
    {
        public string Number { get; set; }
        public decimal Amount { get; set; }
    }

    public class InvoicePrinter
    {
        public void PrintInvoice(Invoice invoice)
        {
            //Body
        }
    }

    //  burda InvoiicePrinter klassi sadece bir isi icra edir
}
