using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class Calculation
    {
        Thousand thousands = new Thousand();
        Hundred hundreds = new Hundred();
        Ten tens = new Ten();
        One ones = new One();
        public int number;
        public string number2;
        public string number3;
        public string T;
        public string h;
        public string t;
        public string o;
        public bool valid_number;
        public bool continue_testing_numbers = true;
        public List<string> romannumeral = new List<string>();
        
        public void obtain_number()
        {
            Console.WriteLine("Please enter your number: 1-9999: ");
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid entry: ");
                obtain_number();
            }                                                    
        }
        public void convert_number()
        {
            number2 = Convert.ToString(number);
            number3 = number2.PadLeft(4, '0');
        }
        public void check_number_length()
        {
            if (number3.Length > 4)
            {
                Console.WriteLine("Number exceeded 9999.  Please choose a lower number:");
            }
            else if (number3.Length <= 4)
            {
                valid_number = true;
            }
        }
        public void verify_number()
        {
            valid_number = false;
            while (valid_number == false)
            {
                obtain_number();
                convert_number();
                check_number_length();
            }
        }
        public void relay_number()
        {
            T = thousands.convert_to_roman(romannumeral[0]);
            h = hundreds.convert_to_roman(romannumeral[1]);
            t = tens.convert_to_roman(romannumeral[2]);
            o = ones.convert_to_roman(romannumeral[3]);
        }
        public void display_roman()
        {
            Console.WriteLine("Roman # {0}{1}{2}{3}", T, h, t, o);
        }
        public void build_list()
        {
            romannumeral.Clear();
            foreach(char digit in number3)
            {
                string newdigit = Convert.ToString(digit);
                romannumeral.Add(newdigit);
            }
        }
        public void continue_testing()
        {
            Console.WriteLine("Do you want to convert another number?");
            Console.WriteLine("Press any key to continue.  Press ESC to exit.");
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                continue_testing_numbers = false;
            }
            
        }
        public void run_program()
        {
            while (continue_testing_numbers == true)
            { 
                verify_number();
                build_list();
                relay_number();
                display_roman();
                continue_testing();
            }
        }
    }
}

