
# Sales Forecast

The customer Superstore wants to perform a Proof of Concept or prototype for a forecasting
tool that eventually will send the data to their Financial Planning tool.


## Tech Stack

**Technolgies:** ASP.NET Core,C#, Html, Javascript, AJAX, Jquery, Linq


## Setup
- Install Microsoft SQL Server, Microsoft SQL Server managment studio(SSMS), Visual Studio 
- Download the given data excel into csv and convert csv data into sql queries. I have commited the sql queries in the repo.
- Create three tables such as orders, orderdetails and orderreturns

## Steps
- Pull the code from github 
- Open this project in the Visual studio 
- Edit the appsettings.json file in the visual studio and change the value for MyConn

```bash
  "MyConn": "Data Source="YOUR_SERVER;Initial Catalog:test;Integrated Security=true"
```
- I use Windows authenticaion here so I have given Integrated Security=true otherwise give userid and password instead of Integrated Security=true. 
- Give database name for  Initial Catalog 

![App Screenshot](https://github.com/AdithyaRamu/salesforecast/blob/3eb72faa3e553a13d492fe90e278e8de90aab6fc/Salesforecast/screenshots/Home.png)
(https://via.placeholder.com/468x300?text=App+Screenshot+Here)
