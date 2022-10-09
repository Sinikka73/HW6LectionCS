//  Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double userB1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double userK1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите значение b2: ");
double userB2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double userK2 = Convert.ToInt32(Console.ReadLine());

if((userK1 - userK2) == 0)
    {
        Console.Write("Задача не имеет решения");
    }
    else
    {
        double coordX = (userB2 - userB1) / (userK1 - userK2);
        double coordY = userK1 * coordX + userB1;
        Console.WriteLine($"Точка пересечения с координатами Х = {coordX} и Y = {coordY}");
    }
