# Marathon-Application
 * Web Crawlers web site and Automatically Upload Data in Microsoft Azure SQL Server Database.
 * Application display data using C#


## To run spider:

1. open cmd prompt (a)

2. go to location of project folder by doing:
   ```
   cd marathon
   ```
   
3. run follwoing cmd in cmd prompt (a) to upload data into Microsoft Azure SQl Server Database
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

   
