/* Exercise 5
 * Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
 * Ensure all fields hold correct data at any given time.
 * Exercise 7 
 * Write a class GSMTest to test the GSM class:
        -Create an array of few instances of the GSM class.
        -Display the information about the GSMs in the array.
        -Display the information about the static property IPhone4S.
 * 
 * Exercise 12
 * Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
        Create an instance of the GSM class.
        Add few calls.
        Display the information about the calls.
        Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        Remove the longest call from the history and calculate the total price again.
        Finally clear the call history and print it.

*/


using System;
using System.Collections.Generic;

namespace MobilePhoneDeviceClass
{
    class GSMTest
    {
        private static void Main()
        {
            try
            {
                List<GSM> gsmList = new List<GSM>();
                gsmList.Add(GSM.IPhone4s);
                Console.WriteLine(GSM.IPhone4s);

                bool repeat = true;
                while (repeat)
                {
                    Console.Write("Please, enter \"Manifacturer\" value (Nokia, Samsung or Apple): ");
                    string manif = Console.ReadLine();
                    Console.Write("Please, enter \"Model\" value (Lumia, Galaxy or iPhone4S: ");
                    string model = Console.ReadLine();
                    Console.WriteLine("If ommit to enter next field the object will be created only with Manufacturer and Model!");
                    Console.Write("Please, enter \"Price\" value (between 100 and 2000): ");
                    string priceString = Console.ReadLine();

                    if (priceString == String.Empty)
                    {
                        GSM cellPhone = new GSM(model, manif);
                        gsmList.Add(cellPhone);
                        Console.WriteLine(cellPhone.ToString());
                    }
                    else
                    {
                        decimal price = decimal.Parse(priceString);
                        Console.Write("Please, enter \"Owner\" value (min 3 max 50 symbols): ");
                        string owner = Console.ReadLine();
                        Console.Write("Please, enter \"size\" value (NotSpecified, small, medium or large): ");
                        string size = Console.ReadLine();
                        Console.Write("Please, enter \"Number of colors\" value: ");
                        string numberOfColors = Console.ReadLine();
                        Console.Write("Please, enter \"Battery type\" value (LiIon, NiMH or NiCd): ");
                        string batteryType = Console.ReadLine();
                        Console.Write("Please, enter \"Hours idle\" value (between 1 and 100): ");
                        int idleHours = int.Parse(Console.ReadLine());
                        Console.Write("Please, enter \"Hours talk\" value (between 1 and 10): ");
                        int talkHours = int.Parse(Console.ReadLine());
                        Display display1 = new Display(size, numberOfColors);
                        Battery battery1 = new Battery("ChinaTheBest", idleHours, talkHours, batteryType);

                        GSM cellPhone = new GSM(model, manif, price, owner, display1, battery1);
                        gsmList.Add(cellPhone);
                        Console.WriteLine(cellPhone.ToString());
                    }

                    Console.Write("Add another instance of GSM y/another key: ");
                    string another = Console.ReadLine();
                    if (another != "y" && another != "Y")
                    {
                        repeat = false;
                    }
                }

                // ------------------GSM Call History Test--------------------
                GSM callPhone = new GSM("Lumia", "Nokia");

                Call call_1 = new Call("0888 888888", 30);
                Call call_2 = new Call("0777 777777", 40);
                Call call_3 = new Call("0666 666666", 50);
                Call call_4 = new Call("0555 555555", 20);

                callPhone.AddCall(call_1);
                callPhone.AddCall(call_2);
                callPhone.AddCall(call_3);
                callPhone.AddCall(call_4);

                PrintCallHistory(callPhone.GetCallHistory());

                float callPricePerMinute = 0.37f;

                Console.WriteLine("Total calls price: {0:C}", callPhone.CalculateTotalPrice(callPricePerMinute));

                int longestCallDuration = 0;
                int longestCallIndex = 0;
                int tempIndex = 0;
                foreach (var call in callPhone.GetCallHistory())
                {
                    if (call.Duration > longestCallDuration)
                    {
                        longestCallDuration = call.Duration;
                        longestCallIndex = tempIndex;
                    }
                    tempIndex++;
                }
                callPhone.DeleteCall(longestCallIndex);
                Console.WriteLine("\nLongest call is deleted!\n");

                PrintCallHistory(callPhone.GetCallHistory());

                Console.WriteLine("Total calls price: {0:C}", callPhone.CalculateTotalPrice(callPricePerMinute));

                Console.WriteLine("\nClear history!\n");
                callPhone.ClearCallHistory();
                PrintCallHistory(callPhone.GetCallHistory());

                
                // ---------------------end Call History Test-------------------

            }
            catch (Exception ex)
            {

                Console.Error.WriteLine(ex.Message);
            }

        }

        private static void PrintCallHistory(List<Call> CallHistory)
        {
            if (CallHistory.Count == 0)
            {
                Console.WriteLine("Call history is empty!");
                return;
            }
            Console.WriteLine("Calls in call history:");
            foreach (var call in CallHistory)
            {
                Console.WriteLine(call);
            }
        }

    }
}