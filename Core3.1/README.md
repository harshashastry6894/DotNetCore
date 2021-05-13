# DotNetCore Template
To unintsall sql server follow below steps
1. Uninstall all the packages intsalled on date (03/12/2020)
OR
1. Azure Data Studio
2. Browser for sql server 2019
3. Microsoft .NET SDK 5.0.100
4. Microsoft Help Viewer
5. Microsoft ODBC driver 17 for sql server
6. Microsoft ODBC driver for sql server
7. Microsoft SQL server 2012 native client
8. Microsoft SQL server 2019 (64-bit)
9. Microsoft SQL server 2019 Setup
10. Microsoft SQL server 2019 T-SQL Language Service
11. Microsoft SQL server Management Studio
12. Microsoft Visual C++ 2013
13. Microsoft Visual C++ 2015-19
14. Microsoft Visual C++ 2017
15. Microsoft Visual Tools for Applications 2017
16. Microsoft VSS writer

# Steps to create a REST web api

# To use db first approach
dotnet ef dbcontext scaffold "Server=SHASTRY;Database=harshaDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models --force

# To store connection string
dotnet user-secrets init
dotnet user-secrets set ConnectionStrings.HarshaDbConnection "Server=SHASTRY;Database=harshaDB;Trusted_Connection=True;"
dotnet ef dbcontext scaffold Name=ConnectionStrings.HarshaDbConnection  Microsoft.EntityFrameworkCore.SqlServer -o Models --force