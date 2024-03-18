// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.
// Пример
// [1 5 11 21 81 4 0 91 2 3]
// => 2

// тип воз.значения + Название+ ()+ {}

// Console.WriteLine("Введите число");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[size];

// void FillingArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1,100);
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i]+ " ");
//     }
// }

// int GetCountNumber()
// {
//     int count=0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i]%10==1 && array[i]%7 ==0)
//         {
//             count= count+1;
//         }
//     }
//     return count;
// }

// FillingArray();
// PrintArray();
// Console.WriteLine("");
// Console.WriteLine(GetCountNumber());






// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.
// Пример
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

Console.WriteLine("Введите число");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

void FillingArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
}

int GetCountNumber()
{
    string result = "";

    for (int i = 0; i < array.Length; i++)
    {
        result = result + array[i];
    }
    return Convert.ToInt32(result);
}

FillingArray();
PrintArray();
System.Console.WriteLine();
Console.WriteLine(GetCountNumber());