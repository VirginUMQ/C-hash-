// ======================================== ДОМАШКА ============================================

// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("\n ================================= ДОМАШНЕЕ ЗАДАНИЕ ===================================\nЗадача 2.\n\n.::СОЗДАНИЕ МАССИВА::.\n");

int[] CreateRndArr (int min, int max, int size)
{
    int [] arr = new int [size];
    for (int i = 0; i < size; i++) {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int InputMin () {
    Console.Write(".::Ввод диапазона массива::. Введите минимальное значение: ");
    int minNumUser = Convert.ToInt32(Console.ReadLine());
    return minNumUser;
}

int InputMax () {
    Console.Write(".::Ввод диапазона массива::. Введите максимальное значение: ");
    int maxNumUser = Convert.ToInt32(Console.ReadLine());
    return maxNumUser;
}

int InputSize () {
        Console.Write(".::Ввод размера массива::. Введите количество элементов массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    return size;
}

void PrintArray (int[] array) {
    Console.Write("Рандомный массив: ");
    for (int i = 0; i < array.Length; i++) {
        Console.Write(array[i] + " ");
    }
}

int CalcEvenNum (int[] array) {
    int EvenNum = 0;
    for(int i = 0; i < array.Length; i++){
        if ( array[i] % 2 == 0 ) { EvenNum += 1; }
    }
    return EvenNum;
}

int CalcOddNum (int[] array){
    int OddNum = 0;
    for(int i = 0; i < array.Length; i++){
        if ( array[i] % 2 != 0 ) { OddNum += 1; }
    }
    return OddNum;
}

void PrintEvenOdd (int even, int odd){
    Console.WriteLine("\nКоличество четных: " + even);
    Console.WriteLine("Количество нечетных: " + odd);
}



int min = InputMin();
int max = InputMax();
int size = InputSize();
int[] array = CreateRndArr(min, max, size);
PrintArray(array);
int even = CalcEvenNum(array);
int odd = CalcOddNum(array);
PrintEvenOdd(even, odd);



