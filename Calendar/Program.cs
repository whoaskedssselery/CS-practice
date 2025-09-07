using System;

class Calendar
{
    private static double startDay;
    private static double currentDay;

   private static void CalendarApp()
   {
      while (true)
      {
         Console.Write("Введите номер начального дня недели (1-пн, 2-вт, 3-ср, 4-чт, 5-пт, 6-сб, 7-вс): ");
         startDay = Convert.ToDouble(Console.ReadLine());

         if (startDay <= 7 && startDay >= 1)
         {
            break;
         }
         Console.WriteLine("Некорректные данные! Попробуйте еще раз.");
      }

      while (true)
      {
         Console.Write("Введите номер дня месяца для проверки (1-31): ");
         currentDay = Convert.ToDouble(Console.ReadLine());

         if (currentDay <= 31 && currentDay >= 1)
         {
            break;
         }
         Console.WriteLine("Некорректные данные! Попробуйте еще раз.");
      }

      isWknd();
   }

   private static void isWknd()
   {
      List<double> specialDays = new List<double>{ 1, 2, 3, 4, 5, 8, 9, 10 };
      if (specialDays.Contains(currentDay))
      {
         Console.WriteLine($"{currentDay} мая - праздничный день");
          return;
      }
      double dayOfTheWeek = (startDay + currentDay - 1) % 7;

      if (dayOfTheWeek == 0) dayOfTheWeek = 7;

      string dayName = dayOfTheWeek switch
      {
         1 => "понедельник",
         2 => "вторник",
         3 => "среда",
         4 => "четверг",
         5 => "пятница",
         6 => "суббота",
         7 => "воскресенье"
      };

        if (dayOfTheWeek == 6 || dayOfTheWeek == 7)
      {
         Console.WriteLine($"{currentDay} мая - {dayName} - выходной день");
      }
      else
      {
         Console.WriteLine($"{currentDay} мая - {dayName} - рабочий день");
      }
   }

    static void Main()
   {
      CalendarApp();
   }
}
