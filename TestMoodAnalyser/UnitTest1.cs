using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerWithTestCase;

namespace TestMoodAnalyser
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodMoodAnalyser()
        {
            ///Arrange
            string message = "I am in sad mood";
            string expected = "sad";
            MoodAnalyser moodanalyser = new MoodAnalyser();//creating a object for a class
            //moodanalyzer.DisplayMoodAnalyzer(message);
            ///Act
            string actual = moodanalyser.DisplayMoodAnalyzer(message);//hear we check the mood of user is happy or sad
            ///Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
