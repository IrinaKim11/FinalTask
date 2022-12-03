string[] array = new string[6] { "adsdaw", "1", "DVSV", "KokkoI", "hh", "dsgshd"};
string[] result = new string[array.Length];

void GetArray(string[] array, string[] result)
{
    for (int i = 0; i < array.Length; i++)
    {
        int count = 0;
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
            Console.Write($"{array[i]} ");
        }
    }

}


GetArray(array, result);
