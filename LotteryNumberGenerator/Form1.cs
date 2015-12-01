/*
 * Code written by: Omar Torreno
 * Date: 12/1/2015  
 * File: Form1.cs
 * 
 * Description:
 * This program will generate 5 random numbers from 1-69 and 1 number from 1-26.
 * This can be used to play the PowerBall lottery to choose numbers for you.
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryNumberGenerator
{
    public partial class Form1 : Form
    {
        private NumberGenerator numGen = new NumberGenerator();
        private NumberHolder numHolder;

        public Form1()
        {
            InitializeComponent();
        }

        //Generate 5 random numbers, sort and display on button click.
        private void button1_Click(object sender, EventArgs e)
        {
            numHolder = new NumberHolder();
            for (int i = 0; i < 5; i++)
            {
                int number = numGen.generateNum();
                if (!numHolder.isDuplicate(number))
                    numHolder.addToArray(number);
                else
                {
                    i--;
                    number = numGen.generateNum();
                }
            }

            //Sort numbers in array.
            Array.Sort(numHolder.NumbersArray);
            
            //Output
            output();
        }

        //This will display the items in the array and generate a powerball number.
        private void output()
        {
            int PBNum = numGen.generatePBNum();
            label2.Text = numHolder.NumbersArray[0].ToString();
            label3.Text = numHolder.NumbersArray[1].ToString();
            label4.Text = numHolder.NumbersArray[2].ToString();
            label5.Text = numHolder.NumbersArray[3].ToString();
            label6.Text = numHolder.NumbersArray[4].ToString();
            label8.Text = PBNum.ToString();
        }
    }
}
