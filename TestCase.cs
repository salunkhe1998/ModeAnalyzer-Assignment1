﻿using ModeAnalyzerAssignment1;
using ModeAnalyzerAssignment1;
using System.Diagnostics.SymbolStore;

namespace TestCaseMoodAnalyzer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCase1_1()
        {
            string input = "I am in Sad Mood";
            string expected = "SAD";


            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();

            string actual = moodAnalyzer.analyseMood(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCase1_2()
        {
            string input = "I am in Any Mood";
            string expected = "HAPPY";


            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();

            string actual = moodAnalyzer.analyseMood(input);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Refactor1_1()
        {
            string input = "I am in Sad Mood";
            string expected = "SAD";


            MoodAnalyser moodAnalyser = new MoodAnalyser();

            string actual = moodAnalyser.msg;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Refactor1_2()
        {
            string input = "I am in Happy Mood";
            string expected = "SAD";


            MoodAnalyser moodAnalyser = new MoodAnalyser();

            string actual = moodAnalyser.msg;

            Assert.AreEqual(expected, actual);
        }
    }
}

