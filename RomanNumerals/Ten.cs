using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class Ten
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
                roman = "X";
            }
            else if (numeral == 2)
            {
                roman = "XX";
            }
            else if (numeral == 3)
            {
                roman = "XXX";
            }
            else if (numeral == 4)
            {
                roman = "XL";
            }
            else if (numeral == 5)
            {
                roman = "L";
            }
            else if (numeral == 6)
            {
                roman = "LX";
            }
            else if (numeral == 7)
            {
                roman = "LXX";
            }
            else if (numeral == 8)
            {
                roman = "LXXX";
            }
            else if (numeral == 9)
            {
                roman = "XC";
            }
            return roman;
        }
    }
}