__author__ = 'A69'
a={}
f=open("ok.txt",'r')
while True:
    line=f.readline()
    if line == "":
        break
    name, amount=line.split()
    a[name]=int(amount)
f.close()
print a
def add():
    print "input name"
    b=raw_input()
    print "input amount"
    c=raw_input()
    if b in a:
     a[b]= a[b]+int(c)
     print c,b,"added"
    else:
     a.update({b:int(c)})
    print "new food",b,"was added"
def minus():
    print "name?"
    b=raw_input()
    print"how many?"
    c=raw_input()
    if b in a:
        a[b] = a[b]-int(c)
        if a[b]>0:
            print c,b,"removed"
        if a[b]<0:
            print a[b],"it's not a positive number...try again."
            a[b]=a[b]+int(c)
        if a[b]==0:
            del a[b]
            print "you have not",b,"so it was removed"
    else:
        print "there's no",b
def search():
    print a
while 1:
    print "1 = insert"
    print "2 = remove"
    print "3 = search"
    print "4 = quit"
    d=input()
    if d==1:
        add()
    if d==2:
        minus()
    if d==3:
       search()
    if d==4:
        o=open("ok.txt",'w')
        output = ""
        for i in a:
            output += i
            output += " "
            output += str(a[i])
            output +='\n'
        o.write(output)

        o.close()
        break
