# -*- coding: utf-8 -*-
import re
from scrapy import Spider
from scrapy.selector import Selector
from marathon.items import MarathonItem    
from scrapy.linkextractors import LinkExtractor
from scrapy import log            
            
class StackCrawlerSpider(Spider):
    name = 'marathon'
    allowed_domains = ['mtecresults.com']
    start_urls = [
        "http://farm.mtecresults.com/race/show/5828?division=M2229&offset=0&perPage=914",
    ]

    def parse(self, response):
        questions = Selector(response).xpath('//div[@class="searchresults"]/div/div/table[@class="runnersearch"]/tbody/tr')
        
        for question in questions:
            
            item = MarathonItem()
            
            item['Bib'] = question.xpath('td[1]/a/text()').extract()
            item['Bib'] = [i.replace("\n\t\t\t\t\t\t\t", "") for i in item['Bib']]
            item['Bib'] = [i.replace("\n\t\t\t\t\t", "") for i in item['Bib']]
            
            item['Name'] = question.xpath('td[2]/a/text()').extract()
            item['Name'] = [i.replace("\n\t\t\t\t\t\t\t", "") for i in item['Name']]
            item['Name'] = [i.replace("\n\t\t\t\t\t", "") for i in item['Name']]
            
            item['Age'] = question.xpath('td[4]/a/text()').extract()
            item['Age'] = [i.replace("\n\t\t\t\t\t\t\t", "") for i in item['Age']]
            item['Age'] = [i.replace("\n\t\t\t\t\t", "") for i in item['Age']]
             
            item['Sex'] = question.xpath('td[3]/a/text()').extract()
            item['Sex'] = [i.replace("\n\t\t\t\t\t\t\t", "") for i in item['Sex']]
            item['Sex'] = [i.replace("\n\t\t\t\t\t", "") for i in item['Sex']]
            
            item['City'] = question.xpath('td[5]/a/text()').extract()
            item['City'] = [i.replace("\n\t\t\t\t\t\t\t", "") for i in item['City']]
            item['City'] = [i.replace("\n\t\t\t\t\t", "") for i in item['City']]
            
            item['State'] = question.xpath('td[6]/a/text()').extract()
            item['State'] = [i.replace("\n\t\t\t\t\t\t\t", "") for i in item['State']]
            item['State'] = [i.replace("\n\t\t\t\t\t", "") for i in item['State']]
            
            item['Overall'] = question.xpath('td[7]/a/text()').extract()
            item['Overall'] = [i.replace("\n\t\t\t\t\t\t\t", "") for i in item['Overall']]
            item['Overall'] = [i.replace("\n\t\t\t\t\t", "") for i in item['Overall']]
            
            item['SexPl'] = question.xpath('td[8]/a/text()').extract()
            item['SexPl'] = [i.replace("\n\t\t\t\t\t\t\t\t", "") for i in item['SexPl']]
            item['SexPl'] = [i.replace("\n\t\t\t\t\t\t", "") for i in item['SexPl']]
            
            item['DivPl'] = question.xpath('td[9]/a/text()').extract()
            item['DivPl'] = [i.replace("\n\t\t\t\t\t\t\t\t", "") for i in item['DivPl']]
            item['DivPl'] = [i.replace("\n\t\t\t\t\t\t", "") for i in item['DivPl']]
            
            item['Time'] = question.xpath('td[10]/a/text()').extract()
            item['Time'] = [i.replace("\n\t\t\t\t\t\t\t", "") for i in item['Time']]
            item['Time'] = [i.replace("\n\t\t\t\t\t", "") for i in item['Time']]
            
            item['Bib'] = re.sub(r'[^a-zA-Z0-9]', '', str(item['Bib']))
            item['Name'] = str(item['Name']).replace('[', '').replace(']', '')
            item['Age'] = str(item['Age']).replace('[', '').replace(']', '')
            item['Sex'] = str(item['Sex']).replace('[', '').replace(']', '')
            item['City'] = str(item['City']).replace('[', '').replace(']', '')
            item['State'] = str(item['State']).replace('[', '').replace(']', '')
            item['Name'] = str(item['Name']).replace("'", "")
            item['Age'] = str(item['Age']).replace("'", "")
            item['Sex'] = str(item['Sex']).replace("'", "")
            item['City'] = str(item['City']).replace("'", "")
            item['State'] = str(item['State']).replace('[', '').replace(']', '')
            item['Overall'] = str(item['Overall']).replace('[', '').replace(']', '')
            item['Overall'] = str(item['Overall']).replace("'", "")
            item['SexPl'] = str(item['SexPl']).replace('[', '').replace(']', '')
            item['SexPl'] = str(item['SexPl']).replace("'", "")
            item['DivPl'] = str(item['DivPl']).replace('[', '').replace(']', '')
            item['DivPl'] = str(item['DivPl']).replace("'", "")
            item['Time'] = str(item['Time']).replace('[', '').replace(']', '')
            item['Time'] = str(item['Time']).replace("'", "")
            
            yield item
