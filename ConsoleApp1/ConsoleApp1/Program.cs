1
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите температуру в градусах Цельсия: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = (9.0 / 5.0) * celsius + 32.0;
        Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit:F2}");
    }
}


2

    using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите радиус шара: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine($"Объём шара: {volume:F2}");
    }
}


3

    using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите стоимость одного ноутбука: ");
        double price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите количество ноутбуков: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите процент скидки: ");
        double discountPercent = Convert.ToDouble(Console.ReadLine());

        double totalAmount = price * quantity * (1 - discountPercent / 100);
        Console.WriteLine($"Общая сумма заказа: {totalAmount:F2}");
    }
}


4

    using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину окружности: ");
        double circumference = Convert.ToDouble(Console.ReadLine());

        double radius = circumference / (2 * Math.PI);
        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine($"Площадь круга: {area:F2}");
    }
}


5


    using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите 4-значное число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int firstDigit = number / 1000;
        int lastDigit = number % 10;

        // Меняем местами
        int swappedNumber = lastDigit *

            6

            using System;

class Program
    {
        static void Main()
        {
            Console.Write("Введите количество дней: ");
            int totalDays = Convert.ToInt32(Console.ReadLine());

            int weeks = totalDays / 7; // Количество полных недель
            int remainingDays = totalDays % 7; // Остаток дней

            Console.WriteLine($"Полных недель: {weeks}");
            Console.WriteLine($"Остаток дней: {remainingDays}");
        }
    }


    7

    using System;

class Program
    {
        static void Main()
        {
            Console.Write("Введите количество школьников (N): ");
            int students = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите общее количество яблок (K): ");
            int apples = Convert.ToInt32(Console.ReadLine());

            int applesPerStudent = apples / students; // Яблок на каждого школьника
            int remainingApples = apples % students; // Остаток яблок в корзинке

            Console.WriteLine($"Яблок на каждого школьника: {applesPerStudent}");
            Console.WriteLine($"Остаток яблок в корзинке: {remainingApples}");
        }
    }
