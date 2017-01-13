using Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserProgram
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            SoleProprietorship s = new SoleProprietorship("FirstSole","First Plaza 1", "SoleProprietorship", 1,"Prime");
            Corporation cp = new Corporation("FirstCorp", "First Plaza 2", "Corporation", 150, "K1");
            StockCompany sck = new StockCompany("FirstStock", "First Plaza 2", "StockCompany", 102, ForProfitOrganizations.subType.closedstock, 16);
            
        }
    }
}
