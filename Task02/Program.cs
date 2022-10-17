// Напишите программу, которая 
// 1. На вход принимает два числа: 
//    num1 и num2 
// 2. Выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 < num2)
{
    Console.WriteLine($"Число максимум:{num1}");
}
else { Console.WriteLine($"Число максимум:{num2}"); }
if (num1 = num2)
{ Console.WriteLine($"Число максимум:{num1 = num2}"); }


