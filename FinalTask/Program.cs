string[] array = new string[6] { "adsdaw", "1", "DVSV", "KokkoI", "hh", "dsgshd" };
string[] result = new string[array.Length];

void GetArray(string[] array, string[] result)
{
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
            // Console.Write($"{array[i]} ");
        }
    }

}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

GetArray(array, result);
PrintArray(result);
