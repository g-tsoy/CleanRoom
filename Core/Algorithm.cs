using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Algorithm
    {
        public static string[] WhoWillCleanToday()
        {
            string[] Schedule = new string[21];
            int thisDayInYear = DateTime.Now.DayOfYear; //алгоритм на на основе номера сегодняшнего дня в году 
            int ifSomebodyWillCleanToday;

            if (thisDayInYear % 2 != 0)//все нечетные дни в году один из пользователей будет дежурить =
            {
                ifSomebodyWillCleanToday = 0; //сегодня один из трех пользователей будет дежурить. Колонка сегодня будет обязательно заполнена.
            }
            else
            {
                thisDayInYear++;
                ifSomebodyWillCleanToday = 1; //сегодня не дежурит. Колонка сегодня будет пустая, зато следующая будет заполнена. Происходит сдвиг на одну позицию 
            }
            Schedule = AlgorithmOfCleaning(thisDayInYear, Schedule, ifSomebodyWillCleanToday);

            for (int i = 0; i < Schedule.Length; i++)//заполняем пустые строки масива пробелом
            {
                if (Schedule[i] == null)
                    Schedule[i] = " ";
                return Schedule;
            }
            return Schedule;
        }

        public static string[] AlgorithmOfCleaning(int thisDayInYear, string[] schedule, int i)
        {
            int numberOfUsers = 3; //количество пользователей 
            int daysBetweenDuties = 1; //дежурство через день
            int firstDayWhenDutiesBegun = 1; //конкретно день дежурства, к которому потом прибавим интервал и получим день следующего дежурства
            int daysToNextDuty = daysBetweenDuties + 1;
            int intervalDutiesOfOneUser = numberOfUsers * daysToNextDuty; //один человек дежурит через 6 дней. То есть сегодняшняя дата плюс 6 = дата следующего дежурства

            if ((thisDayInYear - firstDayWhenDutiesBegun) % intervalDutiesOfOneUser == 0) //если будет дежурить первый пользователей, то номер сегодняшнего дня в году - 1 = кратен 6
                                                                                          //потому что этот пользователей дежурил в первый день в году (дни дежурств будут: 1, 7, 13 и так далее). Аналогично для других
            {
                schedule[3 + i] = "I";
                schedule[12 + i] = "I";
                schedule[15 + i] = "I";
            }
            else if ((thisDayInYear - (firstDayWhenDutiesBegun + daysToNextDuty)) % intervalDutiesOfOneUser == 0)
            {
                schedule[10 + i] = "I";
                schedule[19 + i] = "I";
                schedule[1 + i] = "I";
            }
            else if ((thisDayInYear - (firstDayWhenDutiesBegun + 2 * daysToNextDuty)) % intervalDutiesOfOneUser == 0)
            {
                schedule[17 + i] = "I";
                schedule[5 + i] = "I";
                schedule[8 + i] = "I";
            }
            return schedule;

        }
    }
}

