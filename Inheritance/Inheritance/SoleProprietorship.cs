using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class SoleProprietorship : ForProfitOrganizations
    {
        public SoleProprietorship(string companyName, string companyAddress, string businessType, int employeesNumber, string taxType)
            : base(companyName, companyAddress, businessType, employeesNumber)
        {
            this.taxType = taxType;
        }
        public string taxType { get; set; }
    }
}
