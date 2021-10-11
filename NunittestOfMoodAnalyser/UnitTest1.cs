using NUnit.Framework;
using MoodAnalyzer;

namespace NunittestOfMoodAnalyser
{
    public class Tests
    {

        [Test]
        public void AnalyseMood()
        {
            const string HAPPY_MOOD = "Happy";
            const string SAD_MOOD = "Sad";
            MoodAnalyser mood = new MoodAnalyser();
            string ActualResult = mood.MoodAnalyze(HAPPY_MOOD);
            string ExpectedResult= "Happy";
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}