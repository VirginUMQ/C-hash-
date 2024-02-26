// ====================================== Задача 1: ============================================
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

Console.Write("\nЗадание 1.\nВведите число, которое кратно одновременно 7 и 23: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 % 7 == 0 & num1 % 23 == 0) { Console.WriteLine("Верно!"); }
else { Console.WriteLine("Неверно!"); }



// ====================================== Задача 2: ============================================
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

Console.Write("\nЗадание 2.\n");

int X;
for (X = 0; X == 0;) {
    Console.Write("Введите точку координаты \"X\" (не равную \"0\"): ");
    X = Convert.ToInt32(Console.ReadLine());
}

int Y;
for (Y = 0; Y == 0;) {
    Console.Write("Введите точку координаты \"Y\" (не равную \"0\"): ");
    Y = Convert.ToInt32(Console.ReadLine());
}

if (X > 0 & Y > 0) { Console.Write("Точка координат XY находится в I координатной четверти плоскости."); }
if (X < 0 & Y > 0) { Console.Write("Точка координат XY находится во II координатной четверти плоскости."); }
if (X < 0 & Y < 0) { Console.Write("Точка координат XY находится в III координатной четверти плоскости."); }
if (X > 0 & Y < 0) { Console.Write("Точка координат XY находится в IV координатной четверти плоскости."); }



// ====================================== Задача 3: ============================================
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

Console.Write("\n\nЗадание 3.\n");

int num1099 = 0;
for (int i = 0; i == 0;) {
    Console.Write("Введите число от 10 до 99 включительно: ");
    num1099 = Convert.ToInt32(Console.ReadLine());
    if (num1099 < 10 || num1099 > 99) {  } 
    else { i++; }
}

int numFirst = num1099 / 10;
int numSecond = num1099 % 10;
Console.Write("Сравнение цифр этого числа: \n");
if (numFirst == numSecond) { Console.Write(numFirst + " = " + numSecond); }
else if (numFirst > numSecond){ Console.Write(numFirst + " > " + numSecond); }
else { Console.Write(numFirst + " < " + numSecond); }



// ====================================== Задача 4: ============================================
// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

Console.Write("\n\nЗадание 4.\n");

long Natur = 0;
for (int i = 0; i == 0;){
    Console.Write("Введите натуральное число: ");
    Natur = Convert.ToInt64(Console.ReadLine());
    if (Natur > 0) { i++; }
}

string NaturStr = Convert.ToString(Natur);
for (int i = 0; i < NaturStr.Length;){
    Console.Write(NaturStr[i]);
    i++;
    if (i < NaturStr.Length) { Console.Write(", "); }
    else { Console.Write("."); }
} 


// --------------- РЕШЕНИЕ ГРУПАША (СКОРЕЕ ВСЕГО ТО, ЧТО ОЖИДАЛОСЬ): ----------------------------

// Console.Write("Введите целое число: ");
// int usernum = Convert.ToInt32(Console.ReadLine()); 
// int usernumfake = usernum; 
// int l = 1;

// while( usernumfake != 0 ) {
//     usernumfake = usernumfake / 10; 
//     l = l * 10; 
// }

// while (l > 1) { 
//     l = l / 10;
//     usernumfake = usernum / l; 
//     if (l > 1) {
//         Console.Write(usernumfake + ", ");
//         usernum = usernum % l;
//     }
//     else {
//         Console.Write(usernumfake + ".");
//     }
// }





