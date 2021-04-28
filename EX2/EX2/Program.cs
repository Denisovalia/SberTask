using System;

namespace EX2
{
    class HC
    {
        private double AdvPrc;
        private int MinWDays;
        public HC(double p, int d)
        {
            MinWDays = d;
            AdvPrc = p;
        }
        public double get_AdvPrc()
        {
            return AdvPrc;
        }
        public int get_MinWDays()
        {
            return MinWDays;
        }
    }

    class Employee
    {
        int salary;
        DateTime day_begin;
        DateTime day_end;
        int plan_days;

        public Employee(int s, DateTime b, DateTime e, int p)
        {
            salary = s;
            day_begin = b;
            day_end = e;
            plan_days = p;
        }

        public int WorkDays()
        {
            TimeSpan span = day_end - day_begin;
            return span.Days;
        }
        public void set_DayEnd(DateTime d)
        {
            day_end = d;
        }
        public int GetSalary()
        {
            return salary;
        }

        public int PlanDays()
        {
            return plan_days;
        }

        public DateTime Emp(string flag)
        {
            if (flag == "day_begin")
                return day_begin;
            return day_end;

        }
    }
    class Program
    {
        
        static void Formula_Adv(Employee emp, HC hc, DateTime DE)
        {
            double Prc = hc.get_AdvPrc();
            bool UseAdvDay = false;
            
            if (Prc == 0)
                return;
            if (UseAdvDay == true)
                emp.set_DayEnd(DE);
            DateTime Ade = emp.Emp("day_end");
            if (Ade < emp.Emp("day_end"))
                return;

            int WD = emp.WorkDays();

            int MinWDays = hc.get_MinWDays();
            if (WD < MinWDays)
                return;

           int Salary =  emp.GetSalary();
            int PD = emp.PlanDays();

            double result = Salary / PD * WD * Prc / 100;
            Console.WriteLine(result);

        }
        static void Main(string[] args)
        {
            DateTime D1 = new DateTime(2020, 4, 4);
            DateTime D2 = new DateTime(2021, 4, 4);
            Employee Ivan = new Employee(10000, D1, D2, 20);
            HC hc = new HC(0.1, 1);
            Formula_Adv(Ivan,hc, new DateTime(2021, 4, 4));
        }
    }
}
