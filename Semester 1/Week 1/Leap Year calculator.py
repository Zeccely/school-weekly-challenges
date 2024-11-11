year=int(input('Please enter a Year\n'))
try:
    if year%4==0 and year%100!=0 or year%4==0 and year%100==0 and year%400==0:
        print('This is a Leap Year')
    else:
        print('This is not a Leap Year')
except:
    print('Please enter a year')