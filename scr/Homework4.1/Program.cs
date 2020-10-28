using System;
using System.Linq;

namespace Homework4
{
    class Program
    {
        enum Weeks
        {
            Unknown = 0,
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }
        static void Main(string[] args)
        {
            var (operand, day) = GetUserInput();
            if (!operand)
            {
                Console.WriteLine("Incorect userInput");
                return;
            }
            var dates = GetDates();
            ChekInputDays(dates, day);
            Console.ReadKey();

        }
        /// <summary>
        /// Add DateTime Array dates.
        /// </summary>
        /// <returns></returns>
        private static DateTime[] GetDates()
        {
            var curentYear = DateTime.Now.Year;
            var curetnMonth = DateTime.Now.Month;
            var DaysinMonth = DateTime.DaysInMonth(curentYear, curetnMonth);
            var dates = new DateTime[31];
            for (int i = 1; i<DaysinMonth;i++)
            {
                dates[i] = new DateTime(curentYear, curetnMonth, i);
            }
            return dates;

        }
        /// <summary>
        /// Get userInput.
        /// </summary>
        /// <returns></returns>

        static (bool operand, Weeks day) GetUserInput()
        {
            string userInput = Console.ReadLine();
            return (SwithUserInput(userInput));
        }
        /// <summary>
        /// Swith userInput.
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>
        static (bool operadn, Weeks day) SwithUserInput(string userInput)
        {
            return userInput switch
            {
                "Monday" => (true, Weeks.Monday),
                "Thuesday" => (true, Weeks.Tuesday),
                "Wednesday"=>(true,Weeks.Wednesday),
                "Thursday"=>(true,Weeks.Thursday),
                "Friday"=>(true,Weeks.Friday),
                "Saturday"=>(true,Weeks.Saturday),
                "Sunday"=>(true,Weeks.Sunday),
                _=>(true,Weeks.Unknown),
            };
        }
        /// <summary>
        /// Output date.
        /// </summary>
        /// <param name="dates"></param>
        /// <param name="day"></param>
        static void ChekInputDays(DateTime[]dates,Weeks day)
        {
            foreach ( var date in dates )
            {
                if (date != DateTime.MinValue && date.DayOfWeek.ToString() == day.ToString())
                    Console.WriteLine(date);
            }
        }

    }
}
