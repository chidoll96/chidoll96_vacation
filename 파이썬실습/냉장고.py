__author__ = 'A69'
a={}
print "input name"
b = raw_input()
print "input amount"
c=input()
a.update({b:c})
while 1:
    print "1 = insert"
    print "2 = remove"
    print "3 = search"
    print "4 = quit"
    d=input()
    if d==1:
        print "input name"
        b=raw_input()
        print "input amount"
        c=input()
        if b in a:
           a[b]= a[b]+c
           print c,b,"added"
        else:
            a.update({b:c})
            print "new food",b,"was added"
    if d==2:
         print "name?"
         b=raw_input()
         print"how many?"
         c=input()
         if b in a:
             a[b] = a[b]-c
             if a[b]>0:
                 print c,b,"removed"
             if a[b]<0:
                print a[b],"it's not a positive number...try again."
                a[b]=a[b]+c
             if a[b]==0:
                 del a[b]
                 print "you have not",b,"so it was removed"
         else:
             print "there's no",b
    if d==3:
        print "name?"
        i=raw_input()
        if i in a:
            print "you have",a[i],i
        else:
            print "there's no",i
    if d==4:
        break


