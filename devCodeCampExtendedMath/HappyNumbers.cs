using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devCodeCampExtendedMath
{
    class HappyNumbers //get the first x amount of happy numbers
    {
        List<int> happylist = new List<int>();

        public void Main(int number)
        {
            int nextnumber = happyEquation(number);
            while (nextnumber != 1)
                nextnumber = happyEquation(nextnumber);
            Console.WriteLine(nextnumber);
            //while (happylist.Count <= number)
        }
        
        

        public int happyEquation(int number)
        {
            var numbers = splitNumber(number);
            int basenumber = 0;
            foreach (int n in numbers)
            {
                int show = getSquares(n);
                basenumber += show;
            }
            return basenumber;
        }
        
        public int getSquares(int number)
        {
            double pownumber = Math.Pow(number, 2);
            number = Convert.ToInt32(pownumber);
            return number;
        }

        public List<int> splitNumber(int value)
        {
            List<int> numberlist = new List<int>();
            string numberword = value.ToString();
            char[] numberwordlist = numberword.ToCharArray();
            foreach (char number in numberwordlist)
            {
                numberlist.Add(Convert.ToInt32(number-48));
            }
            return numberlist;

        }


    }
}


/*

    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace HappyNums
{
    class Program
    {
        public static bool ishappy(int n)
        {
            List<int> cache = new List<int>();
            int sum = 0;
            while (n != 1)
            {
                if (cache.Contains(n))
                {
                    return false;
                }
                cache.Add(n);
                while (n != 0)
                {
                    int digit = n % 10;
                    sum += digit * digit;
                    n /= 10;
                }
                n = sum;
                sum = 0;
            }
           return true;            
        }
 
        static void Main(string[] args)
        {
            int num = 1;
            List<int> happynums = new List<int>();
 
            while (happynums.Count < 8)
            {
                if (ishappy(num))
                {
                    happynums.Add(num);
                }
                num++;
            }
            Console.WriteLine("First 8 happy numbers : " + string.Join(",", happynums));
        }
    }
}


    */