
string sentence = "Dory forgot who's Nemo again.";

FindingNemo FindingNemoClass = new();
FindingNemoClass.findNemo(sentence);

Console.ReadKey();


public class FindingNemo
{
    
    public void findNemo(string sentence)
    {
        string[] words = sentence.Split(' ');

        for(int i = 0; i < words.Length; i++)
        {
            if (words[i] == "Nemo")
            {
                VerifyIfFindNemo(i + 1);
                return;
            }
        }
        VerifyIfFindNemo(0);
    }

    private void VerifyIfFindNemo(int result)
    {
        if (result > 0)
        {
            Console.WriteLine($"I found Nemo at {result} !");
        }else Console.WriteLine("I can't find Nemo :( .");
    }
}
