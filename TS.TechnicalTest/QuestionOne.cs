
namespace TS.TechnicalTest;

public class QuestionOne
{
    public static int GetLongestSentance(string s)
    {
        int highestWordCount = 0;

        Dictionary<string, int> sentanceAndWordCount = new Dictionary<string, int>();

        string[] sentances;

        string[] words;

        sentances = s.Split(new char[] {'.', '?', '!'});

        foreach(string sentance in sentances)
        {
            words = sentance.Split(new char[] { ' ' });

            foreach(string word in words)
            {
                if (word.Length > 0)
                {
                    if (sentanceAndWordCount.ContainsKey(sentance))
                    {
                        sentanceAndWordCount[sentance]++;
                    }
                    else
                    {
                        sentanceAndWordCount[sentance] = 1;
                    }
                }
            }
        }

        foreach(var key in sentanceAndWordCount.Keys)
        {
            if (sentanceAndWordCount[key] > highestWordCount)
            {
                highestWordCount = sentanceAndWordCount[key];
            }
        }

        return highestWordCount;
    }
}
