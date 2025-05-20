using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCalculator
{
    public class Calculator
    {
        private double[] number; // private field to store the numbers

        public Calculator(string numberString) // constructor that takes a string of numbers separated by spaces
        {
            var arrayOfNumberString = numberString.Split(' '); // split the string into an array of strings and remove spaces
            number = new double[arrayOfNumberString.Length]; // create an array of doubles with the same length as the string array
            for (int i = 0; i < arrayOfNumberString.Length; i++)
            {
                //number[i] = double.Parse(arrayOfNumberString[i]); // convert each string to a double and store it in the number array
                number[i] = double.TryParse(arrayOfNumberString[i], out double result) ? result : 0; // BETTER practice try to parse the string as a double, if it fails, set it to 0
            }
        }


        public double Sum() // method to calculate the sum of the numbers
        {
            double sum = 0; // variable to store the sum
            foreach (var num in number) // iterate through each number in the array
            {
                sum += num; // add the number to the sum
            }
            return sum; // return the sum
        }

        public double Avarage() // method to calculate the average of the numbers
        {
            double sum = Sum(); // call the Sum method to get the sum of the numbers
            return sum / number.Length; // return the average by dividing the sum by the length of the array
        }

    }
}
