//  Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

int[] getUserArray(int length)
{
    Console.WriteLine();
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Задайте элемент {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void printArray(int[] arrayToPrint)
{
    Console.WriteLine();
    Console.Write("В полученном ряду  [");
    
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if(i < arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.WriteLine();
}

int numberOfPositiveElements(int[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if(inputArray[i] > 0)
        {
            count = count + 1;
        } 
    }
    return count;
}

Console.WriteLine();
Console.Write("Задайте количество элементов массива: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int[] currenArray = getUserArray(userNumber);
printArray(currenArray);
int result = numberOfPositiveElements(currenArray);
Console.Write($"количество положительных элементов: {result}");
