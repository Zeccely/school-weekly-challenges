pre_pas='Potato'
n=4
count=n
try:
    while True:
        user_pas=input('Enter Password:\n')
        if pre_pas==user_pas:
            print('Password Correct')
            break
        if pre_pas!=user_pas and n!=1:
            n=n-1
            count=n
            print('Password Incorrect\n Tries:',count)
            continue
        else:
            print('Account Blocked')
            break
except:
    print('Something went wrong')