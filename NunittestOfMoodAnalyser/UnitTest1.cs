using NUnit.Framework;
using MoodAnalyzer;

namespace NunittestOfMoodAnalyser
{
    public class Tests
    {
        public const string HAPPY_MOOD = "Happy";
        public const string SAD_MOOD = "Sad";
        [Test]
        public void AnalyseMood()
        {
            MoodAnalyser mood = new MoodAnalyser();
            string ActualResult = mood.MoodAnalyze(HAPPY_MOOD);
            string ExpectedResult= "Happy";
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        public void AnalyseForSadMood()
        {
            MoodAnalyser mood = new MoodAnalyser();
            string ActualResult = mood.MoodAnalyze(SAD_MOOD);
            string ExpectedResult = "Sad";
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}