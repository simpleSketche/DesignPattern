using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    
    class Program
    {
        /// <summary>
        /// The application will run this class
        /// This is a simple sample of Single Responsibility Principle
        /// Each class should have one sole responsibility to function,
        /// Single Responsibility Principle helps maintaining the code
        /// base clean and clear to read.
        /// 
        /// In this sample, Journal class's only responsibility is to
        /// create entries to the journal. Other functionalities such
        /// as save, delete, select entry, etc are arranged in another
        /// class called Actions.
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var j = new Journal();
            var a = new Actions();

            j.AddEntry("Smile, be positive.");
            j.AddEntry("Tomorrow is the better future!");
            Console.WriteLine(j);

            Console.WriteLine(a.selectEntry(j, 2));
        }
    }
}
