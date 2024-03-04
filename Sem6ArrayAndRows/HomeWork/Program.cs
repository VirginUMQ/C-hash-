// ====================================== Home work ===========================================

// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.
Console.WriteLine("\nЗадача 1.");

char [,] ArrChar = new char [2,3] {{'1','2','a'},
                                   {'b','5','6'} };
string StrChar = "";
for (int i = 0; i<ArrChar.GetLength(0); i++){
    for (int k = 0; k < ArrChar.GetLength(1); k++){
        StrChar += ArrChar[i,k];
    }
}
Console.WriteLine(StrChar);



// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

Console.WriteLine("\nЗадача 2.");
string StRi = "umqUMQumqUMQ";

string stri = StRi.ToLower(); // все строчные
Console.WriteLine(stri);
string STRI = StRi.ToUpper(); // все заглавные
Console.WriteLine(STRI);



// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
// Перевод консоли с utf-8 на utf-16 для того, чтобы ReadLine мог записать русские буквы

Console.WriteLine("\nЗадача 3.\nВведите произвольную строку: ");
string? UserStr = Console.ReadLine().ToLower();
UserStr = UserStr.TrimStart();
UserStr = UserStr.TrimEnd();
bool palindrom = true;
for (int i = 0; i < UserStr.Length / 2; i++) {
    if (UserStr[i] != UserStr[UserStr.Length - 1 - i]) { palindrom = false; }
}
if (palindrom) { Console.WriteLine(UserStr + " является палиндромом."); }
else { Console.WriteLine(UserStr + " не является палиндромом."); }



// Задача 4*(не обязательная): Задайте строку, состоящую из слов, разделенных пробелами. 
// Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.
Console.WriteLine("\nЗадача 4.");

string words = "Слово не воробей";
string [] ArrWords = words.Split(" ");
string sdrow = "";
for (int i = ArrWords.Length-1; i >= 0; i--){
    sdrow += ArrWords[i] + " ";
}
Console.WriteLine(sdrow);

