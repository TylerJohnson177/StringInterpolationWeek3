using System;

class StringInterpolation
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        
        Console.WriteLine($"{now.ToString("MMMM")} {now.Day:D2}, {now.Year}".PadRight(40));
        Console.WriteLine($"{now.Year}.{now.Month:D2}.{now.Day:D2}");
        Console.WriteLine($"Day {now.Day:D2} of {now.ToString("MMMM")}, {now.Year}");
        Console.WriteLine($"Year:{now.Year}, Month:{now.Month:D2}, Day:{now.Day:D2}");
        Console.WriteLine(now.ToString("dddd").PadLeft(10));
        Console.WriteLine($"{now:t}".PadRight(10) + $"{now.ToString("dddd")}".PadRight(10));
        Console.WriteLine($"h:{now.Hour:D2}, m:{now.Month:D2}, s:{now.Second:D2}");
        Console.WriteLine($"{now.Year}.{now.Month:D2}.{now.Day:D2}.{now.Hour:D2}.{now.Minute:D2}.{now.Second:D2}");

        var pi = Math.PI;

        Console.WriteLine(String.Format($"{pi:C}"));
        Console.WriteLine(String.Format($"{pi:0.000}".PadRight(10)));


    }
    
}