#6sem
# Ввести список целых чисел, оставить в  только двузначные, сделать через filter

def filter_2 ():
    str_num = list(filter(lambda x: len(str(abs(int(x))))==2, input("Введите числа: ").split()))
    print (*str_num)

# вывести отдельно буквы и цифры из списка
def bukvi_cifr ():
    a = ("a", "v", "3", "d", "1" )

    b= filter(str.isalpha, a)
    c= filter (str.isdigit, a)
    print (*b)
    print (*c)


# Преобразовать набор списков
# users = ['user1','user2','user3','user4','user5']
# ids = [4, 5, 9, 14, 7]
# salary = [111,222,333] в другой набор

# ['user1', 4, 111]
# ['user2', 5, 222]
# ['user3', 9, 333] и потом вернуть в исходное состояние

# ['user1', 'user2', 'user3']
# [4, 5, 9]
# [111, 222

def spiska_3 ():
    users = ['user', 'user2', 'user3', 'user4', 'users']
    ids = [4, 5, 9, 14, 7]
    salary = [111,222, 333]

    a,b,c = map(list,zip (users, ids, salary))
    print(a,b,c, sep="\n")

    a,b,c= map(list,zip (a,b,c))
    print(a,b,c, sep="\n")
