number1=int(input('Please write a number\n'))
number2=int(input('Please write another number\n'))
mathematicaloperator=str(input('Input mathematical operation\n'))

try:
    if mathematicaloperator== '+':
        print(number1+number2)
    elif mathematicaloperator== '-':
        print(number1-number2)
    elif mathematicaloperator=='*':
        print(number1*number2)
    elif mathematicaloperator=='/':
        print(number1/number2)
    elif mathematicaloperator== '%':
        print(number1%number2)
    elif mathematicaloperator=='//':
        print(number1//number2)
    else:
        print('Is this a math operator?')

except:
    print('Read the instructions again')