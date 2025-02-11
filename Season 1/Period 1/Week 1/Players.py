#can this be done with dictionaries?
Player1=input('Player 1:\n')
score1= int(input('Score of player 1:\n'))
Player2=input('Player 2:\n')
score2= int(input('Score of player 2:\n'))

try:
    if score1>score2:
        print(Player1,score1)
    elif score2>score1:
        print(Player2,score2)
    else:
        print('There is a tie')
except:
    print('Data wrongly added, try again')