// ================================== Массивы и строки ========================================

// string test1 = null; // строка без значения
// string test2 = ""; // пустая строка // string test2 = String.Empty;

// string testNULL = null;
// bool flag = string.IsNullOrEmpty(testNULL); // проверка пустая ли строка
// Console.WriteLine(flag);

// string testSpace = "\n     \t";
// bool flag2 = string.IsNullOrWhiteSpace(testSpace); // проверка на пробелы
// Console.WriteLine(flag2);

// string test3 = new string('x', 5); // xxxxx
// string test4 = new string(new [] {'H', 'e', 'l', 'l', 'o', '!'}); // Hello!

// Console.WriteLine(test1);
// Console.WriteLine(test2);
// Console.WriteLine(test3);
// Console.WriteLine(test4);

// --------------------------------------------------------------------------------------------

int [] Array = new int [] {1,2,3,4,5};
                 // разделитель, массив
string ArrStr = string.Join(", ", Array); // Записать массив в строку
Console.WriteLine(ArrStr);

string Trim = "     TRIM TEST     ";
Console.WriteLine(Trim.Trim());
Console.WriteLine(Trim.TrimStart());
Console.WriteLine(Trim.TrimEnd());
Console.WriteLine(Trim.Trim(' ', 'T'));

string separator = "1,2,3,4,5";
string [] sepStr = separator.Split(","); // Создать массив из строки, элементы в массиве берутся из строки до запятой
foreach (string item in sepStr){
    Console.WriteLine(item);
}

string GB = "Geek Brains";
Console.WriteLine(GB.Substring(0,4));
Console.WriteLine(GB.Substring(5));

