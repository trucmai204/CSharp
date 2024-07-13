using System.Text;

namespace GetDay
{
    internal class Program
    {
        class Day
        {
            public int day { get; set; }
            public int month { get; set; }
            public int year { get; set; }

            public void Input() 
            {
                Console.Write("Nhập ngày: ");
                day = int.Parse(Console.ReadLine());
                Console.Write("Nhập tháng: ");
                month = int.Parse(Console.ReadLine());
                Console.Write("Nhập năm: ");
                year = int.Parse(Console.ReadLine());
                Console.Write($"Ngày/tháng/năm: {day}/{month}/{year}");
            }
            public Day getNextDay() 
            {
                DateTime currentDate = new DateTime(year, month, day);
                DateTime nextDate = currentDate.AddDays(1);

                return new Day
                {
                    day = nextDate.Day,
                    month = nextDate.Month,
                    year = nextDate.Year
                };

            }
        }
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Day dayMY = new Day();
            dayMY.Input();

            Console.WriteLine($"Ngày tiếp theo là: { dayMY.getNextDay()}");
        }
    }
}
