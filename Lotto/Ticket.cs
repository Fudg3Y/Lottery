using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Lotto
{
    public class Ticket
    {
        
        public string Name; //field

        public string PhoneNumber { get; set; } //autoproperty with no logic

        public int[] Numbers { get; set; } = new int[6];

        

        public Ticket() //constructor
        {
            Name = "Untitled";
        }

        public override string ToString() // This overrides the standard String ToString() class.
        {
            return String.Format("Name: {0} \nPhone Number: {1} \nFirst Number: {2} \nSecond Number: {3} \nThird Number: {4} \nFourth Number: {5} \nFifth Number: {6} \nSixth Number: {7} \nBonus Ball: {8}", Name, PhoneNumber, Numbers[0], Numbers[1], Numbers[2], Numbers[3], Numbers[4], Numbers[5]);
        }

        static DateTime GetNextWeekday(DayOfWeek day)
        {
            DateTime result = DateTime.Now.AddDays(1);
            while (result.DayOfWeek != day)
                result = result.AddDays(1);
            return result;
        }

        
    }



    public class Lotto: Ticket
    {
        private int _bonusBall; //backing variable for BonusBall property

        public int BonusBall //property with logic applied adhering to encapsulation
        {
            get { return _bonusBall; }
            set
            {
                if (value > 0 && value < 50)
                {
                    _bonusBall = value;
                }
                else
                {
                    throw new Exception("The ball number must be between 1 and 49");
                }
            }
            //public List<string> contacts {get; set;} //syntax for a list named contacts
        }
    }
    }
