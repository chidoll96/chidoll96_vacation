from __future__ import division
__author__ = 'A69'

class fraction():
    a=0
    b=0
    def __init__(self,a=0,b=0):
        self.a = a
        self.b=b
        print a,"/",b
    def __add__(self,other):
        if (self.b == other.b):
            c = self.a+other.a
            if (c%self.b==0):
                print  self.a,"/",self.b, '+' ,other.a,"/",other.b,'=',c,'/',self.b,'=',c/self.b
            else :
                print self.a,"/",self.b, '+' ,other.a,"/",other.b,'=', c,'/',self.b
        elif(self.b!=other.b):
            c=self.a*other.b+self.b*other.a
            print self.a,"/",self.b, '+' ,other.a,"/",other.b,'=', c,'/',self.b*other.b
    def __sub__(self, other):
         if (self.b == other.b):
            c = self.a-other.a
            if (c%self.b==0):
                print  self.a,"/",self.b, '-' ,other.a,"/",other.b,'=',c,'/',self.b,'=',c/self.b
            else :
                print self.a,"/",self.b, '-' ,other.a,"/",other.b,'=', c,'/',self.b
         elif(self.b!=other.b):
            c=self.a*other.b-self.b*other.a
            print self.a,"/",self.b, '-' ,other.a,"/",other.b,'=', c,'/',self.b*other.b
    def __mul__(self, other):
        c = self.a*other.a
        print  self.a,"/",self.b, '*' ,other.a,"/",other.b,'=',c,'/',self.b*other.b
    def __truediv__(self, other):
        c = self.a*other.b
        print  self.a,"/",self.b, '/' ,other.a,"/",other.b,'=',c,'/',self.b*other.a
fra1=fraction(input(),input())
fra2=fraction(input(),input())
fra1 + fra2
fra1 - fra2
fra1*fra2
fra1/fra2

