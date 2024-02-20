//=================================== УСЛОВИЯ (if - else): ======================================
// if (условие) { действие }
// else { действие }



//======================================= ЦИКЛЫ (for) ===========================================
//     переменная|условие выхода|действие
// for (int i = 0; i < ar.Length; i++) 
// { действие }



// Задача про наибольшее значение:
int [] ar = {10, 20, -2, 220, 0, 1, 110};
int INDmax = 0;
for (int i = 0; i < ar.Length; i++) 
{
    if (ar[i] > ar[INDmax]) 
    { 
        INDmax = i;
    }
}
Console.WriteLine("Наибольшее число в массиве \"ar\": " + ar[INDmax]);



//==================== ВВОД ДАННЫХ ОТ ПОЛЬЗОВАТЕЛЯ (Console.ReadLine()) =========================
// Console.Write("Как тебя зовут? ");
// string? user = Console.ReadLine(); --- знак "?" указывает, что переменная может хранить значение null
// Console.WriteLine("Привет, " + Convert.ToString(user));

// Convert.ToInt32() (преобразует к типу int)
// Convert.ToDouble() (преобразует к типу double)
// Convert.ToDecimal() (преобразует к типу decimal

Console.Write("Как тебя зовут? [ENG] ");
string? user = Console.ReadLine(); 
Console.WriteLine("Привет, " + Convert.ToString(user));



// Задача про натуральные числа до N:
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Все натуральные числа до числа " + N + " включительно: ");
for (int i = 1; i < N; i++)
{
Console.Write(i + ", ");
}
Console.Write(N + ".");



// Задача ДЗ: 
int a = 10;
int b = 5;
int c = 4;
int d = 6;
float res = a*b/(c+d);
Console.WriteLine("\nДомашнее задание: " + res);
