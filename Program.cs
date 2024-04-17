using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите функцию:");
        Console.WriteLine("1. Расчет площади прямоугольника");
        Console.WriteLine("2. Расчет суммы двух чисел");
        Console.WriteLine("3. Проверка четности числа");
        Console.WriteLine("4. Вывод случайного числа");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                CalculateRectangleArea();
                break;
            case 2:
                Sum();
                break;
            case 3:
                CheckEven();
                break;
            case 4:
                GenerateRandomNumber();
                break;
            default:
                Console.WriteLine("Некорректный выбор");
                break;
        }
    }
    static void CalculateRectangleArea()
    {
        Console.WriteLine("Введите длину прямоугольника:");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите ширину прямоугольника:");
        double width = Convert.ToDouble(Console.ReadLine());

        double area = length * width;
        Console.WriteLine("Площадь прямоугольника: " + area);
    }

    static void Sum()
    {
        Console.WriteLine("Введите первое число:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = num1 + num2;
        Console.WriteLine("Сумма чисел: " + result);
    }

    static void CheckEven()
    {
        Console.WriteLine("Введите число для проверки четности:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("Число четное");
        }
        else
        {
            Console.WriteLine("Число нечетное");
        }
    }

    static void GenerateRandomNumber()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 101); 
        Console.WriteLine("Случайное число: " + randomNumber);
    }
}