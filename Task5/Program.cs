namespace Task5;
class Program
    {

    /*Є назви трьох країн (можна оголосити в коді чи ввести з консолі).
        Визначити яка з назв довша. Відсортувати назви. Вивести на консоль
        введені і відсортовані назви.*/

    //Метод сортування. (швидке сортування краще, ніж бульбашкове, тому звернувся за допомогою до Гугла)
    static void QuickSort(string[] mas, int first, int last)
        {
        string temp;
        var x = mas[(last - first) / 2 + first];
        int i = first;
        int j = last;

        while (i <= j)
            {
            while (string.Compare(mas[i], x) < 0) i++;
            while (string.Compare(mas[j], x) > 0) j--;
            if (i <= j)
                {
                temp = mas[i];
                mas[i] = mas[j];
                mas[j] = temp;
                i++;
                j--;
                }
            }
        if (i < last)
            QuickSort(mas, i, last);

        if (first < j)
            QuickSort(mas, first, j);
        }

    //Метод визначення міста з максимальною кількістю символів (змінив Ваш приклад, бо при переході в else він змінював назву, навідь якщо вона не була найдовшою)
    static void Max(string[] mas)
        {
        int max = mas[0].Length;
        string maxCity = mas[0];
        for (int i = 1; i < mas.Length; i++)
            {
            if (max < mas[i].Length)
                {
                max = mas[i].Length;
                maxCity = mas[i];
                }
            }
        Console.WriteLine($"Найдовша назва - {maxCity}, {max} символів.");
        }

    static void Main(string[] args)
        {
        string n1 = "London", n2 = "Toronto", n3 = "Rome";
        string[] cities = { n1, n2, n3 };
        Max(cities);
        QuickSort(cities, 0, cities.Length - 1);
        Console.WriteLine("Відсортований массив міст: ");
        foreach(string s in cities)
        {
            Console.WriteLine(s);
        }
        }
    }
