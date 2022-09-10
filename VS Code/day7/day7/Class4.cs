using System;
using System.Collections.Generic;
using System.Text;

namespace day7
{
    enum weeks
    {

        // following are the data members
      monday,
      tuesday,
      wednesday,
      thursday,
      friday,
      saturday,
      sunday
    }
    class Class4
    {
        static void Main5(string[] args)
        {

            // getting the integer values of data members..
            Console.WriteLine("The value of monday in week " +
                              "enum is " + (int)weeks.monday);
            Console.WriteLine("The value of tuesday in week " +
                             "enum is " + (int)weeks.tuesday);
            Console.WriteLine("The value of wednesday in week " +
                             "enum is " + (int)weeks.wednesday);
            Console.WriteLine("The value of thursday in week " +
                             "enum is " + (int)weeks.thursday);
            Console.WriteLine("The value of friday in week " +
                             "enum is " + (int)weeks.friday);
            Console.WriteLine("The value of saturday in week " +
                             "enum is " + (int)weeks.saturday);
            Console.WriteLine("The value of sunday in week " +
                             "enum is " + (int)weeks.sunday);

        }
    }
}

