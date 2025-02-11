weatherforecast= input('Please write weather forecast')
try:
    if weatherforecast== 'Rain':
        print('Take an umbrella')
    elif weatherforecast== 'Sunny':
        print('Take sunscreen')
    elif weatherforecast== 'Snow':
        print('Take a scarf')
    else:
        print('No advice for you')
except:
    print('No idea what happened there but the answer is no')