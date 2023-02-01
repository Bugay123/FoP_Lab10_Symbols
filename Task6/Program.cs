namespace Task6;
class Program
    {
    /*Створити масив рядків з назвами доменних імен сайтів. Не менше 5
        сайтів. Відібрати сайти, які закінчуються на “ua” (український домен).
        Відібрані сайти вивести на консоль в один рядок (об’єднати).*/
    static void Main(string[] args)
        {
        string[] domain = { "google.ua", "google.com.ua", "google.us", "google.ca", "google.it" };//массив доменів
        string a = "";//змінна для запису рядку
        foreach (string ua in domain)
            {
            if (ua.EndsWith(".ua"))//визначаємо чи закінчуєтся рядок на ".ua"
                {
                a += ua; //якщо так, то добавляємо його в змінну
                }

            }
        Console.WriteLine(a);//виводимо результат
        }
    }


