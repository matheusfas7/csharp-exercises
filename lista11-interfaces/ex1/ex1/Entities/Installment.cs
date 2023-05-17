using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex1.Entities
{
    class Installment
    {
        public DateTime DueData { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueData, double amount)
        {
            DueData = dueData;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueData.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
