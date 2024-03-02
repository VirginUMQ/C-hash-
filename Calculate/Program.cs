// ====================================== Calculate ===========================================

double InputUserFormul (){
    Console.Clear();
    Console.WriteLine("========================== Примитивный калькулятор =======================");
    double ConvertUserForm = 0;
    for (int i = 0; i == 0;) {
    Console.Write("Введите формулу \n(используйте операции \"+\", \"-\", \"*\", \"/\", дробные числа вводите через \",\"): ");

    string? UserFormStr = Console.ReadLine();

    bool CheckInt = double.TryParse(UserFormStr, out ConvertUserForm);

    if (CheckInt) { i++; }
    else { Console.Clear(); Console.WriteLine("============= Вы ввели некорректную формулу, попробуйте еще раз =============\n"); }
}
return ConvertUserForm;
}


void PrintResult (double Calculate){
    Console.WriteLine("Ответ: " + "...:::Loading:::... КАЛЬКУЛЯТОР В РАЗРАБОТКЕ ...:::Loading:::...");
}


double Calculate = InputUserFormul();
PrintResult(Calculate);