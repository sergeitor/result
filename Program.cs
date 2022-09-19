//  Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//          длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//          либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//          лучше обойтись исключительно массивами.
//

   Console.WriteLine("Занесите массив с клавиатуры! ");

   Console.WriteLine("Сколько элементов в массиве?");

   int count = Convert.ToInt32(Console.ReadLine());

    string [] string_array = new string [count];

    string [] find_array = new string [string_array.Length];

    int index = 0;

    for(int i = 0; i < count; i++)
    {
      Console.WriteLine($"Введите {i + 1} значение массива:");

       string_array[i] = Console.ReadLine()!; 
    }

  for(int i = 0; i < string_array.Length; i++)
  {   
    if(string_array[i].Length <= 3)
       {  
           find_array[index] = string_array[i];
           index += 1;
       }
  } 
    
    Console.Write("[");

    for(int i = 0; i < index; i++)
    {
      if(i == (index - 1)){Console.Write("\"" + find_array[i] + "\""); break;}

      Console.Write("\"" + find_array[i] + "\"" + ",");
    }

    Console.Write("]");
    Console.WriteLine();












  




























