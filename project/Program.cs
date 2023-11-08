using System;

class Program
{
    static void Main()
    {
        
        string[] inputArray = InputData();

       
        string[] filteredArray = FilterData(inputArray);

        
        OutputData(filteredArray);
    }

    
    static string[] InputData()
    {
        Console.WriteLine("Введите элементы массив строк (через запятую и пробел):");
        string input = Console.ReadLine();

        
        string[] inputArray = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        return inputArray;
    }

  
    static string[] FilterData(string[] inputArray)
    {
        
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        
        string[] filteredArray = new string[count];
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                filteredArray[index] = str;
                index++;
            }
        }

        return filteredArray;
    }

    
    static void OutputData(string[] filteredArray)
    {
        Console.WriteLine("Отфильтрованный массив:");
        if (filteredArray.Length == 0)
        {
            Console.WriteLine("Пусто");
        }
        else
        {
            foreach (string str in filteredArray)
            {
                Console.Write(str);
            }
        }
    }
}
