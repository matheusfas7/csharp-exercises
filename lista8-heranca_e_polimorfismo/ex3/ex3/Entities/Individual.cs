using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(double healthExpenditures, string name, double annualIncome) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0;
            if (AnnualIncome < 20000)
            {
                tax += AnnualIncome * 0.15 - HealthExpenditures * 0.5;
            }
            else
            {
                tax += AnnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
            return tax;
        }


    }
}
