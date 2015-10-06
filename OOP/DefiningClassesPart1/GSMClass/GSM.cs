/* Exercise 1
 * Define a class that holds information about a mobile phone device: 
 * model, manufacturer, price, owner, battery characteristics (model, hours idle and hours talk) 
 * and display characteristics (size and number of colors). Define 3 separate classes 
 * (class "GSM" holding instances of the classes "Battery" and "Display").
 * 
 * Exercise 2
 * Define several constructors for the defined classes that take different sets of arguments 
 * (the full information for the class or part of it). Assume that model and manufacturer are 
 * mandatory (the others are optional). All unknown data fill with null.
 * 
 * Exercise 4
 * Add a method in the GSM class for displaying all information about it. Try to override ToString().
 * 
 * Exercise 6
 * Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
 * 
 * Exercise 9
 * Add a property CallHistory in the GSM class to hold a list of the performed calls.
 * Try to use the system class List<Call>.
 * 
 * Exercise 10
 * Add methods in the GSM class for adding and deleting calls from the calls history.
 * Add a method to clear the call history.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDeviceClass
{
    class GSM
    {
        // -----------Fields of GSM---------------------------------------
        private string model;
        private string manifacturer;
        private decimal price;
        private string owner;
        public Display Display = new Display();
        public Battery Battery = new Battery();
        private string output;
        private static GSM iPhone4s = new GSM("iPhone4S", "Apple");
        private string[] modelList = new string[3] { "Lumia", "Galaxy", "iPhone4S" };
        private string[] manifList = new string[3] { "Nokia", "Samsung", "Apple" };
        private List<Call> CallHistory { get; set; }

        // ---------------- Constructors of GSM -------------------------------
        public GSM(string model, string manifacturer)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.CallHistory = new List<Call>();
            this.output = String.Format(
                "Manifacturer:\t\t\t{0}\n" +
                "Model:\t\t\t\t{1}\n",
                this.Manifacturer,
                this.Model);
        }

        public GSM(string model, string manifacturer, decimal price, string owner, Display display, Battery battery)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Price = price;
            this.Owner = owner;
            this.Display = display;
            this.Battery = battery;
            this.CallHistory = new List<Call>();

            this.output = String.Format(
                "Manifacturer:\t\t\t{0}\n" +
                "Model:\t\t\t\t{1}\n" +
                "Price:\t\t\t\t{2}\n" +
                "Owner:\t\t\t\t{3}\n" +
                "Display - size:\t\t\t{4}\n" +
                "Display - number of colors:\t{5}\n" +
                "Battery - Model:\t\t{6}\n" +
                "Battery - idle hours:\t\t{7}\n" +
                "Battery - talk hours:\t\t{8}\n" +
                "Battery type:\t\t\t{9}\n",
                this.Manifacturer,
                this.Model,
                this.Price,
                this.Owner,
                this.Display.Size,
                this.Display.NummberColors,
                this.Battery.BatteryModel,
                this.Battery.IdleHours,
                this.Battery.TalkHours,
                this.Battery.BatteryType);
        }

        // --------------------- Properties of GSM -----------------------------------------
        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = Validate.ValidateModMan(value, modelList, "Model");
            }
        }

        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }

            set
            {
                this.manifacturer = Validate.ValidateModMan(value, manifList, "Manifacturer");
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                this.price = Validate.ValidateIntDec(value, 20, 2000, "Price");
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                if (value.Length < 3 || value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("The name of the owner must be between 3 and 50 symbols long!");
                }

                this.owner = value;
            }
        }

        public static GSM IPhone4s
        {
            get
            {
                return iPhone4s;
            }
        }


        // --------------------- Methods of GSM ----------------------
        public override string ToString()
        {
            return this.output;
        }

        public void AddCall(Call newCall)
        {
            this.CallHistory.Add(newCall);
        }
        public void DeleteCall(Call myCall)
        {
            this.CallHistory.Remove(myCall);
        }
        public void DeleteCall(int index)
        {
            this.CallHistory.RemoveAt(index);
        }
        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }
        public List<Call> GetCallHistory()
        {
            return this.CallHistory;
        }


        /*Exercise 11
         * Add a method that calculates the total price of the calls in the call history. 
         * Assume the price per minute is fixed and is provided as a parameter.*/

        public float CalculateTotalPrice(float pricePerMinute)
        {
            float totalPrice = 0;
            foreach (var call in CallHistory)
            {
                totalPrice += call.Duration * pricePerMinute / 60;
            }
            return totalPrice;
        }
    }
}