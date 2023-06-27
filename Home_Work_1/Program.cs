// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

double b1 = Prompt("ведите точку прямой b1: ");
double k1 = Prompt("ведите точку прямой k1: ");

double b2 = Prompt("ведите точку прямой b2: ");
double k2 = Prompt("ведите точку прямой k2: ");



Console.Clear();



double y = 0;
double x = 0;

Console.WriteLine($"точки прямой: k1 = {k1} , b1 = {b1} ; k2 = {k2} ; b2 = {b2}");


x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

Console.Write($"x = {x} ");
Console.Write($"y = {y} ");

Console.WriteLine(" ");
Console.WriteLine($"точки пересечения двух прямых ({x} ; {y})");
