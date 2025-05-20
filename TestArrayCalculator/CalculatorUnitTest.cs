namespace TestArrayCalculator
{
    public class CalculatorUnitTest
    {
        [Fact]
        public void Sum_SumArrayOfDouble_ExpectedEqualResult()
        {
            var input = "22 10,2 33 1,5";
            var test = new ArrayCalculator.Calculator(input); // create a new instance of the Calculator class with the input string

            var result = test.Sum(); // call the Sum method and store the result

            Assert.Equal(66.7, result); // assert that the result is equal to the expected value
        }

        [Theory]
        [InlineData("22 10,2 33 1,5", 66.7)]
        [InlineData("10 20 30", 60)]
        [InlineData("1 2 3 4 5", 15)]
        [InlineData("0 0 0", 0)]
        [InlineData("1,5 2,5 3,5", 7.5)]

        public void Sum_MultipleSumArrayOfDouble_ExpectedEqualResult(string input, double expectedResult)
        {
            var test = new ArrayCalculator.Calculator(input); 

            var result = test.Sum(); 

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Avarage_AvarageArrayOfDouble_ExpectedEqualResult()
        {
            var input = "22 10,2 33 1,5";
            var test = new ArrayCalculator.Calculator(input); // create a new instance of the Calculator class with the input string
            var result = test.Avarage(); // call the Avarage method and store the result
            Assert.Equal(16.675, result); // assert that the result is equal to the expected value
        }

        [Theory]
        [InlineData("22 10,2 33 1,5", 16.675)]
        [InlineData("10 20 30", 20)]
        [InlineData("1 2 3 4 5", 3)]
        [InlineData("0 0 0", 0)]
        [InlineData("1,5 2,5 3,5", 2.5)]

        public void Avarage_MultipleAvarageArrayOfDouble_ExpectedEqualResult(string input, double expectedResult)
        {
            var test = new ArrayCalculator.Calculator(input); 
            var result = test.Avarage(); 
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(GetTestData))]

        public void Max_MultipleMaxArrayOfDouble_ExpectedEqualResult(string input, double expectedResult)
        {
            var test = new ArrayCalculator.Calculator(input); 
            var result = test.Max(); 
            Assert.Equal(expectedResult, result);
        }

        public static List<object[]> GetTestData()
        {
            return new List<object[]>
            {
                new object[] { "22 10,2 33 1,5", 33 },
                new object[] { "10 20 30", 30 },
                new object[] { "1 2 3 4 5", 5 },
                new object[] { "0 0 0", 0 },
                new object[] { "1,5 2,5 3,5", 3.5 }
            };
        }
    }
}

// COMPITI
// provare a metter eun po' di test su serverManager (???)
// testare separatamente un po' di funzioni recuperare file
// test numero di elementi recuperato corretto
// test opzione di ricerca
// posgresql 