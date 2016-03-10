using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace time
{
    public class MyTimer
    {
        static int n = 0; //Счетчик.
        public static void Main()
        {
            System.Timers.Timer tmr = new System.Timers.Timer();
            tmr.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            tmr.Interval = 500; //Устанавливаем интервал в 1 сек.
            tmr.Enabled = true; //Вкючаем таймер.
            while (n != 4) ; //Таймер тикает 4 раза.
        }
        //Метод для отработки события Elapsed таймера.
        public static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            //Делаем некоторые действия.
            Console.WriteLine("Hello World!");
            //Увеличиваем счетчик.
            n++;
        }
    }
}
