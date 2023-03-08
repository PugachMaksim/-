// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int numA;
int numB;
int numC;
bool iskl = false;

Console.WriteLine($"Введите первое число A ");
iskl = int.TryParse(Console.ReadLine()!, out numA);
if (iskl == true)
{
    Console.WriteLine("Введите второе число B ");
    iskl = int.TryParse(Console.ReadLine()!, out numB);
    if (iskl == true)
    {
        Console.WriteLine("Введите третье число C ");
        iskl = int.TryParse(Console.ReadLine()!, out numC);
        if (iskl == true)
        { 
            if (numA > numB)
            {
                if (numA > numC)
                {
                    Console.Write("max = ");
                    Console.WriteLine(numA);
                }
                else 
                {
                    Console.Write("max = ");
                    Console.WriteLine(numC);
                }
            }
            else 
                if (numB > numC)
                {
                Console.Write("max = ");
                Console.WriteLine(numB);
                }
                else 
                {
                Console.Write("max = ");
                Console.WriteLine(numC);
                }
        }
        else Console.WriteLine($"неверный ввод"); 
    }
    else Console.WriteLine($"неверный ввод");
}
else Console.WriteLine($"неверный ввод");