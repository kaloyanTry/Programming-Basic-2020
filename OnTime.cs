﻿using System;

namespace _3._3.OnTimeExampMy
{
    class OnTime
    {
        static void Main(string[] args)
        {
            int inputHourExamp = int.Parse(Console.ReadLine());
            int inputMinutesExamp = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinures = int.Parse(Console.ReadLine());

            int timeExamp = (inputHourExamp * 60) + inputMinutesExamp;
            int timeArrival = (arrivalHour * 60) + arrivalMinures;

            int diffEarly = timeExamp - timeArrival;
            int diffAfter = timeArrival - timeExamp;

            int hour = 0;
            int minutes = 0;

            if (timeExamp == timeArrival) Console.WriteLine("On time");
            else if (diffEarly > 0 && diffEarly <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{diffEarly} minutes before the start");
            }
            else if (diffEarly > 30 && diffEarly <= 59)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{diffEarly} minutes before the start");
            }
            else if (diffEarly == 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{diffEarly/60}:00 hours before the start");
            }
            else if (diffEarly > 60)
            {
                hour = diffEarly / 60;
                minutes = diffEarly % 60;
                Console.WriteLine("Early");
                if (minutes < 10) Console.WriteLine($"{hour}:0{minutes} hours before the start");
                else Console.WriteLine($"{hour}:{minutes} hours before the start");
            }
            else if (diffAfter > 0 && diffAfter <= 59)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{diffAfter} minutes after the start");
            }
            else if (diffAfter >= 60)
            {
                hour = diffAfter / 60;
                minutes = diffAfter % 60;
                Console.WriteLine("Late");
                if (minutes < 10) Console.WriteLine($"{hour}:0{minutes} hours after the start");
                else Console.WriteLine($"{hour}:{minutes} hours after the start");
            }
        }
    }
}
