// ЕСЛИ ТИПЫ ДАННЫХ ОДИНАКОВЫЕ, ТО И summ БУДЕТ ИМЕТЬ ТИП ДАННЫХ int
int a1 = 10;
int a2 = 15;
int summ = a1 + a2;
Console.WriteLine(summ);

// ЕСЛИ ТИПЫ ДАННЫХ РАЗНЫЕ(int - long | double + int), 
// ТО summ2 БУДЕТ ИМЕТЬ ТИП ДАННЫХ С БОЛЬШИМ РАЗМЕРОМ(long)
long l1 = 5;
long summ2 = a2 - l1;
Console.WriteLine(summ2);

double d1 = 4.4;
double summ3 = d1 + a1;
Console.WriteLine(summ3);

int product1 = a1 * a2;
long product2 = a1 * l1;
Console.WriteLine(product1);
Console.WriteLine(product2);


// ДЕЛЕНИЕ
int delenie = a2 / a1; // int в этом случае неверно, будет выводиться только целое число (1)
// Для деления нужно чтобы хотя бы одна переменная имела вещественный тип данных
// и delenie2 тогда тоже можно будет определить как вещественный тип данных
double d2 = 10;
double delenie2 = a2 / d2;
Console.WriteLine(delenie);
Console.WriteLine(delenie2);