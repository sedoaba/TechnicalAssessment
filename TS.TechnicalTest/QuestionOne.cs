
namespace TS.TechnicalTest;

public class QuestionOne
{
    public static int GetLongestSentance(string s)
    {
        int highestWordCount = 0;

        Dictionary<string, int> sentanceAndWordCount = new Dictionary<string, int>();

        string[] sentances;

        string[] words;

        //just spliting the sentances when the following characters are found (.), (?) and (!)
        sentances = s.Split(new char[] {'.', '?', '!'});

        foreach(string sentance in sentances)
        {
            Console.WriteLine(sentance);
        }

        return highestWordCount;
      
    }
}
