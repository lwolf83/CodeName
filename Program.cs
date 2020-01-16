using System;

namespace codeName
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringName;
            int numberName;
            stringName = RepresentationCalculator.GetName();
            numberName = RepresentationCalculator.CodeName(stringName);
            RepresentationCalculator.DisplayCodedName(stringName, numberName);
            int numberNameOneDigit = RepresentationCalculator.SumOfEachDigitUntilOneDigit(numberName);
            RepresentationCalculator.DisplayCodedName(stringName, numberNameOneDigit);
        }
    }
}
