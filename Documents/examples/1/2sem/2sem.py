# Домашка 2
# 1. Нарограмму, которая принимает на вход вещественное число и показывает сумму его цифр.
# Пример:
# - 6782 -> 23
# - 0,56 -> 11
def sum_vesh ():
    a = float(input (' Введите число, а я скажу сумму чисел в нём'))
    a_str = len(str(a))
    sum = 0
    for i in range (a_str):
       if str(a)[i:i+1:1] != '.':
           b =int (str(a)[i:i+1:1])
           sum = sum + b
    print (sum)

# 2. Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.
# Пример: пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)
def peremn ():
    a = int(input(' Введите число, а я умножу'))
    sum = 1
    for i in range (5):
        if i > 1:
            sum = sum*i
    print (sum)


# 3. Задайте список из n чисел последовательности (1+ 1/n)*n  и выведите на экран их сумму.
# Пример: Для n = 6: {1: 4,  2: 7, 3: 10, 4: 13, 5: 16, 6: 19}
def posled ():
    n= int (input ('Введите n:'))
    cl = []
    sum = 0
    for i in range(n):
        cl.append(3*(i+1)+1)
        print (f"{i+1}:{cl[i]}", end =', ')
        sum = sum + cl[i]
    print('Сумма:', sum)
#posled ()

# 4*. Задайте список из N элементов, заполненных числами из промежутка [-N, N]. Найдите произведение
# элементов на указанных позициях

def sluch_promeg ():
    n= int (input ('Введите n:'))
    n_len =  n* 2 + 1 #Длина отрезка

    n_pozic1 = int(input(f'Введите 1 позицию от 0 до {n_len-1}: '))
    n_pozic2 = int(input(f'Введите 2 позицию от 0 до {n_len-1} и не равное {n_pozic1}: ' ))
    n_source = []

    #задаём исходный отрезок
    for i in range(-n, n+1):
        n_source.append (i)

    #считаем произведение
    print (n_source [n_pozic1]*n_source [n_pozic2])


# 5. Реализуйте алгоритм перемешивания списка.

def shuffle1 ():
    import random
    list = [1, 2, 3, 4, 5]
    random.shuffle(list)
    print (list)
