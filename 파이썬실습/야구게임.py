__author__ = 'A69'
import random
c = 0
d = 0
a=[random.randrange(1,10),random.randrange(1,10),random.randrange(1,10)]
for z in range(0,3):
    for p in range(z+1,3):
        if a[p]==a[z]:
            a[p]=random.randrange(1,10)
            z=0
print a
while c<3:
 c=0
 d=0
 b=[input(),input(),input()]

 for i in range(0,3):
    for j in range(0,3):
        if a[i]==b[j] and i == j:
            c +=1
        if a[i] == b[j] and i!=j:
            d += 1
 if c!= 0:
  print c,"strike"
 if d!=0:
  print d,"ball"

