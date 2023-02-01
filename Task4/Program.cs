namespace Task4;
class Program
{
    /*Є слово з помилкою Ітенрн. Виправити помилки для отримання
        слова Інтернет.*/

    static void Main(string[] args)
    {
        string a = "Ітенрн";
        a = a.Insert(1, "н").Remove(4, 1).Insert(6, "ет");
        Console.WriteLine(a);
    }
}