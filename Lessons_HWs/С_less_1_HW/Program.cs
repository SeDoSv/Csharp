// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($"Максимальным из введённых чисел является {num1}");
// }
// else
// {
//     Console.WriteLine($"Максимальным из введённых чисел является {num2}");
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("Введите три числа: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2 && num1 > num3)
// {
//     Console.WriteLine($"Число {num1} - наибольшее");
// }
// if (num2 > num1 && num2 > num3)
// {
//     Console.WriteLine($"Число {num2} - наибольшее");
// }
// if (num3 > num1 && num3 > num2)
// {
//     Console.WriteLine($"Число {num3} - наибольшее");
// }


// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 0)
// {
//     Console.WriteLine("Введите число, отличное от нуля");
//     Int32.TryParse(Console.ReadLine(), out num);
// }
// if (num % 2 == 0)
// {
//     Console.WriteLine("Число является чётным");
// }
// else
// {
//     Console.WriteLine("Число является нечётным");
// }


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


Console.Write("Введите целое положительное число, отличное от нуля: ");
int num = Convert.ToInt32(Console.ReadLine());
do
{
    if (num <= 0)
    {
        Console.Write("Число не может быть отрицательным или равным нулю! Введите число заново: ");
        Int32.TryParse(Console.ReadLine(), out num);
    }
}while(num <= 0); 
for (int i = 1; i < num+1; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " ");
    }
}

