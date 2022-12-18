
# Понять входит ли в строку "plr"

def plr():
    input_str = input ("Введите: ")
    res = (lambda x: "plr" in x)(input_str)
    print (res)


#наибольший общий делитель
import random
def naib_obshii():
    a = random. randint (0, 1001)
    b = random. randint (0, 1001)
    c = [a, b]
    print(c)

    while max(a, b) % min(a, b) !=0:
        if a > b: a = a % b
        elif a < b: b = b % a
    print (min(a, b))
