/*Exercise 8
 * Create a class Call to hold a call performed through a GSM.
 *It should contain date, time, dialed phone number and duration (in seconds).*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MobilePhoneDeviceClass
{
    class Call
    {
        private readonly DateTime dateTime = new DateTime();
        private string dialedNumber;
        private int duration;

        public Call()
            : this("[Unknown number]", 0)
        {
        }
        public Call(string dialedNumber, int duration)
        {
            this.dateTime = DateTime.Now;
            this.DialedNumber = dialedNumber;
            this.Duration = duration;
        }

        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Duration can not be less than zero!");
                }
                duration = value;
            }
        }

        public string DialedNumber
        {
            get
            {
                return dialedNumber;
            }
            set
            {
                dialedNumber = value;
            }
        }

        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }

        public override string ToString()
        {
            return ("Date: " + this.dateTime.ToShortDateString() + " Time: " + this.dateTime.ToShortTimeString() +
                " Dialed Number: " + this.DialedNumber + " Duration: " + this.Duration + " sec");
        }
    }
}
