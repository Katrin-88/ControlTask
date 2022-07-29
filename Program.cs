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

string[] ThreeValueArray(string[] array, int count)
{
    string[] newArray = new string[count];
    int j = 0;
    for(int i = 0; i < array.Length; i++)
    {
        int length = array[i].Length;
        if(length <= 3)
        {
             newArray[j] = array[i];
             j++;
        }
    }
    return newArray;
}

string ShowArray(string[] array)
{
    string result = string.Empty;
    for(int i = 0; i < array.Length; i++)
    {
      result += ($"\"{array[i]}\" ");
    }
    return result;
}

Console.Write($"Input number of words: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] startArray = CreateStringArray(size);
int count = CountOfWords(startArray);
string[] finishArray = ThreeValueArray(startArray, count);
string result = ShowArray(finishArray);
Console.WriteLine($"New array is: {result}");