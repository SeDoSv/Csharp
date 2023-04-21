// // Напишите программу, которая на вход принимает число и выдаёт его квадрат (число, умноженное на само себя)

// // Например:
// // 4 -> 16
// // -3 -> 9
// // -7 -> 49

Console.WriteLine($"Введите число:");
double num = Convert.ToInt32(Console.ReadLine());
if (num > 10)
{
    Console.WriteLine($"more then 10");
}
else
{
    Console.WriteLine($"less then 10");
}
//Console.WriteLine($"Result: {num % 4}");



// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Write("Введите первое число ");
Console.WriteLine("и затем введите второе число:");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2)
{
    Console.WriteLine("Певрое число является квадратом второго числа");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго числа");
}



// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Введите номер дня недели:");
int num = Convert.ToInt32(Console.ReadLine());
 if (num == 1)
 {
    Console.WriteLine("Monday");
 }
 if (num == 2)
 {
    Console.WriteLine("Tuesday");
 }
 if (num == 3)
 {
    Console.WriteLine("Wednesday");
 }
 if (num == 4)
 {
    Console.WriteLine("Thursday");
 }
 if (num == 5)
 {
    Console.WriteLine("Friday");
 }
 if (num == 6)
 {
    Console.WriteLine("Saturday");
 }
 if (num == 7)
 {
    Console.WriteLine("Sunday");
 }

 //or

Console.Write("Введите номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());

string[] mas = {"понедельник", "вторник", "среда", "четверг", "пятница", "суббота", "воскресение"};

if (num < 8 && num > 0)
{
    Console.WriteLine($"День недели: {mas[num-1]}");
}
else
{
    Console.WriteLine("В неделе только 7 дней, болван!");
}



// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 99 && num < 1000)
{
    Console.WriteLine(num % 10);
}
else
{
    Console.WriteLine("Я просил ввести трёхначное число! Начните заново, пожалуйста.");
}