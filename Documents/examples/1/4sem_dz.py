
#4 дз

# 1) Вычислить число c заданной точностью d
# Пример:
# - при $d = 0.001, π = 3.141.$    $10^{-1} ≤ d ≤10^{-10}$

def chislo_vich ():
    chislo = 3.1415926535
    tochnost = 3
    promeg = str (chislo)
    chislo2 = float (promeg[:tochnost+2])
    print(chislo2)

# 2) Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.

def mnozhiteli ():
    number = int (input ("Введите число, а я найду его множители: "))

    list = []
    i = 2
    count = 0
    while i <= number:
        if number % i == 0:
            list.append(i)
            number //= i
            i = 2
            count +=1
        else: i += 1
    if count != 0 : print (f"Множители числа: {list}")
    else : print ("Множителей нет")


# 3) Задайте последовательность чисел. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности.
def nepovtor ():
    list = [1,3,4,1,3,1,5]
    list2 = []

    for i in range(len(list)):
        if list.count(i) == 1: list2.append(i)

    print (list2)


# 4) Задана натуральная степень k. Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена и записать в файл многочлен степени k.
# Пример:
# k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0

from random import randint
def stepeni ():

    k = 5
    list = []

    for i in range(k+1) :
        list.append(randint (0, 101))

    print(list)
    list2 = []

    for i in range(0, k+1):
        list2. insert(0, i)
    print(list2)
    list3 = []

    for i in range (k-1):
        list3.append(f'{list[i]}x^{list2[i]}')

    list3.append(f' {list[-2]}x')
    list3.append (list[-1])
    print (list3)
    final = ''

    for i in range(k):
        final = final + (f' {list3[i]} +')
    final = final + (f' {list3[-1]} = 0')
    print(final)

    with open('task_4_4.txt', 'w') as data: data.write(final )


# 5)Даны два файла, в каждом из которых находится запись многочлена. Задача - сформировать файл, содержащий сумму многочленов.

def readpoly (poly) :
    poly = poly[:poly.find ("=")]
    poly = poly.split("+")
    polynome1 = {}
    for part in poly:
        if part.count ('^') == 1:
            power = int (part[part.find('^') + 1:])
            if part.count ('*') == 1: const = int (part[:part.find('x') - 1])
            else: const = 1
        elif part.count('x') == 1:
            power = 1
            if part. count ('*') == 1: const = int(part[:part. find('x') - 1])
            else: const = 1
        else:
            power = 0
            const = int (part)

        polynome1 [power] = const
    return polynome1

def mnogochl_gen (dict_n):

        polynome = '=0'

        powers = sorted(dict_n.keys())
        print(powers)

        for pow_d in powers:
            const = dict_n[pow_d]
            if pow_d == 0:
                polynome = "+" + str(const) + polynome
            elif pow_d == 1:
                if const == 1:
                    polynome = "+x" + polynome
                else:  polynome = "+" + str(const) + "*×" + polynome
            else:
                if const == 1:
                    polynome ="+x^" + str(pow_d) + polynome
                else: polynome = "+" + str(const) + "*×^" + str(pow_d) + polynome

        polynome = polynome [1:]
        return polynome

def mnogochl ():
    path_1 = "task_4_5_1.txt"
    path_2 = "task_4_5_2.txt"

    file = open(path_1, "r")
    poly1 = file.readline()
    file.close()

    file = open(path_2, "r")
    poly2 = file.readline()
    file.close()

    print("Первый:",poly1, ". Второй:", poly2)

    poly_dic1 = readpoly(poly1)
    poly_dic2 = readpoly(poly2)

    print("Первый словарь:",poly_dic1, ". Второй словарь:", poly_dic2)

    sum_dic = {}
    for k in poly_dic1.keys() : sum_dic [k] = poly_dic1[k] + poly_dic2.get(k, 0)

    for k in poly_dic2.keys():
        if poly_dic1.get(k, 0) == 0: sum_dic[k] = poly_dic2[k]

    print ('Сумма: ',mnogochl_gen (sum_dic))
