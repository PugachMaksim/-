// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int n = 2;
int A;
bool iskl = false;

Console.WriteLine("Введите число ");
iskl = int.TryParse(Console.ReadLine()!, out A);
if (iskl == true)
{
    while (n <= A)
    {
        Console.Write($"{n} ");
        n += 2;
    }
}
else Console.WriteLine($"неверный ввод");