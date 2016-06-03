using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class Thousand
    {
        public string roman;
        public string convert_to_roman(string romannumeral)
        {
            int numeral = Convert.ToInt32(romannumeral);
            if (numeral == 0)
            {
                roman = "";
            }
            else if (numeral == 1)
            {
                roman = "M";
            }
            else if (numeral == 2)
            {
                roman = "MM";
            }
            else if (numeral == 3)
            {
                roman = "MMM";
            }
            else if (numeral == 4)
            {
                roman = "MMMM";
            }
            else if (numeral == 5)
            {
                roman = "MMMMM";
            }
            else if (numeral == 6)
            {
                roman = "MMMMMM";
            }
            else if (numeral == 7)
            {
                roman = "MMMMMMM";
            }
            else if (numeral == 8)
            {
                roman = "MMMMMMMM";
            }
            else if (numeral == 9)
            {
                roman = "MMMMMMMMM";
            }
            return roman;
        }
    }
}
