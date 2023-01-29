package JAVA;
import java.util.Scanner;
import java.time.LocalDateTime;


public class lesson1 {
    
    public static void main(String[] args){
//дз 1 
    //1. Вычислить n-ое треугольного число(сумма чисел от 1 до n), n! (произведение чисел от 1 до n) тр 5 = 1+2+3+4+5


    Scanner input = new Scanner (System.in); 
    System.out.println("Введите n для вычисления n-ое треугольного числа:");
    int n = input.nextInt(); 
    int sum = 0; 
    input.close();
    if (n <= 0){
        System.out.println("Нет, похоже нужно ввести положительное число");
    } 
    else {
        sum = n * (n + 1) / 2;
        System.out.println(sum);
        }

    // 2. Вывести все простые числа от 1 до 1000
    System.out.println("Введите положительное число: ");
    Scanner n = new Scanner(System.in);
    int input = n.nextInt();
    n.close();    

    boolean b = true;
    for (int prost = 2; prost <= input; prost++) {
        for (int i = 2; i <prost; i++) {
            if (prost % i == 0) {
                b = false;
                break;
            }
        }
        if (b) System.out.println(prost);
        else b = true;
    
    }

    
    //3. Сделать простой калькулятор

            System.out.println("Введите первое число, потом после Enter другое:");
            Scanner inp= new Scanner(System.in);
            int num1 = 0;
            int num2 = 0;            
            num1 = inp.nextInt();
            num2 = inp.nextInt();
            int ans = 0;
            
            System.out.println("Выберите действие: 1 Сложить, 2 Вычесть 3 Умножить и 4 Разделить:");
            int choose;
            choose = inp.nextInt();
            switch (choose){
            case 1:
                System.out.println(add( num1,num2));
                break;
            case 2:
                System.out.println(sub( num1,num2));
                break;      
            case 3:
                System.out.println(mult( num1,num2));
                break;
            case 4:
                System.out.println(div( num1,num2));
                break;
                default:
                    System.out.println("Что-то не так");

            }

        }
        public static int add(int x, int y)
        {
            int result = x + y;
            return result;
        }
        public static int sub(int x, int y)
        {
            int result = x-y;
            return result;
        }
        public static int mult(int x, int y)
        {
            int result = x*y;
            return result;
        }
        public static int div(int x, int y)
        {
            int result = x/y;
            return result;

    }
}
