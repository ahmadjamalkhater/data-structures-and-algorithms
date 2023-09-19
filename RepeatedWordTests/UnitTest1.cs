using System;
using System.Collections.Generic;
using Xunit;

public class WordProcessorTests
{
    public class UnitTest1
    {
        
        [Fact]
        public void NullInput()
        {
            string input = null;
            string result = RepeatedWord.FindFirstRepeatedWord(input);
            Assert.Null(result);
        }

        [Fact]
        public void NoRepeatedWord()
        {
            string input = "This is a good student.";
            string result = RepeatedWord.FindFirstRepeatedWord(input);
            Assert.Null(result);
        }

        [Fact]
        public void RepeatedWordExists()
        {
            string input = "This is  a good student with a smart brain";
            string result = RepeatedWord.FindFirstRepeatedWord(input);
            Assert.Equal("a", result);
        }
    }
}

   