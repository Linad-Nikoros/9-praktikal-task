// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
Console.WriteLine("Введите N");
int num1=Convert.ToInt32(Console.ReadLine());
if (num1>=1)
{
Console.WriteLine("Введеное число должно быть меньше 1");
}
else
{
PrintNumber(num1);
}

void PrintNumber(int num1)
{
if (num1<=1)
{
Console.WriteLine($"{num1}");
PrintNumber(num1+1);
 num1++;
}
}
