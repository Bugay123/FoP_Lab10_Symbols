namespace Task2;
class Program
    {

    /*Ввести з консолі рядок символів на нижньому регістрі і перетворити
        всі літери у прописні (на верхньому регістрі). Результат вивести на
        консоль.*/

    static void Main(string[] args)
        {
        Console.WriteLine("Введиіть слово або речення: ");
        string word = Console.ReadLine();
        Console.WriteLine(word.ToUpper());
        }
    }