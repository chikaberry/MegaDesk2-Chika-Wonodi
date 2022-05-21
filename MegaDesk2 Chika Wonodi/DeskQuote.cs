using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk2_Chika_Wonodi
{
    internal class DeskQuote
    {
        public string CustomerName { get; set; }

        public DateTime QuoteDate { get; set; }

        public string shipping { get; set; }

        public Desk Desk { get; set; }
    }
}


