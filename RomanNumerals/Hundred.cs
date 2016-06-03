using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class Hundred
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
                roman = "C";
            }
            else if (numeral == 2)
            {
                roman = "CC";
            }
            else if (numeral == 3)
            {
                roman = "CCC";
            }
            else if (numeral == 4)
            {
                roman = "CD";
            }
            else if (numeral == 5)
            {
                roman = "D";
            }
            else if (numeral == 6)
            {
                roman = "DC";
            }
            else if (numeral == 7)
            {
                roman = "DCC";
            }
            else if (numeral == 8)
            {
                roman = "DCCC";
            }
            else if (numeral == 9)
            {
                roman = "CM";
            }
            return roman;
        }
    }
}
