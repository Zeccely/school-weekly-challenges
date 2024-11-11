classroomdict={'Mathematics':'Room 1', 'Physics':'Room 2', 'Chemistry':'Room 3','Biology':'Room 4','Geology':'Room 5','Philosophy':'Room 6', 'English':'Room 7', 'History': 'Room 8'}
studentname= input('What is your name?\n')
studentsubject= input('What is your next subject\n')

if studentsubject in classroomdict:
    print(studentname,'go to',classroomdict.get(studentsubject))
else:
    print('I have no advice for you')