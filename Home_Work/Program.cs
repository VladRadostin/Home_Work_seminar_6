// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int numbers = Math.Abs(Convert.ToInt32(Prompt("Введите сколько чисел хотели бы ввести: ")));
double[] array = new double[numbers];
int Count = 0;

double Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    double result = Convert.ToDouble(value);
    return result;
}

for (int i = 0; i < array.Length; i++)
{
    array[i] = Prompt($"Введите число номер {i+1}: ");
    if (array[i] > 0)
    {
        Count++;
    }
}

Console.WriteLine(" ");
Console.WriteLine($"пользователь ввёл {Count} чисел больше 0");