import random
counter= 0
shouldguess=True
numberstuff= random.randint(1,100) #used the internet to check for a function that generates a random  integer but no floats are allowed :(
    
    
while shouldguess:   #This is the safest way to do this thing, Break is not elegant
    
    try:
        guess_number=int(input('Guess a number between 1 and 100\n'))
        if guess_number < numberstuff:
            print('Too Low')
            counter= counter+1
            stringy = "You have tried " + str(counter) + " times"
            print(stringy)
        elif guess_number > numberstuff:
            print('Too high')
            counter= counter+1
            print("You have tried",counter,"times.")
        else:
            print('Good Job')
            print("You got it after",counter,'times!')
        
        
            retry=input("Do you want to play again? Y/N\n")
            if retry=="Y":
                shouldguess=True
            else:
                shouldguess=False
            
    except:
        print('Decimals and letters are forbidden') #haha youre stuck now, get the number or it keeps running hehehehehehehehehehe
        