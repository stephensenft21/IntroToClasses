using System; 
using System.Collections.Generic;

using System;

namespace ClassIntro
{
    class Car
    {
        // This is a field
        // These are similar to properties but they are typically private
        // and don't specify getters and setters
        private string _vinNumber;

        private int _standardTestDrive = 5;

        // Constructor
        public Car(string make, string model, int mileage)
        {
            Mileage = mileage;
            Model = model;
            Make = make;

            Random rand = new Random();
            _vinNumber = rand.Next(10_000, 100_000).ToString();
        }

        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public int Mileage { get; private set; }
        public string Color { get; set; }
        public string CountryOfOrigin { get; set; }
        public bool IsInspected { get; set; }

        public string Description
        {
            get
            {
                return $"{Year} {Make} {Model} with {Mileage} miles";
            }
        }

        public void Drive(int milesDriven)
        {
            Mileage += milesDriven;
        }

        public void Drive()
        {
            Mileage += _standardTestDrive;
        }

        public void Drive(bool isFriend)
        {
            Mileage += _standardTestDrive + 5;
        }

        public string Honk()
        {
            return "Hoooooonk!";
        }
    }
}