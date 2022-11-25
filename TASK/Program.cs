
int size = 6;

string[] array1 = new string[size];
Console.WriteLine ($"Введите массив из {size} строк");
FillArray(array1);

string[] array2 = new string[array1.Length];

void FillArray (string[] arr)
{
    for (int i=0; i<size; i++)
    {
        arr[i]=Console.ReadLine();
    }
}
void SecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
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
SecondArray(array1, array2);

Console.WriteLine ("Новый массив:");
PrintArray(array2);

