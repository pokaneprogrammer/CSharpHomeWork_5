// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

 int Prompt(string message)
 {
    Console.ForegroundColor = ConsoleColor.White;

    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
 }


int[] ArrayFill(int size)
{
    int i = 0;
    int[] array = new int[size];
    while (i < size)
    {
        array[i] = new Random().Next(99, 1000);
        i++;
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1) { System.Console.Write(", "); }
    }

    System.Console.Write("]");
   
}


int EvenNumberCounter(int[] array)
{
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 ==0) { evenCount++; };
    }
    return evenCount;
}

//-----------------------------------------------------------------------------------//

int sizeArray = Prompt("Введите размер массива : ");
for (int i = 0; i < 4; i++) // Чтобы не вызывать 4 раза Dotnet
{
    int[] newArray = ArrayFill(sizeArray);
    PrintArray(newArray);
    System.Console.Write(" -> ");
    System.Console.WriteLine(EvenNumberCounter(newArray));
}