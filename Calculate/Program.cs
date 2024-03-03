// ====================================== Calculate ===========================================

// #заброшено

// - записать в строку, проверить на символы
// - пройтись циклом по ней до пробела или знаков + - * / 
// - записать отдельные части в массив, ar[0] = число до пробела/знака, ar[1] = число от пробела/знака до пробела/знака/конца
// - условия в зависимости от знаков, ar[0] * ar[1] / ar[2] и т.д. => ответ

double InputUserFormul (){
    Console.Clear();
    Console.WriteLine("=========================== Примитивный калькулятор ========================");
    double ConvertUserForm = 0;
    for (int i = 0; i == 0;) {
    Console.Write("\t\t\t\tВведите формулу \n(используйте операции \"+\", \"-\", \"*\", \"/\", дробные числа вводите через \",\"): ");

    string? UserFormStr = Console.ReadLine();

    bool CheckInt = double.TryParse(UserFormStr, out ConvertUserForm);

    if (CheckInt) { i++; }
    else { Console.Clear(); Console.WriteLine("================ Вы ввели некорректную формулу, попробуйте еще раз =============="); }
}
return ConvertUserForm;
}





void PrintResult (double Calculate){
    Console.WriteLine("Ответ: " + "...:::Loading:::... КАЛЬКУЛЯТОР В РАЗРАБОТКЕ ...:::Loading:::...");
}


double Calculate = InputUserFormul();

PrintResult(Calculate);