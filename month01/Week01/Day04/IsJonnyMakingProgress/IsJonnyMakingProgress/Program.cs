IsJonnyMakingProgress Jonny = new();
int progress = Jonny.progressDays(new int[] { 9, 9 });

Console.WriteLine($"Progress days: {progress}");

Console.ReadKey();

public class IsJonnyMakingProgress
{
    public int progressDays(int[] milesRunEverySaturday)
    {
        int result = 0;
        for(int i = 0; i < milesRunEverySaturday.Length - 1; i++)
            if (milesRunEverySaturday[i] < milesRunEverySaturday[i + 1]) result++;
        return result;
    }
}