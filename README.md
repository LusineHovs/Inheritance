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
