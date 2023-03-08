// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int num;
bool iskl = false;

Console.WriteLine("Введите число ");
iskl = int.TryParse(Console.ReadLine()!, out num);
if (iskl == true)
    {
        if (num % 2 != 0)
        {
        Console.Write(num);
        Console.Write(" - ");
        Console.Write("нечетное число");
        }
        else
        {
        Console.Write(num);
        Console.Write("  ");
        Console.Write("четное число");
        }
    }
else Console.WriteLine($"неверный ввод");