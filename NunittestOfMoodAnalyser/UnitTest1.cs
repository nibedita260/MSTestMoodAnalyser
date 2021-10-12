using NUnit.Framework;
using MoodAnalyzer;

namespace NunittestOfMoodAnalyser
{
    public class Tests
    {
        [Test]
        //Test Case-1.1
        public void Analyse_Happy_Mood()
        {   
            string mood = "I am in Happy Mood ";
            MoodAnalyser moodAnalyse = new MoodAnalyser();
            string ActualResult = moodAnalyse.MoodAnalyze(mood);
            string ExpectedResult = "Happy";
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        //Test Case-1.2
        public void Analyse_Sad_Mood()
        {
            string mood = "I am in Sad Mood ";
            MoodAnalyser moodAnalyse = new MoodAnalyser();
            string ActualResult = moodAnalyse.MoodAnalyze(mood);
            string ExpectedResult = "Sad";
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
    }
}