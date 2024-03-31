// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

// char[,] array = new char[,]
// {
//     {'a', 'b', 'c'},
//     {'d', 'e', 'f'},
//     {'g', 'h', 'i'}
// };

// string result = string.Empty;

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         result += array[i, j];
//     }
// }

// Console.WriteLine(result);


// Задача 2: 
// Задайте строку, содержащую латинские буквы
//  в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные.

// System.Console.WriteLine("Введите строку");
// string input = Console.ReadLine();
// System.Console.WriteLine(input);

// string result = input.ToLower();
// Console.WriteLine(result);


// Задача 3: 
// Задайте произвольную строку. 
// Выясните, является ли она палиндромом.

// bool Palindrom(string s)
// {
//     for (int i = 0; i < s.Length / 2; i++)
//     {
//         if (s[i] != s[s.Length - i - 1])
//         {
//             return false;
//         }
//     }
//         return true;
//     }

// Console.WriteLine("Введите строку:");
// string s = Console.ReadLine();

// if (Palindrom(s)) 
// {
// Console.WriteLine("Эта строка - палиндром");
// }
// else Console.WriteLine("Эта строка - не палиндром");