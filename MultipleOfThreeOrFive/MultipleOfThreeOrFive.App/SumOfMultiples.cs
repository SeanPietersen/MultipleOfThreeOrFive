using System;

namespace MultipleOfThreeOrFive.App
{
    public class SumOfMultiples : ISumOfMultiples
    {
        /* check if value is negative or positive, if negative or zero return 0.
         * create an empty int and set value to zero
         * get all the numbers that are multiples of 3 and multiples of 4
         * add the number to the created int value
         * return value
         * 
         */
        public int Solution(int value)
        {
            if (value > 0)
            {
                int result = 0;
                for (int i = 1; i < value; i++)
                {
                    if(i % 3 == 0 ||i % 5 == 0 )
                    {
                        result += i;
                    }                                        
                }
                return result;
            }

            return 0;
        }
    }
}
