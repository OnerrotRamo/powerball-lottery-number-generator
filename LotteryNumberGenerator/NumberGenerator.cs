/*
 * Code written by: Omar Torreno
 * Date: 12/1/2015  
 * File: NumberGenerator.cs
 * 
 * Description:
 * This program will generate 5 random numbers from 1-69 and 1 number from 1-26.
 * This can be used to play the PowerBall lottery to choose numbers for you.
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotteryNumberGenerator
{
    class NumberGenerator
    {        
        private const int MAX_NUMBER = 70;
        private const int MIN_NUMBER = 1;
        private const int MAX_PB_NUMBER = 27;       
        private Random numGen = new Random();

        //Generate and return a number between max and min numbers.
        public int generateNum()
        {
            int number = numGen.Next(MIN_NUMBER, MAX_NUMBER);
            return number;
        }

        //Generate and return PowerBall Number.
        public int generatePBNum()
        {
            int number = numGen.Next(MIN_NUMBER, MAX_PB_NUMBER);
            return number;
        }
    }
}
