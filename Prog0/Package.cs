// File: Package.cs
// Package serves as the abstract class of the Package hierachy and inherits from Parcel.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class Package: Parcel
    
    {
        // Backing fields
        private double _length; // Package's length
        private double _width;  // Package's width
        private double _height; // Package's height
        private double _weight; // Package's weight

        // Precondition:  Length > 0, Width > 0,
        //                Height > 0, Weight > 0
        // Postcondition: The package is created with the specified values for
        //                origin address and destination address and its dimensions
        public Package(Address orginAddress, Address destAddress, double length, double width,
            double height, double weight):base(orginAddress, destAddress)
        {
            Length = length; // Length property assigned to length
            Width = width;   // Width property assigned to width
            Height = height; // Height property assigned to height
            Weight = weight; // Weight property assigned to weight
        }
        public double Length
        {
            // Precondition:  None
            // Postcondition: The package's length has been returned
            get
            {
                return _length;
            }

            // Precondition:  value > 0
            // Postcondition: The package's length has been set to the
            //                specified value
            set
            {
                if (value > 0) // if greater than zero
                    _length = value; // length is assigned value
                else
                    throw new ArgumentOutOfRangeException("Length", value,
                        "Length must be > 0");    // throw exception if value entered is not greater than 0
            }
        }

        public double Width
        {
            // Precondition:  None
            // Postcondition: The package's width has been returned
            get
            {
                return _width;
            }

            // Precondition:  value > 0
            // Postcondition: The package's width has been set to the
            //                specified value
            set
            {
                if (value > 0) // if greater than zero
                    _width = value; // width is assigned value
                else
                    throw new ArgumentOutOfRangeException("Width", value,
                        "Width must be > 0");  // throw exception if value entered is not greater than 0
            }
        }

        public double Height
        {
            // Precondition:  None
            // Postcondition: The package's height has been returned
            get
            {
                return _height;
            }

            // Precondition:  value > 0
            // Postcondition: The package's height has been set to the
            //                specified value
            set
            {
                if (value > 0) // if greater than zero
                    _height = value; // height is assigned value
                else
                    throw new ArgumentOutOfRangeException("Height", value,
                        "Height must be > 0");  // throw exception if value entered is not greater than 0
            }
        }

        public double Weight
        {
            // Precondition:  None
            // Postcondition: The package's weight has been returned
            get
            {
                return _weight;
            }

            // Precondition:  value > 0
            // Postcondition: The package's weight has been set to the
            //                specified value
            set
            {
                if (value > 0) // if greater than zero
                    _weight = value; // weight is assigned value
                else
                    throw new ArgumentOutOfRangeException("Weight", value,
                        "Weight must be > 0");  // throw exception if value entered is not greater than 0
            }
        }

        // Precondition:  None
        // Postcondition: A String with the Package's data has been returned
        public override string ToString()
        {
            return String.Format("{0}{5}Length: {1}{5}Width: {2}{5}Height: {3}{5}Weight: {4}",
         base.ToString(), Length, Width, Height, Weight, Environment.NewLine); // Base string is displayed along with the dimensions
        }

    }
}
