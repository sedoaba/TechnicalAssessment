namespace TS.TechnicalTest;
public class QuestionTwo
{
    public static int GetPitDepth(int[] points)
    {
        int n = points.Length;

        int NoPitsFound = -1;

        for(int i = 1; i < n - 1; i++)
        {
            Console.WriteLine(points[i]);
        }

        return NoPitsFound;
    }
}
