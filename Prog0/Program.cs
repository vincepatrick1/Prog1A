// Program 1A
// CIS 200-01/76
// Due: 10/11/2016
// By: C6181 (students use Grading ID)
// Description: This program creates a simple hierarchy and uses polymorphism. It is
// used for a package delivery system and defines many different parcels and 
// demonstrates each class' inheritance
// File: Program.cs
// Simple test program for initial Parcel classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45", 
                "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 1.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.25M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.75M); // Test Letter 3


            GroundPackage gP1 = new GroundPackage(a1, a2, 3, 4, 4, 6);                   // Test GroundPackage
            NextDayAirPackage nDA = new NextDayAirPackage(a3, a1, 59, 22, 18, 100, 30m);  // Test NextDayAirPackage
            NextDayAirPackage nDA2 = new NextDayAirPackage(a3, a1, 60, 24, 16, 100, 30m); // Test NextDayAirPackage2
            TwoDayAirPackage tDA = new TwoDayAirPackage(a4, a1, 80, 30, 20, 110, TwoDayAirPackage.Delivery.Early);  // Test TwoDayAirPackage
            TwoDayAirPackage tDA2 = new TwoDayAirPackage(a4, a2, 100, 50, 14, 120, TwoDayAirPackage.Delivery.Saver); // Test TwoDayAirPackage2

            List<Package> packages = new List<Package>(); // Test list of packages
            // Add test package data to the list
            packages.Add(gP1);
            packages.Add(nDA);
            packages.Add(nDA2);
            packages.Add(tDA);
            packages.Add(tDA2);
            //Display each package object in the list
            foreach (Package pk in packages)
            {
                Console.WriteLine(pk);
                Console.WriteLine("--------------------");
            }
                List<Parcel> parcels = new List<Parcel>(); // Test list of parcels

            // Add test data to list
            parcels.Add(l1);
            parcels.Add(l2);
            parcels.Add(l3);

            // Display data
            Console.WriteLine("Program 0 - List of Parcels\n\n");

            foreach (Parcel p in parcels)
            {
                Console.WriteLine(p);
                Console.WriteLine("--------------------");
            }
        }
    }
}
