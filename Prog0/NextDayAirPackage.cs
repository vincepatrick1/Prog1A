// File: NextDayAirPackage.cs

// The NextDayAirPackage class is a concrete derived class of AirPackage. NextDayAir Packages
// have a fixed express fee cost.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class NextDayAirPackage: AirPackage
    {
        private decimal _expressFee;  // backing field for the cost of express shipping

        // Precondition:  cost >= 0
        // Postcondition: The nextdayairpackage is created with the specified values for
        //                origin address, destination address, costdimensions, and express fee
        public NextDayAirPackage(Address orginAddress, Address destAddress, double length, double width,
            double height, double weight, decimal expressFee):base(orginAddress, destAddress,length,width,height,weight)
        {
            ExpressFee = expressFee;   // assign property to variable
        }
        // Precondition:  None
        // Postcondition: The next day package's express fee has been returned
        public decimal ExpressFee
        {
            get
            {
                return _expressFee;  // returns fee
            }
            // Precondition:  value >= 0
            // Postcondition: The Express fee's cost has been set to the
            //                specified value
            private set
            {
                if (value >= 0)  // if non-negative
                    _expressFee= value; // fee is specified value
                else
                    throw new ArgumentOutOfRangeException("ExpressFee", value,
                        "ExpressFee must be >= 0");    // throw exception if value entered is not greater than or equal to 0
            }
        }
        // Precondition:  None
        // Postcondition: The nextdaypackage's cost has been returned
        public override decimal CalcCost()
        {
            const double SIZE_FACTOR = .40;   // factor to multiply dimensions
            const double WEIGHT_FACTOR = .30; // factor to multiply weight
            const double HEAVY_CHARGE = .25;  // charge when heavy
            const double LARGE_CHARGE = .25;  // charge when large
            decimal baseCost = (decimal)(SIZE_FACTOR * (Length + Width + Height)
                + WEIGHT_FACTOR * (Weight) + (double)ExpressFee); // define normal base cost
            
            if (IsHeavy() == true)  // if package is heavy
            {
                 baseCost += (decimal)(HEAVY_CHARGE * (Weight)); // Add a weight charge to the base cost
            }
               
            if (IsLarge() == true)  // if package is large
            {
                baseCost += (decimal)(LARGE_CHARGE * (Length + Width + Height)); // Add a charge applied to the dimensions to the base cost
            }
                               
                return baseCost;    // return base cost running total
        }
        // Precondition:  None
        // Postcondition: A String with the nextdayair package's data has been returned
        public override string ToString()
        {
            return String.Format("{0}{2}Express Fee: {1:C}",
         base.ToString(), ExpressFee, Environment.NewLine);  // return base string along with Express Fee in currency format
        }
    }
}
