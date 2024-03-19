
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
            //so for each sentance i will split into words when i find a space in the sentance
            words = sentance.Split(new char[] { ' ' });

            foreach(string word in words)
            {
                //check if the word is valid by check its length
                if(word.Length > 0)
                {
                    //when the word is valid i do a check if my dictionary has the sentance stored
                    if (sentanceAndWordCount.ContainsKey(sentance))
                    {
                        Console.WriteLine("Found");
                    }
                    else
                    {
                        Console.WriteLine("Must Store");
                    }
                }
            }
        }

        return highestWordCount;
      
    }
}
