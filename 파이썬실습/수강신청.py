__author__ = 'A69'
a={}
A={}
oops =[]
f=open("subject.txt",'r')
while True:
    line=f.readline()
    if line == "":
        break
    subject, code=line.split()
    a[code]=subject
f.close()
g=open("user.txt",'r')
while True:
    line=g.readline()
    if line == "":
        break
    temp,hold=line.split()

    A[temp]=a[hold]
g.close()



print a
print A
#A -> USER : SUBJECT  a-> CODE : subject
def add():
    print "input user name"
    b=raw_input()
    print "input code"
    c=raw_input()
    if b in A:
        if a[c]in A[b]:
            print "already have",a[c]
        else:
          A[b]= A[b]+a[c]
          print "new subject",a[c],"added"
    else:
     A[b]=a[c]
     print "new subject",A[b],"was added !"
def minus():
    print "name?"
    b=raw_input()
    print"code?"
    c=raw_input()
    if b in A:
        if a[c] in A[b]:
            print a[c],"was removed"
            wow = A[b].index(a[c])
            index1 = ""
            index2 = ""
            index3 = ""
            for i in A[b][:wow]:
             index1 += i
            for i in A[b][wow+6:]:
             index2 += i
            index3 = index1+index2
            A[b] = ""
            A[b] = index3
        else:
            print "there's no",a[c]
    else:
        print "That's not a user"
def search():
    print a
def user():
    print "user name?"
    b = raw_input()
    if b in A:
     print A[b]
    else:
        print "That's not a user"
while 1:
    print "1 = search code"
    print "2 = add"
    print "3 = remove"
    print "4 = user search"
    print "5 = quit"
    d=input()
    if d==2:
        add()
    if d==3:
        minus()
    if d==1:
       search()
    if d==4:
       user()
    if d==5:

        break

