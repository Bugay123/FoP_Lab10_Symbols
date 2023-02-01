namespace Task1;
class Program

/*Ввести з консолі рядок з чотирьох символів одночасно (наприклад.
2022). Перевірити, чи вони утворюють число. Якщо так, обчислити
суму цифр числа. Якщо ні, вивести повідомлення «Потрібно ввести
число».*/
    {
    //Метод зчитування з консолі
    static void ReadLine()
        {
        Console.WriteLine("Введіть 4 символи: ");
        string symbols = Console.ReadLine();
        int intNumber; //тимчасова змінна для числа
        bool isNumber = int.TryParse(symbols, out intNumber); //перевірка введених данних на число
        if (isNumber) Sum(intNumber); //якщо число, то викликає метод обчислення
        else //якщо не число, то виводить в консоль повідомлення та перезапускає функцію
            {
            Console.WriteLine($"Потрібно ввести число");
            ReadLine();
            }
        }
    //Метод обчислення сумми цифр введеного числа
    static void Sum(int number)
        {
        int sum = 0; //змінная для сумми
        int lastDigit = 0; //змінна для залишку
        while (number != 0)
            {
            lastDigit = number % 10;

            sum = sum + lastDigit;
            number = number / 10;
            }
        Console.WriteLine($"Сумма цифр введеного числа {sum}");
        }

    static void Main(string[] args)
        {
        ReadLine();
        }
    }
