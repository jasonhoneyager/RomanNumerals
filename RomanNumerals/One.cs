using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class One
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
                roman = "I";
            }
            else if (numeral == 2)
            {
                roman = "II";
            }
            else if (numeral == 3)
            {
                roman = "III";
            }
            else if (numeral == 4)
            {
                roman = "IV";
            }
            else if (numeral == 5)
            {
                roman = "V";
            }
            else if (numeral == 6)
            {
                roman = "VI";
            }
            else if (numeral == 7)
            {
                roman = "VII";
            }
            else if (numeral == 8)
            {
                roman = "VIII";
            }
            else if (numeral == 9)
            {
                roman = "IX";
            }
            return roman;
        }
    }
}
