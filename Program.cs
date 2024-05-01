// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Console.Write("Введите количество элементов массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// string [] stringArray = new string [m];
// void array(string [] stringArray)
// {
//   for (int i = 0;i<stringArray.Length;i++)
//   {
//      Console.WriteLine($"Введите {i+1} элемент массива»);
//      stringArray[i] = Console.ReadLine();
//   }
// }
// string [] symbol(string [] stringArray)
// {
//   int n = 0;
//   for (int i = 0;i<stringArray.Length;i++)
//   {
//     if(stringArray[i].Length <=3)
//     n++;
//   }
//   string [] rez = new string [n];
//   int j = 0;
//   for (int i = 0;i<stringArray.Length;i++)
//   {
//     if(stringArray[i].Length <=3)
//     {
//         rez[j] = stringArray[i];
//         j++;
//     }
//   }
//   return rez;
// }
// void printA(string [] stringArray)
// {
//     Console.Write("[");
//     for (int i = 0;i<stringArray.Length;i++)
//     {
//     Console.Write($"»"‘{stringArray[i]}’, "«");
//     }
//     Console.Write(«]»);
// }
// array(stringArray);
// printA(symbol(stringArray));



// // /Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

// Console.Write("Введите необходимое количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// string[] array1 = new string[size];
// for (int i = 0; i < size; i++)
// {
//     Console.Write($"Введите {i+1}-й элемент: ");
//     string element = Convert.ToString(Console.ReadLine());
//     array1[i] = element;
// }

// string [] array2 = new string [array1.Length];

// void FinalArray (string [] array1, string [] array2)
// {
//     int pos = 0;
//     for (int i = 0; i < array1.Length; i++)
//     {
//         if (array1[i].Length <= 3)
//         {
//         array2 [pos] = array1 [i];
//         pos ++;
//         }
//     }
// }
// void PrintArray(string[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }
// Console.WriteLine();
// FinalArray(array1, array2);
// PrintArray(array2);


{
    static void Main()
    {
        // Введите исходный массив строк
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();
        string[] originalStrings = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Фильтруем строки длиной меньше или равной 3 символам
        string[] filteredStrings = FilterStrings(originalStrings);

        // Выводим результат
        Console.WriteLine("Результат:");
        foreach (string str in filteredStrings)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] inputStrings)
    {
        int count = 0;
        foreach (string str in inputStrings)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;
        foreach (string str in inputStrings)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }
}
