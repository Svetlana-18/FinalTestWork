// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//  длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//  либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//  лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Введите размер массива (целое положительное число)");

int size = Convert.ToInt32(Console.ReadLine());
string[] array1 = new string[size];
void CreationArray(string[] array1)
{
    int count = 0;

    for (int i = 0; i < size; i++)
    {
        if (array1[i] != " ")
            Console.WriteLine($"Введите {i + 1}-й элемент массива");
        array1[i] = Console.ReadLine()!;
        count++;
    }

}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            Console.Write($"{arr[i]} ");
    }

    Console.WriteLine();
}

CreationArray(array1);

PrintArray(array1);

