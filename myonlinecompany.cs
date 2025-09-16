using System;
using PropertiesDemo;

namespace PropertiesDemo
{
    // Class representing a Online Company
    public class OnlineCompany
    {
        //Auto-implemented property (no extra logic, just stores data)
        public string Name { get; set; }

        //Auto-implemented property with only getter (read-only property)
        public string Owner { get; }

        // Custom property with private field
        private int pages;

        public int Pages
        {
            get { return pages; } // return current value
            set
            {
                //Validation: pages cannot be less than 1
                if (value < 1)
                    pages = 1; // default
                else
                    pages = value;
            }
        }

        // Constructor
        public OnlineCompany(string name, string owner, int pages)
        {
            Name = name;
            Owner = owner; //read-only property can only be set in contructor
            Pages = pages; //uses validation in property
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name:{Name}, Owner:{Owner}, Pages:{Pages}");
        }
    }
    internal class NewBaseType
    {
        static void Main()
        {
            //Create company objects
            OnlineCompany company1 = new OnlineCompany("Hexley Corp", "Nathan Green", 300);
            OnlineCompany company2 = new OnlineCompany("Terrano Inc", "Brian Sanderson", -5);

            //Display company info
            company1.PrintInfo();
            company2.PrintInfo();
        }
    }
}
