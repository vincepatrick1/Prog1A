// File: AirPackage.cs
// AirPackage serves as the abstract class of the AirPackage hierachy and inherits from Package.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class AirPackage: Package
    {   public const double HEAVY_WEIGHT= 75;  // const for weight that is heavy
        public const double LARGE_SIZE = 100;  // const for size that is large
        // Precondition:  None
        // Postcondition: The airpackage is created with the methods IsHeavy and IsLarge that specify
        // if the package is heavy or large
        public AirPackage(Address orginAddress, Address destAddress, double length, double width,
            double height, double weight):base(orginAddress, destAddress,length,width,height,weight)
        {
        }
        // Precondition: The Length, Width, Height, and Weight have been validated
        // Postcondition: The air package is either heavy or not
        public bool IsHeavy()
        {
            if (Weight >= HEAVY_WEIGHT)    // if package's weight is greater or equal 75
                return true;     // package is heavy
            else
                return false;    // package is not heavy
        }
        // Precondition: The Length, Width, Height, and Weight have been validated
        // Postcondition: The air package is either large or not
        public bool IsLarge()
        {
            if (Length + Width + Height >= LARGE_SIZE)  // if the dimensons are greater than 100 
                return true;                       // package is large
            else
                return false;                      // package is not large
        }
        // Precondition:  None
        // Postcondition: A String with the air package's data has been returned
        public override String ToString()
        {
            return String.Format("{0}{3}Heavy: {1}{3}Large: {2}",
         base.ToString(), IsHeavy(), IsLarge(), Environment.NewLine); // string returns base string along with heavy/large status
        }
    }
}
