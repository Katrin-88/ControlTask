string[] CreateStringArray(int size)
{
    string[] array = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} word: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

int CountOfWords(string[] array)
{
    int count = 0;
    int length = array.Length;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        count++;
    }
    return count;
}
