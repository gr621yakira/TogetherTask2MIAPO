using System;

class Program
{
    static void Main()
    {
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
            Console.WriteLine($"Температура в градусах Фаренгейта: {fahrenheit}");}

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
        
        int choice = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("5. Вывод таблицы умножения");
        Console.WriteLine("6. Подсчёт суммы чисел");
        Console.WriteLine("7. Перевод температур");
        Console.WriteLine("8. Проверка на палиндром");
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
}