# Inheritance

This program shows you Inheritance classical exapmle using For-Profit Organizations and its subtypes.

#Keywords
C# 6.0, .Net Framework 4.6, Microsoft Visual Studio.

# Base Class
In *Inheritance folder* you will see **ForProfitOrganizations** class, which is the *base class* with the following properties and methods:

```C#
public string companyName { get; set; }
public string companyAddress { get; set; }
public string businessType { get; set; }
public int employeesNumber { get; set; }
```
- getProfit() 
- getMarketShare()

# Derived Classes

In *Inheritance folder* also you will find derived classes of ForProfitOrganizations
### Corporation
Derived class with the following property and method:
```C#
public string subType { get; set; }
```
- stockTrading()

### SoleProprietorship
Derived class with the following property:
```C#
public string taxType { get; set; }
```

### StockCompany
Derived class with the following property:
```C#
public int shareholdersNumber { get; set; }
```

- In *UserProgram folder* is **UserProgram** which is for users. Using this program users can create and initialize desired profit company type with its' functions. 

```C#
namespace UserProgram
{

 class Program
 {

     static void Main(string[] args)
     {
StockCompany sck = new StockCompany("FirstStock", "First Plaza 2", "StockCompany", 102, ForProfitOrganizations.subType.closedstock, 16);
     }
 }
}
```

### If we print above mentioned StockCompany class fields, output will be :
- StockCompany name               => FirstStock
- StockCompany address            => First Plaza 2
- StockCompany businessType       => StockCompany
- StockCompany employeesNumber    => 102
- StockCompany subType            => closedstock
- StockCompany shareholdersNumber => 16
