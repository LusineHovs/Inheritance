using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    
    public class StockCompany : ForProfitOrganizations
    {
        public int shareholdersNumber { get; set; }

        public StockCompany(string companyName, string companyAddress, string businessType, int employeesNumber, subType en, int shareholdersNumber)
            : base(companyName, companyAddress, businessType, employeesNumber)
        {
            this.shareholdersNumber = shareholdersNumber;
        }
    }
}
