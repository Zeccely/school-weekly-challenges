N=input('Give me a number below 10 \n')
usernumber=float(N)
try:
    if usernumber < 10:
        cheat= usernumber+1
        print(cheat, 'So I win')
    elif usernumber == 9:
        print('You have bested me! Nooooo')
    elif usernumber > 10:
        print('You rule breaker, Give me a number below 10')
except:
    print('Write down a number')

replay=input('Would you like to play again? please write Y/N\n')
try:
    if replay== 'Y':
       print('Okay')
#How to tell computer to go back to the above conditions and ask for input again without a function)
    elif replay== 'N':
        quit()
except:
    print('Please write Y or N')
