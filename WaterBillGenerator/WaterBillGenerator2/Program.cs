using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WaterBillGenerator
{
    internal class Program
    {
        private const int BasicUnitLimit = 100;
        private const int IntermediateUnitLimit = 250;
        private const int BasicUnitRate = 5;
        private const int IntermediateUnitRate = 10;
        private const int ExcessUnitRate = 20;
        private const int MeterCharge = 75;

        static void Main(string[] args)
        {
            Console.WriteLine("Water Bill Generator");
            Console.Write("Enter number of units consumed: ");

            try
            {
                int unitsConsumed = Convert.ToInt32(Console.ReadLine());

                if (unitsConsumed >= 0)
                {
                    int totalCharge = (unitsConsumed <= BasicUnitLimit)
                        ? unitsConsumed * BasicUnitRate
                        : (unitsConsumed <= IntermediateUnitLimit)
                            ? BasicUnitLimit * BasicUnitRate + (unitsConsumed - BasicUnitLimit) * IntermediateUnitRate
                            : BasicUnitLimit * BasicUnitRate + (IntermediateUnitLimit - BasicUnitLimit) * IntermediateUnitRate + (unitsConsumed - IntermediateUnitLimit) * ExcessUnitRate;

                    double totalWaterBill = totalCharge * MeterCharge;
                    Console.WriteLine("Total Water Bill: " + totalWaterBill);
                }
                else
                {
                    Console.WriteLine("Error: The number of units consumed cannot be negative.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
        }
    }
}
