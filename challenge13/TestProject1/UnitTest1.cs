using Xunit;

public class BracketValidationTests
{
    [Fact]
    public void TestValidBracketCombinations()
    {
        string[] inputs = new string[]
        {
            "{}",
            "{}(){}",
            "()[[Extra Characters]]",
            "(){}[[]]",
            "{}{Code}[Fellows](())"
        };

        foreach (string input in inputs)
        {
            bool result = BracketValidation.ValidateBrackets(input);
            Assert.True(result, $"{input} should be balanced.");
        }
    }

    [Fact]
    public void TestInvalidBracketCombinations()
    {
        string[] inputs = new string[]
        {
            "[({}]",
            "(](",
            "{(})"
        };

        foreach (string input in inputs)
        {
            bool result = BracketValidation.ValidateBrackets(input);
            Assert.False(result, $"{input} should be unbalanced.");
        }
    }
}
