// ======================================== ДОМАШКА ============================================

// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

Console.WriteLine("\n ================================= ДОМАШНЕЕ ЗАДАНИЕ ===================================\nЗадача 1.");

// Без функций:
// for (int i = 0; i == 0;){
//     Console.Write("Введите целое число (чтобы перейти к следующему заданию,\nвведите \"q\" или число, сумма цифр которого четная): ");
//     string? UserNumStr = Console.ReadLine();
    
//         if (UserNumStr == "q"){ i++; }
//         else {
//     int UserNumInt = Convert.ToInt32(UserNumStr);
//     bool Chet = false;
//     int summ = 0;
//     for(int a = 0; a < UserNumStr.Length; a++){
//         summ = summ + Convert.ToInt32(UserNumStr[a]);
//     }
//     if (summ % 2 == 0) { Chet = true; }

//     if (Chet == true){ i++; }
// }
// }

// Функции:

string InputData () {
    Console.Write("Введите целое число (чтобы завершить, введите \"q\" или число,\nсумма цифр которого четная): ");
    string UserNumStr = Console.ReadLine();
    return UserNumStr; 
}

int ConvertToIntAndSumm (string UserNumStr){
    int summ = 0;
    for(int a = 0; a < UserNumStr.Length; a++){
        summ = summ + (Convert.ToInt32(UserNumStr[a]));
    }
    return summ;
}

bool SummChet (int summ){
    bool Chet = false;
    if (summ % 2 == 0) { Chet = true; }
    else { Chet = false;}
    return Chet;
}

void ToRun(){
for (int i = 0; i == 0;) {
string UserNumStr = InputData();
if (UserNumStr == "q") { i ++; }
else {
int summ = ConvertToIntAndSumm(UserNumStr);
bool Chet = SummChet(summ);
if (Chet) { i++; }
}
}
}

ToRun();
