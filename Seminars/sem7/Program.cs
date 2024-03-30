// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию
// Пример:
// 123 => 6
// 63 => 9

// System.Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// System.Console.WriteLine("Сумма = "+GetSumNum(num));

// int GetSumNum(int number)
// {
//     if(number <= 0)
//     {
//         return 0;
//     }
//     return number % 10 + GetSumNum(number/10);
// }

// Задайте значение N. Напите программу, которая вывведет
// все натуральные числа в промежутке от 1 до N.
// Указание
// использовать рекурсию. Не использовать цикл.
// Пример:
// N=5 => 1 2 3 4 5

// System.Console.WriteLine("Введите число");
// int N = int.Parse(Console.ReadLine());

// int firstElement = 1;
// void PrintNum(int start)
// {
//     if(start > N)
//     {
//         return;
//     }
//     System.Console.Write(start+" ");
//     PrintNum(start+1);
// }

// PrintNum(firstElement);


// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.
// УказаниеИспользовать рекурсию. Не использовать цикл.
// Пример:
// "hello" => h l l
// "World" => W r l d
// "Hello world" => H l l w r l d

// System.Console.WriteLine("Введите строку");
// string userInput = Console.ReadLine();

// string vowels = "aeiouy";

// int i = 0;
// void PintStr(string str,int i)
// {
//     if(str.Length <= i)
//     {
//         return;
//     }
//     if(vowels.Contains(str[i]))
//     {
//         System.Console.WriteLine(str[i]);
//     }
//     PintStr(str,i+1);
// }

// PintStr(userInput, i);