# -*- coding: utf-8 -*-

# Define here the models for your scraped items
#
# See documentation in:
# https://doc.scrapy.org/en/latest/topics/items.html

import scrapy

from scrapy.item import Item, Field

class MarathonItem(Item):
    # define the fields for your item here like:
    # name = scrapy.Field()
    Bib = Field()
    Name = Field()
    Sex = Field()
    Age = Field()
    City = Field()
    State = Field()
    Overall = Field()
    SexPl = Field()
    DivPl = Field()
    Time = Field()
