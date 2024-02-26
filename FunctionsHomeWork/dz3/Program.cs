// ======================================== ДОМАШКА ============================================

// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

Console.WriteLine("\n ================================= ДОМАШНЕЕ ЗАДАНИЕ ===================================\nЗадача 3.\n");

void PrintArray (int[] arr){
    Console.Write("\nМассив: ");
    for (int i = 0; i < arr.Length; i++){
        Console.Write(arr[i] + " ");
    }
}

int[] reverseArr (int [] arr){
    int[] rra = new int [arr.Length];
    int num = 0;
    for (int i = 0; i <= arr.Length / 2 ; i++){
        num = arr[i];
        rra[i] = arr[arr.Length - 1 - i];
        rra[arr.Length - 1 - i] = num;
    }
    return rra;
}

void PrintReverseArray (int[] rra){
    Console.Write("\nПеревернутый массив: ");
    for (int i = 0; i < rra.Length; i++){
        Console.Write(rra[i] + " ");
    }
}


int[] arr = {124, 346, 568, 6789, 234, 25, 568, 67, 9, 78, 0, 1};
PrintArray(arr);
int[] rra = reverseArr(arr);
PrintReverseArray(rra);

