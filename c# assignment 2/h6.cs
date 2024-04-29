using System;
class hourminutes

{
    static double CalculateAngle(int hour, int minute)
    {
        
        if (hour < 0 || hour > 23 || minute < 0 || minute > 59)
        {
            throw new ArgumentException("Invalid time format");
        }
     
        hour %= 12;
       
        double hourAngle = 0.5 * (hour * 60 + minute);
        double minuteAngle = 6 * minute;
        
        double angleDifference = Math.Abs(hourAngle - minuteAngle);
       
        return Math.Min(360 - angleDifference, angleDifference);
    }
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Input hour: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input minute: ");
            int minute = Convert.ToInt32(Console.ReadLine());
            double angle = CalculateAngle(hour, minute);
            Console.WriteLine("The angle between hour hand and minute hand is " + angle + " degrees");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}