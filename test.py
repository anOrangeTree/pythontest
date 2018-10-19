# -*- coding:UTF-8 -*-
from imp import reload
import sys


reload(sys)

#sys.setdefaultencoding('utf8')

def Test1(para1,para2):
    return para1+para2

def Test2():
    return '等等我'

if __name__ == '__main__':
    print(Test1(2,5))
    print(Test2())