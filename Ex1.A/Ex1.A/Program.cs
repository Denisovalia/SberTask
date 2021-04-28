using System;

namespace Ex1.A
{
    class Program
    {

        static void task1(int day, int month, int year, int start_sick, int end_sick)
        {
            int sum = 0;
            int N = 0;
            N = DateTime.DaysInMonth(year, month);

            for (int i = day; i <= N; i++)
            {
                DateTime date1 = new DateTime(year, month, i);
                if (start_sick == i)
                {
                    i = end_sick;
                    continue;
                }
                if (date1.DayOfWeek != DayOfWeek.Sunday && date1.DayOfWeek != DayOfWeek.Saturday)
                {

                    if (i < 20)
                        sum = sum + 200;
                    else
                        sum = sum + 300;
                }

            }

            Console.WriteLine(sum);
        }


        static void Main(string[] args)
        {
            
            
            string input;
            string date;
            int month = 0;
            int year = 0;
            int day;
            int start_sick;
            int end_sick;
            Console.WriteLine("Введите день начала отсчета");
            day = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц от 1 до 12");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите год");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите начало больничного (если нет больничного введите 0)");
            start_sick = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конец больничного (если нет больничного введите 0)");
            end_sick = int.Parse(Console.ReadLine());
            task1(day, month, year, start_sick, end_sick);
           
        }
    }
}
