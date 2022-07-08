using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1.Model
{
    class TWorkers
    {
        string surname;
        string name;
        int dayBirthday;
        int monthBirthday;
        int yearBirthday;
        int dayW;
        int monthW;
        int yearW;
        string town;
        public TWorkers(string surname, string name, int dayBirthday,
        int monthBirthday,int yearBirthday,int dayW,int monthW,int yearW,string town)
        {
           
            this.surname = surname;
            this.name = name;
            this.dayBirthday = dayBirthday;
            this.monthBirthday = monthBirthday;
            this.yearBirthday = yearBirthday;
            this.dayW = dayW;
            this.monthW = monthW;
            this.yearW = yearW;
            this.town = town;
        }
        public string Name()
        {
            return name;
        }
        public string Surname()
        {
            return surname;
        }
        public int AgeW()
        {
            DateTime datw = new DateTime(yearW, monthW, dayW);
            DateTime now = DateTime.Today;
            int agew = now.Year - datw.Year;
            now = now.AddYears(-agew);
            if (datw > now) agew--;
            return agew;
        }
        public int Age()
        {
            DateTime date = new DateTime(yearBirthday, monthBirthday, dayBirthday);
            DateTime now = DateTime.Today;
            int age = now.Year-date.Year;
            now = now.AddYears(-age);
            if (date > now) age--;
            return age;
        }
        public string ShowWorkers ()
        {
            string s;
            s = $"Фамилия {surname}\n";
            s += $"Имя {name}\n";
            s += $"Дата рождения {dayBirthday}.{monthBirthday}.{yearBirthday}\n";
            s += $"Должность {town}\n";
            s += $"Дата начала работы {dayW}.{monthW}.{yearW}\n";
            s += $"стаж {AgeW()}\n";
            s += $"возраст {Age()}\n";
            return s;
        }

    }
}

