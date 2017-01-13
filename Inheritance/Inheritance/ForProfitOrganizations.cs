using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    
    public class ForProfitOrganizations
    {
        public enum subType
        {
            openstock,
            closedstock
        };

        public string companyName { get; set; }
        public string companyAddress { get; set; }
        public string businessType { get; set; }
        public int employeesNumber { get; set; }

        public ForProfitOrganizations(string companyName, string companyAddress, string businessType, int employeesNumber)
        {
            this.companyName = companyName;
            this.companyAddress = companyAddress;
            this.businessType = businessType;
            this.employeesNumber = employeesNumber;
        }

        public int getProfit(int revenue, int cost)
        {
            int profit = revenue - cost;
            return profit;
        }
        public int getMarketShare(int capacity, int competitors)
        {
            int ownshare = capacity - competitors;
            return ownshare;
        }
    }
}
