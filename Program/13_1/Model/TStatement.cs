using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_1.Model
{
    class TStatement
    {
        DateTime nameStatement;
        int numworkers;
        TWorkers[] workers;
        TWorkers[] sup;
        string spis;
        public TStatement()
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
            string path = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "list.txt");
            StreamReader sr = new StreamReader(path, System.Text.Encoding.Default);
            nameStatement = DateTime.Today;
            numworkers = int.Parse(sr.ReadLine());
            workers = new TWorkers[numworkers];
            Console.WriteLine();
            for (int i = 0; i < workers.Length; i++)
            {
                surname = sr.ReadLine();
                name = sr.ReadLine();
                dayBirthday = int.Parse(sr.ReadLine());
                monthBirthday = int.Parse(sr.ReadLine());
                yearBirthday = int.Parse(sr.ReadLine());
                dayW = int.Parse(sr.ReadLine());
                monthW = int.Parse(sr.ReadLine());
                yearW = int.Parse(sr.ReadLine());
                town = sr.ReadLine();
                workers[i] = new TWorkers(surname,name, dayBirthday,
                    monthBirthday, yearBirthday,dayW,monthW,yearW,town);
            }
        }
        public string ShowStatement()
        {
            spis = "";
            for (int i = 0; i < workers.Length; i++)
            {
                spis +=  workers[i].ShowWorkers();
                workers[i].ShowWorkers();
                Console.WriteLine();
            }
            return spis;
        }
        public string Staz()
        {
            spis = $"";
            //3 МинМаксСтаж
            int iii = 0;
            int max = workers[0].AgeW();
            for (int i = 1; i < workers.Length; i++)
            {
                if (workers[i].AgeW() >= max)
                {
                    iii=i;
                    max = workers[i].AgeW();
                }
                if (i == numworkers - 1)
                {
                    spis += $" Максимальный стаж {max} лет у " +
                        $"{workers[iii].Name()} {workers[iii].Surname()}";
                }
            }
            int ii = 0;
            int min = workers[0].AgeW();
            for (int i = 1; i < workers.Length; i++)
            {
                if (workers[i].AgeW() <= min)
                {
                    ii=i;
                    min = workers[i].AgeW();
                }
                if (i == numworkers - 1)
                {
                    spis += $" Минимальный стаж {min} лет у " +
                        $"{workers[ii].Name()} {workers[ii].Surname()}";
                }
            }
            return spis;
        }
        public string Goodjob()
        {
            spis = "";
            //4+ поощрение
            for (int i = 0; i < workers.Length; i++)
            {
                string m = "ни";
                string n = "кто";
                int o = 0;
                if (workers[i].AgeW() >= 10)
                {
                    m = workers[i].Surname();
                    n = workers[i].Name();
                    spis += $" {m} {n} \n";
                }
                else
                {
                    o++;
                    if (o == numworkers)
                       spis += $" {m} {n} \n";
                }
               
            }
            return spis;
        }
        public string AgeWorker()
        {
            spis = "";
            //5+ по возрасту
            sup = new TWorkers[numworkers];
            for (int i = 0; i < workers.Length; i++)
            {
                for (int j = i + 1; j < workers.Length; j++)
                {
                    if (workers[i].Age() > workers[j].Age())
                    {
                        (workers[i], workers[j]) = (workers[j], workers[i]);
                    }

                }
                sup[i] = workers[i];
                
            }
            for (int i = 0; i < workers.Length; i++)
            {
                spis += $"{ sup[i].Name()} { sup[i].Surname()}\n";
            }
            return spis;
        }
       
    }
}

