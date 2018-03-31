// File: GroundPackage.cs

// The GroundPackage class is a concrete derived class of Package. Ground Packages
// have a cost defined by dimensions and zoneDistance.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class GroundPackage : Package
    {

        // Precondition: None
        // Postcondition: The ground package is created with the specified values for
        //                origin zip, destination zip, length, width,
        //                height, and weight
        public GroundPackage(Address orginAddress, Address destAddress, double length, double width,
            double height, double weight) : base(orginAddress, destAddress, length, width, height, weight)
        {
        }
        public int ZoneDistance
        {
            // Precondition:  None
            // Postcondition: The ground package's zone distance is returned.
            //                The zone distance is the positive difference between the
            //                first digit of the origin zip code and the first
            //                digit of the destination zip code.
            get
            {
                const int FIRST_DIGIT_FACTOR = 10000; // Denominator to extract 1st digit
                int dist;                             // Calculated zone distance
               

                dist = Math.Abs((OriginAddress.Zip/ FIRST_DIGIT_FACTOR) - 
                    (DestinationAddress.Zip / FIRST_DIGIT_FACTOR)); // Calculate Zonedist by taking the zip from 
                                                                 // orgin address and subtracting it by dest address and taking abs value

                return dist; // reutrn zonedistance result
            }
        }

        // Precondition:  None
        // Postcondition: The ground package's cost has been returned
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = .20;   // Dimension coefficient in cost equation
            const double WEIGHT_FACTOR = .05; // Weight coefficient in cost equation

            return (decimal)(DIM_FACTOR * (Length + Width + Height) + WEIGHT_FACTOR * (ZoneDistance + 1) * Weight); // return cost as decimal
        }

        // Precondition:  None
        // Postcondition: A String with the ground package's data has been returned
        public override String ToString()
        {
            return String.Format("{0}{2}ZoneDistance: {1}",
         base.ToString(), ZoneDistance, Environment.NewLine);  // Return base string along with Zone Distance
            
        }
    }
}
