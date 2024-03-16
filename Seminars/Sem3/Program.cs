// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры:
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// System.Console.Write("Задайте размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// System.Console.Write("Введи необходимое число: ");
// int userNum = Convert.ToInt32(Console.ReadLine());

// string findNum = "Нет";

// for (int i = 0; i < array.Length; i++) // "Length" Специально свойство ,которое подсчитывает кол.элементов
// {
//     array[i] = new Random().Next(1, 20);
//     System.Console.Write(array[i] + " ");

//     if (array[i] == userNum)
//     {
//         findNum = "Да";
//     }
// }
//System.Console.WriteLine(findNum);


// Задайте массив из 10 элементов, заполненный числами
// из промежутка [-10, 10]. Замените отрицательные элементы 
// на положительные, а положительные на отрицательные.
// Пример:
// [1 -5 6]
// >= [-1 5 -6]

// int[] array = new int[10];
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = new Random().Next(-10, 11);
//     System.Console.Write(array[i]+ "\t");;
// }
// System.Console.WriteLine();
// for (int i = 0; i < array.Length; i++) 
// {
//     array[i] = -1 * array[i];
//     System.Console.Write(array[i]+ "\t");
// }


// Найдите произведение пар чисел в одномерном массиве. Парой
// считаеся первый и последний элемент, второй и предпоследний и
// т.д. Результат запигшите в новый массив.
// Пример:
// [1 3 2 4 2 3] >= [3 6 8]
// [2 3 1 7 5 6 3] >= [6 18 5] (Элемент 7 не имеент пары)

// System.Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];

// int[] array2 = new int[array.Length / 2];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 10);
//     System.Console.Write(array[i] + "\t");
// }
// System.Console.WriteLine();

// for (int i = 0; i < array2.Length; i++)
// {
//     array2[i] = array[i] * array[array.Length - 1 - i];
//     System.Console.Write(array2[i] + "\t");
// }


// Дано натуральное трёхзначное число. Создайте массив, состоящий из
// цифр этого числа. Младший разряд числа должен располагаться на 0-м
// индексе массива, старший - на 2-м.
// Пример:
// 456 => [6 5 4]
// 781 => [1 8 7]

System.Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[3];

for (int i = 0; i < array.Length; i++)
{
    array[i] = num % 10;
    System.Console.Write(array[i] + " ");
    num = num / 10;
}


// System.Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// double[] array = new double[3];

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-10, 10)+new.Random().NextDouble();
//     array[i] = num % 10;
//     System.Console.Write(array[i] + " ");
//     num = num / 10;
// }