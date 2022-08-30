// Найти произведение пар чисел в одномерном массиве
// Пара - это первый и последний,второй и предпоследний итд
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введите кол-во элементов одномерного массива ");
int n = int.Parse(Console.ReadLine());
int [] massive = new int [n];
void InputPrintMassive (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100);
        Console.Write($"{array[i]} ");
    }
}
void ProductFirstLastElements(int [] array)
{
    int first_last = 0,first = 0,last = 0;
    for (int i = 0; i < array.Length/2; i++)
    {

        first = array[i];
        last = array[array.Length-i-1];
        first_last = first*last;
        Console.WriteLine($"{first} x {last} = {first_last} ");
    }
}
InputPrintMassive(massive);
Console.WriteLine("\nТеперь распечатаем произведение пар чисел в этом массиве согласно порядкa:");
Console.WriteLine("первый и последний,второй и предпоследний итд");
ProductFirstLastElements(massive);