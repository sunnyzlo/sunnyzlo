#ДЗ 3 Данные, функции и модули в Python
#1) Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.
#Пример: [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12
def sum_nechet():
    list = [2, 3, 7, 1, 10]
    sum =0
    for i in range(len(list)):
        if (i+1) %2 != 0: sum = sum + list[i]
    print (sum)


#2)Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
#Пример:
#- [2, 3, 4, 5, 6] => [12, 15, 16];
#- [2, 3, 5, 6] => [12, 15]

def sum_s_koncov():
    list = [2, 3, 7, 1, 10]
    cl = []
    for i in range(len(list)):
        if i <len(list)/2:
            sum = list[i] + list[len(list)-1-i]
            cl.append(sum)
    print (cl)

#3)Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным
# значением дробной части элементов.#Пример:
#- [1.1, 1.2, 3.1, 5, 10.01] => 0.19

def raznica():
    list = [1.801, 1.2, 3.1, 5, 10.01]
    list_after_dot = []
    max_len = 0
    for i in range(len(list)):
        if "." in str(list[i]):
            difference = list [i] - int (list [i])
            list_after_dot.append(round(difference,10))

    max = 0
    min = 1
    for i in range(len(list_after_dot)):
        if max < list_after_dot[i]: max = list_after_dot[i]
        if min > list_after_dot[i]: min = list_after_dot[i]

    print (max - min)


#4) Напишите программу, которая будет преобразовывать десятичное число в двоичное.
#Пример:
#- 45 -> 101101
#- 3 -> 11
#- 2 -> 10

def des_dvoich():
    desyatich = int(input('Введите десятичное число, а я переведу его в двоичное:  '))
    dvoich = ''

    while desyatich > 0:
        dvoich = str(desyatich % 2) + dvoich
        desyatich = desyatich // 2

    print(dvoich)


#5) Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов. Негафибоначчи
#Пример:
#- для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

def negafibonacci(n):
    if n in {0, 1}: return n
    elif n < 0: return negafibonacci(n + 2) - negafibonacci(n + 1)
    return negafibonacci(n - 1) + negafibonacci(n - 2)

for n in range(-6, 3):
   print (negafibonacci(n) )
