// Задача 1: 
// Задайте значения M и N. Напишите программу, которая
//  выведет все натуральные числа в промежутке от M до N. 
//  Использовать рекурсию, не использовать циклы.

// System.Console.WriteLine("Введите первое число");
// int M = int.Parse(Console.ReadLine());
// System.Console.WriteLine("Введите число больше первого");
// int N = int.Parse(Console.ReadLine());

// void PrintNum(int start)
// {
//     if(start > N)
//     {
//         return;
//     }
//     System.Console.Write(start+" ");
//     PrintNum(start+1);
// }

// PrintNum(M);


// Задача 2: 
// Напишите программу вычисления функции
//  Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// AkkermanFunction(m,n);

// void AkkermanFunction(int m, int n)
// {
//     Console.Write(Akkerman(m, n)); 
// }

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }


// Задача 3: 
// Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];

// void FillingArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1,100);
//     }
// }

// int i = 0;
// void PrintArray(int[] arr, int i) 
// {
//     if (i >= arr.Length)
//     {
//         return;
//     }    
//     PrintArray(arr, i + 1);
//     Console.Write(arr[i]+" ");
// }

// FillingArray();
// PrintArray(array,i);

