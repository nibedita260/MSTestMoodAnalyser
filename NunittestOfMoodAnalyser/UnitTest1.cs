using NUnit.Framework;
using MoodAnalyzer;

namespace NunittestOfMoodAnalyser
{
    public class Tests
    {
        public const string HAPPY_MOOD = "I am in Happy Mood";
        public const string SAD_MOOD = "I am in Sad Mood";
        [Test]
        public void AnalyseForHappyMood()
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
        [Test]
        public void AnalyseForNullMood()
        {
            MoodAnalyser mood = new MoodAnalyser("");//null mood
            string ActualResult = mood.MoodAnalyze();
            string ExpectedResult = "Happy";
            Assert.AreEqual(ExpectedResult, ActualResult);//Happy,Happy 
        }
    }
}