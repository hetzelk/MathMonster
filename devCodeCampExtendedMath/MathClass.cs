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
            
            Console.WriteLine("Enter a number from 1 to 1,000 for a list of happy numbers.");
            numberh = Convert.ToInt32(Console.ReadLine());
            HappyNumbers happy = new HappyNumbers();
            happy.Main(numberh);
            /*
            Console.WriteLine("Enter a number from 1 to 10,000 for a Roman Numeral.");
            numberr = Convert.ToInt32(Console.ReadLine());
            RomanNumeral roman = new RomanNumeral();
            roman.romanEquation(numberr);
            
            Console.WriteLine("Enter a number from 1 to 1,000 to find the greatest common denominator.");
            numbere = Convert.ToInt32(Console.ReadLine());
            EuclideanAlgorithm euclidean = new EuclideanAlgorithm();
            euclidean.euclideanEquation(numbere);*/


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