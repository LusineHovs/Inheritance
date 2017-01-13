# Inheritance

This program shows you Inheritance classical exapmle using For-Profit Organizations and its subtypes.
# Base Class
In *Inheritance folder* you will see **ForProfitOrganizations** class, which is the *base class* with the following properties and methods:

~~~
public string companyName { get; set; }
public string companyAddress { get; set; }
public string businessType { get; set; }
public int employeesNumber { get; set; }
~~~
- getProfit() 
- getMarketShare()

# Derived Classes

In *Inheritance folder* also you will find derived classes of ForProfitOrganizations
### Corporation
Derived class with the following property and method:
~~~
public string subType { get; set; }
~~~
- stockTrading()

### SoleProprietorship
Derived class with the following property:
~~~
public string taxType { get; set; }
~~~

### StockCompany
Derived class with the following property:
~~~
public int shareholdersNumber { get; set; }
~~~

- In *UserProgram folder* is **UserProgram** which is for users. Using this program users can create and initialize desired profit company type with its' functions. 

~~~
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
~~~
