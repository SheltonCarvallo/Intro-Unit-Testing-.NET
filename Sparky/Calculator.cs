using System.ComponentModel.DataAnnotations;

namespace Sparky
{
    public class Calculator
    {
        public ICollection<int> NumberRange = new List<int>();
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public double AddNumbersDouble(double a, double b)
        {
            return a + b;
        }

        public bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }

        public IEnumerable<int> GetOddRange(int min, int max)
        {
            NumberRange.Clear();
            for(int i = min; i <= max; i++)
            {
                if(IsOddNumber(i))
                {
                    NumberRange.Add(i);
                }
            }

            return NumberRange;
        }
    }
}
