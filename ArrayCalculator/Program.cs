namespace ArrayCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = "22 10,2 33 1,5";
            var calc = new Calculator(input); // create a new instance of the Calculator class with the input string

            Console.WriteLine($"The sum of the numbers is: {calc.Sum()}"); // call the Sum method and print the result
            Console.WriteLine($"The average of the numbers is: {calc.Avarage()}"); // call the Avarage method and print the result
            Console.WriteLine($"The max of the numbers is: {calc.Max()}"); // call the Max method and print the result
        }
    }
}
