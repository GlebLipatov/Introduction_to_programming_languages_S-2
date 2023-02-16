Console.WriteLine("Задание 1\n");

SecondNumberReturn(456);
SecondNumberReturn(782);
SecondNumberReturn(918);

Console.WriteLine("\nЗадание 2\n");

ThirdNumberReturn(78);
ThirdNumberReturn(326790);

Console.WriteLine("\nЗадание 3\n");

// IsWeekend(6);
// IsWeekend(7);
// IsWeekEnd(1);



int SecondNumberReturn(int n)
{
    n = n / 10;
    n = n % 10;

    Console.WriteLine("Вторая цифра: " + n);

    return n;
}

int[] ThirdNumberReturn(int n)
{
    int fromLeft = 0;
    int fromRight = 0;

    if (n / 10000 == 0)
    {
        Console.WriteLine("Третьей цифры нет");
        return new int[0];
    }

    fromLeft = (n % 10000) / 1000;
    fromRight = (n % 100) / 10;

    Console.WriteLine("Третья цифра с начала: " + fromLeft);
    Console.WriteLine("Третья цифра с конца: " + fromRight);



    return new int[] {fromLeft, fromRight};
}