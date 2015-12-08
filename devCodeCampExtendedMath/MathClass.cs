using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devCodeCampExtendedMath
{
    public class MathClass
    {
        public static void Main()
        {
            int numberh;
            int numberr;
            int numbere;
            int numberm;

            Console.WriteLine("Enter a number from 1 to 47 for a list of fibbonacci numbers.");
            numberm = Convert.ToInt32(Console.ReadLine());
            MyMathThing mine = new MyMathThing();
            mine.Main(numberm);
            
            Console.WriteLine("Enter a number from 1 to 10,000 for a Roman Numeral.");
            numberr = Convert.ToInt32(Console.ReadLine());
            RomanNumeral roman = new RomanNumeral();
            roman.romanEquation(numberr);
            
            Console.WriteLine("Enter a number from 1 to 1,000 to find the greatest common denominator.");
            numbere = Convert.ToInt32(Console.ReadLine());
            EuclideanAlgorithm euclidean = new EuclideanAlgorithm();
            euclidean.euclideanEquation(numbere);

            Console.WriteLine("Enter a number from 1 to see if it's happy or not.");
            Console.WriteLine("If it doesn't answer 1 within a second, then it's not a happy number.");
            Console.WriteLine("I couln't break out of the loop correctly before the projec was due.");
            numberh = Convert.ToInt32(Console.ReadLine());
            HappyNumbers happy = new HappyNumbers();
            happy.Main(numberh);

            Console.Read();
        }
    }
}


/*

Write a function to find the nth(integer pass by value) happy numbers and returns a list of ints
       
Write a function that will take in a number as a string and return its roman numeral numeral equivilant as a string. This should support only pass by reference.  
       
Write a function that implements Euclidean's algorithm. This should support onlny pass by value.
       

    
Find an advanced equation that is currently not supported by System.Math
       

    
    
Write a console application that tests the functionality of this library


    */