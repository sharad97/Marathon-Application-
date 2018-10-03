# Marathon-Application
 * Web Crawles web site (using scrapy - python) and Automatically Upload Data in Microsoft Azure SQL Server Database.
 * MVC application in C# with the latest .NET version using data


## To run spider:

1. create Microsoft Azure SQL Server Database

2. create Table in database with column and datatypes (see [SQLQuery.sql](https://github.com/sharad97/Marathon-Application-/blob/Development/SQLQuery.sql))

3. open cmd prompt (a)

4. go to location of project folder by doing:
   ```
   cd marathon
   ```
   
5. run follwoing cmd in cmd prompt (a) to upload data into Microsoft Azure SQl Server Database
   and creates json + csv file automatically:
   ```
   scrapy crawl marathon
   ```
   
## Create new spider

1. open cmd prompt then run:
   ```
   scrapy startproject project_name (eg. scrapy startproject pisa_spider)
   ```
   
## Requirements 

1. Python installed
2. Scrapy installed (using anaconda or miniconda)
3. pymssql installed
4. Microsoft Azure SQL Server
5. Microsoft SQL Server Management
6. Option: Microsoft Visual Studio

 ## In Progress
 * MVC application in C# with the latest .NET version using data from Database
 #version 1 (Released) 
 [https://webapplication320181003040402.azurewebsites.net](https://webapplication320181003040402.azurewebsites.net)
