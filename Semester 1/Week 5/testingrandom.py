import random
lightlist=[]
while len(lightlist) < 10:
    number = random.randint(1,1000)
    lightlist.append(number)
print(lightlist)