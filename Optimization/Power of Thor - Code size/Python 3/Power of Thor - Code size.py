x,y,X,Y=map(int,input().split())
while 1:a=Y<y;print("S"*a+"W"*(X>x)+"E"*(X<x));Y+=a