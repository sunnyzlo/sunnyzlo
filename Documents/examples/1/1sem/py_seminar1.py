#Домашка 1
#1 Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
# Пример: 6 -> да- 7 -> да- 1 -> нет

def weekends ():
    x = int(input(f'Введите номер дня недели от 1 до 7, а я покажу выходной ли он: '))
    if 0 < x < 6: print("Это будень")
    else: print("Это выходной")


#2 Напишите программу для проверки истинности утверждения (X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z (расшифровка этого выражения
# not(x[0] or x[1] or x[2] = not x[0] and not x[1] and not x[2]) для всех значений предикат.

def predikat ():
    x1 = int(input(f'Введите число, а потом ещё два, а я кое-что проверю: '))
    x2 = int(input(f'Введите второе число: '))
    x3 = int(input(f'Введите третье число: '))
    if x1 or x2 or x3 == x1 and x2 and x3: print ('Так и есть')
    else: print('Неверно')


#3 Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
# в которой находится эта точка .
# Пример:- x=34; y=-30 -> 4- x=2; y=4-> 1- x=-34; y=-30 ->
def what_quarter ():
    x = int(input(f'Введите x: '))
    y = int(input(f'Введите у: '))
    if x > 0 and y > 0: print('Первая четверть')
    elif x < 0 and y > 0: print('Вторая четверть')
    elif x < 0 and y < 0: print('Третья четверть')
    else: print('Четвертая четверть')

#4 Напишите программу, которая по заданному номеру четверти,  показывает диапазон возможных координат точек в этой четверти (x и y).

def what_quarter2 ():

    x = input('Введите четверть: ')
    if x =='Первая четверть' or x =='Первая': print('x > 0 and y > 0')
    elif x =='Вторая четверть' or x =='Вторая': print('x < 0 and y > 0')
    elif x =='Третья четверть' or x =='Третья': print('x < 0 and y < 0')
    else: print('x > 0 and y < 0')


#5 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
# Пример:- A (3,6); B (2,1) -> 5,09- A (7,-5); B (1,-1) -> 7,21
def distance ():
    Ax = float(input(f'Введите A x: '))
    Ay = float(input(f'Введите A y: '))
    Bx = float(input(f'Введите B x: '))
    By = float(input(f'Введите B y: '))

    print (((Ax-Bx)**2 + (Ay-By)**2)**0.5)
