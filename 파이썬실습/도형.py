
__author__ = 'A69'
import math
class shape:
    area = 0
    def __init__(self,area=0):
        self.area = area
    def func(self):
        pass
    def printr(self):
        print "Area : {0}".format(self.area)

class twodim(shape):
    perimeter = 0
    def __init__(self,perimeter=0):
        self.perimeter = perimeter
    def printt(self):

        print "Perimeter : {0}".format(self.perimeter),"\n"

class threedim(shape):
    volume = 0
    def __init__(self,volume=0):
        self.volume = volume
    def printy(self):
        print "Volume : {0}".format(self.volume),"\n"

class rectangle(twodim):
    x = 0
    y = 0
    def __init__(self,x,y):
        print "----------- Rectangle ------------ "
        self.x=x
        self.y=y
    def calarea(self):
        self.area = self.x*self.y
    def calperi(self):
        self.perimeter = 2*(self.x+self.y)

class triagnle(twodim):
    a = 0
    def __init__(self,a):
        print "----------- Triangle ------------ "
        self.a = a
    def calarea(self):
        self.area = (math.sqrt(3)/4)*pow(self.a,2)
    def calperi(self):
        self.perimeter = self.a*3

class circle(twodim):
    r = 0
    def __init__(self,r):
        print "----------- Circle ------------ "
        self.r = r
    def calarea(self):
        self.area= pow(self.r,2)*3.14
    def calperi(self):
        self.perimeter =  self.r * 2 * 3.14

class sphere(threedim):
    r =0
    def __init__(self,r):
        print "----------- Sphere ------------ "
        self.r = r
    def calarea(self):
                self.area = 4 * pow(self.r,2) * 3.14
    def calvol(self):
        self.volume = pow(self.r,3) * 3.14 * 4.0/3

class cube(threedim):
    a=0
    def __init__(self,a):
        print "----------- Cube ----------- "
        self.a = a
    def calarea(self):
        self.area = pow(self.a,2)*6
    def calvol (self):
        self.volume = pow(self.a,3)
rect=rectangle(2,4)
rect.calarea()
rect.calperi()
rect.printr(),rect.printt()

tri=triagnle(3)
tri.calarea()
tri.calperi()
tri.printr(),tri.printt()

cir=circle(4)
cir.calarea()
cir.calperi()
cir.printr(),cir.printt()

cu=cube(4)
cu.calarea()
cu.calvol()
cu.printr(),cu.printy()

sph=sphere(4)
sph.calarea()
sph.calvol()
sph.printr(),cu.printy()


