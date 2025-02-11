#overall I am disliking instances and how I cannot connect the defs properly. I need help please
#learned lower() online because when I mistyped DOne or done I got an error
def user_input():
    should_ask = True
    list_of_numbers = []
    while should_ask:
        number = input("Input numbers, write Done when finished\n")
        try:
            if number.lower() != "done":            
                list_of_numbers.append(int(number))           
            else:                    
                should_ask = False
        except:
            print("Please no decimals or letters and try again")
            continue
    return list_of_numbers
    
def weekly_input(list_of_numbers):  
    ind=0
    weeks_listed=[]
    while ind < len(list_of_numbers):
        week=list_of_numbers[ind:ind+7]
        weeks_listed.append(week)
        ind=ind+7
    return weeks_listed

user_numbers = user_input()
weekly= weekly_input(user_numbers)
print(weekly)
print(user_numbers)

def average(user_numbers):
    try:
        numbersum = (sum(user_numbers))
        print(numbersum)
        print(numbersum/len(user_numbers))
        return numbersum / len(user_numbers)
    except:
        print('There was an error, do not divide by 0')

#def average_weekly(weekly, start, end):




#average_weekly(user_numbers)

    

    
    


#daverage(user_numbers)
#average_weekly(user_numbers)


