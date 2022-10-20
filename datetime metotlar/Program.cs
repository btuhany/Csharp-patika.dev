using System;

namespace datetime_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine(DateTime.Now);
			Console.WriteLine(DateTime.Now.Date);
			Console.WriteLine(DateTime.Now.Day);
			Console.WriteLine(DateTime.Now.Month);
			Console.WriteLine(DateTime.Now.Year);
			Console.WriteLine(DateTime.Now.Hour);
			Console.WriteLine(DateTime.Now.Minute);
			Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
			Console.WriteLine(DateTime.Now.DayOfYear);

			Console.WriteLine(DateTime.Now.ToLongDateString());
			Console.WriteLine(DateTime.Now.ToShortDateString());
			Console.WriteLine(DateTime.Now.ToLongTimeString());
			Console.WriteLine(DateTime.Now.ToShortTimeString());

			Console.WriteLine(DateTime.Now.AddDays(2));
			Console.WriteLine(DateTime.Now.AddHours(2));
			Console.WriteLine(DateTime.Now.AddSeconds(2));
			Console.WriteLine(DateTime.Now.AddMonths(2));
			Console.WriteLine(DateTime.Now.AddYears(2));
			Console.WriteLine(DateTime.Now.AddMilliseconds(2));

            //Datetime format
			Console.WriteLine(DateTime.Now.ToString("dd")); 
			Console.WriteLine(DateTime.Now.ToString("ddd")); 
			Console.WriteLine(DateTime.Now.ToString("dddd")); 
			
			Console.WriteLine(DateTime.Now.ToString("MM")); 
			Console.WriteLine(DateTime.Now.ToString("MMM")); 
			Console.WriteLine(DateTime.Now.ToString("MMMM")); 
			
			Console.WriteLine(DateTime.Now.ToString("yy"));  
			Console.WriteLine(DateTime.Now.ToString("yyyy")); 
            
			// MATH Kütüphanesi
			
			Console.WriteLine(Math.Abs(-25));
			Console.WriteLine(Math.Sin(90));
			Console.WriteLine(Math.Cos(90));
			Console.WriteLine(Math.Tan(90));
			Console.WriteLine(Math.Ceiling(22.3));
			Console.WriteLine(Math.Round(22.3));
			Console.WriteLine(Math.Round(22.7));
			Console.WriteLine(Math.Floor(22.3));
			
			Console.WriteLine(Math.Min(2,6));
			Console.WriteLine(Math.Max(6,7));
			Console.WriteLine(Math.Pow(3,4));
			Console.WriteLine(Math.Sqrt(9));
			Console.WriteLine(Math.Log(9));
			Console.WriteLine(Math.Exp(3));
			Console.WriteLine(Math.Log10(100));
        }
    }
}
