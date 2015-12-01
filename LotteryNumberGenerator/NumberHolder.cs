/*
 * Code written by: Omar Torreno
 * Date: 12/1/2015  
 * File: NumberHolder.cs
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
    class NumberHolder
    {
        private int[] numbersArray = new int[5];

        public int[] NumbersArray
        {
            get 
            {
                return numbersArray;
            }
        }

        //Add generated number to number holder array.
        public void addToArray(int number)
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                if(numbersArray[i] == 0)
                {
                    numbersArray[i] = number;
                    i = numbersArray.Length;
                }
                    
            }
        }

        //Check array if it contains duplicate values, return boolean.
        public bool isDuplicate(int number)
        {
            bool isDup = false;
            if (numbersArray.Contains(number))
            {
                isDup = true;
            }
            return isDup;
        }
    }    
}
