// Определить, присутствует ли в заданном массиве, некоторое число
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Введите некоторое число");
int n = int.Parse(Console.ReadLine());
int [] array = {3,5,77,-1,4,3,35-4,356,-44};
string NumberInArray (int [] array)
{   
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] == n) return "есть";
    }
    return "отцутствует"; 
}
string res = NumberInArray(array);

Console.WriteLine($"Число в данном  массиве {res}");