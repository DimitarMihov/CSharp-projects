using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhoneDeviceClass
{
    class Display
    {
        private string numberColors;
        private string size;

        public Display()
        {

        }

        public Display(string size, string numberOfColors)
        {
            this.Size = size;
            this.NummberColors = numberOfColors;
        }

        public string Size
        {
            get
            {
                return size;
            }
            set
            {

                if (value != "NotSpecified" &&
                    value != "small" &&
                    value != "medium" &&
                    value != "large")
                {
                    throw new ArgumentException("The value for the size must be in list: \"NotSpecified, small, medium, large\"");
                }

                this.size = value;
            }
        }

        public string NummberColors
        {
            get
            {
                return numberColors;
            }

            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentException("Please, enter \"Number of colors\" value!");
                }

                this.numberColors = value;
            }
        }
    }
}
