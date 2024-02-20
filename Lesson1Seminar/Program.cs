// ================================== Задачи на уроке ==========================================



// Задача 1:
Console.Write("\nЗадача 1:\nВведите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());
if(first*first == second) {
    Console.Write("Первое число является квадратом второго.");
}
else{
    Console.Write("Первое число не является квадратом второго.");
}



// Задача 2:
Console.Write("\n\nЗадача 2:\nВведите положительное число: ");
int nN = Convert.ToInt32(Console.ReadLine());
int n = -nN;
Console.WriteLine("Ниже представлены все числа от " + n + " до " + nN + " включительно:");
for(int i = n; i < nN; i++){
    Console.Write(i + ", ");
}
Console.Write(nN + ".");



// Задача 3:
Console.Write("\n\nЗадача 3:\nВведите положительное трехзначное число: ");
int XXX = Convert.ToInt32(Console.ReadLine());
int X1 = XXX / 100;
// От души
int X2 = XXX / 10 % 10;
int X3 = XXX % 10;
Console.Write("Сумма всех цифр этого числа равна " + (X1 + X2 + X3) + ".");



// Домашнее задание. Задача 1:
 Console.WriteLine("\n\nДомашнее задание. Задача 1:\nВведите первое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num1 > num2){
     Console.WriteLine(num1 + " больше " + num2 + ".");
    }
    else if (num1 == num2) {
    Console.WriteLine(num1 + " равно " + num2 + ".");
    }
    else {
    Console.WriteLine(num2 + " больше " + num1 + ".");
    }

