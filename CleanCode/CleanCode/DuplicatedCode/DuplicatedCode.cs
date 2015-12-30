
using System;

namespace CleanCode.DuplicatedCode
{
    public class DuplicatedCode
    {
        public class Time
        {
            public int Hours { get; set; }
            public int Minutes { get; set; }

            public Time(int hours, int minutes)
            {
                Hours = hours;
                Minutes = minutes;
            }

            public static Time Parse(string str)
            {
                int hours;
                int minutes;
                if (!String.IsNullOrWhiteSpace(str))
                {
                    int time;
                    if (Int32.TryParse(str.Replace(":", ""), out time))
                    {
                        hours = time/100;
                        minutes = time%100;
                    }
                    else
                    {
                        throw new ArgumentException("str");
                    }
                }
                else
                    throw new ArgumentNullException("str");
                return new Time(hours, minutes);
            }
        }
        public void AdmitGuest(string name, string admissionDateTime)
        {
            // Some logic 
            // ...

            var time = Time.Parse(admissionDateTime);

            if (time.Hours < 10)
            {

            }
        }

        public void UpdateAdmission(int admissionId, string name, string admissionDateTime)
        {
            // Some logic 
            // ...

            var time = Time.Parse(admissionDateTime);

            // Some more logic 
            // ...
            if (time.Hours < 10)
            {

            }
        }
    }
}
