// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] array = new int[8];


// void CreateArray(int[] array, int min, int max)   
// {
    
    
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
    
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//        Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();

// }

// int EvenNumbers(int[] array)
// {
//     int even = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] % 2 == 1)
//         {
//             even++;
//         }
//     }
//     return even;
// }



// CreateArray(array, 100, 300);
// ShowArray(array);
// Console.WriteLine();

// int even = EvenNumbers(array);

// Console.WriteLine("the number of even numbers is: " + even);


// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.



// int[] array = new int[9];


// void CreateArray(int[] array, int min, int max)   
// {
    
    
//     for(int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max);
//     }
    
// }

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//        Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();

// }

// int OddNumbers(int[] array)
// {
//     int sum = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(i % 2 != 1)
//         {
//             sum = sum + array[i];
//         }
//     }
//     return sum;
// }



// CreateArray(array, 5, 10);
// ShowArray(array);
// Console.WriteLine();

// int sum = OddNumbers(array);

// Console.WriteLine("sum of elements on odd positions is: " + sum);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


// double[] array = new double[11];

// for (int i = 0; i < array.Length; i++ )
//   {
//     array[i] = new Random().Next(2, 10);
//     Console.Write(array[i] + " ");
//   }


// double min = array[0];
// double max = array[0];

// for(int i = 0; i < array.Length; i++)
// {
//     if (max < array[i])
//   {
//     max = array[i];
//   }
//     if (min > array[i])
//   {
//     min = array[i];
//   }
// }
   
// double diff = max - min;

// Console.WriteLine("The difference between max and min is: " + diff);

// ------------------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------------------
// В последней задаче Next ругается на вещественные числа, и не выполняет код. Не подскажете, в чем ошибка? И еще, Павел, 
// по поводу доп занятий вы сказали к куратору обращаться, но он, как я понял, в отпуске до сих пор. Мне вам в телегу 
// написать, как буду готов?
// Так же извиняюсь, что не вовремя ДЗ сдал.
// ------------------------------------------------------------------------------------------------------------------------
// ------------------------------------------------------------------------------------------------------------------------





