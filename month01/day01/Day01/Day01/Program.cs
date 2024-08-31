Console.Write("Enter your age: ");
try
{
    var result = new AgeCalculator().AgeToDays(Console.ReadLine());
    Console.Write($"You are: {result} days old.");
}
catch(Exception ex)
{
    Console.WriteLine("Something went wrong.");
    Console.WriteLine(ex.Message);
}

Console.ReadKey();

public class AgeCalculator
{
    const int AGE = 365;


    public int AgeToDays(int yo)
    {
        if (yo <= 0 || yo > int.MaxValue)
        {
            throw new Exception($"Enter a valid number(0 - {int.MaxValue})");
        }
        return yo * AGE;
    }

    public int AgeToDays(string getAge)
    {
        int.TryParse(getAge, out int result);
        return AgeToDays(result);
    }
}
