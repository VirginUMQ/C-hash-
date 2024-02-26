// Создание функции(метода) заполнения массива рандомными числами:
int [] CreateRandomArray (int min, int max, int size) {
int[] array = new int [size];

for(int i = 0; i < size; i++){
    array[i] = new Random().Next(min, max+1); // создание рандомного массива
}

return array;
} 


// Создание функции(метода) вывода массива в терминал:
void ShowArray(int[] array){
    Console.Write("Ваш рандомный массив: ");
    foreach (int i in array){
        Console.Write(i + " ");
    }
}

Console.Write("\nОнлайн урок. Функции 2.\nСоздание рандомного массива. Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон. Минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите диапазон. Максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(min, max, size);
ShowArray(array);

int kch = 0;
for(int i = 0; i < size; i++){
    if (i % 2 == 0) { kch ++; }
}
Console.WriteLine("\nЧетных: " + kch);

int knch = 0;
for(int i = 0; i < size; i++){
    if (i % 2 != 0) { knch ++; }
}
Console.WriteLine("Нечетных: " + knch);