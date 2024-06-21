using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnly_Collections
{
    /*
    Question 1: Read-Only Collections
    Create a list of strings with the values {"red", "green", "blue"}.
    Convert the list to a read-only collection.
    Attempt to add another element to the read-only collection (expect an error). but add a comment on this one after testing
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfColors = new List<string>
            {
                "red", "green", "blue"
            };

            //Code to convert mutable list to readonly list
            IEnumerable<string> readOnly_listOfColors = listOfColors.AsReadOnly();

            readOnly_listOfColors.Add("orange"); //An error showing that a read-only list cannot be modified
        }
    }
}
