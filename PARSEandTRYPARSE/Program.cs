// ===================== ИСКЛЮЧЕНИЯ ДАННЫХ ОТ ПОЛЬЗОВАТЕЛЯ (TryParse) ===========================
Console.Write("\nИсключение данных от пользователя (TryParse).\nПрограмма не даст ввести символы, а также ненатуральное число.\n");

for ( bool i = false; i == false; ) { 
    Console.Write("Введите натуральное число: ");
    string? strCountEl = Console.ReadLine();
    i = int.TryParse(strCountEl, out var ggg); // - попытается преобразовать
// полученную строку от пользователя в int. Если успешно - вернет true, в противном случае - false.
    
    if ( i == true) {
    int CountEl = int.Parse(strCountEl);
    if ( CountEl <= 0 ) { i = false; } // если число <= 0, то i = false
    } 
} // ПРАВДА ХЗ КАК ВЫВЕСТИ CountEl ЗА ЦИКЛ НЕ МЕНЯЯ КОД, ЧТОБЫ РАБОТАТЬ С ПЕРЕМЕННОЙ ДАЛЬШЕ
