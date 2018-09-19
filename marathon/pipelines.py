# -*- coding: utf-8 -*-

# Define your item pipelines here
#
# Don't forget to add your pipeline to the ITEM_PIPELINES setting
# See: https://doc.scrapy.org/en/latest/topics/item-pipeline.html

import pymssql

from scrapy.conf import settings
from scrapy.exceptions import DropItem
from scrapy.exporters import JsonItemExporter
from scrapy.exporters import CsvItemExporter

from scrapy import log

class MarathonPipeline(object):
    def __init__(self):
        self.conn = pymssql.connect(host='marathondata.database.windows.net', user='sharad@marathondata', password='123456p!', database='Marathon')
        self.cursor = self.conn.cursor()

    def process_item(self, item, spider):
        try:
            self.cursor.execute("INSERT INTO runner(Age, Bib, City, DivPl, Name, Overall, Sex, SexPl, State, Time) VALUES (%s, %s, %s, %s, %s, %s, %s, %s, %s, %s)", (item['Age'], item['Bib'], item['City'], item['DivPl'], item['Name'], item['Overall'], item['Sex'], item['SexPl'], item['State'], item['Time']))
            self.conn.commit()
        except pymssql.Error as e:
            print ("error")

        return item  

        
class JsonPipeline(object):
    def __init__(self):
        self.file = open("marathon_data.json", 'wb')
        self.exporter = JsonItemExporter(self.file, encoding='utf-8', ensure_ascii=False)
        self.exporter.start_exporting()
 
    def close_spider(self, spider):
        self.exporter.finish_exporting()
        self.file.close()
 
    def process_item(self, item, spider):
        self.exporter.export_item(item)
        return item
        
class CsvPipeline(object):
    def __init__(self):
        self.file = open("marathon_data.csv", 'wb')
        self.exporter = CsvItemExporter(self.file, str)
        self.exporter.start_exporting()
 
    def close_spider(self, spider):
        self.exporter.finish_exporting()
        self.file.close()
 
    def process_item(self, item, spider):
        self.exporter.export_item(item)
        return item

def create_valid_csv(self, item):
    for key, value in item.items():
        is_string = (isinstance(value, basestring))
        if (is_string and ("," in value.encode('utf-8'))):
            item[key] = "\"" + value + "\""        