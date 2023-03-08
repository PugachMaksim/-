// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3 
int numA;
int numB;
bool iskl = false;

Console.WriteLine($"Введите первое число A ");
iskl = int.TryParse(Console.ReadLine()!, out numA);
if (iskl == true)
{
    Console.WriteLine("Введите второе число B ");
    iskl = int.TryParse(Console.ReadLine()!, out numB);
    if (iskl == true)
    {
        if (numA > numB)
        {
        Console.Write(numA);
        Console.Write(" = ");
        Console.Write("max");
        }
        else
        {
        Console.Write(numB);
        Console.Write(" = ");
        Console.Write("max");
        }
    }
    else Console.WriteLine($"неверный ввод");
}
else Console.WriteLine($"неверный ввод");