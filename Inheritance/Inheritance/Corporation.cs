using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Corporation : ForProfitOrganizations
    {
        public string subType { get; set; }

        public Corporation(string companyName, string companyAddress, string businessType, int employeesNumber, string subType)
           : base(companyName, companyAddress, businessType, employeesNumber)
        {
            this.subType = subType;
        }

        public int stockTrading(int uprice, int quantity)
        {
            int gain = uprice * quantity;
            return gain;
        }
    }
}
