// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Console.Write("Введите число: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.WriteLine(recursion(1,num));

// string recursion(int MinValue, int n)
// {
//     if (MinValue == n)
//     {
//         return n.ToString();
//     }
//     return (recursion(MinValue+1,n)+ " " + MinValue);
// }

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите число M: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"Сумма натуральных элементов в промежутке между {num} и {num2} = {recursion(num, num2)}");

// int recursion(int m, int n)
// {
//     if (m>n)
//     {
//         return 0;
//     }
//     if (m == n)
//     {
//         return m;
//     }
//     return m+ recursion(m+1,n);
// }

//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.Write("Введите число M: ");
// int num = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число N: ");
// int num2 = int.Parse(Console.ReadLine()!);
// Console.WriteLine($" A({num},{num2}) = {ackermann(num, num2)}");

// int ackermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n+1;
//     }
//     else if (m >0 && n==0)
//     {
//         return ackermann(m-1,1);
//     }
//     else if ( m> 0 && n> 0)
//     {
//         return ackermann(m-1, ackermann(m,n-1));
//     }
//     return ackermann(m,n);
// }