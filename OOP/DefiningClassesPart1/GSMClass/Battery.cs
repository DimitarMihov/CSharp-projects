/*Exercise 3
 * Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDeviceClass
{
    public enum BatteryType
    {
        NotSpecified,
        LiIon,
        NiMH,
        NiCd
    }

    class Battery
    {
        private string batteryModel;
        private int idleHours;
        private int talkHours;
        private BatteryType batteryType;

        public string BatteryModel
        {
            get
            {
                return batteryModel;
            }

            set
            {
                try
                {

                    if (value == String.Empty ||
                        value.Length > 20)
                    {
                        throw new ArgumentException("Please, enter \"Battery model\" value with max lenght of 20 symbols!");
                    }

                    this.batteryModel = value;
                }
                catch (ArgumentException ae)
                {

                    Console.Error.WriteLine(ae.Message);
                    throw;
                }
            }
        }

        public int IdleHours
        {
            get
            {
                return idleHours;
            }

            set
            {
                this.idleHours = Validate.ValidateIntDec(value, 1, 100, "\"Idle hours\"");
            }
        }

        public int TalkHours
        {
            get
            {
                return talkHours;
            }

            set
            {
                this.talkHours = Validate.ValidateIntDec(value, 1, 10, "\"Talk hours\"");
            }
        }

        public string BatType
        {
            set
            {
                try
                {
                    BatteryType batteryType = (BatteryType)Enum.Parse(typeof(BatteryType), value);
                    this.batteryType = batteryType;
                }
                catch (ArgumentException)
                {
                    throw new ArgumentException("The type of the battery must be in the list:\"LiIon, NiMH, NiCd\"");
                }
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return batteryType;
            }
        }

        public Battery()
        {

        }

        public Battery(string model, int idle, int talk, string batType)
        {
            this.BatteryModel = model;
            this.IdleHours = idle;
            this.TalkHours = talk;
            this.BatType = batType;
        }




    }
}

