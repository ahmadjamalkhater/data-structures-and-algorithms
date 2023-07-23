namespace CC13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "{}";
            bool result = BracketValidation.ValidateBrackets(input);
            Console.WriteLine(result); // Output: True

            input = "{}(){}";
            result = BracketValidation.ValidateBrackets(input);
            Console.WriteLine(result); // Output: True

            input = "()[[Extra Characters]]";
            result = BracketValidation.ValidateBrackets(input);
            Console.WriteLine(result); // Output: True

            input = "(){}[[]]";
            result = BracketValidation.ValidateBrackets(input);
            Console.WriteLine(result); // Output: True

            input = "{}{Code}[Fellows](())";
            result = BracketValidation.ValidateBrackets(input);
            Console.WriteLine(result); // Output: True

            input = "[({}]";
            result = BracketValidation.ValidateBrackets(input);
            Console.WriteLine(result); // Output: False

            input = "(](";
            result = BracketValidation.ValidateBrackets(input);
            Console.WriteLine(result); // Output: False

            input = "{(})";
            result = BracketValidation.ValidateBrackets(input);
            Console.WriteLine(result); // Output: False
        }
    }
}