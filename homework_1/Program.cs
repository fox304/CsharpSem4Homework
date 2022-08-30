// В одномерном массиве из 123 чисел найти кол-во элементов из отрезка [10,99]
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Зададим массив из 123 чисел ");
int [] array = new int [123];
void FillPrintArray(int [] arr)
{
    for (int i = 0;i<arr.Length;i++)
    {
        arr[i]=new Random().Next(1,200);
        Console.Write($"{arr[i]} ");
    }
}
int CountElementsInTheRange(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>9 && arr[i]<100) count++;
    }
    return count;
}
FillPrintArray(array);
Console.WriteLine();
int res = CountElementsInTheRange(array);
Console.WriteLine($"Кол-во элементов в массиве из отрезка [10,99] равно {res}");