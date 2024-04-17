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
        Console.WriteLine("5. Вывод таблицы умножения");
        Console.WriteLine("6. Подсчёт суммы чисел");
        Console.WriteLine("7. Перевод температур");
        Console.WriteLine("8. Проверка на палиндром");
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
            case 5:
                PrintMultiplicationTable();    
                break;
            case 6:
                SumNumbers();   
                break;
            case 7: CelsiusToFahrenheit();   
                break;
            case 8:
                CheckPalindrome();    
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
   static void PrintMultiplicationTable()
        {
            Console.WriteLine("Введите число для вывода таблицы умножения:");    
            int num = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine($"Таблица умножения для числа {num}:");    
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");    
            }
        }

        static void SumNumbers()
        {
            Console.WriteLine("Введите число для подсчета суммы чисел до него:");    
            int num = Convert.ToInt32(Console.ReadLine());    
            int sum = 0;    
            for (int i = 1; i <= num; i++)
            {
                sum += i;    
            }
            Console.WriteLine($"Сумма чисел до {num}: {sum}");}

        static void CelsiusToFahrenheit()
        {
            Console.WriteLine("Введите температуру в градусах Цельсия:");    
            double celsius = Convert.ToDouble(Console.ReadLine());    
            double fahrenheit = celsius * 9 / 5 + 32;    
            Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit}");
        }
      
        static void CheckPalindrome()
        {    Console.WriteLine("Введите слово для проверки на палиндром:");    
            string word = Console.ReadLine();    
            string reversedWord = "";    
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];    }

            if (word.ToLower() == reversedWord.ToLower())
            {
                Console.WriteLine("Слово является палиндромом");    }
            else    {
                Console.WriteLine("Слово не является палиндромом");    }
        }
}