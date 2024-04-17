using System;

class Program
{
    static void Main()
    {
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
}