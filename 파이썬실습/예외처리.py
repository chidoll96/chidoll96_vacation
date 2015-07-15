#-*- coding:utf-8 -*-
#파일 입출력 및 예외처리 예제

__author__ = 'A69'
filename = raw_input()
try:
 c= open(filename,'r')
 while True:
    line = c.readline()
    if not line: break
    print(line)
 c.close()
 a =open(filename,'a')
 print "Add contents"
 a.write(raw_input())
 a.write('\n')
 print "Added"
except IOError,c:
  print c
  print "There is no %s file" % filename
  print "Create %s file" % filename
  b = open(filename,'w')
  print "Contents?"
  b.write(raw_input())
  b.write('\n')
  print "Created"
  b.close()



