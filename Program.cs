// Дз
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите число: ");
String number = Console.ReadLine()!;
int num1 = int.Parse(number);
Console.Write("Введите второе число: ");
number = Console.ReadLine()!;
int num2 = int.Parse(number);
if (num1 > num2)
    Console.WriteLine(num1);
else
    Console.WriteLine(num2);
*/

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Введите второе число: ");
String number = Console.ReadLine()!;
int num1 = int.Parse(number);
Console.Write("Введите второе число: ");
number = Console.ReadLine()!;
int num2 = int.Parse(number);
Console.Write("Введите третье число: ");
number = Console.ReadLine()!;
int num3 = int.Parse(number);
int max = num1;
if (num2 > max)max = num2;
if (num3 > max)max = num3;
    Console.WriteLine("Максимальное число = " + max);

*/

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0)
    Console.WriteLine("Четное ");
else
{
    Console.WriteLine($"Число:{num} нечетное");    
}
*/


// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine()); 
for (int i = 1; i <= n; i++)
{
if (i % 2 == 0)
Console.Write(i + ".");    
}
*/
