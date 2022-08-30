// В указанном массиве вещественных чисел 
// найдите разницу между максимальным и минимальным элементом
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введите кол-во элементов массива от двух до тысячи");

int Filter()// фильтруем от ввода более 1000,нуля,нуля вначале числа, единицы
{
    string n1 = "2";
    while (true)
    {   
        n1 = Console.ReadLine();
        if (n1[0] == '0') Console.WriteLine("0 вначале вводить нельзя");
        else if  (Convert.ToInt32(n1) == 1) Console.WriteLine("нужно больше одного"); 
        else if(Convert.ToInt32(n1) > 1000) Console.WriteLine("нужно не более 1000");       
        else break;
    } 
    int n = Convert.ToInt32(n1);
    return n;
}

void FillPrintArray(double [] arr)//создание,вывод массива

{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble()*999-1;
        Console.WriteLine($"{arr[i]} ");
    }
}
void SubtractMaxAndMinElements(double [] arr) // определяет макс. и мин. элемент и получает их разницу
{
    double max = arr[0],min = arr[0];
    if (arr[1]>max) max = arr[1];
    else min = arr[1];
    for (int i = 1; i < arr.Length; i++)
    {
       if (arr[i]>max) max = arr[i];
       else if (arr[i]<min) min = arr[i]; 
    }
    Console.Write($"\n разница между максимальным {max} и минимальным {min} элементами равна {max-min}");
}
double [] massive = new double [Filter()];
FillPrintArray(massive);
SubtractMaxAndMinElements(massive);