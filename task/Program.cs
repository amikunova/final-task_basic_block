// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 

void Main()
{ 
    string[] newArray = new[] { "Hello", "Kazan","Hi!","dogs","2+" };
    string[] filteredArray = FilteredArray(newArray);

    PrintArray(filteredArray);
    System.Console.WriteLine();
}

string[] FilteredArray(string[] array)
{
    int count = 0;
    foreach (string c in array)
    {
        if (c.Length < 4)
        {
            count++;
        }
    }
    
    string[] resultArray = new string[count];
    int index = 0;
    
    foreach (string b in array)
    {
        if (b.Length <= 3)
        {
            resultArray[index] = b;
            index++;
        }
    }
    return resultArray;
}


void PrintArray(string[] newArray)
{
    foreach (string item in newArray)
    {
        Console.Write(item + " ");
    }
}

Main();

