// This example demonstrates the DateTime.DayOfWeek property
using System;
enum Weeks
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}
class Sample
{

    public static void Main()
    {

        Curentday();
        Console.WriteLine();
        try
        {
            Console.WriteLine("Enter the name of the day format:(Monday, Tuesday,Wednesday,Thursday,)");
            WeeksbyName();
            Console.WriteLine();

            Console.WriteLine("Enter the number of the day format 1-7st");
            DaybyNumber();
        }
        catch
        {
            Console.WriteLine("Enter correct information");
            Console.WriteLine("Enter the name of the day format:(Monday, Tuesday,Wednesday,Thursday,)");
            WeeksbyName();
            Console.WriteLine();

            Console.WriteLine("Enter the number of the day format 1-7st");
            DaybyNumber();
        }


    }
    static void WeeksbyName()
    {
        string today = Console.ReadLine();
        string number;
        if (today == Weeks.Monday.ToString())
        {
            number = "1st";
        }
        else if (today == Weeks.Tuesday.ToString())
        {
            number = "2st";
        }
        else if (today == Weeks.Wednesday.ToString())
        {
            number = "3st";
        }
        else if (today == Weeks.Thursday.ToString())
        {
            number = "4st";
        }
        else if (today == Weeks.Friday.ToString())
        {
            number = "5st";
        }
        else if (today == Weeks.Saturday.ToString())
        {
            number = "6st";
        }
        else
        {
            number = "7st";
        }
        Console.WriteLine($"Today is {today}, {number} days of week");
    }
    static void DaybyNumber()
    {
        int numberofday = Convert.ToInt32(Console.ReadLine());
        string digit;
        if (numberofday == (int)Weeks.Monday)
        {
            digit = "1st Monday";
        }
        else if (numberofday == (int)Weeks.Tuesday)
        {
            digit = "2st Tuesday";
        }
        else if (numberofday == (int)Weeks.Wednesday)
        {
            digit = "3st Wednesday";
        }
        else if (numberofday == (int)Weeks.Thursday)
        {
            digit = "4st Thursday";
        }
        else if (numberofday == (int)Weeks.Friday)
        {
            digit = "5st Friday";
        }
        else if (numberofday == (int)Weeks.Saturday)
        {
            digit = "6st Saturday";
        }
        else
        {
            digit = "7st Sunday";
        }
        Console.WriteLine($"Your insert day {digit}");
    }
    static void Curentday()
    {
        string today = DateTime.Now.DayOfWeek.ToString();
        Console.WriteLine($"Today is {today}");
    }


} 
/*
This example produces the following results:

Is Thursday the day of the week for 5/1/2003?: True
The day of the week for 5/1/2003 is Thursday.
*/
