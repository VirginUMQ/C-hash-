// ====================================== РЕКУРСИЯ ============================================

// Рекурсия (recursion) — это поведение функции, при котором она вызывает сама себя. 
// Такие функции называются рекурсивными. В отличие от цикла, 
// они не просто повторяются несколько раз, а работают «внутри» друг друга.
// Известная шутка гласит: «Чтобы понять рекурсию, надо понять рекурсию».


int InputUser () 
{
    int UserNum = 0;
    for(bool i = false; i == false;){
    i = int.TryParse(Console.ReadLine(), out UserNum);
    if (i == false | UserNum < 0) { Console.Write("Введите целое положительное число: "); i = false; }
}
return UserNum;
}

int FUCKtorial (int Fu)
{
if (Fu == 1 || Fu == 0) { return 1; } 

return Fu * FUCKtorial(Fu-1); 
}

void PrintResFuck (int resFu)
{
    Console.WriteLine("Факториал равен: " + resFu);
}


Console.Write("\n=============== РЕКУРСИЯ ===============\nЗадача 1. Нахождение факториала\nВведите число: ");

PrintResFuck(FUCKtorial(InputUser()));
// int UserNum = InputUser();
// int resultFu = FUCKtorial(UserNum);
// PrintResFuck(resultFu);



// ===================================== ОТЛАДКА ==============================================
// Отладка - процесс поиска и исправления ошибок в программном коде
Console.Write("\n=============== ОТЛАДКА ===============");
// ДЗ: ДОБАВИТЬ В КОД ОТЛАДОЧНЫЙ ВЫВОД РАСКРУЧИВАНИЯ РЕКУРСИИ

int OTLADKA (int dzNum) 
{
if (dzNum == 0 || dzNum == 1) { return 1; }

int res = dzNum * OTLADKA(dzNum-1);
Console.WriteLine(dzNum + "! = " + res + " ");
return res;
}

Console.WriteLine("\nРаскручивание рекурсии: ");
PrintResFuck(OTLADKA(8));

