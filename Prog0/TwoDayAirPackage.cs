// File: TwoDayAirPackage.cs

// The TwoDayAirPackage class is a concrete derived class of AirPackage. TwoDayAir Packages
// have a fixed Delivery Type.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class TwoDayAirPackage:AirPackage
    {
        public enum Delivery {Early, Saver } // Create enum Delivery type

        // Precondition:  Enum Delivery is created
        // Postcondition: The twodayairpackage is created with the specified values for
        //                origin address, destination address, length,width, height, weight, and Delivery value
        public TwoDayAirPackage(Address orginAddress, Address destAddress, double length, double width,
            double height, double weight, Delivery value):base(orginAddress, destAddress,length,width,height,weight)
        {
            DeliveryType = value;  //assign property to variable
        }
        public Delivery DeliveryType
        {
            // Precondition:  None
            // Postcondition: The package's delivery type has been returned
            get;

            // Precondition:  None
            // Postcondition: The package's delivery type has been set to
            //                the specified value
            set;
        }
        // Precondition:  None
        // Postcondition: The twodayairpackage's cost has been returned
        public override decimal CalcCost()
        {
            const double FACTOR = .25;     // const for multiplier of size and weight
            const decimal DISCOUNT = .90m; // const for Saver discount

            decimal baseCost = (decimal)(FACTOR * (Length + Width + Height)
                + FACTOR * (Weight)); // define normal base cost

            if (DeliveryType == Delivery.Saver) // if deliverytype is saver
            {
                return baseCost * DISCOUNT;      // a 10% discount is given
            }
            else                        // if it is not
            {
                return baseCost;        // return normal base cost
            }
        }
           // Precondition:  None
           // Postcondition: A String with the two day air package's data has been returned
        public override string ToString()
        {
            return String.Format("{0}{2}Delivery Type: {1}",
         base.ToString(), DeliveryType, Environment.NewLine); // string returns base string along with deliverytype
        }

    }
    }

