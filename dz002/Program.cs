// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Привет! Тебе нужно ввести три числа");

Console.WriteLine("Первое число ");
long a = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Второе число ");
long b = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Третие число ");
long c = Convert.ToInt16(Console.ReadLine());
long max = a;



if ( b> max)
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine("максимально число " + max);
