// ======================= Создание рандомного двумерного массива ===============================
//                                         строки    колонны
int [,] Create2dArray(int min, int max, int rows, int cols){
    int [,] array = new int [rows,cols];
    for(int i=0; i<rows;i++){
        for(int j=0; j<cols;j++){
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}

void Show2dArray(int [,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int summDiag (int [,] array){
    int summ = 0;
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1);j++){
            if (i == j){
                summ += array[i,j];
            }
        }
    }
    return summ;
}

void printSummDiag(int summ){
    Console.WriteLine("Сумма элементов на главной диагонали: " + summ);
}

float [] CreateNewArray (int [,] array){
    float summ = 0;
    float [] NewArray = new float [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            summ = summ + array[i, j];
        }
    NewArray[i] = summ / array.GetLength(1);
    summ = 0;
    }
    return NewArray;
}

void PrintNewArr (float [] NewArray){
    Console.Write("Новый массив из среднего арифметического значения каждой строки массива: ");
    foreach (float i in NewArray){
        Console.Write(i + " ");
    }
}

Console.Clear();

Console.WriteLine("Input min value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input rows count:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input cols count:");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] array = Create2dArray(min,max,rows,cols);
Show2dArray(array);


// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

printSummDiag(summDiag(array));

PrintNewArr(CreateNewArray(array));