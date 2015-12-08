using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devCodeCampExtendedMath
{
    class EuclideanAlgorithm
    {
        public void euclideanEquation(int number)
        {
            List<int> range = new List<int>();
            List<int> gcdlist = new List<int>();
            int answer;
            Console.WriteLine("Greatest Common Denominator Answer");
            int i = 1;
            while (i <= number-1)
            {
                range.Add(i);
                i++;
            }

            /*foreach (int n in range)
            {
                Console.WriteLine(n.ToString());
            }*/

            foreach (int n in range)
            {
                answer = findGCD(number, n);
                gcdlist.Add(answer);
                Console.WriteLine(answer.ToString());
            }

            int greatestanswer = gcdlist.Max();
            Console.WriteLine(greatestanswer);

        }

        public int findGCD(int firstnumber, int secondnumber)
        {
            while (firstnumber != 0 && secondnumber != 0)
            {
                if (firstnumber > secondnumber)
                    firstnumber %= secondnumber;
                else
                    secondnumber %= firstnumber;
            }

            if (firstnumber == 0)
                return secondnumber;
            else
                return firstnumber;
        }
    }
}
