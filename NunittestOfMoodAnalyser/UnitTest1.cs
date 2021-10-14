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
        [Test]//TestCase-5 
        public void GivenMoodAnalyserClassName_WhenAnalyse_ShouldReturnObject()
        {
            //Arrange
            object expected = new MoodAnalyser();
            //Act
            object resultobj = MoodAnalyzerFactory.createMoodAnalyse("MoodAnalyzer.MoodAnalyser", "MoodAnalyser");
            //Assert
            expected.Equals(resultobj);
        }
        [Test]//TestCase-5 .1
        public void GivenMoodAnalyserWrongClassName_WhenAnalyse_ShouldReturnObject()
        {
            try
            {
                //Arrange
                string className = "WrongNamespace.MoodAnalyse";
                string constructor = "MoodAnalyse";
                //Act
                object resultobj = MoodAnalyzerFactory.createMoodAnalyse(className, constructor);
            }
            catch (MoodAnalyserCustomException ex)
            {
                //Assert
                Assert.AreEqual("Class Not Found", ex.Message);
            }
        }
        [Test]//TestCase-5 .2
        public void GivenMoodAnalyserWrongConstructorName_WhenAnalyse_ShouldReturnObject()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzer.MoodAnalyser";
                string constructor = "WrongConstructor";
                //Act
                object resultobj = MoodAnalyzerFactory.createMoodAnalyse(className, constructor);
            }
            catch (MoodAnalyserCustomException ex)
            {
                //Assert
                Assert.AreEqual("Constructor Not Found", ex.Message);
            }
        }
        //TestCase-6.1
        [Test]
        public void Given_MoodAnalyser_Class_Name_Should_Return_MoodAnalyser_Object_Using_Parametrized_Constructor()
        {
            //Arrange
            string className = "MoodAnalyzer.MoodAnalyser";
            string constructor = "MoodAnalyser";
            MoodAnalyser expectedObj = new MoodAnalyser("HAPPY");
            //Act
            object resultObj = MoodAnalyzerFactory.CreateMoodAnalyserObjectUsingParametzisedConstructor(className, constructor,"HAPPY");
            //Assert
            expectedObj.Equals(resultObj);
        }
        //TestCase-6.2
        [Test]
        public void Given_Wrong_Class_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "WrongNameSpace.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                MoodAnalyser expectedObj = new MoodAnalyser("HAPPY");
                //Act
                object resultObj = MoodAnalyzerFactory.CreateMoodAnalyserObjectUsingParametzisedConstructor(className, constructorName, "HAPPY");
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Class Not Found", e.Message);
            }
        }
        //TC 6.3:-Pass Wrong Constructor parameter, cactch the Exception and throw indicating No such method Error
        [Test]
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzer.MoodAnalyser";
                string constructorName = "WrongConstructorName";
                MoodAnalyser expectedObj = new MoodAnalyser("HAPPY");
                //Act
                object resultObj = MoodAnalyzerFactory.CreateMoodAnalyserObjectUsingParametzisedConstructor(className, constructorName, "HAPPY");
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor is not Found", e.Message);
            }
        }
        //TC 7.1:-Given Happy Message,Should Return Happy
        [Test]
        public void Given_HappyMood_ShouldReturn_Happy()
        {
            //Arrange
            string expected = "Happy";
            //Act
            string mood = MoodAnalyzerFactory.InvokeAnalyseMood("Happy", "MoodAnalyze");
            //Assert
            Assert.AreEqual(expected, mood);
        }
        //TC 7.2:-Pass Wrong Method Name, catch the Exception and throw indicating No such method Error
        [Test]
        public void Given_Improper_Method_Name_Should_Throw_MoodAnalysisException_For_InvokeMoodAnalyse()
        {
            try
            {
                //Arrange
                string message = "HAPPY";
                //Act
                string mood = MoodAnalyzerFactory.InvokeAnalyseMood(message, "MoodAnalyze");
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor is not Found", e.Message);
            }
        }
        //TC 8.1:-Given Happy Message,Should Return Happy
        [Test]
        public void Given_HappyMessage_WithReflector__ShouldReturn_Happy()
        {
            //Arrange
            //Act
            string result = MoodAnalyzerFactory.SetField("Happy", "mood");
            //Assert
            Assert.AreEqual("Happy", result);
        }
        //TC 8.2:-Pass Wrong Field Name, catch the Exception and throw indicating No such Field Error
        [Test]
        public void Given_Improper_Field_Name_Should_Throw_MoodAnalysisException_WithReflector()
        {
            try
            {
                //Arrange
                string message = "Happy";
                //Act
                string mood = MoodAnalyzerFactory.SetField(message, "mood");
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Field is Not Found", e.Message);
            }
        }
        //TC 8.3:-Pass Field Value As Null, catch the Exception and throw indicating Message Should Not NUll Error
        [Test]
        public void Given_Null_Field_Value_Should_Throw_MoodAnalysisException_WithReflector()
        {
            try
            {
                //Arrange
                string message = null;
                //Act
                string mood = MoodAnalyzerFactory.SetField(message, "mood");
            }
            catch (MoodAnalyserCustomException e)
            {
                //Assert
                Assert.AreEqual("Message should not be null", e.Message);
            }
        }
    }
}