// Console.WriteLine("What is your name?");
// string name = Console.ReadLine();
// Console.WriteLine("Hello " + name + "!");
// System.Console.WriteLine("How old are you?");
// int age = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(age);



// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// System.Console.Write("Введите первое число : ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите второе число : ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == number2 * number2)
// {
//     System.Console.WriteLine("Первое число является квадратом второго");
// }
// else
// {
//     System.Console.WriteLine("Не является квадратом второго числа");
// }



// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// System.Console.Write("Введите  число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// int i = -number;
// while ( i <= number)
// {
//     System.Console.Write(i + " ");
//     i++;
// }



// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// System.Console.Write("Введите трёхзначное число : ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ( number >= 100 && number <= 999)
// {
//     int ed = number % 10;
//     int sot = number / 100;
//     System.Console.WriteLine($"{number} -> {sot + ed}");
// }
// else
// {
//     System.Console.WriteLine("Ввели не трёхзначное число");
// }