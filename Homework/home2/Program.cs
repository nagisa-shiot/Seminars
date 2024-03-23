// Задача 1: 
// Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. Программа 
// завершается при вводе символа ‘q’ или при вводе числа,
// сумма цифр которого чётная.\


// while (true) 
// {
// Console.Write("Введите число или 'q' для выхода: ");
// string input = Console.ReadLine(); 
// if (input == "q") 
// {
// break;
// }
// int number;
// if (int.TryParse(input, out number)) 
// {
// int sum = 0;
// while (number > 0) 
// {
// sum += number % 10; 
// number /= 10; 
// }
// if (sum % 2 == 0) 
// {
// Console.WriteLine("Stop");
// break;
// }
// }
// else 
// {
// Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое числоили 'q'.");
// }
// }


// Задача 2: 
// Задайте массив заполненный случайными 
// трёхзначными числами. Напишите программу, к
// оторая покажет количество чётных чисел в массиве.

// Console.WriteLine("Введите число");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// void FillingArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100,1000);
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }
// }

// int EvenElement()
// {
//     int count=0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]%2==0 )
//         {
//             count= count+1;
//         }
//     }
//     return count;
// }
// FillingArray();
// PrintArray();
// Console.WriteLine("");
// Console.WriteLine(EvenElement());



// Задача 3: 
// Напишите программу, которая перевернёт 
// одномерный массив (первый элемент станет последним, 
// второй – предпоследним и т.д.)


// Console.WriteLine("Введите число");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// void FillingArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,100);
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }
// }

// void Reverse()
// {
//     Array.Reverse(array);
 
//         Console.WriteLine(String.Join(',', array));
// }

// FillingArray();
// PrintArray();
// System.Console.WriteLine();
// Reverse();


