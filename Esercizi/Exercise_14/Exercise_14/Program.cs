using System;
using System.Collections.Generic;

namespace Exercise_14
{
	class Program
	{
		static DateTime now = DateTime.Today;
		static void Main(string[] args)
		{ 
			DateTime checkday = new DateTime (2015, 07,01);
			if (checkday <= now) 
			{
				Console.WriteLine ("Can't count working days in the past");
			}
			else
			{
				WorkingDay counter = new WorkingDay(checkday);
				counter.count(checkday);
			}
		}
		static DateTime[] nationalholydays = new DateTime[] 
		{
			new DateTime (2015, 4, 25),
			new DateTime (2015, 5, 1),
			new DateTime (2015, 6, 2),
			new DateTime (2015, 8, 15),
			new DateTime (2015, 11, 1),
			new DateTime (2015, 12, 8),
			new DateTime (2015, 12, 25),
			new DateTime (2015, 12, 26),
			new DateTime (2016, 1, 1),
			new DateTime (2016, 1, 6),
			new DateTime (2016, 3, 27),
			new DateTime (2016, 3, 28),
			new DateTime (2016, 4, 25),
			new DateTime (2016, 5, 1),
			new DateTime (2016, 6, 2),
			new DateTime (2016, 8, 15),
			new DateTime (2016, 11, 1),
			new DateTime (2016, 12, 8),
			new DateTime (2016, 12, 25),
			new DateTime (2016, 12, 26),
			new DateTime (2017, 1, 1),
			new DateTime (2017, 1, 6),
			new DateTime (2017, 3, 27),
			new DateTime (2017, 3, 28),

		};
		static DateTime[] workingsaturdays = new DateTime[]
		{
			new DateTime(2015, 5, 2),
			new DateTime(2015, 5, 23),
			new DateTime(2015, 6, 23),
			new DateTime(2015, 7, 11),
			new DateTime(2015, 7, 18),
			new DateTime(2015, 8, 22),
			new DateTime(2015, 8, 28),
			new DateTime(2015, 9, 12),
			new DateTime(2015, 9, 19),
			new DateTime(2015, 9, 26),
		}; 
	
		class WorkingDay
		{
			DateTime nextday = new DateTime();

			public WorkingDay(DateTime next)
			{
				this.nextday = next;
			}

			public void count( DateTime check)
			{
				int cnt = 0;
				DateTime dateValue = DateTime.Today;
				List<DateTime> dateList = new List<DateTime>();
				dateList.Add(dateValue);
				int weekends = (int)dateValue.DayOfWeek;
				int holiday = 0;
				while (now.AddDays(1) <= nextday)
				{
					now = now.AddDays(1);
					dateList.Add(now);
				}
				foreach (var item in dateList)
				{
					for (int i = 0; i < nationalholydays.Length; i++)
					{
						if (item == nationalholydays [i]) 
						{
							holiday = 1;
						}
					}
					if (weekends == 6) {
						holiday = 1;
					} 
					else if (weekends == 7) 
					{
						holiday = 1;
					}
					for (int i = 0; i < workingsaturdays.Length; i++)
					{
						if (item == workingsaturdays [i]) 
						{
							holiday = 0;
						}
					}
					if (weekends == 7) 
					{
						weekends = 1;
						holiday = 0;
					}
					if (holiday == 0) 
					{
						cnt++;
					}
				}
				Console.WriteLine ("There are " + cnt + " days between today and " + check.Day + "." + check.Month + "." + check.Year);
			}
		}
	}
}