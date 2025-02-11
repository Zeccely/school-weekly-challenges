userword=input('Write a word\n')
listofletters=[]
for x in userword:
    listofletters.append(x)

print(listofletters)

userletter=input('Now write a letter\n')
if userletter in listofletters:
    print('Yes')
else:
    print('No')
newword=[]
for x in userword:
    if x!=userletter:
        newword.append('*')
    else:
        newword.append(x)
print(newword)
