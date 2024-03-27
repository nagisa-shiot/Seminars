// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.

// char[] array = new char[]{'r', '6', '@', '+'};
// //int[] array2 = new int[]{45,71,90,-123,75};
// string result = "";

// for (int i = 0; i < array.Length; i++)
// {
//   result = result + array[i];  
// }

// System.Console.WriteLine(result);


// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.

// string userInput =  "есмиз878Т76";

// char[] array = new char[userInput.Length];

// int i = 0;
// while (i < array.Length)
// {
//     array[i] = userInput[i];
//     System.Console.Write(array[i]+ " ");
//     i++;
// }


// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько средни
// введённх букв гласных.
// Пример:
// "hello" => 2
// "world" => 1

// System.Console.WriteLine("Введите строчку");
// string userInput = Console.ReadLine();

// string vowels = "aeiouy";

// int count = 0;

// for (int i = 0; i < userInput.Length; i++)
// {
//     if(vowels.Contains(userInput[i])) // Функция 'Contains' проверяет, есть ли данный символ в нашей строчке
//     {
//         count++;
//     }
// }
// System.Console.WriteLine(count);