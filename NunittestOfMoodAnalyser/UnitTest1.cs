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
            MoodAnalyser mood = new MoodAnalyser(HAPPY_MOOD);
            string ActualResult = mood.MoodAnalyze();
            string ExpectedResult= "Happy";
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        public void AnalyseForSadMood()
        {
            MoodAnalyser mood = new MoodAnalyser(SAD_MOOD);
            string ActualResult = mood.MoodAnalyze();
            string ExpectedResult = "Sad";
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}