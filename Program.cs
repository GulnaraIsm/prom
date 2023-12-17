string[] arr1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[arr1.Length];
void SecondArrayWithIF(string[] arr1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = arr1[i];
        count++;
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
SecondArrayWithIF(arr1, array2);
PrintArray(array2);