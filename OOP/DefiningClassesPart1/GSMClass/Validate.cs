using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDeviceClass
{
    class Validate
    {
        internal static int ValidateIntDec(int input, int min, int max, string errorValue)
        {

            if (input < min ||
                input > max)
            {
                throw new ArgumentOutOfRangeException(String.Format("Please, enter {0} between {1} and {2} !", errorValue, min, max));
            }

            int output = input;
            return output;

        }

        internal static decimal ValidateIntDec(decimal input, decimal min, decimal max, string errorValue)
        {

            if (input < min ||
                input > max)
            {
                throw new ArgumentOutOfRangeException(String.Format("Please, enter {0} between {1} and {2} !", errorValue, min, max));
            }

            decimal output = input;
            return output;

        }

        internal static string ValidateModMan(string input, string[] list, string errorValue)
        {
            string listString = String.Empty;
            bool equal = false;
            foreach (var item in list)
            {
                if (input.CompareTo(item) == 0)
                {
                    equal = true;
                }

                listString = listString + item + ", ";
            }

            if (!equal)
            {
                throw new ArgumentOutOfRangeException(String.Format("The value of the {0} must be among the values of given list: {1}!", errorValue, listString));
            }

            string output = input;
            return output;
        }


    }
}