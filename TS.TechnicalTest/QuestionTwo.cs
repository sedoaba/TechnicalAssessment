namespace TS.TechnicalTest;
public class QuestionTwo
{
    public static int GetPitDepth(int[] points)
    {
        int n = points.Length;

        int depth = -1;

        for(int i = 1; i < n - 1; i++)
        {
            //checking if the current point is greater than the previous point
            //then decrease the depth
            if (points[i] > points[i - 1])
                depth--;

            //checking if the current point is less than the previous point
            //then increment the depth
            if (points[i] < points[i + 1])
                depth++;

        }

        return depth;
    }
}
