using TS.TechnicalTest;

namespace TS.UnitTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void Q1_BasicNominalTest()
    {
        var input = $"We test coders. Give us a try";
        var outcome = QuestionOne.GetLongestSentance(input);

        Assert.AreEqual(4, outcome);
    }

    [TestMethod]
    public void GetLogestSentance_With_Successful_Result()
    {
        var input = "Forget CVs..Save time . x x";

        var outcome = QuestionOne.GetLongestSentance(input);

        Assert.AreEqual(2, outcome);
    }
}
