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
}
