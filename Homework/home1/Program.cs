// Задача 1: 
// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

// System.Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0 && num % 23 == 0)
// {
//     System.Console.WriteLine("Число крато 7 и 23");
// }
// if (num % 7 == 0)
// {
//     System.Console.WriteLine("Число кратно только 7");
// }
// else if (num % 23 == 0)
// {
//     System.Console.WriteLine("Число кратно только 23");
// }
// else 
// {
//     System.Console.WriteLine("Число не кратно не 7, не 23");
// }



// Задача 2: 
// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.

// System.Console.Write("Введите точку x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите точку y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x >= 0 && y >= 0)
// {
//     System.Console.WriteLine("Первая четрветь");
// }
// if (x <= 0 && y >= 0)
// {
//     System.Console.WriteLine("Вторая четрветь");
// }
// if (x <= 0 && y <= 0)
// {
//     System.Console.WriteLine("Третья четрветь");
// }
// if (x >= 0 && y <= 0)
// {
//     System.Console.WriteLine("Четвертая четрветь");
// }



// Задача 3:
//  Напишите программу, которая принимает на вход 
//  целое число из отрезка [10, 99] и показывает 
//  наибольшую цифру числа.

// int num = new Random().Next(10,100);
// System.Console.WriteLine(num);
// int num1 = num / 10 ;    // первая цифра числа
// int num2 = num % 10;     // вторая цифра числа
// if (num1 > num2)
// {
//     System.Console.WriteLine("Наибольшая цифра: " + num1);
// }
// else if (num1 < num2)
// {
//     System.Console.WriteLine("Наибольшая цифра: " + num2);
// }
// else
// {
//     System.Console.WriteLine("Цифры равны");
// }



// Задача 4:
// Напишите программу, которая на вход 
// принимает натуральное число N, а на выходе 
// показывает его цифры через запятую.

// System.Console.Write("Введите число : ");
// int N = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while ( i <= N)
// {
//     Console.Write(i + ",");
//   i++;
// }
// if (N <= 0)
// {
//     System.Console.WriteLine("Вы ввели не натурально число!");
// }






