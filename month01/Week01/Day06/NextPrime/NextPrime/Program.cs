
NextPrime.Run(24);

Console.ReadKey();

public static class NextPrime
{
    public static void Run(int input)
    {
        while (!IsPrime(input)) input++;
        Console.WriteLine($"Next Prime: {input}");
    }

    private static bool IsPrime(int n)
    {
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

