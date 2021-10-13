using NUnit.Framework;
using MoodAnalyzer;

namespace NunittestOfMoodAnalyser
{
    public class Tests
    {
        const string HAPPY_MOOD = "Happy";
        const string SAD_MOOD = "Sad";
        const string NULLMsg = "Mood can't be Null";
        const string EmptyMsg = "Mood should not Empty";
        [Test]
        //Test Case-2.1
        public void Analyse_Happy_Mood()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in happy mood");
            string ActualResult = mood.MoodAnalyze();
            string ExpectedResult = HAPPY_MOOD;
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        //Test Case-2.2
        public void Analyse_Sad_Mood()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in sad mood");
            string ActualResult = mood.MoodAnalyze();
            string ExpectedResult = SAD_MOOD;
            Assert.AreEqual(ExpectedResult, ActualResult);
        }
        [Test]
        //Test Case 3
        public void Analyse_Null_Mood()
        {
            MoodAnalyser mood = new MoodAnalyser(null);//null mood
            string ActualResult = mood.MoodAnalyze();
            string ExpectedResult = NULLMsg;
            Assert.AreEqual(ExpectedResult, ActualResult); 
        }
        [Test]
        //Test Case 4
        public void Analyse_Given_Empty_Mood()
        {
            MoodAnalyser mood = new MoodAnalyser("");//empty mood
            string ActualResult = mood.MoodAnalyze();
            string ExpectedResult = EmptyMsg;
            Assert.AreEqual(ExpectedResult, ActualResult); 
        }
        [Test]
        //Test Case 4.1
        public void Analyse_Given_Empty_Mood_custom_throw_Exception()
        {
            try
            {
                MoodAnalyser mood = new MoodAnalyser("");//empty mood
                string ActualResult = mood.MoodAnalyze();
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(EmptyMsg, ex.Message);//empty mood exception handling
            }
        }
        [Test]
        //Test Case 4.2
        public void Analyse_Given_Null_Mood_custom_throw_Exception()
        {
            try
            {
                MoodAnalyser mood = new MoodAnalyser(null);//null mood
                string ActualResult = mood.MoodAnalyze();
            }
            catch (MoodAnalyserCustomException ex)
            {
                Assert.AreEqual(NULLMsg, ex.Message);//null mood exception handling
            }
        }
    }
}