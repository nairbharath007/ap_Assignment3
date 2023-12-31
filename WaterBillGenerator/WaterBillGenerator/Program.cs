﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterBillGenerator
{
    internal class Program
    {
        private const int MeterCharge = 75;
        static void Main(string[] args)
        {
            Console.WriteLine("Water Bill Generator");
            Console.Write("Enter number of units consumed: ");
            int unitsConsumed = Convert.ToInt32(Console.ReadLine());
            //int meterCharge = 75;
            /*int totalCharge;
            if(unitsConsumed<=100)
                totalCharge = unitsConsumed * 5;
            else if(unitsConsumed<=250)
                totalCharge = unitsConsumed * 10;    
            else
                totalCharge = unitsConsumed * 20;
            */
            if (unitsConsumed >= 0)
            {
                int totalCharge = (unitsConsumed <= 100) ? unitsConsumed * 5 : (unitsConsumed <= 250) ? unitsConsumed * 10 : unitsConsumed * 20;

                double totalWaterBill = totalCharge * MeterCharge;
                Console.WriteLine("Total Water Bill: " + totalWaterBill);

                //Console.WriteLine("Press any key to exit.");
                //Console.ReadKey();
            }
            else
                Console.WriteLine("Enter positive values.");
        }
    }
}
