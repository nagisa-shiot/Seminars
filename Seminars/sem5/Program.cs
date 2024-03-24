// Задайте двумерный маассив. Найдите эелементы, у который оба
// индекса чётные, и замените эти элементы на их квадраты.
// Пример:
// 2 3 4 3
// 4 3 4 1=>
// 2 9 5 4
// Обсудить этапы решения задачи
// оформить этапы в виде функции
// 4 3 4 3
// 4 3 4 1
// 2 9 25 4

// int[,] array = new int[5, 4];

// void FillingArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 30);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void ChangeArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 array[i, j] = array[i, j] * array[i, j];
//             }
//         }
//     }
//     System.Console.WriteLine();
// }

// FillingArray();
// PrintArray();
// ChangeArray();
// PrintArray();

// Задайте двумерный массив. Найдите сумму элементов,
// находящихся на главной диагонали (с индексами(0,0);(1,1) и
// т.д.
// Пример:
// 2 3 4 3
// 4 3 4 1 => 2 + 3 + 5 = 10
// 2 9 5 4


// int[,] array = new int[3, 6];

// void FillingArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 30);
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int FillingOneArray()
// {
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i == j)
//             {
//                 sum += array[i, j];
//             }
//         }
//     }
//     return sum;
//     System.Console.WriteLine();
// }

// FillingArray();
// PrintArray();
// System.Console.WriteLine("Сумма = " + FillingOneArray());


// Задайте двумерный массив из целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значиний по сторокам двумерного массива.
// Пример:
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4


System.Console.WriteLine("Введите число");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число");
int colums = int.Parse(Console.ReadLine());

int[,] array = new int[rows,colums];
double[] array2 = new double[array.GetLength(0)];

void FillingArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 30);
        }
    }
}

void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

void FillingOneArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum+= array[i,j];
        }
        array2[i] = sum/array.GetLength(1);
    }
    
    System.Console.WriteLine();
}

void PrintOneArray()
{
    for (int i = 0; i < array2.Length; i++)
    {
        System.Console.Write(array2[i] + "\t");
    }
}

FillingArray();
PrintArray();
FillingOneArray();
PrintOneArray();