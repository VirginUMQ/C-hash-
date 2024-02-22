// =============================== УРОК ОНЛАЙН. МАССИВЫ. ========================================

// ЗАДАЧИ НА УРОКЕ:



// Задача 1. Создать массив и написать программу, которая ищет есть ли определенное число в массиве

Console.WriteLine("\nЗадачи на уроке.\nЗадача 1.");
    Console.Write("Создание массива. Введите количество элементов в массиве: ");
    int countAr = Convert.ToInt32(Console.ReadLine()); 
int[] arrayNums = new int [countAr];
for (int i = 0; i < arrayNums.Length ; i++) { 
    Console.Write($"Создание массива. Введите значение индексу {i}: ");
    arrayNums[i] = Convert.ToInt32(Console.ReadLine()); 
 }
Console.Write("Введите число, которое нужно найти в массиве: ");
int numFind = Convert.ToInt32(Console.ReadLine()); 

bool flag = false;

foreach (int item in arrayNums) {
    if (item == numFind){
        flag = true;
    }
}

if (flag){ Console.Write($"В массиве есть {numFind}."); }
else { Console.Write($"В массиве нет {numFind}."); }



// Задача 2. Задайте массив из 10 элементов, заполненный числами из промежутка [-10, 10].
// Замените отрицательные элементы на положительные, а положительные на отрицательные.

Console.WriteLine("\n\nЗадача 2.");
int[] ar2 = new int [6];
for (int i = 0; i < ar2.Length;){
    Console.Write($"Создание массива. Введите значение для элемента с индексом {i} (от -10 до 10): ");
    int numAr2 = Convert.ToInt32(Console.ReadLine());
    ar2[i] = numAr2;
    if (numAr2 >= -10 & numAr2 <= 10) {i++;}
}

Console.Write("Ваш массив: ");
for (int i = 0; i < ar2.Length; i++){
    
    Console.Write(ar2[i]);
    if (i < ar2.Length - 1) { Console.Write(", "); }
    else { Console.Write("."); }
}

int[] minusAr2 = new int [ar2.Length];
Console.Write("\nМассив (*-1): ");
for (int i = 0; i < ar2.Length; i++){
    minusAr2[i] = ar2[i] * -1;
    Console.Write(minusAr2[i]);
    if (i < ar2.Length - 1) { Console.Write(", "); }
    else { Console.Write("."); }
}



// Задача 3. Найдите произведения пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новый массив. (СОЕДЕНИЛ С ЗАДАЧЕЙ 2)
// Пример:
// [1 3 2 4 2 3] => [3 6 8]
// [2 3 1 7 5 6 3] => [6 18 5] (элемент 7 не имеет пары)

Console.WriteLine("\n\nЗадача 3. (Продолжение задачи 2.)");
int[] newAr3 = new int [ar2.Length/2];
for (int i = 0; i < ar2.Length / 2; i++) {
    newAr3[i] = ar2[i] * ar2[ar2.Length - 1 - i];
    Console.WriteLine($"Произведение пары элементов вашего массива ({ar2[i]} и {ar2[ar2.Length - 1 - i]}): {newAr3[i]}");
}



